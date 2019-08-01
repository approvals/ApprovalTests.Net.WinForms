using System.Drawing;
using System.Windows.Forms;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using ApprovalTests.Tests.WinForms;
using ApprovalTests.WinForms;
using Xunit;

[UseReporter(typeof(AllFailingTestsClipboardReporter))]
public class WinFormTests
{
#if DEBUG
    [Fact]
    public void DemoAlternativeMachineSpecific()
    {
        using (var previous =
                // begin-snippet: alternative_naming
                WinFormsApprovals.RegisterDefaultAdditionalInfo(ApprovalResults.UniqueForUserName)
            // end-snippet
        )
        {
            using (var info = WinFormsApprovals.GetDefaultAdditionalInfo()())
            {
                var name = Approvals.GetDefaultNamer().Name;
                var approvalName =
                    // begin-snippet: alternative_custom_name
                    "WinFormTests.DemoAlternativeMachineSpecific.ForUser.Tomas";
                // end-snippet:

                Assert.Equal(approvalName, name);
            }
        }
    }
#endif

    [Fact]
    public void TestControlApproved()
    {
        WinFormsApprovals.Verify(
            new Button
            {
                BackColor = Color.LightBlue,
                Text = "Help"
            });
    }

    [Fact]
    public void TestFormApproval()
    {
        #region usage

        WinFormsApprovals.Verify(new Form());

        #endregion
    }

    [Fact]
    public void VerifyCompleteFormTest()
    {
        WinFormsApprovals.VerifyEventsFor(new DemoForm());
    }
}