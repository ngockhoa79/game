namespace Ice.ProjectCos.Config
{
	public class ConfigSingle<T, T1> where T : ConfigSingle<T, T1>, new() where T1 : class
	{
		protected T1[] items_;

		public static T Instance { get; protected set; }

		public static void Load()
		{
		}

		protected void Init(T1[] array)
		{
		}
	}
}
