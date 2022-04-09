namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<TEnumerable> IsEmpty<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (!value.Any())
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is not empty!"));
  }

  public static ConditionValueHolder<TEnumerable> IsNotEmpty<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Any())
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' is empty!"));
  }

  public static ConditionValueHolder<TEnumerable> Contains<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    TElement containsValue,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Contains(containsValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' does not contain '{containsValue}'!"));
  }

  public static ConditionValueHolder<TEnumerable> DoesNotContain<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    TElement containsValue,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (!value.Contains(containsValue))
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' contains '{containsValue}'!"));
  }

  public static ConditionValueHolder<TEnumerable> ContainsAny<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Intersect(containsValues).Any())
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' does not contain one of the defined values!"));
  }

  public static ConditionValueHolder<TEnumerable> DoesNotContainAny<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (!value.Intersect(containsValues).Any())
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' contains one of the defined values!"));
  }

  public static ConditionValueHolder<TEnumerable> ContainsAll<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Intersect(containsValues).Count() == containsValues.Count())
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' does not contain all of the defined values!"));
  }

  public static ConditionValueHolder<TEnumerable> DoesNotContainAll<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Intersect(containsValues).Count() != containsValues.Count())
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' contains all of the defined values!"));
  }

  public static ConditionValueHolder<TEnumerable> HasCount<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int valueCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Count() == valueCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' has not the expected element count '{valueCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> DoesNotHaveCount<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int valueCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;

    if (value.Count() != valueCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' has an element count of '{valueCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> CountIsInRange<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int minCount, int maxCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;
    var valueCount = value.Count();

    if (valueCount >= minCount && valueCount <= maxCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' element count is not in the range of '{minCount}' to '{maxCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> CountIsNotInRange<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int minCount, int maxCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;
    var valueCount = value.Count();

    if (valueCount < minCount || valueCount > maxCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' element count is in the range of '{minCount}' to '{maxCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> CountIsLessThan<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int maxCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;
    var valueCount = value.Count();

    if (valueCount < maxCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' element count is bigger than '{maxCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> CountIsLessThanOrEqual<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int maxCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;
    var valueCount = value.Count();

    if (valueCount <= maxCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' element count is bigger than '{maxCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> CountIsGreaterThan<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int minCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;
    var valueCount = value.Count();

    if (valueCount > minCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' element count is smaller than '{minCount}'!"));
  }

  public static ConditionValueHolder<TEnumerable> CountIsGreaterThanOrEqual<TElement, TEnumerable>(
    this ConditionValueHolder<TEnumerable> valueHolder,
    int minCount,
    string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
  {
    IEnumerable<TElement> value = valueHolder.Value;
    var valueCount = value.Count();

    if (valueCount >= minCount)
    {
      return valueHolder;
    }

    throw new ArgumentOutOfRangeException(
        valueHolder.ValueName,
        valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder.ValueName}' element count is smaller than '{minCount}'!"));
  }
}
