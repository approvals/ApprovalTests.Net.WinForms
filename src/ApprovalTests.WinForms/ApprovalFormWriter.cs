using System.Windows.Forms;
using ApprovalTests.Core;

namespace ApprovalTests.WinForms
{
    public class ApprovalFormWriter : IApprovalWriter
    {
        private readonly Form form;

        public ApprovalFormWriter(Form form)
        {
            this.form = form;
        }

        public virtual string GetApprovalFilename(string basename)
        {
            return $"{basename}.approved.png";
        }

        public virtual string GetReceivedFilename(string basename)
        {
            return $"{basename}.received.png";
        }

        public virtual string WriteReceivedFile(string received)
        {
            return WinFormsUtils.ScreenCapture(received, form);
        }
    }
}