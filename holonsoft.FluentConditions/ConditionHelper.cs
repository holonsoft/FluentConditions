﻿using System.Runtime.CompilerServices;

namespace holonsoft.FluentConditions;
public static partial class ConditionHelper
{
  public static ConditionValueHolder<T> Requires<T>(
    this T value,
    string name,
    [System.Runtime.CompilerServices.CallerMemberName] string callerMemberName = "",
    [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
    [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0) => new ConditionValueHolder<T>(value, name, callerMemberName, sourceFilePath, sourceLineNumber);

  private static ConditionValueHolder<TNew> Requires<TOld, TNew>(
      this TNew value,
      ConditionValueHolder<TOld> forCopy)
      => new(value, forCopy.ValueName, forCopy.CallerMemberName, forCopy.SourceFilePath, forCopy.SourceLineNumber);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static string GetExceptionCallerText<T>(this ConditionValueHolder<T> valueHolder, string exceptionMessage)
    => $"{exceptionMessage}{Environment.NewLine}At method '{valueHolder.CallerMemberName}' in '{valueHolder.SourceFilePath}:{valueHolder.SourceLineNumber}'";
}
