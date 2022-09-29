namespace SqlBulkTools.BulkCopy
{
	public struct ColumnMapping
	{
		public string ColumnName { get; set; }
		public string PropertyName { get; set; }

		public ColumnMapping(string propertyName, string columnName) : this()
		{
			PropertyName = propertyName;
			ColumnName = columnName;
		}
	}
}