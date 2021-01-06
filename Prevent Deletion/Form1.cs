using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Prevent_Deletion
{
    public partial class PreventDeletion : Form
    {
        private string strValue;

        public PreventDeletion()
        {
            InitializeComponent();
        }

        private void Button1_click(object sender, EventArgs e)
        {

            strValue = textBox1.Text;

            if (File.Exists(strValue))
            {
                label1.Text = $"{strValue} file location verified";
            }  // End If
            else
            {
                label1.Text = $"{strValue} file does NOT exist.";
                if (Directory.Exists(strValue))
                {
                    label1.Text = $"{strValue} directory location verified";
                }  // End If
                else
                {
                    label1.Text = $"{strValue} directory does NOT exist.";
                }  // End Else

            }  // End Else

             ProcessStartInfo processtartinfo = new ProcessStartInfo
             {
                 Arguments = $"\"{strValue}\" /deny \"Everyone\":(DE)",
                 WindowStyle = ProcessWindowStyle.Hidden,
                 FileName = "C:\\Windows\\System32\\icacls.exe",
                 RedirectStandardOutput = true,
                 UseShellExecute = false,
             };

            label1.Text = "Please wait. This process can take a few minutes to complete. This is because there are many inherited permissions. Only the file or directory you defined will be modified.";

            using (var process = Process.Start(processtartinfo))
            {
                var standardOutput = new StringBuilder();

                while (!process.HasExited)
                {
                    label1.Text = standardOutput.Append(process.StandardOutput.ReadToEnd()).ToString();
                }  // End while

                label1.Text = standardOutput.Append(process.StandardOutput.ReadToEnd()).ToString();

            }  // End using
            
        } // End Button1_click

    }  // End partial class

}  // End namespace