using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

public static class CharactersSkeletonDataList
{
	private class ThreadParam
	{
		public class Content
		{
			public string boneAndSlotJson;

			public string[] animationJson;
		}

		public Dictionary<CharactersType, Content> jaList;
	}

	private class ThreadProtobufParam
	{
		public Dictionary<CharactersType, byte[]> protoList;
	}

	[CompilerGenerated]
	private sealed class _003CLoadSkeletonDataAsync_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<CharactersType> charactersList;

		public Action callback;

		private List<CharactersType>.Enumerator _003C_003E7__wrap1;

		private CharactersType _003CcharacterType_003E5__3;

		private WWW _003Cwww_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadSkeletonDataAsync_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static bool UsingThread;

	public static CharacterSkeletonInitType initType;

	public static string skeletonPath;

	private static bool _initialized;

	private static Dictionary<CharactersType, SkeletonJsonData> _skeletonDataList;

	private static GameObject newGo;

	private static bool _threadCallback;

	private static ThreadProtobufParam param;

	public static bool Initialized => false;

	public static void Update()
	{
	}

	public static void InitAllSkeletonData()
	{
	}

	private static void ReadFromProtobuf(List<CharactersType> charactersList)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSkeletonDataAsync_003Ed__13))]
	private static IEnumerator LoadSkeletonDataAsync(List<CharactersType> charactersList, Action callback)
	{
		return null;
	}

	private static void AsyncLoadWithProtobuf(object paramObject)
	{
	}

	public static SkeletonJsonData GetOrLoad(CharactersType characterType)
	{
		return null;
	}

	private static void ReloadCharacters(List<CharactersType> charactersList)
	{
	}

	private static void ThreadCallback()
	{
	}

	private static void AsyncLoadSkeletonDataThread(object paramObject)
	{
	}

	private static SkeletonJsonData ReloadCharacter(CharactersType characterType, JsonAsset jsonAsset)
	{
		return null;
	}

	private static SkeletonJsonData ReloadCharacterPure(CharactersType characterType, string boneAndSlotJson, string[] animationJson)
	{
		return null;
	}
}
