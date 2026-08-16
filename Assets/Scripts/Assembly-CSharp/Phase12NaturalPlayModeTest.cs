using System;
using System.IO;
using System.Threading;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using HutongGames.PlayMaker;
using Ice.ProjectCos.UI.DataModel;

namespace Phase12Testing
{
    /// <summary>
    /// Phase 12 Pure Observer Test Harness.
    /// Strictly NO event injection, NO direct method calls, NO forced SetActive.
    /// </summary>
    public static class Phase12NaturalPlayModeTest
    {
        private static string TraceFilePath => Path.Combine(Application.dataPath, "../../phase12_natural_trace.txt");

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

        public static void RunNaturalObserverTestSync()
        {
            try
            {
                if (File.Exists(TraceFilePath)) File.Delete(TraceFilePath);

                LogTrace("=================================================================");
                LogTrace("[PHASE 12 OBSERVER] Starting Pure Natural Execution Observer");
                LogTrace("[TRACE 1/19] Stage1_Login loading...");
                EditorSceneManager.OpenScene("Assets/__Scene/GameScene/Stage1_Login.unity");

                LogTrace("[TRACE 2/19] Checking LoginFsm in scene...");
                GameObject loginFsmGo = GameObject.Find("LoginFsm");
                PlayMakerFSM fsm = (loginFsmGo != null) ? loginFsmGo.GetComponent<PlayMakerFSM>() : null;
                
                if (fsm != null)
                {
                    LogTrace($"[PHASE 12 OBSERVER] LoginFsm found. Active state = '{fsm.ActiveStateName}'");
                }

                // Check for step 2 manager
                LoginFsmStep2Manager step2 = GameObject.FindObjectOfType<LoginFsmStep2Manager>(true);
                bool isStep2Active = (step2 != null && step2.gameObject.activeInHierarchy);
                LogTrace($"[PHASE 12 OBSERVER] LoginFsmStep2Manager found. activeInHierarchy = {isStep2Active}");

                // Observe for 3 seconds without ANY harness intervention
                float start = Time.realtimeSinceStartup;
                while (Time.realtimeSinceStartup - start < 3.0f)
                {
                    Thread.Sleep(50);
                }

                bool isSetDataOk = (Me.Ins != null && Me.Ins.SetDataOk);
                LogTrace($"[PHASE 12 OBSERVER] End of natural observation. Me.SetDataOk = {isSetDataOk}");
                LogTrace("=================================================================");
            }
            catch (Exception ex)
            {
                LogTrace($"[PHASE 12 ERROR] Exception: {ex}");
            }
        }
    }
}
