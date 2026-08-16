using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class BuffTemplateManager : ConfigSingleExtend<BuffTemplateManager, BuffTemplate>
	{
		private readonly Dictionary<int, BuffStage> _needAffactFsmBuffDic;

		private readonly Dictionary<int, BuffStage> _needLockAllBuffDic;

		public BuffTemplate[] BuffArray => null;

		private void InitNeedAffactFsmBuffDic()
		{
		}

		public bool NeedAffactFsm(int _buffId, BuffStage _stage)
		{
			return false;
		}

		private void InitLockAllBuffDic()
		{
		}

		public bool NeedLockAll(int _buffId, BuffStage _stage)
		{
			return false;
		}
	}
}
