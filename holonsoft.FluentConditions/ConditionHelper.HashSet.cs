using System.Collections.Generic;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<HashSet<TElement>> IsEmpty<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			string exceptionMessage = null)
			=> IsEmpty<TElement, HashSet<TElement>>(valueHolder, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> IsNotEmpty<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			string exceptionMessage = null)
			=> IsNotEmpty<TElement, HashSet<TElement>>(valueHolder, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> Contains<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			TElement containsValue,
			string exceptionMessage = null)
			=> Contains<TElement, HashSet<TElement>>(valueHolder, containsValue, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> DoesNotContain<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			TElement containsValue,
			string exceptionMessage = null)
			=> DoesNotContain<TElement, HashSet<TElement>>(valueHolder, containsValue, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> ContainsAny<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> ContainsAny<TElement, HashSet<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> DoesNotContainAny<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> DoesNotContainAny<TElement, HashSet<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> ContainsAll<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> ContainsAll<TElement, HashSet<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> DoesNotContainAll<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null)
			=> DoesNotContainAll<TElement, HashSet<TElement>>(valueHolder, containsValues, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> HasCount<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int valueCount,
			string exceptionMessage = null)
			=> HasCount<TElement, HashSet<TElement>>(valueHolder, valueCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> DoesNotHaveCount<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int valueCount,
			string exceptionMessage = null)
			=> DoesNotHaveCount<TElement, HashSet<TElement>>(valueHolder, valueCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> CountIsInRange<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
			=> CountIsInRange<TElement, HashSet<TElement>>(valueHolder, minCount, maxCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> CountIsNotInRange<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
			=> CountIsNotInRange<TElement, HashSet<TElement>>(valueHolder, minCount, maxCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> CountIsLessThan<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int maxCount,
			string exceptionMessage = null)
			=> CountIsLessThan<TElement, HashSet<TElement>>(valueHolder, maxCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> CountIsLessThanOrEqual<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int maxCount,
			string exceptionMessage = null)
			=> CountIsLessThanOrEqual<TElement, HashSet<TElement>>(valueHolder, maxCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> CountIsGreaterThan<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int minCount,
			string exceptionMessage = null)
			=> CountIsGreaterThan<TElement, HashSet<TElement>>(valueHolder, minCount, exceptionMessage);

		public static ConditionValueHolder<HashSet<TElement>> CountIsGreaterThanOrEqual<TElement>(
			this ConditionValueHolder<HashSet<TElement>> valueHolder,
			int minCount,
			string exceptionMessage = null)
			=> CountIsGreaterThanOrEqual<TElement, HashSet<TElement>>(valueHolder, minCount, exceptionMessage);
	}
}
