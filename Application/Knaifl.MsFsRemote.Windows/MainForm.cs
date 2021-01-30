using System;
using System.Net.Http;
using System.Windows.Forms;
using Knaifl.MsFsRemote.SimClient;

namespace Knaifl.MsFsRemote.Windows
{
    public partial class MainForm : Form
    {
        private readonly HttpClient httpClient;

        public MainForm()
        {
            this.InitializeComponent();
            this.httpClient = new HttpClient();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UIHdgSetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);
            var newHeading = Convert.ToUInt32(this.UIHeadingValue.Text);

            simClient.SetHeading(newHeading);
        }

        private void UICourse1SetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);
            var newCourse = Convert.ToUInt32(this.UICourse1Value.Text);

            simClient.SetCourse1(newCourse);
        }

        private void UICourse2SetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);
            var newCourse = Convert.ToUInt32(this.UICourse2Value.Text);

            simClient.SetCourse2(newCourse);
        }

        private void UIAltSetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);
            var newAltitude = Convert.ToUInt32(this.UIAltValue.Text);

            simClient.SetAltitude(newAltitude);
        }

        private void UISpeedSetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);
            var newSpeed = Convert.ToUInt32(this.UISpeedValue.Text);

            simClient.SetSpeed(newSpeed);

        }

        private void UIAutopilotEnabledButton_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UIAutopilotEnabledButton.Checked)
            {
                simClient.EnableAutopilot(true);
            }
            else
            {
                simClient.EnableAutopilot(false);
            }
        }

        private void UINavEnabledButton_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UINavEnabledButton.Checked)
            {
                simClient.EnableNav(true);
            }
            else
            {
                simClient.EnableNav(false);
            }
        }

        private void UIHdgEnabledButton_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UIHdgEnabledButton.Checked)
            {
                simClient.EnableHdg(true);
            }
            else
            {
                simClient.EnableHdg(false);
            }
        }

        private void UIAppEnabledMode_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UIAppEnabledMode.Checked)
            {
                simClient.EnableApp(true);
            }
            else
            {
                simClient.EnableApp(false);
            }
        }

        private void UIFlcEnabledButton_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UIFlcEnabledButton.Checked)
            {
                simClient.EnableFlc(true);
            }
            else
            {
                simClient.EnableFlc(false);
            }
        }

        private void UIAltEnabledButton_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UIAltEnabledButton.Checked)
            {
                simClient.EnableAlt(true);
            }
            else
            {
                simClient.EnableAlt(false);
            }
        }

        private void UIYdEnabledButton_CheckedChanged(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            if (this.UIYdEnabledButton.Checked)
            {
                simClient.EnableYd(true);
            }
            else
            {
                simClient.EnableYd(false);
            }
        }

        private void UINav1SetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            simClient.SetNav1(Convert.ToUInt32(this.UINav1Value.Text));
        }

        private void UINav2SetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            simClient.SetNav2(Convert.ToUInt32(this.UINav2Value.Text));
        }

        private void UINdb1SetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            simClient.SetAdf1(Convert.ToUInt32(this.UINdb1Value.Text));
        }

        private void UINdb2SetButton_Click(object sender, EventArgs e)
        {
            var simClient = new RemoteClient(this.Handle);

            simClient.SetAdf2(Convert.ToUInt32(this.UINdb2Value.Text));
        }
    }
}
