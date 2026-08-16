using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace MMT
{
	public class MobileMovieTexture : MonoBehaviour
	{
		public delegate void OnFinished(MobileMovieTexture sender);

		[SerializeField]
		private string m_path;

		[SerializeField]
		private Material[] m_movieMaterials;

		[SerializeField]
		private bool m_playAutomatically;

		[SerializeField]
		private bool m_advance;

		[SerializeField]
		private int m_loopCount;

		[SerializeField]
		private float m_playSpeed;

		[SerializeField]
		private bool m_scanDuration;

		[SerializeField]
		private bool m_seekKeyFrame;

		private IntPtr m_nativeContext;

		private IntPtr m_nativeTextureContext;

		private int m_picX;

		private int m_picY;

		private int m_yStride;

		private int m_yHeight;

		private int m_uvStride;

		private int m_uvHeight;

		private Vector2 m_uvYScale;

		private Vector2 m_uvYOffset;

		private Vector2 m_uvCrCbScale;

		private Vector2 m_uvCrCbOffset;

		private const int CHANNELS = 3;

		private Texture2D[] m_ChannelTextures;

		private double m_elapsedTime;

		private bool m_hasFinished;

		private const string PLATFORM_DLL = "theorawrapper";

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AbsolutePath { get; set; }

		public Material[] MovieMaterial => null;

		public bool PlayAutomatically
		{
			set
			{
			}
		}

		public int LoopCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float PlaySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ScanDuration
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SeekKeyFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Width { get; private set; }

		public int Height { get; private set; }

		public float AspectRatio => 0f;

		public double FPS => 0.0;

		public bool IsPlaying => false;

		public bool Pause
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public double PlayPosition
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Duration => 0.0;

		public event OnFinished onFinished
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

		[PreserveSig]
		private static extern IntPtr CreateContext();

		[PreserveSig]
		private static extern void DestroyContext(IntPtr context);

		[PreserveSig]
		private static extern bool OpenStream(IntPtr context, string path, int offset, int size, bool pot, bool scanDuration, int maxSkipFrames);

		[PreserveSig]
		private static extern void CloseStream(IntPtr context);

		[PreserveSig]
		private static extern int GetPicWidth(IntPtr context);

		[PreserveSig]
		private static extern int GetPicHeight(IntPtr context);

		[PreserveSig]
		private static extern int GetPicX(IntPtr context);

		[PreserveSig]
		private static extern int GetPicY(IntPtr context);

		[PreserveSig]
		private static extern int GetYStride(IntPtr context);

		[PreserveSig]
		private static extern int GetYHeight(IntPtr context);

		[PreserveSig]
		private static extern int GetUVStride(IntPtr context);

		[PreserveSig]
		private static extern int GetUVHeight(IntPtr context);

		[PreserveSig]
		private static extern bool HasFinished(IntPtr context);

		[PreserveSig]
		private static extern double GetDecodedFrameTime(IntPtr context);

		[PreserveSig]
		private static extern double GetUploadedFrameTime(IntPtr context);

		[PreserveSig]
		private static extern double GetTargetDecodeFrameTime(IntPtr context);

		[PreserveSig]
		private static extern void SetTargetDisplayDecodeTime(IntPtr context, double targetTime);

		[PreserveSig]
		private static extern double GetVideoFPS(IntPtr context);

		[PreserveSig]
		private static extern float GetAspectRatio(IntPtr context);

		[PreserveSig]
		private static extern double Seek(IntPtr context, double seconds, bool waitKeyFrame);

		[PreserveSig]
		private static extern double GetDuration(IntPtr context);

		[PreserveSig]
		private static extern IntPtr GetNativeHandle(IntPtr context, int planeIndex);

		[PreserveSig]
		private static extern IntPtr GetNativeTextureContext(IntPtr context);

		[PreserveSig]
		private static extern void SetPostProcessingLevel(IntPtr context, int level);

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		private void Open()
		{
		}

		private void AllocateTexures()
		{
		}

		public void SetTextures(Material material)
		{
		}

		public void RemoveTextures(Material material)
		{
		}

		private void CalculateUVScaleOffset()
		{
		}

		private void DestroyTextures()
		{
		}
	}
}
