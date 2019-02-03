using System.Drawing;
using System.Windows.Forms;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalTests.Tests.WinForms;
using ApprovalTests.WinForms;
using Xunit;
using Button = System.Windows.Forms.Button;

[UseReporter(typeof(AllFailingTestsClipboardReporter), typeof(ImageReporter))]
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
        WinFormsApprovals.Verify(new Form());
    }

    [Fact]
    [UseReporter(typeof(TortoiseDiffReporter))]
    public void VerifyCompleteFormTest()
    {
        WinFormsApprovals.VerifyEventsFor(new DemoForm());
    }
}