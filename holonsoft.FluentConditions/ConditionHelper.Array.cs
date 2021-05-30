using System.Collections.Generic;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<TElement[]> IsEmpty<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			string exceptionMessage = null)
			=> IsEmpty<TElement, TElement[]>(valueHolder, exceptionMessage);

		public static ConditionValueHolder<TElement[]> IsNotEmpty<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			string exceptionMessage = null)
			=> IsNotEmpty<TElement, TElement[]>(valueHolder, exceptionMessage);

		public static ConditionValueHolder<TElement[]> Contains<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			TElement containsValue,
			string exceptionMessage = null)
			=> Contains<TElement, TElement[]>(valueHolder, containsValue, exceptionMessage);

		public static ConditionValueHolder<TElement[]> DoesNotContain<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			TElement containsValue,
			string exceptionMessage = null)
			=> DoesNotContain<TElement, TElement[]>(valueHolder, containsValue, exceptionMessage);

		public static ConditionValueHolder<TElement[]> ContainsAny<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> ContainsAny<TElement, TElement[]>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<TElement[]> DoesNotContainAny<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> DoesNotContainAny<TElement, TElement[]>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<TElement[]> ContainsAll<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> ContainsAll<TElement, TElement[]>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<TElement[]> DoesNotContainAll<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> DoesNotContainAll<TElement, TElement[]>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<TElement[]> HasCount<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int valueCount,
			string exceptionMessage = null)
			=> HasCount<TElement, TElement[]>(valueHolder, valueCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> DoesNotHaveCount<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int valueCount,
			string exceptionMessage = null)
			=> DoesNotHaveCount<TElement, TElement[]>(valueHolder, valueCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> CountIsInRange<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
			=> CountIsInRange<TElement, TElement[]>(valueHolder, minCount, maxCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> CountIsNotInRange<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
			=> CountIsNotInRange<TElement, TElement[]>(valueHolder, minCount, maxCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> CountIsLessThan<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int maxCount,
			string exceptionMessage = null)
			=> CountIsLessThan<TElement, TElement[]>(valueHolder, maxCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> CountIsLessThanOrEqual<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int maxCount,
			string exceptionMessage = null)
			=> CountIsLessThanOrEqual<TElement, TElement[]>(valueHolder, maxCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> CountIsGreaterThan<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int minCount,
			string exceptionMessage = null)
			=> CountIsGreaterThan<TElement, TElement[]>(valueHolder, minCount, exceptionMessage);

		public static ConditionValueHolder<TElement[]> CountIsGreaterThanOrEqual<TElement>(
			this ConditionValueHolder<TElement[]> valueHolder,
			int minCount,
			string exceptionMessage = null)
			=> CountIsGreaterThanOrEqual<TElement, TElement[]>(valueHolder, minCount, exceptionMessage);
	}
}
