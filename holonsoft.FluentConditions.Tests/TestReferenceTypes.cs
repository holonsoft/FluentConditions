using FluentAssertions;
using System;
using Xunit;

namespace holonsoft.FluentConditions.Tests
{
	public class TestReferenceTypes
	{
		[Fact]
		public void TestNotNull()
		{
			object obj = new object();

			Action requireAction
				= () => obj.Requires(nameof(obj))
									 .IsNotNull();

			requireAction.Should().NotThrow();

			obj = null;

			requireAction.Should().Throw<ArgumentNullException>();
		}

		[Fact]
		public void TestNull()
		{
			object obj = null;

			Action requireAction
				= () => obj.Requires(nameof(obj))
									 .IsNull();

			requireAction.Should().NotThrow();

			obj = new object();

			requireAction.Should().Throw<ArgumentNullException>();
		}
	}
}
