using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace holonsoft.FluentConditions.Tests
{
	public class TestEnumerable
	{
		[Fact]
		public void TestHasElementArray()
		{
			int[] enumerable = new[] { 1, 2 };

			Action requireAction
				= () => enumerable.Requires(nameof(enumerable))
													.IsNotEmpty();

			requireAction.Should().NotThrow();

			enumerable = Array.Empty<int>();

			requireAction.Should().Throw<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void TestHasElementEnumerable()
		{
			IEnumerable<int> enumerable = new[] { 1, 2 };

			Action requireAction
				= () => enumerable.Requires(nameof(enumerable))
													.IsNotEmpty();

			requireAction.Should().NotThrow();

			enumerable = Array.Empty<int>();

			requireAction.Should().Throw<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void TestHasElementHashSet()
		{
			HashSet<int> enumerable = new() { 1, 2 };

			Action requireAction
				= () => enumerable.Requires(nameof(enumerable))
													.IsNotEmpty();

			requireAction.Should().NotThrow();

			enumerable = new();

			requireAction.Should().Throw<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void TestHasElementList()
		{
			List<int> enumerable = new() { 1, 2 };

			Action requireAction
				= () => enumerable.Requires(nameof(enumerable))
													.IsNotEmpty();

			requireAction.Should().NotThrow();

			enumerable = new();

			requireAction.Should().Throw<ArgumentOutOfRangeException>();
		}

	}
}
