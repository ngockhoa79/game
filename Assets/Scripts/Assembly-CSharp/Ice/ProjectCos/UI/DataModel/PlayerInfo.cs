using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class PlayerInfo : DataModelBase
	{
		public static Action<int, int> OnPreem;

		public Action<int> OnEnergyChanged;

		public Action<int> OnStatimaChanged;

		public Action<int> OnCrystalChanged;

		public Action<int> OnGoldChanged;

		public Action<int> OnReputaionChanged;

		public Action<int> OnTrailCoinChanged;

		public Action<int> OnTransformSoulChanged;

		public Action<int> ActionDouChangCoinChanged;

		public Action<int> OnCreditChanged;

		private int _crystal;

		private int m_BuyCrystal;

		private int _gold;

		private int _douChangBi;

		private int _energy;

		private int _transformSoul;

		private int _reputation;

		private int _trialCoin;

		private int _guildContribution;

		private int _makyouCoin;

		private int _totalExp;

		private int _level;

		private DateTime _lastRefreshEnergyTime;

		public int BoughtEnergyTimes;

		public int BuyGoldTimes;

		private TimeSpan EnergyRemainSpan;

		private float EnergyRemainTimeSpan;

		private TimeSpan TotalEnergyRemainSpan;

		private int energyUpdateInterval;

		private int energyLimit;

		private Timer activeTimer;

		private Timer autoTimer;

		private Timer energyActiveTimer;

		private Timer energyAutoTimer;

		public int Crystal
		{
			get => _crystal;
			set => _crystal = value;
		}

		public int BuyCrystal
		{
			get => m_BuyCrystal;
			set => m_BuyCrystal = value;
		}

		public int Gold
		{
			get => _gold;
			set => _gold = value;
		}

		public int ShenYuCoin
		{
			get => 0;
			set {}
		}

		public int Energy
		{
			get => _energy;
			set => _energy = value;
		}

		public int TransformSoul
		{
			get => _transformSoul;
			set => _transformSoul = value;
		}

		public int Reputation
		{
			get => _reputation;
			set => _reputation = value;
		}

		public int TrialCoin
		{
			get => _trialCoin;
			set => _trialCoin = value;
		}

		public int GuildContribution
		{
			get => _guildContribution;
			set => _guildContribution = value;
		}

		public int MakyouCoin
		{
			get => _makyouCoin;
			set => _makyouCoin = value;
		}

		public int TotalExp
		{
			get => _totalExp;
			set => _totalExp = value;
		}

		public int Level
		{
			get => _level;
			set => _level = value;
		}

		public DateTime LastRefreshEnergyTime
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public float LevelRatio => 0f;

		public string ExpFullDesc => null;

		public int EnergyMax => 0;

		public string EnergyFullDesc => null;

		public int Credit => 0;

		public string EnergyRemainTime => null;

		public string TotalEnergyRemainTime => null;

		public int TotalEnergyRemainSecond => 0;

		public PlayerInfo()
		{
		}

		public PlayerInfo(PlayerInfo src)
		{
		}

		public void ReloadFromProto(PlayerPropertyInfoProto proto)
		{
		}

		public bool IsEnergyMax()
		{
			return false;
		}

		public bool IsEnoughCredit(int cost)
		{
			return false;
		}

		public void ClearTimer()
		{
		}

		public void StartTimer()
		{
		}

		private void _energy_max()
		{
		}

		private void _energy_start_consume()
		{
		}

		private void OnActiveTimer(Timer self)
		{
		}

		private void OnAutoUpdateEnergy(Timer self)
		{
		}

		private void OnEnergyActiveRemainTimer(Timer self)
		{
		}

		private void RefreshNewFunctionOpen(int cur_level)
		{
		}

		public void ClearNewFunctionOpen()
		{
		}

		public bool IsEnoughCrystal(int cost)
		{
			return false;
		}

		public bool IsEnougGold(int cost)
		{
			return false;
		}

		public bool IsEnoughTrailCoin(int cost)
		{
			return false;
		}

		public bool IsEnoughSoul(int cost)
		{
			return false;
		}

		public bool IsEnoughReputation(int cost)
		{
			return false;
		}

		public bool IsEnoughEnergy(int cost)
		{
			return false;
		}
	}
}
