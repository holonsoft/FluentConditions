using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<T> Evaluate<T>(
			this ConditionValueHolder<T> valueHolder,
			Func<T, bool> expression,
			string exceptionMessage = null)
		{
			T value = valueHolder._value;

			if (expression(value))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' does not fit criteria '{expression}'!"));
		}
	}
}
