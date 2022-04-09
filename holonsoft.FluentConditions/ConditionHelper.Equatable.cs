namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<T> IsEqualTo<T>(
    this ConditionValueHolder<T> valueHolder,
    T equalValue,
    string exceptionMessage = null) where T : IEquatable<T>
  {
    var value = valueHolder.Value;

    if (value.Equals(equalValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is not equal to '{equalValue}'!"));
  }

  public static ConditionValueHolder<T> IsNotEqualTo<T>(
    this ConditionValueHolder<T> valueHolder,
    T equalValue,
    string exceptionMessage = null) where T : IEquatable<T>
  {
    var value = valueHolder.Value;

    if (!value.Equals(equalValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is equal to '{equalValue}'!"));
  }
}
