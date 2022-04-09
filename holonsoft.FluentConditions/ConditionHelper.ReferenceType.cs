namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<T> IsNull<T>(
    this ConditionValueHolder<T> valueHolder,
    string exceptionMessage = null) where T : class
  {
    var value = valueHolder.Value;

    if (value == null)
    {
      return valueHolder;
    }

    throw new ArgumentNullException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is not null!"));
  }

  public static ConditionValueHolder<T> IsNotNull<T>(
    this ConditionValueHolder<T> valueHolder,
    string exceptionMessage = null) where T : class
  {
    var value = valueHolder.Value;

    if (value != null)
    {
      return valueHolder;
    }

    throw new ArgumentNullException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is null!"));
  }
}
