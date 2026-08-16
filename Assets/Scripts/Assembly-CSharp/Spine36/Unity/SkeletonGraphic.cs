using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Spine36.Unity
{
	[AddComponentMenu("Spine/SkeletonGraphic (Unity UI Canvas)")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(CanvasRenderer), typeof(RectTransform))]
	[ExecuteInEditMode]
	public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, IAnimationStateComponent, ISkeletonAnimation, IHasSkeletonDataAsset
	{
		public SkeletonDataAsset skeletonDataAsset;

		[SpineSkin(null, "skeletonDataAsset", true, false)]
		public string initialSkinName;

		public bool initialFlipX;

		public bool initialFlipY;

		[SpineAnimation(null, "skeletonDataAsset", true, false)]
		public string startingAnimation;

		public bool startingLoop;

		public float timeScale;

		public bool freeze;

		public bool unscaledTime;

		private Texture overrideTexture;

		protected Skeleton skeleton;

		protected AnimationState state;

		[SerializeField]
		protected MeshGenerator meshGenerator;

		private DoubleBuffered<MeshRendererBuffers.SmartMesh> meshBuffers;

		private SkeletonRendererInstruction currentInstructions;

		public SkeletonDataAsset SkeletonDataAsset => null;

		public Texture OverrideTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Texture mainTexture => null;

		public Skeleton Skeleton
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public SkeletonData SkeletonData => null;

		public bool IsValid => false;

		public AnimationState AnimationState => null;

		public MeshGenerator MeshGenerator => null;

		public event UpdateBonesDelegate UpdateLocal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateWorld
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event MeshGeneratorDelegate OnPostProcessVertices
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset skeletonDataAsset, Transform parent)
		{
			return null;
		}

		public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		public override void Rebuild(CanvasUpdate update)
		{
		}

		public virtual void Update()
		{
		}

		public virtual void Update(float deltaTime)
		{
		}

		public void LateUpdate()
		{
		}

		public Mesh GetLastMesh()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Initialize(bool overwrite)
		{
		}

		public void UpdateMesh()
		{
		}
	}
}
