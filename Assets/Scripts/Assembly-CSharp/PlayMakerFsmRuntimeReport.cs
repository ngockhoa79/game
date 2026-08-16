// PlayMakerFsmRuntimeReport.cs
// Attach to LoginFsm GameObject to validate FSM in Play Mode
// Reports: Fsm.Initialized, States, Actions assembly, OnEnter execution
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using HutongGames.PlayMaker;

[RequireComponent(typeof(PlayMakerFSM))]
public class PlayMakerFsmRuntimeReport : MonoBehaviour
{
    [Header("Report Settings")]
    public bool reportOnAwake = true;
    public bool reportOnStart = true;
    public bool testActionOnEnter = true;

    private PlayMakerFSM _fsmComp;

    private void Awake()
    {
        _fsmComp = GetComponent<PlayMakerFSM>();

        if (reportOnAwake)
        {
            Debug.Log("══════════════════════════════════════════════════════");
            Debug.Log("[PlayMakerFsmRuntimeReport] AWAKE — FSM Initialization Report");
            Debug.Log("══════════════════════════════════════════════════════");
            ReportFsmState("AWAKE");
        }
    }

    private void Start()
    {
        if (reportOnStart)
        {
            Debug.Log("══════════════════════════════════════════════════════");
            Debug.Log("[PlayMakerFsmRuntimeReport] START — FSM State Report");
            Debug.Log("══════════════════════════════════════════════════════");
            ReportFsmState("START");
            ReportAllActions();
        }
    }

    private void ReportFsmState(string phase)
    {
        if (_fsmComp == null)
        {
            Debug.LogError($"[{phase}] PlayMakerFSM component is null!");
            return;
        }

        var fsm = _fsmComp.Fsm;

        Debug.Log($"[{phase}] PlayMakerFSM.Fsm != null : {fsm != null}");
        if (fsm == null) return;

        Debug.Log($"[{phase}] Fsm.Name             : {fsm.Name}");
        Debug.Log($"[{phase}] Fsm.Initialized      : {fsm.Initialized}");
        Debug.Log($"[{phase}] Fsm.States.Length    : {fsm.States?.Length ?? 0}");
        Debug.Log($"[{phase}] Fsm.StartState       : {fsm.StartState}");
        Debug.Log($"[{phase}] Fsm.ActiveState      : {fsm.ActiveState?.Name ?? "NULL"}");
    }

    private void ReportAllActions()
    {
        var fsm = _fsmComp?.Fsm;
        if (fsm?.States == null) return;

        Debug.Log("── Action Details Per State ─────────────────────────");

        string[] expectedActionTypes = new[]
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

        var foundActionTypes = new HashSet<string>();

        foreach (var state in fsm.States)
        {
            if (state.Actions == null || state.Actions.Length == 0) continue;

            Debug.Log($"\n  State: [{state.Name}]");
            foreach (var action in state.Actions)
            {
                if (action == null) continue;

                Type t = action.GetType();
                string asmName = t.Assembly.GetName().Name;
                bool fromRealAssembly = asmName == "Assembly-CSharp";
                string mark = fromRealAssembly ? "✅" : "⚠️";

                Debug.Log($"    {mark} Action : {t.Name}");
                Debug.Log($"         Assembly : {asmName}");
                Debug.Log($"         Enabled  : {action.Enabled}");
                Debug.Log($"         Fsm ref  : {(action.Fsm != null ? "OK" : "NULL")}");
                Debug.Log($"         State ref: {(action.State != null ? "OK" : "NULL")}");

                foundActionTypes.Add(t.Name);

                if (testActionOnEnter && action.Enabled)
                {
                    try
                    {
                        // Just verify OnEnter is callable (but don't actually call it in non-WaitStart states)
                        var onEnterMethod = t.GetMethod("OnEnter",
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                        int ilLen = onEnterMethod?.GetMethodBody()?.GetILAsByteArray()?.Length ?? 0;
                        Debug.Log($"         OnEnter IL : {ilLen} bytes  {(ilLen > 2 ? "(real implementation)" : "(stub)")}");
                    }
                    catch (Exception ex)
                    {
                        Debug.LogWarning($"         OnEnter check failed: {ex.Message}");
                    }
                }
            }
        }

        // Check which expected actions were found
        Debug.Log("\n── Expected Action Resolution Report ────────────────");
        foreach (var expectedName in expectedActionTypes)
        {
            bool found = foundActionTypes.Contains(expectedName);
            Debug.Log($"  {(found ? "✅" : "❌")} {expectedName} : {(found ? "Found in FSM" : "NOT found")}");
        }
    }
}
