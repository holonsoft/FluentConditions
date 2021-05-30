using System;
using System.Runtime.CompilerServices;

namespace holonsoft.FluentConditions
{
	public static partial class ConditionHelper
	{
		public static ConditionValueHolder<T> Requires<T>(
			this T value,
			string name,
			[System.Runtime.CompilerServices.CallerMemberName] string callerMemberName = "",
			[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
			[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
		{
			return new ConditionValueHolder<T>(value, name, callerMemberName, sourceFilePath, sourceLineNumber);
		}

		private static ConditionValueHolder<TNew> Requires<TOld, TNew>(
			this TNew value,
			ConditionValueHolder<TOld> forCopy)
			=> new(value, forCopy._valueName, forCopy._callerMemberName, forCopy._sourceFilePath, forCopy._sourceLineNumber);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string GetExceptionCallerText<T>(this ConditionValueHolder<T> valueHolder, string exceptionMessage)
			=> $"{exceptionMessage}{Environment.NewLine}At method '{valueHolder._callerMemberName}' in '{valueHolder._sourceFilePath}:{valueHolder._sourceLineNumber}'";
	}
}
