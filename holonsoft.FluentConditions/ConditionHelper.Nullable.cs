namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<T> HasValue<T>(
    this ConditionValueHolder<Nullable<T>> valueHolder,
    string exceptionMessage = null) where T : struct
  {
    var value = valueHolder.Value;

    if (value.HasValue)
    {
      return Requires(value.Value, valueHolder);
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"Nullable '{valueHolder.ValueName}' has no value!"));
  }

  public static ConditionValueHolder<Nullable<T>> HasNoValue<T>(
    this ConditionValueHolder<Nullable<T>> valueHolder,
    string exceptionMessage = null) where T : struct
  {
    var value = valueHolder.Value;

    if (!value.HasValue)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"Nullable '{valueHolder.ValueName}' has a value '{value.Value}'!"));
  }
}
