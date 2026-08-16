using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class InstanceResourceToObject : FsmStateAction
{
	[RequiredField]
	public LoadResourceType resourceType;

	[RequiredField]
	public FsmString resourceName;

	[RequiredField]
	public FsmGameObject targetObject;

	[RequiredField]
	public FsmString parentName;

	[RequiredField]
	public FsmFloat delay;

	private bool genOver;

	private float timer;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void InstanceResource()
	{
	}
}
