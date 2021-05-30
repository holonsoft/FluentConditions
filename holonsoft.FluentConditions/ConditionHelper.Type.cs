using System;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<T> IsOfType<T>(
			this ConditionValueHolder<T> valueHolder,
			Type type,
			string exceptionMessage = null)
		{
			T value = valueHolder._value;

			if (type.IsAssignableFrom(value.GetType()))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is not of type '{type}'!"));
		}

		public static ConditionValueHolder<TValue> IsOfType<TValue, TType>(
			this ConditionValueHolder<TValue> valueHolder,
			string exceptionMessage = null)
			=> IsOfType(valueHolder, typeof(TType), exceptionMessage);

		public static ConditionValueHolder<T> IsNotOfType<T>(
			this ConditionValueHolder<T> valueHolder,
			Type type,
			string exceptionMessage = null)
		{
			T value = valueHolder._value;

			if (!type.IsAssignableFrom(value.GetType()))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{value}' is of type '{type}'!"));
		}

		public static ConditionValueHolder<TValue> IsNotOfType<TValue, TType>(
			this ConditionValueHolder<TValue> valueHolder,
			string exceptionMessage = null)
			=> IsNotOfType(valueHolder, typeof(TType), exceptionMessage);

		public static ConditionValueHolder<Type> IsOfType(
			this ConditionValueHolder<Type> valueHolder,
			Type type,
			string exceptionMessage = null)
		{
			Type valueType = valueHolder._value;

			if (type.IsAssignableFrom(valueType))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{valueType}' is not of type '{type}'!"));
		}

		public static ConditionValueHolder<Type> IsOfType<TType>(
			this ConditionValueHolder<Type> valueHolder,
			string exceptionMessage = null)
			=> IsOfType(valueHolder, typeof(TType), exceptionMessage);

		public static ConditionValueHolder<Type> IsNotOfType(
			this ConditionValueHolder<Type> valueHolder,
			Type type,
			string exceptionMessage = null)
		{
			Type valueType = valueHolder._value;

			if (!type.IsAssignableFrom(valueType))
				return valueHolder;

			throw new ArgumentOutOfRangeException(
				valueHolder._valueName,
				valueHolder.GetExceptionCallerText(exceptionMessage ?? $"'{valueHolder._valueName}' with value '{valueType}' is not of type '{type}'!"));
		}

		public static ConditionValueHolder<Type> IsNotOfType<TType>(
			this ConditionValueHolder<Type> valueHolder,
			string exceptionMessage = null)
			=> IsNotOfType(valueHolder, typeof(TType), exceptionMessage);
	}
}
