using System;
using System.Collections.Generic;
using System.Linq;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<IEnumerable<T>> IsEmpty<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (!value.Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is not empty!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> IsNotEmpty<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is empty!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> Contains<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			T containsValue,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Contains(containsValue))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' does not contain '{containsValue}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> DoesNotContain<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			T containsValue,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (!value.Contains(containsValue))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' contains '{containsValue}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> ContainsAny<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			IEnumerable<T> containsValues,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Intersect(containsValues).Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' does not contain one of the defined values!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> DoesNotContainAny<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			IEnumerable<T> containsValues,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (!value.Intersect(containsValues).Any())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' contains one of the defined values!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> ContainsAll<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			IEnumerable<T> containsValues,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Intersect(containsValues).Count() == containsValues.Count())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' does not contain all of the defined values!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> DoesNotContainAll<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			IEnumerable<T> containsValues,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Intersect(containsValues).Count() != containsValues.Count())
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' contains all of the defined values!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> HasCount<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int valueCount,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Count() == valueCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' has not the expected element count '{valueCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> DoesNotHaveCount<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int valueCount,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;

			if (value.Count() != valueCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' has an element count of '{valueCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> CountIsInRange<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount >= minCount && valueCount <= maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is not in the range of '{minCount}' to '{maxCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> CountIsNotInRange<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int minCount, int maxCount,
			string exceptionMessage = null)
		{
			IEnumerable<T> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount < minCount || valueCount > maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is in the range of '{minCount}' to '{maxCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> CountIsLessThan<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int maxCount,
			string exceptionMessage = null) where T : IComparable<T>
		{
			IEnumerable<T> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount < maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is bigger than '{maxCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> CountIsLessThanOrEqual<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int maxCount,
			string exceptionMessage = null) where T : IComparable<T>
		{
			IEnumerable<T> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount <= maxCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is bigger than '{maxCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> CountIsGreaterThan<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int minCount,
			string exceptionMessage = null) where T : IComparable<T>
		{
			IEnumerable<T> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount > minCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is smaller than '{minCount}'!"));
		}

		public static ConditionValueHolder<IEnumerable<T>> CountIsGreaterThanOrEqual<T>(
			this ConditionValueHolder<IEnumerable<T>> valueHolder,
			int minCount,
			string exceptionMessage = null) where T : IComparable<T>
		{
			IEnumerable<T> value = valueHolder._value;
			int valueCount = value.Count();

			if (valueCount >= minCount)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' element count is smaller than '{minCount}'!"));
		}
	}
}
