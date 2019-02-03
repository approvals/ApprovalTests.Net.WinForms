# <img src="https://avatars3.githubusercontent.com/u/36907" height="30px"> ApprovalTests.StatePrinter

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) to allow simple approval of complex models using [StatePrinter](https://github.com/kbilsted/StatePrinter).


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/ApprovalTests.StatePrinter.svg?style=flat)](https://www.nuget.org/packages/ApprovalTests.StatePrinter/)

https://nuget.org/packages/ApprovalTests.StatePrinter/

    PM> Install-Package ApprovalTests.StatePrinter


## Usage

Given a model:

<!-- snippet: model -->
```cs
public class Turtle
{
    public string Name { get; set; }
    public Turtle On { get; set; }

    public Turtle(string name, Turtle onTurtle)
    {
        Name = name;
        On = onTurtle;
    }
}
```
<sup>[snippet source](/src/ApprovalTests.StatePrinter.Tests/StatePrinterTests.cs#L21-L34)</sup>
<!-- endsnippet -->

That is verified:

<!-- snippet: usage -->
```cs
public class StatePrinterTests
{
    [Fact]
    public void TestVerifyCircleReferences()
    {
        var turtle = new Turtle("jim",
            new Turtle("kasper",
                new Turtle("llewellyn", null)));
        turtle.On.On.On = turtle;
        StatePrinterApprovals.Verify(turtle);
    }
}
```
<sup>[snippet source](/src/ApprovalTests.StatePrinter.Tests/StatePrinterTests.cs#L4-L19)</sup>
<!-- endsnippet -->

Will result in this as an approved file:

```
Root = new Turtle(), ref: 0
{
    Name = "jim"
    On = new Turtle()
    {
        Name = "kasper"
        On = new Turtle()
        {
            Name = "llewellyn"
            On = -> 0
        }
    }
}
```


## Links

 * NuGet: https://nuget.org/packages/ApprovalTests.StatePrinter/
 * Build: [![Build Status](https://dev.azure.com/approvals/ApprovalTests.Net.StatePrinter/_apis/build/status/approvals.ApprovalTests.Net.StatePrinter?branchName=master)](https://dev.azure.com/approvals/ApprovalTests.Net.StatePrinter/_build/latest?definitionId=1&branchName=master)
