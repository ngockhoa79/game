public class IllustDictPageCombination
{
	protected int[] LogicalIndices;

	protected int TotalPage;

	protected int Key;

	public int this[int index] => 0;

	public bool IsUninitialized => false;

	public int KeyIndex => 0;

	public int LeftIndex => 0;

	public int RightIndex => 0;

	public int CurrentLogicalPage => 0;

	public int LeftLogicalPage => 0;

	public int RightLogicalPage => 0;

	public IllustDictPageCombination(int keyPage, int totalPage)
	{
	}

	private IllustDictPageCombination()
	{
	}

	public IllustDictPageCombination PredictNextCombination(int newKeyPage)
	{
		return null;
	}

	public static IllustDictPageCombination GetUninitializedCombination()
	{
		return null;
	}
}
