using Ice.ProjectCos.UI.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class UIMainSceneTopPanel : IceUIBase
{
	[CompilerGenerated]
	private sealed class _003C_Get_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<bool, string> action;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003C_Get_003Ed__63(int _003C_003E1__state)
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

	public static UINotification globalNotification;

	public static UIBulletinPanel globalBulletinPanel;

	public Action E_OnAddCrystal;

	public Action E_OnAddGold;

	public Action E_OnAddEnergy;

	public Action E_OnMail;

	public Action E_OnChat;

	public Action E_OnActivity;

	public Action E_OnTask;

	public Action E_OnHongBao;

	public Action E_OnCheckin;

	public Action E_OnProjGrowth;

	public Action E_OnVip;

	public Action E_OnShopMistry;

	public Action E_OnPlayerInfo;

	public Action E_OnHuoDong;

	public Action E_OnLianHua;

	public Action E_OnIllustDict;

	public Action E_OnOpenCele;

	public Action E_OnNextNewFunction;

	public static Action<bool> OnRedpackChanged;

	public UIMainScenePlayerInfo uiPlayerInfo;

	public UILabel lbCrystal;

	public UILabel lbGold;

	public UILabel lbEnergy;

	public UIEventListener btnAddCrystal;

	public UIEventListener btnAddGold;

	public UIEventListener btnAddEnergy;

	public UIEventListener btnMail;

	public UIEventListener btnChat;

	public UIEventListener btnActivity;

	public UIEventListener btnTask;

	public UIEventListener btnHongBao;

	public UIEventListener btnCheckin;

	public UIEventListener btnProjGrowth;

	public UIEventListener bnShopMistery;

	public UIEventListener btnPlayerInfo;

	public UIEventListener btnLianHua;

	public UIEventListener btnHuoDong;

	public UIEventListener btnOnlineReward;

	public UIEventListener btnOpenCele;

	public UIEventListener btnIllustDict;

	public UIEventListener btnNextNewFunction;

	public UIEventListener btnBindMobile;

	public UIEventListener btnChangeBG;

	public Transform notificationRoot;

	public UINotification uiNotification;

	public UIPanel bulletinBoard;

	public UIOnlineReward uiOnlineReward;

	public UIGrid uiGrid;

	public GameObject CheckinReddot;

	public IceAnimatorTotalCommander CheckinReddotAni;

	public UIEventListener btnAds;

	public UIEventListener fullBtn;

	public UISprite fullSprite;

	private const string QiangHongBao = "MainScene_text_LingHongBao";

	private const string FaHongBao = "MainScene_text_FaHongBao";

	private const string Child = "Text";

	private void Start()
	{
	}

	protected override void DoPrepare()
	{
		RefreshDynaticData();
	}

	private void UpdateFullSprite()
	{
	}

	private void callb(bool b, string s)
	{
	}

	public void Get(string url, Action<bool, string> actionResult = null)
	{
	}

	[IteratorStateMachine(typeof(_003C_Get_003Ed__63))]
	private IEnumerator _Get(string url, Action<bool, string> action)
	{
		return null;
	}

	private void SetBoundBtnFalse()
	{
	}

	private void hideTemporarily()
	{
	}

	private void handleRedpackBtnStatus(bool code)
	{
	}

	private void handleNextNewBtnStatus()
	{
	}

	protected override void DoShowOnscreen()
	{
		RefreshDynaticData();
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void Update()
	{
	}

	private void RefreshDynaticData()
	{
		if (Me.Ins == null) return;
		if (lbGold != null)
		{
			// [RECOVERED]
			lbGold.text = Me.Ins.PlayerInfo.Gold.ToString("N0");
		}
		if (lbCrystal != null)
		{
			// [RECOVERED]
			lbCrystal.text = Me.Ins.PlayerInfo.Crystal.ToString("N0");
		}
		if (lbEnergy != null)
		{
			// [RECOVERED]
			lbEnergy.text = Me.Ins.PlayerInfo.Energy.ToString();
		}
		if (uiPlayerInfo != null)
		{
			uiPlayerInfo.PlayerData();
		}
	}

	private void ClearDynaticData()
	{
	}

	public void UpdateEnergy(int energy)
	{
		if (lbEnergy != null)
		{
			lbEnergy.text = energy.ToString();
		}
	}

	public void OnShopMisteryAppear()
	{
	}

	public void UpdateCheckinRedDot()
	{
	}

	public void OnBulletinPanelClick()
	{
	}
}
