using System.Drawing;
using System.Windows.Forms;
using ApprovalTests.Reporters;
using ApprovalTests.Tests.WinForms;
using ApprovalTests.WinForms;
using Xunit;
using Button = System.Windows.Forms.Button;

[UseReporter(typeof(AllFailingTestsClipboardReporter))]
public class WinFormTests
{
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