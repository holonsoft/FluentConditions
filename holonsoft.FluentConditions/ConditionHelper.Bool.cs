using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<bool> IsTrue(
			this ConditionValueHolder<bool> valueHolder,
			string exceptionMessage = null)
		{
			if (valueHolder._value)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is false!"));
		}

		public static ConditionValueHolder<bool> IsFalse(
			this ConditionValueHolder<bool> valueHolder,
			string exceptionMessage = null)
		{
			if (!valueHolder._value)
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' is true!"));
		}
	}
}
