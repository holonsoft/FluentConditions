using FluentAssertions;
using System;
using Xunit;

namespace holonsoft.FluentConditions.Tests
{
	public class TestBool
	{
		[Fact]
		public void TestIsTrue()
		{
			bool boolValue = true;

			Action requireAction
				= () => boolValue.Requires(nameof(boolValue))
												 .IsTrue();

			requireAction.Should().NotThrow();

			boolValue = false;

			requireAction.Should().Throw<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void TestIsFalse()
		{
			bool boolValue = false;

			Action requireAction
				= () => boolValue.Requires(nameof(boolValue))
												 .IsFalse();

			requireAction.Should().NotThrow();

			boolValue = true;

			requireAction.Should().Throw<ArgumentOutOfRangeException>();
		}
	}
}
