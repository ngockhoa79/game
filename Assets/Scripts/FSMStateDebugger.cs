using System.Collections;
using UnityEngine;
using HutongGames.PlayMaker;

/// <summary>
/// FSMStateDebugger – chỉ debug, không sửa game logic.
///
/// CÁCH DÙNG:
///   Attach script này vào BẤT KỲ GameObject nào trong scene.
///   Script sẽ tự tìm PlayMakerFSM có FsmName == targetFsmName trong toàn scene.
///   Sau đó theo dõi state thay đổi và log mỗi khi transition xảy ra.
///
/// KHÔNG attach trực tiếp vào LoginFsm – script tự tìm.
/// </summary>
public class FSMStateDebugger : MonoBehaviour
{
    [UnityEngine.Tooltip("Tên FSM cần debug. Để trống = dùng FSM đầu tiên tìm được trên cùng GameObject.")]
    public string targetFsmName = "LoginFsm";

    [UnityEngine.Tooltip("Tên GameObject chứa FSM. Để trống = tìm trong toàn scene.")]
    public string targetGameObjectName = "LoginFsm";

    // Thời gian tối đa chờ FSM init (giây)
    private const float MaxWaitSeconds = 10f;

    private PlayMakerFSM _fsmComponent;
    private string _lastStateName = "";
    private bool _initialized = false;
    private bool _initFailed = false;

    void Awake()
    {
        Debug.Log($"[FSM DEBUG] Awake – GameObject: {gameObject.name}");
    }

    void Start()
    {
        Debug.Log($"[FSM DEBUG] Start – FSMStateDebugger trên: {gameObject.name}");
        StartCoroutine(InitializeAfterPlayMaker());
    }

    /// <summary>
    /// Chờ PlayMaker initialize xong rồi mới bắt đầu đọc.
    /// PlayMaker gọi Fsm.Init() trong PlayMakerFSM.Start() → chờ ít nhất 1 frame sau Start().
    /// </summary>
    private IEnumerator InitializeAfterPlayMaker()
    {
        // Chờ 1 frame để PlayMakerFSM.Start() có cơ hội chạy
        yield return null;

        float waited = 0f;
        bool logged = false;

        while (waited < MaxWaitSeconds)
        {
            _fsmComponent = FindTargetFSM();

            if (_fsmComponent != null)
            {
                // Kiểm tra Fsm.Initialized
                if (_fsmComponent.Fsm != null && _fsmComponent.Fsm.Initialized)
                {
                    OnFSMReady();
                    yield break;
                }

                // Fsm object tồn tại nhưng chưa Initialized, hoặc Fsm null → chờ thêm
                if (!logged)
                {
                    Debug.Log($"[FSM DEBUG] PlayMakerFSM component found ({_fsmComponent.FsmName}), chờ Initialized...");
                    logged = true;
                }
            }
            else if (!logged)
            {
                Debug.Log($"[FSM DEBUG] Chưa tìm thấy PlayMakerFSM '{targetFsmName}', đang chờ...");
                logged = true;
            }

            yield return null;
            waited += Time.unscaledDeltaTime;
        }

        // Timeout
        _initFailed = true;
        LogDiagnostics();
    }

    /// <summary>
    /// Tìm PlayMakerFSM đúng theo tên FSM và tên GameObject.
    /// Ưu tiên: cùng GameObject → theo targetGameObjectName → toàn scene.
    /// </summary>
    private PlayMakerFSM FindTargetFSM()
    {
        // 1. Thử GetComponent trên cùng object (nếu debugger được attach thẳng vào LoginFsm)
        if (!string.IsNullOrEmpty(targetFsmName))
        {
            var onSelf = PlayMakerFSM.FindFsmOnGameObject(gameObject, targetFsmName);
            if (onSelf != null) return onSelf;
        }

        // 2. Tìm theo tên GameObject
        if (!string.IsNullOrEmpty(targetGameObjectName))
        {
            var go = GameObject.Find(targetGameObjectName);
            if (go != null)
            {
                if (!string.IsNullOrEmpty(targetFsmName))
                {
                    var found = PlayMakerFSM.FindFsmOnGameObject(go, targetFsmName);
                    if (found != null) return found;
                }
                // Thử lấy component đầu tiên
                var first = go.GetComponent<PlayMakerFSM>();
                if (first != null) return first;
            }
        }

        // 3. Tìm toàn scene theo tên FSM
        var allFsms = FindObjectsOfType<PlayMakerFSM>();
        foreach (var fsm in allFsms)
        {
            if (!string.IsNullOrEmpty(targetFsmName) && fsm.FsmName == targetFsmName)
                return fsm;
        }

        // 4. Fallback: component trên cùng object (không quan tâm tên)
        return GetComponent<PlayMakerFSM>();
    }

    private void OnFSMReady()
    {
        _initialized = true;
        _lastStateName = _fsmComponent.ActiveStateName;

        Debug.Log($"[FSM DEBUG] PlayMakerFSM component found");
        Debug.Log($"[FSM DEBUG] FSM initialized");
        Debug.Log($"[FSM DEBUG] FSM Name: {_fsmComponent.FsmName}");
        Debug.Log($"[FSM DEBUG] State Count: {(_fsmComponent.FsmStates != null ? _fsmComponent.FsmStates.Length : 0)}");
        Debug.Log($"[FSM DEBUG] Current State: {_lastStateName}");

        // Log tên tất cả states
        if (_fsmComponent.FsmStates != null && _fsmComponent.FsmStates.Length > 0)
        {
            var sb = new System.Text.StringBuilder("[FSM DEBUG] All States:");
            foreach (var s in _fsmComponent.FsmStates)
                sb.Append("\n  - ").Append(s.Name);
            Debug.Log(sb.ToString());
        }
    }

    void Update()
    {
        if (!_initialized || _initFailed || _fsmComponent == null)
            return;

        string currentState = _fsmComponent.ActiveStateName;

        if (currentState != _lastStateName)
        {
            Debug.Log($"[FSM DEBUG] STATE CHANGED: {_lastStateName} -> {currentState}");
            _lastStateName = currentState;
        }
    }

    /// <summary>
    /// Diagnostic dump khi không thể init sau MaxWaitSeconds.
    /// </summary>
    private void LogDiagnostics()
    {
        Debug.LogWarning($"[FSM DEBUG] TIMEOUT: Không thể initialize FSM sau {MaxWaitSeconds}s. Chạy diagnostics:");
        Debug.LogWarning($"[FSM DEBUG] DIAG | Debugger GameObject: {gameObject.name}");

        if (_fsmComponent == null)
        {
            Debug.LogWarning($"[FSM DEBUG] DIAG | PlayMakerFSM component: NULL (không tìm thấy trong scene)");
        }
        else
        {
            bool fsmNull = _fsmComponent.Fsm == null;
            bool initialized = !fsmNull && _fsmComponent.Fsm.Initialized;
            int stateCount = (!fsmNull && _fsmComponent.Fsm.States != null) ? _fsmComponent.Fsm.States.Length : -1;

            Debug.LogWarning($"[FSM DEBUG] DIAG | PlayMakerFSM.name: {_fsmComponent.name}");
            Debug.LogWarning($"[FSM DEBUG] DIAG | PlayMakerFSM.FsmName: {_fsmComponent.FsmName}");
            Debug.LogWarning($"[FSM DEBUG] DIAG | PlayMakerFSM.Fsm: {(fsmNull ? "NULL" : "non-null")}");
            Debug.LogWarning($"[FSM DEBUG] DIAG | Fsm.Initialized: {initialized}");
            Debug.LogWarning($"[FSM DEBUG] DIAG | Fsm.States count: {stateCount}");
            Debug.LogWarning($"[FSM DEBUG] DIAG | Thời điểm: Time={Time.time:F2}s, Frame={Time.frameCount}");
        }

        // Liệt kê tất cả PlayMakerFSM trong scene để hỗ trợ debug
        var allFsms = FindObjectsOfType<PlayMakerFSM>();
        Debug.LogWarning($"[FSM DEBUG] DIAG | Tổng PlayMakerFSM trong scene: {allFsms.Length}");
        foreach (var f in allFsms)
        {
            bool fNull = f.Fsm == null;
            Debug.LogWarning($"[FSM DEBUG] DIAG |   GO='{f.gameObject.name}' FSMName='{f.FsmName}' Fsm={(fNull ? "NULL" : "OK")} Init={(!fNull && f.Fsm.Initialized)}");
        }
    }
}