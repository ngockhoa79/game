using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spine36.Unity
{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[HelpURL("http://esotericsoftware.com/spine-unity-documentation#Rendering")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent, IHasSkeletonDataAsset
	{
		public delegate void SkeletonRendererDelegate(SkeletonRenderer skeletonRenderer);

		public delegate void InstructionDelegate(SkeletonRendererInstruction instruction);

		public SkeletonDataAsset skeletonDataAsset;

		public string initialSkinName;

		public bool initialFlipX;

		public bool initialFlipY;

		[FormerlySerializedAs("submeshSeparators")]
		[SpineSlot(null, null, false, true, false)]
		public string[] separatorSlotNames;

		[NonSerialized]
		public readonly List<Slot> separatorSlots;

		[Range(-0.1f, 0f)]
		public float zSpacing;

		public bool useClipping;

		public bool immutableTriangles;

		public bool pmaVertexColors;

		public bool clearStateOnDisable;

		public bool tintBlack;

		public bool singleSubmesh;

		[FormerlySerializedAs("calculateNormals")]
		public bool addNormals;

		public bool calculateTangents;

		public bool logErrors;

		public bool disableRenderingOnOverride;

		[NonSerialized]
		private readonly Dictionary<Material, Material> customMaterialOverride;

		[NonSerialized]
		private readonly Dictionary<Slot, Material> customSlotMaterials;

		private MeshRenderer meshRenderer;

		private MeshFilter meshFilter;

		[NonSerialized]
		public bool valid;

		[NonSerialized]
		public Skeleton skeleton;

		[NonSerialized]
		private readonly SkeletonRendererInstruction currentInstructions;

		private readonly MeshGenerator meshGenerator;

		[NonSerialized]
		private readonly MeshRendererBuffers rendererBuffers;

		public SkeletonDataAsset SkeletonDataAsset => null;

		public Dictionary<Material, Material> CustomMaterialOverride => null;

		public Dictionary<Slot, Material> CustomSlotMaterials => null;

		public Skeleton Skeleton => null;

		public event SkeletonRendererDelegate OnRebuild
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

		private event InstructionDelegate generateMeshOverride
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

		public event InstructionDelegate GenerateMeshOverride
		{
			add
			{
			}
			remove
			{
			}
		}

		public static T NewSpineGameObject<T>(SkeletonDataAsset skeletonDataAsset) where T : SkeletonRenderer
		{
			return null;
		}

		public static T AddSpineComponent<T>(GameObject gameObject, SkeletonDataAsset skeletonDataAsset) where T : SkeletonRenderer
		{
			return null;
		}

		public void SetMeshSettings(MeshGenerator.Settings settings)
		{
		}

		public virtual void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void ClearState()
		{
		}

		public void EnsureMeshGeneratorCapacity(int minimumVertexCount)
		{
		}

		public virtual void Initialize(bool overwrite)
		{
		}

		public virtual void LateUpdate()
		{
		}
	}
}
