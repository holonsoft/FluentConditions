namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<string> IsNullOrWhiteSpace(
    this ConditionValueHolder<string> valueHolder,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (string.IsNullOrWhiteSpace(value))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is not null or whitespace!"));
  }

  public static ConditionValueHolder<string> IsNotNullOrWhiteSpace(
    this ConditionValueHolder<string> valueHolder,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!string.IsNullOrWhiteSpace(value))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is null or whitespace!"));
  }

  public static ConditionValueHolder<string> IsNullOrEmpty(
    this ConditionValueHolder<string> valueHolder,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (string.IsNullOrEmpty(value))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' is not null or empty!"));
  }

  public static ConditionValueHolder<string> IsNotNullOrEmpty(
    this ConditionValueHolder<string> valueHolder,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!string.IsNullOrEmpty(value))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is null or empty!"));
  }

  public static ConditionValueHolder<string> IsShorterThan(
    this ConditionValueHolder<string> valueHolder,
    int maxLength,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value ?? "";
    var length = value.Length;

    if (length < maxLength)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' and length '{length}' is longer than '{maxLength}'!"));
  }

  public static ConditionValueHolder<string> IsShorterThanOrEqual(
    this ConditionValueHolder<string> valueHolder,
    int maxLength,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value ?? "";
    var length = value.Length;

    if (length <= maxLength)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' and length '{length}' is longer than '{maxLength}'!"));
  }

  public static ConditionValueHolder<string> IsLongerThan(
    this ConditionValueHolder<string> valueHolder,
    int minLength,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value ?? "";
    var length = value.Length;

    if (length > minLength)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' and length '{length}' is shorter than '{minLength}'!"));
  }

  public static ConditionValueHolder<string> IsLongerThanOrEqual(
    this ConditionValueHolder<string> valueHolder,
    int minLength,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value ?? "";
    var length = value.Length;

    if (length >= minLength)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' and length '{length}' is shorter than '{minLength}'!"));
  }

  public static ConditionValueHolder<string> HasLength(
    this ConditionValueHolder<string> valueHolder,
    int requiredLength,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value ?? "";
    var length = value.Length;

    if (length == requiredLength)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' and length '{length}' does not fit the required length '{requiredLength}'!"));
  }

  public static ConditionValueHolder<string> LengthInRange(
    this ConditionValueHolder<string> valueHolder,
    int minLength,
    int maxLength,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value ?? "";
    var length = value.Length;

    if (length >= minLength && length <= maxLength)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' and length '{length}' does not fit the required length range of '{minLength}' to '{maxLength}'!"));
  }

  public static ConditionValueHolder<string> StartsWith(
    this ConditionValueHolder<string> valueHolder,
    string startsWithValue,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (value.StartsWith(startsWithValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' does not start with '{startsWithValue}'!"));
  }

  public static ConditionValueHolder<string> DoesNotStartWith(
    this ConditionValueHolder<string> valueHolder,
    string startsWithValue,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!value.StartsWith(startsWithValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' starts with '{startsWithValue}'!"));
  }

  public static ConditionValueHolder<string> EndsWith(
    this ConditionValueHolder<string> valueHolder,
    string endsWithValue,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (value.EndsWith(endsWithValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' does not end with '{endsWithValue}'!"));
  }

  public static ConditionValueHolder<string> DoesNotEndWith(
    this ConditionValueHolder<string> valueHolder,
    string endsWithValue,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!value.EndsWith(endsWithValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' ends with '{endsWithValue}'!"));
  }

  public static ConditionValueHolder<string> Contains(
    this ConditionValueHolder<string> valueHolder,
    string containsValue,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (value.Contains(containsValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' does not contain '{containsValue}'!"));
  }

  public static ConditionValueHolder<string> DoesNotContain(
    this ConditionValueHolder<string> valueHolder,
    string containsValue,
    string exceptionMessage = null)
  {
    var value = valueHolder.Value;

    if (!value.Contains(containsValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' with value '{value}' contains '{containsValue}'!"));
  }
}
