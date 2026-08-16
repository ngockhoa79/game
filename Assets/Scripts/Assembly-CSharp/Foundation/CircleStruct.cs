namespace Foundation
{
	public class CircleStruct<Data> where Data : class
	{
		private class InternalData<DataClass> where DataClass : class
		{
			public InternalData<DataClass> Preview;

			public Data MyData;

			public InternalData<DataClass> Next;
		}

		private InternalData<Data>[] _list;

		private InternalData<Data> _prepareToSetData;

		public CircleStruct(int maxCount)
		{
		}

		public Data[] GetListFromLast()
		{
			return null;
		}

		public void PushNewAnnouncement(Data _data)
		{
		}
	}
}
