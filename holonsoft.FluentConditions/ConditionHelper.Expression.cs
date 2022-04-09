namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<T> Evaluate<T>(
    this ConditionValueHolder<T> valueHolder,
    Func<T, bool> expression,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (expression(value))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' does not fit criteria '{expression}'!"));
  }
}
