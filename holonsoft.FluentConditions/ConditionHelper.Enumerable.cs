using System;
using System.Collections.Generic;
using System.Linq;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<TEnumerable> IsEmpty<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (!value.Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is not empty!"));
		}

		public static ConditionValueHolder<TEnumerable> IsNotEmpty<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is empty!"));
		}

		public static ConditionValueHolder<TEnumerable> Contains<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			TElement containsValue,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Contains(containsValue))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' does not contain '{containsValue}'!"));
		}

		public static ConditionValueHolder<TEnumerable> DoesNotContain<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			TElement containsValue,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (!value.Contains(containsValue))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' contains '{containsValue}'!"));
		}

		public static ConditionValueHolder<TEnumerable> ContainsAny<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Intersect(containsValues).Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' does not contain one of the defined values!"));
		}

		public static ConditionValueHolder<TEnumerable> DoesNotContainAny<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (!value.Intersect(containsValues).Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' contains one of the defined values!"));
		}

		public static ConditionValueHolder<TEnumerable> ContainsAll<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Intersect(containsValues).Count() == containsValues.Count())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' does not contain all of the defined values!"));
		}

		public static ConditionValueHolder<TEnumerable> DoesNotContainAll<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			IEnumerable<TElement> containsValues,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Intersect(containsValues).Count() != containsValues.Count())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' contains all of the defined values!"));
		}

		public static ConditionValueHolder<TEnumerable> HasCount<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int valueCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Count() == valueCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' has not the expected element count '{valueCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> DoesNotHaveCount<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int valueCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;

			if (value.Count() != valueCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' has an element count of '{valueCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> CountIsInRange<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount >= minCount && valueCount <= maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is not in the range of '{minCount}' to '{maxCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> CountIsNotInRange<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount < minCount || valueCount > maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is in the range of '{minCount}' to '{maxCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> CountIsLessThan<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int maxCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount < maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is bigger than '{maxCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> CountIsLessThanOrEqual<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int maxCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount <= maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is bigger than '{maxCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> CountIsGreaterThan<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int minCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount > minCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is smaller than '{minCount}'!"));
		}

		public static ConditionValueHolder<TEnumerable> CountIsGreaterThanOrEqual<TElement, TEnumerable>(
			this ConditionValueHolder<TEnumerable> valueHolder,
			int minCount,
			string exceptionMessage = null) where TEnumerable : IEnumerable<TElement>
		{
			IEnumerable<TElement> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount >= minCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is smaller than '{minCount}'!"));
		}
	}
}
