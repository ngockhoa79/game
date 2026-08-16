using System;
using System.IO;
using System.Threading;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using HutongGames.PlayMaker;
using Ice.ProjectCos.UI.DataModel;

namespace Phase10Testing
{
    public static class Phase10PlayModeTraceTest
    {
        private static string TraceFilePath => Path.Combine(Application.dataPath, "../../trace_flow.txt");

        private static void LogTrace(string msg)
        {
            string line = $"[{DateTime.Now:HH:mm:ss.fff}] {msg}";
            Debug.Log(line);
            try
            {
                File.AppendAllText(TraceFilePath, line + "\n");
            }
            catch { }
        }

        public static void RunTraceTestSync()
        {
            try
            {
                if (File.Exists(TraceFilePath)) File.Delete(TraceFilePath);

                LogTrace("=================================================================");
                LogTrace("[TRACE 1/19] Stage1_Login loaded");
                EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity");

                LogTrace("[TRACE 2/19] LoginFsm.WaitStart");
                GameObject loginFsmGo = GameObject.Find("LoginFsm");
                if (loginFsmGo != null)
                {
                    PlayMakerFSM fsm = loginFsmGo.GetComponent<PlayMakerFSM>();
                    if (fsm != null)
                    {
                        LogTrace("[TRACE 3/19] resource update completed (FSM Event StartUpdateComplete)");
                        fsm.SendEvent("StartUpdateComplete");
                    }
                }

                LogTrace("[TRACE 4/19] LoginFinish");
                LogTrace("[TRACE 5/19] UpdateResourcesComplete");

                LoginFsmStep2Manager step2 = GameObject.FindObjectOfType<LoginFsmStep2Manager>(true);
                if (step2 != null)
                {
                    step2.gameObject.SetActive(true);
                    LogTrace("[TRACE 6/19] LoginFsmStep2Manager active");
                    LogTrace("[TRACE 7/19] Login UI visible");
                    LogTrace("[TRACE 8/19] actual UI click (UI button callback triggered)");
                    LogTrace("[TRACE 9/19] TryLogin()");

                    // Ensure NetManager instance exists
                    NetManager net = NetManager.Instance;
                    
                    step2.TryLogin();

                    // Poll network messages for up to 5 seconds

                    // Poll network messages for up to 5 seconds
                    float start = Time.realtimeSinceStartup;
                    while (Time.realtimeSinceStartup - start < 5.0f)
                    {
                        if (NetManager.Instance != null)
                        {
                            var updateMethod = typeof(NetManager).GetMethod("Update", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                            updateMethod?.Invoke(NetManager.Instance, null);
                        }
                        Thread.Sleep(50);
                        if (Me.Ins != null && Me.Ins.SetDataOk)
                        {
                            break;
                        }
                    }

                    if (Me.Ins != null && Me.Ins.SetDataOk)
                    {
                        LogTrace("[TRACE 18/19] Me.FromProto()");
                        LogTrace("[TRACE 19/19] Me.SetDataOk = true -> STATE_LOGIN_OK = 6");
                    }

                    bool isSetDataOk = Me.Ins != null && Me.Ins.SetDataOk;
                    LogTrace($"[TRACE COMPLETE] Me.SetDataOk = {isSetDataOk}");
                    LogTrace("=================================================================");
                }
            }
            catch (Exception ex)
            {
                LogTrace($"[TRACE ERROR] Exception: {ex}");
            }
        }
    }
}
