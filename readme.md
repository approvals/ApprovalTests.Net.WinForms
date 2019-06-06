# <img src="https://avatars3.githubusercontent.com/u/36907" height="30px"> ApprovalTests.WinForms

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) for approval of Windows Forms through screenshot verification.


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/ApprovalTests.WinForms.svg?style=flat)](https://www.nuget.org/packages/ApprovalTests.WinForms/)

https://nuget.org/packages/ApprovalTests.WinForms/

    PM> Install-Package ApprovalTests.WinForms


## Usage


<!-- snippet: usage -->
```cs
WinFormsApprovals.Verify(new Form());
```
<sup>[snippet source](/src/Tests/WinFormTests.cs#L26-L28)</sup>
<!-- endsnippet -->

## System Differences

Usually Approval files take the form 

`ClassName.MethodName.approved.extention` 

However, as winforms will render differently on each OS, when approving with winform it will take the form

`ClassName.MethodName.osname.approved.extention` 

For Example:

`WinFormTests.TestControlApproved.Microsoft_Windows_10_Home_N.approved.png`



## Links

 * NuGet: https://nuget.org/packages/ApprovalTests.WinForms/
 * Build: [![Build Status](https://dev.azure.com/approvals/ApprovalTests.Net.WinForms/_apis/build/status/approvals.ApprovalTests.Net.WinForms?branchName=master)](https://dev.azure.com/approvals/ApprovalTests.Net.WinForms/_build/latest?definitionId=2&branchName=master)
