using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<T> IsNull<T>(
			this ConditionValueHolder<T> valueHolder,
			string exceptionMessage = null) where T : class
		{
			T value = valueHolder._value;

			if (value == null)
				return valueHolder;

			throw new ArgumentNullException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is not null!"));
		}

		public static ConditionValueHolder<T> IsNotNull<T>(
			this ConditionValueHolder<T> valueHolder,
			string exceptionMessage = null) where T : class
		{
			T value = valueHolder._value;

			if (value != null)
				return valueHolder;

			throw new ArgumentNullException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is null!"));
		}
	}
}
