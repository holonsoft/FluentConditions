using System.Collections.Generic;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<List<TElement>> IsEmpty<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			string exceptionMessage = null)
			=> IsEmpty<TElement, List<TElement>>(valueHolder, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> IsNotEmpty<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			string exceptionMessage = null)
			=> IsNotEmpty<TElement, List<TElement>>(valueHolder, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> Contains<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			TElement containsValue,
			string exceptionMessage = null)
			=> Contains<TElement, List<TElement>>(valueHolder, containsValue, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> DoesNotContain<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			TElement containsValue,
			string exceptionMessage = null)
			=> DoesNotContain<TElement, List<TElement>>(valueHolder, containsValue, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> ContainsAny<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> ContainsAny<TElement, List<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> DoesNotContainAny<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> DoesNotContainAny<TElement, List<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> ContainsAll<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> ContainsAll<TElement, List<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> DoesNotContainAll<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> DoesNotContainAll<TElement, List<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> HasCount<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int valueCount,
			string exceptionMessage = null)
			=> HasCount<TElement, List<TElement>>(valueHolder, valueCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> DoesNotHaveCount<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int valueCount,
			string exceptionMessage = null)
			=> DoesNotHaveCount<TElement, List<TElement>>(valueHolder, valueCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> CountIsInRange<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
			=> CountIsInRange<TElement, List<TElement>>(valueHolder, minCount, maxCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> CountIsNotInRange<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
			=> CountIsNotInRange<TElement, List<TElement>>(valueHolder, minCount, maxCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> CountIsLessThan<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int maxCount,
			string exceptionMessage = null)
			=> CountIsLessThan<TElement, List<TElement>>(valueHolder, maxCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> CountIsLessThanOrEqual<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int maxCount,
			string exceptionMessage = null)
			=> CountIsLessThanOrEqual<TElement, List<TElement>>(valueHolder, maxCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> CountIsGreaterThan<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int minCount,
			string exceptionMessage = null)
			=> CountIsGreaterThan<TElement, List<TElement>>(valueHolder, minCount, exceptionMessage);

		public static ConditionValueHolder<List<TElement>> CountIsGreaterThanOrEqual<TElement>(
			this ConditionValueHolder<List<TElement>> valueHolder,
			int minCount,
			string exceptionMessage = null)
			=> CountIsGreaterThanOrEqual<TElement, List<TElement>>(valueHolder, minCount, exceptionMessage);
	}
}
