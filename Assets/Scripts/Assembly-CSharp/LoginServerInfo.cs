using Ice.ProjectCos.Config;

public class LoginServerInfo
{
	public string DisplayId { get; set; }

	public string Id { get; set; }

	public string Name { get; set; }

	public int State { get; set; }

	public string Ip { get; set; }

	public int Port { get; set; }

	public static LoginServerInfo ConvertFrom(MyServerInfo.ServerInfoTemplate template)
	{
		if (template == null)
		{
			return null;
		}
		return new LoginServerInfo
		{
			DisplayId = template.DisplayID,
			Id = template.ID,
			Name = template.Name,
			State = (int)template.State,
			Ip = template.IpAddress,
			Port = template.Port
		};
	}
}
