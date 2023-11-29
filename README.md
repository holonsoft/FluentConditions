# FluentConditions

# New in 2.0.1
* Support for net8
* Net5 will not be supported anymore
* Update of several test unit nugets

FluentConditions is a framework for checking function parameters for certain criterias.
For example asserting that your input is not null. 
You also get clean error messages with a reference to the line of code that faulted.

As example:

``` c#
public void Test(bool boolValue = false)
{
	boolValue.Requires(nameof(boolValue))
		 .IsTrue();
}
```

would throw:

---

'boolValue' is false!
At method 'Test' in 'C:\Path\To\Your.cs:5'

---

## Thank you
We would like to thank Steven van Deursen because his library CuttingEdge.Conditions inspired us to program this.
