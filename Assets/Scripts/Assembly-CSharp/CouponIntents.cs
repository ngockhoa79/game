using Ice.ProjectCos.UI.Intents;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

public class CouponIntents : IceUIIntent
{
	private const string IntentKeyword = "Coupon";

	public CouponIntents() : base()
	{
	}

	protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
	{
		if (panelCollector != null)
		{
			UIPanel panel;
			if (panelCollector.TryGetPanel("Coupon", out panel))
			{
				return panel;
			}
			panel = UILoader.Load<UIPanel>("UICoupon", "mainscene", panelCollector.transform);
			if (panel != null)
			{
				panelCollector.RegistPanel("Coupon", panel);
			}
			return panel;
		}
		return null;
	}

	protected override void SetPanelData()
	{
		base.SetPanelData();
	}

	protected override void ClearPanelData()
	{
		base.ClearPanelData();
	}
}
