using System.Windows.Forms;
using ApprovalTests.Core;
using ApprovalTests.Writers;

namespace ApprovalTests.WinForms
{
    public class ApprovalControlWriter : IApprovalWriter
    {
        Control control;

        public ApprovalControlWriter(Control controlHandle)
        {
            control = controlHandle;
        }

        public virtual string GetApprovalFilename(string basename)
        {
            return $"{basename}{WriterUtils.Approved}.png";
        }

        public virtual string GetReceivedFilename(string basename)
        {
            return $"{basename}{WriterUtils.Received}.png";
        }

        public virtual string WriteReceivedFile(string received)
        {
            return WinFormsUtils.ScreenCapture(received, control);
        }
    }
}