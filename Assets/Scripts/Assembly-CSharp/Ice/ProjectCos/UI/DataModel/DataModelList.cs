using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class DataModelList<T> : DataModelBase
	{
		protected List<T> _list;

		protected void SetList(List<T> newList)
		{
		}

		protected void Clear()
		{
		}

		protected T GetListItemAt(int index)
		{
			return default(T);
		}

		protected int GetCount()
		{
			return 0;
		}
	}
}
