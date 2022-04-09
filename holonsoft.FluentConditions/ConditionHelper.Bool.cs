namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<bool> IsTrue(
    this ConditionValueHolder<bool> valueHolder,
    string exceptionMessage = null)
  {
    if (valueHolder.Value)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is false!"));
  }

  public static ConditionValueHolder<bool> IsFalse(
    this ConditionValueHolder<bool> valueHolder,
    string exceptionMessage = null)
  {
    if (!valueHolder.Value)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is true!"));
  }
}
