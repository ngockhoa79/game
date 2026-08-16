using UnityEngine;

public interface IceUIListImplementor<Data, Widget> where Widget : Component
{
	Widget CreateWidget(Transform itemsHolder);

	GameObject CreateSeparator(Transform itemsHolder);

	void SetData(Widget widget, Data data);
}
