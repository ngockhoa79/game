using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

namespace Ice.ProjectCos.Config
{
	public class ClientDataConfigTemplateManager : ConfigSingle<ClientDataConfigTemplateManager, ClientDataConfigTemplate>
	{
		private Dictionary<string, float> _valueDic;

		public Dictionary<string, float> ValueDic => null;

		private void AddFloat(string _name, float _value)
		{
		}

		public float GetClientConfigData(string _name)
		{
			return 0f;
		}
	}
}
