namespace holonsoft.FluentConditions
{
	public readonly ref struct ConditionValueHolder<T>
	{
		internal readonly T _value;

		internal readonly string _valueName;
		internal readonly string _callerMemberName;
		internal readonly string _sourceFilePath;
		internal readonly int _sourceLineNumber;

		public ConditionValueHolder(T value, string valueName, string callerMemberName, string sourceFilePath, int sourceLineNumber)
		{
			_value = value;
			_valueName = valueName;
			_callerMemberName = callerMemberName;
			_sourceFilePath = sourceFilePath;
			_sourceLineNumber = sourceLineNumber;
		}
	}
}
