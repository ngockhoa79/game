// SpineWWW Stub — Auto-generated to resolve missing namespace errors.
// The original SpineWWW library was a custom Spine runtime DLL that is no
// longer present in this project. These stubs allow the project to compile.
// All methods are empty (no-op) because the decompiled code that references
// SpineWWW is itself stub-only (no logic).

using UnityEngine;

namespace SpineWWW
{
    /// <summary>Stub for SpineWWW.Skeleton</summary>
    public class Skeleton
    {
        public float ScaleX;
        public float ScaleY;
        public Skeleton() { }
    }

    /// <summary>Stub for SpineWWW.TrackEntry — used as animation callback parameter</summary>
    public class TrackEntry
    {
        public TrackEntry() { }
    }

    /// <summary>Stub for SpineWWW.AnimationState</summary>
    public class AnimationState
    {
        public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop) { return null; }
        public void ClearTrack(int trackIndex) { }

        public event System.Action<TrackEntry> Complete;
        public event System.Action<TrackEntry> End;
    }
}

namespace SpineWWW.Unity
{
    /// <summary>Stub for SpineWWW.Unity.SkeletonAnimation — used as field/property type on MonoBehaviours</summary>
    public class SkeletonAnimation : MonoBehaviour
    {
        public SpineWWW.Skeleton skeleton;
        public SpineWWW.AnimationState state;

        public string AnimationName { get { return string.Empty; } set { } }
        public bool loop { get; set; }
        public float timeScale { get; set; }

        public void Initialize(bool overwrite) { }
        public void ClearState() { }
    }
}
