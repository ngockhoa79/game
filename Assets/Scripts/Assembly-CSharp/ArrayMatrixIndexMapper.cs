public class ArrayMatrixIndexMapper
{
	public int RowCount { get; private set; }

	public int ColumnCount { get; private set; }

	public bool IsLeftToRight { get; private set; }

	public bool IsTopToBottom { get; private set; }

	public ArrayMatrixIndexMapper(int rowCount, int columnCount, bool isLeftToRight, bool isTopToBottom)
	{
	}

	public void ArrayIndexToRowColumn(int index, out int row, out int column)
	{
		row = default(int);
		column = default(int);
	}

	public int RowColumnToArrayIndex(int row, int column)
	{
		return 0;
	}
}
