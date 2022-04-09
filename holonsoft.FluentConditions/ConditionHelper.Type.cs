namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<T> IsOfType<T>(
    this ConditionValueHolder<T> valueHolder,
    Type type,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (type.IsAssignableFrom(value.GetType()))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
      valueHolder.ValueName,
      valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is not of type '{type}'!"));
  }

  public static ConditionValueHolder<TValue> IsOfType<TValue, TType>(
    this ConditionValueHolder<TValue> valueHolder,
    string exceptionMessage = null)
    => IsOfType(valueHolder, typeof(TType), exceptionMessage);

  public static ConditionValueHolder<T> IsNotOfType<T>(
    this ConditionValueHolder<T> valueHolder,
    Type type,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!type.IsAssignableFrom(value.GetType()))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
      valueHolder.ValueName,
      valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is of type '{type}'!"));
  }

  public static ConditionValueHolder<TValue> IsNotOfType<TValue, TType>(
    this ConditionValueHolder<TValue> valueHolder,
    string exceptionMessage = null)
    => IsNotOfType(valueHolder, typeof(TType), exceptionMessage);

  public static ConditionValueHolder<Type> IsOfType(
    this ConditionValueHolder<Type> valueHolder,
    Type type,
    string exceptionMessage = null)
  {
    var valueType = valueHolder.Value;

    if (type.IsAssignableFrom(valueType))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
      valueHolder.ValueName,
      valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{valueType}' is not of type '{type}'!"));
  }

  public static ConditionValueHolder<Type> IsOfType<TType>(
    this ConditionValueHolder<Type> valueHolder,
    string exceptionMessage = null)
    => IsOfType(valueHolder, typeof(TType), exceptionMessage);

  public static ConditionValueHolder<Type> IsNotOfType(
    this ConditionValueHolder<Type> valueHolder,
    Type type,
    string exceptionMessage = null)
  {
    var valueType = valueHolder.Value;

    if (!type.IsAssignableFrom(valueType))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
      valueHolder.ValueName,
      valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{valueType}' is not of type '{type}'!"));
  }

  public static ConditionValueHolder<Type> IsNotOfType<TType>(
    this ConditionValueHolder<Type> valueHolder,
    string exceptionMessage = null)
    => IsNotOfType(valueHolder, typeof(TType), exceptionMessage);

  public static ConditionValueHolder<Type> IsAbstract(
   this ConditionValueHolder<Type> valueHolder,
   string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (value.IsAbstract)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
      valueHolder.ValueName,
      valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is not abstract!"));
  }

  public static ConditionValueHolder<Type> IsNotAbstract(
    this ConditionValueHolder<Type> valueHolder,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!value.IsAbstract)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
      valueHolder.ValueName,
      valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is abstract!"));
  }
}