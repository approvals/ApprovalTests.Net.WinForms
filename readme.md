<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /readme.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# <img src="https://avatars3.githubusercontent.com/u/36907" height="30px"> ApprovalTests.WinForms

[![Build status](https://ci.appveyor.com/api/projects/status/n6gbfw25qnbflu7k/branch/master?svg=true)](https://ci.appveyor.com/project/SimonCropp/approvaltests-net-winforms)
[![NuGet Status](https://img.shields.io/nuget/v/ApprovalTests.WinForms.svg)](https://www.nuget.org/packages/ApprovalTests.WinForms/)

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) for approval of Windows Forms through screenshot verification.


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/ApprovalTests.WinForms.svg?style=flat)](https://www.nuget.org/packages/ApprovalTests.WinForms/)

https://nuget.org/packages/ApprovalTests.WinForms/

    PM> Install-Package ApprovalTests.WinForms


## Usage

<!-- snippet: usage -->
<a id='snippet-usage'></a>
```cs
WinFormsApprovals.Verify(new Form());
```
<sup><a href='/src/Tests/WinFormTests.cs#L42-L46' title='Snippet source file'>snippet source</a> | <a href='#snippet-usage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## System Differences

Usually Approval files take the form:

`ClassName.MethodName.approved.extension`

However, as WinForms will render differently on each OS, when approving with WinForms it will take the form

`ClassName.MethodName.osname.approved.extension`

It does this before each run by calling

<!-- snippet: additional_info -->
<a id='snippet-additional_info'></a>
```cs
ApprovalResults.UniqueForOs;
```
<sup><a href='/src/ApprovalTests.WinForms/WinFormsApprovals.cs#L16-L18' title='Snippet source file'>snippet source</a> | <a href='#snippet-additional_info' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

An Example Approval File would be:

`WinFormTests.TestControlApproved.Microsoft_Windows_10_Home_N.approved.png`


### Customizing System Naming

If you would like a different naming system you can customize the default naming.

For example, if you would like to use the the users name you could do this:

<!-- snippet: alternative_naming -->
<a id='snippet-alternative_naming'></a>
```cs
WinFormsApprovals.RegisterDefaultAdditionalInfo(ApprovalResults.UniqueForUserName);
```
<sup><a href='/src/Tests/WinFormTests.cs#L16-L18' title='Snippet source file'>snippet source</a> | <a href='#snippet-alternative_naming' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Would yield:

<!-- snippet: alternative_custom_name -->
<a id='snippet-alternative_custom_name'></a>
```cs
"WinFormTests.DemoAlternativeMachineSpecific.ForUser.Tomas";
```
<sup><a href='/src/Tests/WinFormTests.cs#L22-L24' title='Snippet source file'>snippet source</a> | <a href='#snippet-alternative_custom_name' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Read more on [EnvironmentSpecificTest here](https://github.com/approvals/ApprovalTests.Net/blob/master/ApprovalTests/docs/EnvironmentSpecificTests.md)
