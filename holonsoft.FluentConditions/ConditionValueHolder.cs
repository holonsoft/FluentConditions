namespace holonsoft.FluentConditions;
public readonly ref struct ConditionValueHolder<T>
{
  internal readonly T Value;

  internal readonly string ValueName;
  internal readonly string CallerMemberName;
  internal readonly string SourceFilePath;
  internal readonly int SourceLineNumber;

  public ConditionValueHolder(T value, string valueName, string callerMemberName, string sourceFilePath, int sourceLineNumber)
  {
    Value = value;
    ValueName = valueName;
    CallerMemberName = callerMemberName;
    SourceFilePath = sourceFilePath;
    SourceLineNumber = sourceLineNumber;
  }
}
