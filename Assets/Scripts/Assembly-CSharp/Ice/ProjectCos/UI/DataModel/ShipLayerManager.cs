using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ShipLayerManager
	{
		public static readonly int SHIP_DISPLAY_RANGE;

		public static readonly int SHIP_DEPTH_BASE;

		public static readonly int SHIP_LAYER_INTERVAL;

		public static readonly int SHIP_SUBLAYER_INTERVAL;

		public static readonly int SHIP_MAX_COUNT;

		public Dictionary<int, int>[] ShipSubLayerPool;

		public List<ShipLayerInfo> ShipLayerInfos;

		~ShipLayerManager()
		{
		}

		private void ClearSubLayerPool()
		{
		}

		public ShipLayerInfo FindShipLayerInfo(int shipID)
		{
			return null;
		}

		public void RebuildSubLayerPool()
		{
		}

		public void Clear()
		{
		}

		private void RegisterShipLayerInfo(ShipLayerInfo newInfo)
		{
		}

		public ShipLayerInfo FetchShipLayerInfo(int shipID)
		{
			return null;
		}

		public void RemoveShipLayerInfo(int shipID)
		{
		}

		private int GetAFreeSubLayer(int layerID)
		{
			return 0;
		}

		private int GetTotalCount()
		{
			return 0;
		}
	}
}
