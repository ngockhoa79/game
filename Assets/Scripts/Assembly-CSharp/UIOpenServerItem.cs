using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIOpenServerItem : MonoBehaviour
{
	private const string Color1 = "[5b4436]";

	private const string Color2 = "[ba0f0a]";

	public UIOpenServerItemComplex complex;

	public UIOpenServerItemSimplex simplex;

	public OpenServerElement Element
	{
		set
		{
		}
	}

	private void set(OpenServerElement e)
	{
	}

	private void inactive()
	{
	}

	private void setComplex(OpenServerElement e)
	{
	}

	private string getRewardTitle()
	{
		return null;
	}

	private string getTaskDesc(int id, OpenServerTaskTemplate.TaskInfo_ ti, int c)
	{
		return null;
	}

	private void setSimplex(OpenServerElement e)
	{
	}

	private string shitFormat(string original, OpenServerTaskTemplate.TaskInfo_ ti, int current)
	{
		return null;
	}
}
