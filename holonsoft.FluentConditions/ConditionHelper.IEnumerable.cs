namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<IEnumerable<TElement>> IsEmpty<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    string exceptionMessage = null)
    => IsEmpty<TElement, IEnumerable<TElement>>(valueHolder, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> IsNotEmpty<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    string exceptionMessage = null)
    => IsNotEmpty<TElement, IEnumerable<TElement>>(valueHolder, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> Contains<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    TElement containsValue,
    string exceptionMessage = null)
    => Contains<TElement, IEnumerable<TElement>>(valueHolder, containsValue, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> DoesNotContain<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    TElement containsValue,
    string exceptionMessage = null)
    => DoesNotContain<TElement, IEnumerable<TElement>>(valueHolder, containsValue, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> ContainsAny<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null)
    => ContainsAny<TElement, IEnumerable<TElement>>(valueHolder, containsValues, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> DoesNotContainAny<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null)
    => DoesNotContainAny<TElement, IEnumerable<TElement>>(valueHolder, containsValues, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> ContainsAll<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null)
    => ContainsAll<TElement, IEnumerable<TElement>>(valueHolder, containsValues, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> DoesNotContainAll<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    IEnumerable<TElement> containsValues,
    string exceptionMessage = null)
    => DoesNotContainAll<TElement, IEnumerable<TElement>>(valueHolder, containsValues, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> HasCount<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int valueCount,
    string exceptionMessage = null)
    => HasCount<TElement, IEnumerable<TElement>>(valueHolder, valueCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> DoesNotHaveCount<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int valueCount,
    string exceptionMessage = null)
    => DoesNotHaveCount<TElement, IEnumerable<TElement>>(valueHolder, valueCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> CountIsInRange<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int minCount, int maxCount,
    string exceptionMessage = null)
    => CountIsInRange<TElement, IEnumerable<TElement>>(valueHolder, minCount, maxCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> CountIsNotInRange<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int minCount, int maxCount,
    string exceptionMessage = null)
    => CountIsNotInRange<TElement, IEnumerable<TElement>>(valueHolder, minCount, maxCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> CountIsLessThan<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int maxCount,
    string exceptionMessage = null)
    => CountIsLessThan<TElement, IEnumerable<TElement>>(valueHolder, maxCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> CountIsLessThanOrEqual<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int maxCount,
    string exceptionMessage = null)
    => CountIsLessThanOrEqual<TElement, IEnumerable<TElement>>(valueHolder, maxCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> CountIsGreaterThan<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int minCount,
    string exceptionMessage = null)
    => CountIsGreaterThan<TElement, IEnumerable<TElement>>(valueHolder, minCount, exceptionMessage);

  public static ConditionValueHolder<IEnumerable<TElement>> CountIsGreaterThanOrEqual<TElement>(
    this ConditionValueHolder<IEnumerable<TElement>> valueHolder,
    int minCount,
    string exceptionMessage = null)
    => CountIsGreaterThanOrEqual<TElement, IEnumerable<TElement>>(valueHolder, minCount, exceptionMessage);
}
