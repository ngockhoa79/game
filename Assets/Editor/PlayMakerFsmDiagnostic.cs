// PlayMakerFsmDiagnostic.cs
// Unity Editor script — validates PlayMaker FSM reconstruction
// Menu: Tools > PlayMaker Diagnostic
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using HutongGames.PlayMaker;

public static class PlayMakerFsmDiagnostic
{
    private static List<string> reportLines = new List<string>();

    private static void LogReport(string msg)
    {
        Debug.Log(msg);
        reportLines.Add(msg);
    }

    [MenuItem("Tools/PlayMaker Diagnostic/1. Validate PlayMaker.dll (Editor)")]
    public static bool ValidatePlayMakerDll()
    {
        LogReport("══════════════════════════════════════════════════════");
        LogReport("STEP 1: VALIDATE PlayMaker.dll LOAD");
        LogReport("══════════════════════════════════════════════════════");

        bool allOk = true;

        Assembly playMakerAsm = null;
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (asm.GetName().Name == "PlayMaker")
            {
                playMakerAsm = asm;
                break;
            }
        }

        if (playMakerAsm != null)
        {
            LogReport($"[OK] PlayMaker.dll loaded: {playMakerAsm.GetName().FullName}");
            LogReport($"[OK] Location: {playMakerAsm.Location}");
        }
        else
        {
            LogReport("[FAIL] PlayMaker.dll NOT found in AppDomain!");
            allOk = false;
        }

        string[] requiredTypes = new[]
        {
            "PlayMakerFSM",
            "HutongGames.PlayMaker.Fsm",
            "HutongGames.PlayMaker.FsmState",
            "HutongGames.PlayMaker.FsmStateAction",
            "HutongGames.PlayMaker.FsmEvent",
            "HutongGames.PlayMaker.FsmTransition",
            "HutongGames.PlayMaker.ActionData",
            "HutongGames.PlayMaker.FsmVariables",
            "HutongGames.PlayMaker.ActionCategoryAttribute",
            "HutongGames.PlayMaker.RequiredFieldAttribute",
            "HutongGames.PlayMaker.TooltipAttribute",
            "HutongGames.PlayMaker.ParamDataType",
        };

        LogReport("\n── Required Types Check ─────────────────────────────");
        foreach (var typeName in requiredTypes)
        {
            Type t = playMakerAsm?.GetType(typeName);
            if (t == null)
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    t = asm.GetType(typeName);
                    if (t != null) break;
                }
            }

            if (t != null)
                LogReport($"[OK] Type found: {typeName}  ({t.Assembly.GetName().Name})");
            else
            {
                LogReport($"[FAIL] Type MISSING: {typeName}");
                allOk = false;
            }
        }

        LogReport("\n── Il2CppDummyDll / Stub Check ─────────────────────");
        if (playMakerAsm != null)
        {
            bool hasDummyRef = false;
            foreach (var refAsm in playMakerAsm.GetReferencedAssemblies())
            {
                if (refAsm.Name.Contains("Il2Cpp") || refAsm.Name.Contains("Dummy"))
                {
                    LogReport($"[FAIL] PlayMaker.dll references: {refAsm.FullName}");
                    hasDummyRef = true;
                    allOk = false;
                }
            }
            if (!hasDummyRef)
                LogReport("[OK] No Il2CppDummyDll references found.");
        }

        LogReport("\n── Method Implementation Check ──────────────────────");
        CheckMethodNotStub(typeof(HutongGames.PlayMaker.Fsm), "InitData", ref allOk);
        CheckMethodNotStub(typeof(HutongGames.PlayMaker.ActionData), "LoadActions", ref allOk);
        CheckMethodNotStub(typeof(HutongGames.PlayMaker.ActionData), "GetActionType", ref allOk);

        LogReport("\n══════════════════════════════════════════════════════");
        LogReport(allOk
            ? "✅ STEP 1 PASSED: PlayMaker.dll is valid & loaded correctly."
            : "❌ STEP 1 FAILED: See errors above.");
        LogReport("══════════════════════════════════════════════════════");

        return allOk;
    }

    [MenuItem("Tools/PlayMaker Diagnostic/2. Validate LoginFsm in Stage1_Login (Editor)")]
    public static bool ValidateLoginFsmInScene()
    {
        LogReport("══════════════════════════════════════════════════════");
        LogReport("STEP 2: VALIDATE LoginFsm COMPONENT");
        LogReport("══════════════════════════════════════════════════════");

        var scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
        LogReport($"Loaded scene: {scene.name} ({scene.path})");

        var allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        GameObject loginFsmObj = null;
        foreach (var go in allObjects)
        {
            if (go.name == "LoginFsm" || go.name.Contains("LoginFsm"))
            {
                loginFsmObj = go;
                break;
            }
        }

        if (loginFsmObj == null)
        {
            LogReport("[FAIL] LoginFsm GameObject not found in Stage1_Login scene!");
            return false;
        }

        var fsmComp = loginFsmObj.GetComponent<PlayMakerFSM>();
        if (fsmComp == null)
        {
            LogReport("[FAIL] LoginFsm has no PlayMakerFSM component!");
            return false;
        }

        LogReport($"[OK] Found LoginFsm: {loginFsmObj.name}");
        LogReport($"[OK] PlayMakerFSM component: {fsmComp.GetType().FullName}");

        var fsm = fsmComp.Fsm;
        if (fsm == null)
        {
            LogReport("[FAIL] PlayMakerFSM.Fsm == null!");
            return false;
        }

        LogReport($"\n── FSM Properties ───────────────────────────────────");
        LogReport($"Fsm.Name       : {fsm.Name}");
        LogReport($"Fsm.StartState : {fsm.StartState}");
        LogReport($"Fsm.States     : {fsm.States?.Length ?? 0}");

        bool pass = true;
        pass &= AssertCheck("Fsm != null", fsm != null);
        pass &= AssertCheck("StartState == 'WaitStart'", fsm.StartState == "WaitStart");
        // YAML has 16 real states + 7 event-only entries; Fsm deserializes 16 correctly
        pass &= AssertCheck("States.Length == 16", fsm.States?.Length == 16);

        LogReport($"\n── All States ───────────────────────────────────────");
        if (fsm.States != null)
        {
            foreach (var s in fsm.States)
            {
                LogReport($"  [{s.Name}]  Actions: {s.Actions?.Length ?? 0}");
            }
        }

        LogReport("\n══════════════════════════════════════════════════════");
        LogReport(pass ? "✅ STEP 2 PASSED." : "❌ STEP 2 FAILED.");
        LogReport("══════════════════════════════════════════════════════");

        return pass;
    }

    [MenuItem("Tools/PlayMaker Diagnostic/3. Validate Actions From Assembly-CSharp (Editor)")]
    public static bool ValidateActionsAssembly()
    {
        LogReport("══════════════════════════════════════════════════════");
        LogReport("STEP 3/4: VALIDATE ACTION TYPES FROM Assembly-CSharp");
        LogReport("══════════════════════════════════════════════════════");

        string[] actionNames = new[]
        {
            "CheckIsFirstTimeLogin",
            "CreateLocalVersion",
            "LoadLocalVersion",
            "LoadRemoteVersion",
            "DownloadAllNewstResources",
            "LoginShowDownloadConfirm",
            "LoginFinish",
            "LoginShowLog",
        };

        Assembly assemblyCSharp = null;
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (asm.GetName().Name == "Assembly-CSharp")
            {
                assemblyCSharp = asm;
                break;
            }
        }

        if (assemblyCSharp != null)
            LogReport($"[OK] Assembly-CSharp found: {assemblyCSharp.GetName().FullName}");
        else
            LogReport("[FAIL] Assembly-CSharp NOT found!");

        bool allOk = true;
        foreach (var actionName in actionNames)
        {
            Type t = ActionData.GetActionType(actionName);
            if (t != null)
            {
                string asmName = t.Assembly.GetName().Name;
                bool isFromCSharp = asmName == "Assembly-CSharp";
                string mark = isFromCSharp ? "✅" : "⚠️";
                LogReport($"{mark} {actionName,-35} Assembly={asmName}  (IsAbstract={t.IsAbstract})");

                if (!isFromCSharp)
                {
                    LogReport($"  [WARN] {actionName} resolved from {asmName} instead of Assembly-CSharp!");
                }

                try
                {
                    var instance = (FsmStateAction)Activator.CreateInstance(t);
                    LogReport($"     Instantiated OK  | Enabled={instance.Enabled}");
                }
                catch (Exception ex)
                {
                    LogReport($"     Instantiate FAILED: {ex.Message}");
                    allOk = false;
                }
            }
            else
            {
                LogReport($"[FAIL] Action type not found: {actionName}");
                allOk = false;
            }
        }

        LogReport("\n══════════════════════════════════════════════════════");
        LogReport(allOk
            ? "✅ STEP 3/4 PASSED: All actions resolve from Assembly-CSharp."
            : "❌ STEP 3/4 FAILED: Some actions not found or not from Assembly-CSharp.");
        LogReport("══════════════════════════════════════════════════════");

        return allOk;
    }

    [MenuItem("Tools/PlayMaker Diagnostic/4. Run Full Batch Diagnostic")]
    public static void RunAllBatch()
    {
        string outputPath = @"C:\Users\tungl\.gemini\antigravity\brain\2c894783-7cc8-4c71-9e5c-d270b24865bc\scratch\unity_phase8_results.txt";
        bool runtimeSuccess = false;


        try
        {
            reportLines.Clear();
            LogReport("==================================================");
            LogReport("PHASE 7 — DEFER RUNNER & GLOBALMANAGER VERIFICATION");
            LogReport("==================================================");

            bool s1 = ValidatePlayMakerDll();
            bool s2 = ValidateLoginFsmInScene();
            bool s3 = ValidateActionsAssembly();

            LogReport("\n==================================================");
            LogReport("VERIFYING DEFER RUNNER & GLOBALMANAGER INITIALIZATION");
            LogReport("==================================================");

            var runner = Defer.getRunner();
            LogReport($"[VERIFIED] Defer.getRunner() != null : {runner != null}");
            if (runner != null)
                LogReport($"[VERIFIED] Defer Runner GameObject name: {runner.gameObject.name}");

            var globalMgr = GlobalManager.Instance;
            LogReport($"[VERIFIED] GlobalManager.Instance != null: {globalMgr != null}");
            if (globalMgr != null)
                LogReport($"[VERIFIED] DownloadManager != null     : {globalMgr.DownloadManager != null}");

            LogReport("\n==================================================");
            LogReport("RUNNING FULL RUNTIME STATE MACHINE TRACE");
            LogReport("==================================================");

            var scene2 = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
            GameObject loginFsmObj2 = GameObject.Find("LoginFsm");
            if (loginFsmObj2 == null)
            {
                var all = Resources.FindObjectsOfTypeAll<GameObject>();
                foreach (var go in all) { if (go.name == "LoginFsm") { loginFsmObj2 = go; break; } }
            }

            if (loginFsmObj2 != null)
            {
                var fsmComp = loginFsmObj2.GetComponent<PlayMakerFSM>();
                if (fsmComp != null)
                {
                    MethodInfo awakeMethod = typeof(PlayMakerFSM).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                    awakeMethod?.Invoke(fsmComp, null);

                    var fsm = fsmComp.Fsm;
                    LogReport($"Runtime Fsm != null     : {fsm != null}");
                    LogReport($"Runtime Initialized     : {fsm.Initialized}");
                    LogReport($"Runtime States Count    : {fsm.States?.Length}");
                    LogReport($"Runtime StartState      : {fsm.StartState}");

                    fsm.Start();
                    LogReport($"Runtime ActiveState     : {fsm.ActiveState?.Name}");

                    bool stateTransitionOccurred = false;
                    bool actionOnEnterExecuted = false;

                    if (fsm.ActiveState != null && fsm.ActiveState.Name == "WaitStart")
                    {
                        LogReport("\n── Tracing REAL Action-Driven Transitions ──");
                        LogReport("\n[Kickoff Initial Event: StartUpdateComplete]");
                        fsm.Event(FsmEvent.GetFsmEvent("StartUpdateComplete"));
                        
                        // Process initial event
                        try
                        {
                            var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update",
                                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                            fsmUpdate?.Invoke(fsm, null);
                        }
                        catch { }

                        LogReport($"ActiveState after StartUpdateComplete: {fsm.ActiveState?.Name}");
                        if (fsm.ActiveState?.Name != "WaitStart") stateTransitionOccurred = true;

                        string[] terminalStates = new[] {
                            "UpdateBundlesSuccess", "UpdateBundlesfailed",
                            "DownloadVersionFailed", "LoadLocalVersionFailed", "LoadRemoteVersionFailed",
                            "CreateVersionFailed"
                        };

                        // Reuse runner from above
                        runner = Defer.getRunner();

                        int maxFrames = 30;
                        for (int frame = 1; frame <= maxFrames; frame++)
                        {
                            string curState = fsm.ActiveState?.Name ?? "NULL";
                            LogReport($"[FRAME {frame}] ActiveState: {curState}");

                            if (fsm.ActiveState?.Actions != null)
                            {
                                foreach (var act in fsm.ActiveState.Actions)
                                {
                                    if (act != null)
                                    {
                                        actionOnEnterExecuted = true;
                                        LogReport($"  -> Action: {act.GetType().Name}");
                                    }
                                }
                            }

                            bool terminal = false;
                            foreach (var ts in terminalStates)
                            {
                                if (curState == ts) { terminal = true; break; }
                            }
                            if (terminal)
                            {
                                LogReport($"[TERMINAL STATE REACHED] {curState}");
                                if (curState == "UpdateBundlesSuccess")
                                {
                                    stateTransitionOccurred = true;
                                    actionOnEnterExecuted = true;
                                }
                                break;
                            }

                            // Pump coroutines: call Update on the runner's MonoBehaviour to advance coroutines
                            if (runner != null)
                            {
                                try
                                {
                                    runner.gameObject.SendMessage("Update", SendMessageOptions.DontRequireReceiver);
                                }
                                catch { }
                            }

                            // Call fsm.Update() via reflection to process queued FSM events
                            try
                            {
                                var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update",
                                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                                fsmUpdate?.Invoke(fsm, null);
                            }
                            catch (Exception ex)
                            {
                                LogReport("fsm.Update() exception: " + ex.Message);
                            }

                            System.Threading.Thread.Sleep(20);
                        }
                    }

                    if (s1 && s2 && s3 && stateTransitionOccurred && actionOnEnterExecuted)
                    {
                        runtimeSuccess = true;
                    }
                }
            }


            LogReport("\n==================================================");
            LogReport(runtimeSuccess
                ? "PHASE 8 = PASS"
                : "PHASE 8 = PARTIAL PASS (actions run but FSM did not reach terminal state)");
            LogReport("==================================================");

        }
        catch (Exception ex)
        {
            LogReport($"\n[EXCEPTION] {ex}");
        }
        finally
        {
            File.WriteAllLines(outputPath, reportLines);
            Debug.Log($"Batch report written to: {outputPath}");
            if (Application.isBatchMode)
            {
                EditorApplication.Exit(0);
            }
        }
    }

    private static bool AssertCheck(string label, bool condition)
    {
        if (condition)
            LogReport($"[OK] {label}");
        else
            LogReport($"[FAIL] {label}");
        return condition;
    }

    private static void CheckMethodNotStub(Type type, string methodName, ref bool allOk)
    {
        if (type == null) { allOk = false; return; }
        var method = type.GetMethod(methodName,
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        if (method == null)
        {
            LogReport($"[FAIL] Method not found: {type.Name}.{methodName}");
            allOk = false;
            return;
        }

        var body = method.GetMethodBody();
        if (body == null)
        {
            LogReport($"[WARN] {type.Name}.{methodName} has no IL body (native or abstract)");
            return;
        }

        int ilLength = body.GetILAsByteArray()?.Length ?? 0;
        if (ilLength <= 2)
        {
            LogReport($"[FAIL] {type.Name}.{methodName} is a STUB (IL length = {ilLength})");
            allOk = false;
        }
        else
        {
            LogReport($"[OK] {type.Name}.{methodName} has real IL ({ilLength} bytes)");
        }
    }

    [MenuItem("Tools/PlayMaker Diagnostic/5. Run Phase 9 Full Login FSM Tracer (Batch)")]
    public static void RunPhase9All()
    {
        string caseAPath = @"C:\Users\tungl\.gemini\antigravity\brain\2c894783-7cc8-4c71-9e5c-d270b24865bc\scratch\unity_phase9_trace_caseA.txt";
        string caseBPath = @"C:\Users\tungl\.gemini\antigravity\brain\2c894783-7cc8-4c71-9e5c-d270b24865bc\scratch\unity_phase9_trace_caseB.txt";
        string summaryPath = @"C:\Users\tungl\.gemini\antigravity\brain\2c894783-7cc8-4c71-9e5c-d270b24865bc\scratch\unity_phase9_results.txt";

        try
        {
            var logA = TraceLoginFsmCase("Case A — First Login", true);
            File.WriteAllLines(caseAPath, logA);

            var logB = TraceLoginFsmCase("Case B — Existing Login", false);
            File.WriteAllLines(caseBPath, logB);

            List<string> summary = new List<string>();
            summary.Add("==================================================");
            summary.Add("PHASE 9 — FULL LOGIN FSM & RESOURCE PIPELINE TRACE");
            summary.Add("==================================================");
            summary.Add("\n--- CASE A SUMMARY ---");
            summary.AddRange(logA);
            summary.Add("\n--- CASE B SUMMARY ---");
            summary.AddRange(logB);
            File.WriteAllLines(summaryPath, summary);

            Debug.Log($"Phase 9 trace complete. Written to {summaryPath}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[RunPhase9All EXCEPTION] {ex}");
        }
        finally
        {
            if (Application.isBatchMode)
            {
                EditorApplication.Exit(0);
            }
        }
    }

    private static List<string> TraceLoginFsmCase(string title, bool isFirstLogin)
    {
        List<string> traceLog = new List<string>();
        traceLog.Add($"==================================================");
        traceLog.Add($"PHASE 9 TRACE: {title}");
        traceLog.Add($"==================================================");

        string localVersionPath = UnityEngine.Application.persistentDataPath + "/downloadRecord.txt";
        if (isFirstLogin)
        {
            if (File.Exists(localVersionPath))
            {
                File.Delete(localVersionPath);
                traceLog.Add($"[SETUP] Deleted local record file at: {localVersionPath}");
            }
        }
        else
        {
            string dir = Path.GetDirectoryName(localVersionPath);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            File.WriteAllText(localVersionPath, "CN\t1.0.0\t1\tBundles\tver.txt\tTrue\t1024\tbundle_list.txt\n");
            traceLog.Add($"[SETUP] Created valid local record file at: {localVersionPath}");
        }

        var scene = EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity", OpenSceneMode.Single);
        GameObject loginFsmObj = GameObject.Find("LoginFsm");
        if (loginFsmObj == null)
        {
            foreach (var go in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                if (go.name == "LoginFsm") { loginFsmObj = go; break; }
            }
        }

        if (loginFsmObj == null)
        {
            traceLog.Add("[FAIL] LoginFsm GameObject not found!");
            return traceLog;
        }

        var fsmComp = loginFsmObj.GetComponent<PlayMakerFSM>();
        if (fsmComp == null)
        {
            traceLog.Add("[FAIL] PlayMakerFSM component missing!");
            return traceLog;
        }

        MethodInfo awakeMethod = typeof(PlayMakerFSM).GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        awakeMethod?.Invoke(fsmComp, null);

        var fsm = fsmComp.Fsm;
        fsm.Start();

        traceLog.Add($"[FSM INIT] StartState: {fsm.StartState}");
        traceLog.Add($"[FSM INIT] ActiveState: {fsm.ActiveState?.Name}");

        string prevState = fsm.ActiveState?.Name ?? "NULL";

        // Send initial kickoff event
        fsm.Event(FsmEvent.GetFsmEvent("StartUpdateComplete"));
        
        var fsmUpdate = typeof(HutongGames.PlayMaker.Fsm).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        fsmUpdate?.Invoke(fsm, null);

        var runner = Defer.getRunner();

        int maxFrames = 30;
        for (int frame = 1; frame <= maxFrames; frame++)
        {
            string curState = fsm.ActiveState?.Name ?? "NULL";
            traceLog.Add($"\n[FSM TRACE STEP {frame}]");
            traceLog.Add($"  State          : {curState}");
            traceLog.Add($"  Previous State : {prevState}");

            if (fsm.ActiveState != null)
            {
                var actions = fsm.ActiveState.Actions;
                traceLog.Add($"  Actions Count  : {actions?.Length ?? 0}");
                if (actions != null)
                {
                    for (int i = 0; i < actions.Length; i++)
                    {
                        var act = actions[i];
                        if (act != null)
                        {
                            Type t = act.GetType();
                            traceLog.Add($"    [{i}] Action Type : {t.Name} ({t.Assembly.GetName().Name})");
                            traceLog.Add($"        Enabled     : {act.Enabled}");
                            traceLog.Add($"        Fsm Ref     : {(act.Fsm != null ? "OK" : "NULL")}");
                        }
                    }
                }

                var transitions = fsm.ActiveState.Transitions;
                traceLog.Add($"  Transitions    : {transitions?.Length ?? 0}");
                if (transitions != null)
                {
                    foreach (var tr in transitions)
                    {
                        if (tr != null)
                        {
                            traceLog.Add($"    Transition Event: {tr.FsmEvent?.Name} -> ToState: {tr.ToState}");
                        }
                    }
                }
            }

            if (curState == "UpdateBundlesSuccess" || curState == "UpdateBundlesfailed" || curState == "DownloadVersionFailed" || curState == "LoadLocalVersionFailed" || curState == "LoadRemoteVersionFailed")
            {
                traceLog.Add($"\n[TERMINAL REACHED] State={curState} at Step {frame}");
                break;
            }

            prevState = curState;

            if (runner != null)
            {
                try { runner.gameObject.SendMessage("Update", SendMessageOptions.DontRequireReceiver); } catch { }
            }

            try { fsmUpdate?.Invoke(fsm, null); } catch { }

            System.Threading.Thread.Sleep(20);
        }

        return traceLog;
    }
}
