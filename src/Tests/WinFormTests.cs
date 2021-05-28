using System.Drawing;
using System.Windows.Forms;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Tests.WinForms;
using ApprovalTests.WinForms;
using Xunit;

public class WinFormTests
{
#if DEBUG
    [Fact]
    public void DemoAlternativeMachineSpecific()
    {
        using var previous =
        // begin-snippet: alternative_naming
            WinFormsApprovals.RegisterDefaultAdditionalInfo(ApprovalResults.UniqueForUserName);
        // end-snippet
        using var info = WinFormsApprovals.GetDefaultAdditionalInfo()();
        var name = Approvals.GetDefaultNamer().Name;
        var approvalName =
        // begin-snippet: alternative_custom_name
            "WinFormTests.DemoAlternativeMachineSpecific.ForUser.Tomas";
        // end-snippet
    }
#endif

    [Fact]
    public void TestControlApproved()
    {
        using (ApprovalResults.UniqueForDotNetVersion())
        {
            WinFormsApprovals.Verify(
                new Button
                {
                    BackColor = Color.LightBlue,
                    Text = "Help"
                });
        }
    }

    [Fact]
    public void TestFormApproval()
    {
        using (ApprovalResults.UniqueForDotNetVersion())
        {
            #region usage

            WinFormsApprovals.Verify(new Form());

            #endregion
        }
    }
#if NET48
    [Fact]
    public void VerifyCompleteFormTest()
    {
        using (ApprovalResults.UniqueForDotNetVersion())
        {
            WinFormsApprovals.VerifyEventsFor(new DemoForm());
        }
    }
#endif
}