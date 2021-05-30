using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{

		public static ConditionValueHolder<T> IsInRange<T>(
			this ConditionValueHolder<T> valueHolder,
			T minValue, T maxValue,
			string exceptionMessage = null) where T : IComparable<T>
		{
			T value = valueHolder._value;

			if (value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is not in the range of '{minValue}' to '{maxValue}'!"));
		}

		public static ConditionValueHolder<T> IsNotInRange<T>(
			this ConditionValueHolder<T> valueHolder,
			T minValue, T maxValue,
			string exceptionMessage = null) where T : IComparable<T>
		{
			T value = valueHolder._value;

			if (value.CompareTo(minValue) < 0 || value.CompareTo(maxValue) > 0)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is in the range of '{minValue}' to '{maxValue}'!"));
		}

		public static ConditionValueHolder<T> IsGreaterThan<T>(
			this ConditionValueHolder<T> valueHolder,
			T minValue,
			string exceptionMessage = null) where T : IComparable<T>
		{
			T value = valueHolder._value;

			if (value.CompareTo(minValue) > 0)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is smaller than '{minValue}'!"));
		}

		public static ConditionValueHolder<T> IsGreaterThanOrEqual<T>(
			this ConditionValueHolder<T> valueHolder,
			T minValue,
			string exceptionMessage = null) where T : IComparable<T>
		{
			T value = valueHolder._value;

			if (value.CompareTo(minValue) >= 0)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is smaller than '{minValue}'!"));
		}

		public static ConditionValueHolder<T> IsLessThan<T>(
			this ConditionValueHolder<T> valueHolder,
			T maxValue,
			string exceptionMessage = null) where T : IComparable<T>
		{
			T value = valueHolder._value;

			if (value.CompareTo(maxValue) < 0)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is bigger than '{maxValue}'!"));
		}

		public static ConditionValueHolder<T> IsLessThanOrEqual<T>(
			this ConditionValueHolder<T> valueHolder,
			T maxValue,
			string exceptionMessage = null) where T : IComparable<T>
		{
			T value = valueHolder._value;

			if (value.CompareTo(maxValue) <= 0)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is bigger than '{maxValue}'!"));
		}
	}
}
