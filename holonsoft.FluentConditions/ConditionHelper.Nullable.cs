using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<T> HasValue<T>(
			this ConditionValueHolder<Nullable<T>> valueHolder,
			string exceptionMessage = null) where T : struct
		{
			T? value = valueHolder._value;

			if (value.HasValue)
				return Requires(value.Value, valueHolder);

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"Nullable '{valueHolder._valueName}' has no value!"));
		}

		public static ConditionValueHolder<Nullable<T>> HasNoValue<T>(
			this ConditionValueHolder<Nullable<T>> valueHolder,
			string exceptionMessage = null) where T : struct
		{
			T? value = valueHolder._value;

			if (!value.HasValue)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"Nullable '{valueHolder._valueName}' has a value '{value.Value}'!"));
		}
	}
}
