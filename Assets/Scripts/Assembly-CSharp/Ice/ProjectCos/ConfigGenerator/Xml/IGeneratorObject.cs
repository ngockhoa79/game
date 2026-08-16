namespace Ice.ProjectCos.ConfigGenerator.Xml
{
	internal interface IGeneratorObject
	{
		void Read(ConfigElement item);

		void Init();
	}
}
