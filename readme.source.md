# <img src="https://avatars3.githubusercontent.com/u/36907" height="30px"> ApprovalTests.StatePrinter

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) for approval of Windows Forms through screenshot verification.


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/ApprovalTests.WinForms.svg?style=flat)](https://www.nuget.org/packages/ApprovalTests.WinForms/)

https://nuget.org/packages/ApprovalTests.WinForms/

    PM> Install-Package ApprovalTests.WinForms


## Usage

Given a model:

snippet: model

That is verified:

snippet: usage

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

 * NuGet: https://nuget.org/packages/ApprovalTests.WinForms/
 * Build: [![Build Status](https://dev.azure.com/approvals/ApprovalTests.Net.WinForms/_apis/build/status/approvals.ApprovalTests.Net.WinForms?branchName=master)](https://dev.azure.com/approvals/ApprovalTests.Net.WinForms/_build/latest?definitionId=1&branchName=master)