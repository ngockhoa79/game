using Ice.ProjectCos.UI.DataModel;

public sealed class PriceInfo
{
	public CurrencyType CurrencyType { get; private set; }

	public int Count { get; private set; }

	public PriceInfo(int propertyType, int count)
	{
	}
}
