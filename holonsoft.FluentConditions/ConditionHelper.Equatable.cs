using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<T> IsEqualTo<T>(
			this ConditionValueHolder<T> valueHolder,
			T equalValue,
			string exceptionMessage = null) where T : IEquatable<T>
		{
			T value = valueHolder._value;

			if (value.Equals(equalValue))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is not equal to '{equalValue}'!"));
		}

		public static ConditionValueHolder<T> IsNotEqualTo<T>(
			this ConditionValueHolder<T> valueHolder,
			T equalValue,
			string exceptionMessage = null) where T : IEquatable<T>
		{
			T value = valueHolder._value;

			if (!value.Equals(equalValue))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is equal to '{equalValue}'!"));
		}
	}
}
