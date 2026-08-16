namespace Ice.ProjectCos.ConfigGenerator.Xml.Template
{
	public class ServerInfoTemplate : IGeneratorObject
	{
		public int State { get; private set; }

		public string ID { get; private set; }

		public string Name { get; private set; }

		public string IpAddress { get; private set; }

		public int Port { get; private set; }

		public virtual void Read(ConfigElement element)
		{
		}

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ServerInfoTemplate, new()
		{
			return null;
		}

		public static ServerInfoTemplate[] Load()
		{
			return null;
		}
	}
}
