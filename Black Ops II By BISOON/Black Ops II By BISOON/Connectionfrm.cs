using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using System.Net;
using System.IO;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading;

namespace Black_Ops_II_By_BISOON
{
    public partial class Connectionfrm : Form
    {
        public static string userName;
        public static string userClan;
        public static PS3API PS3 = new PS3API();
        BOIIfrm frm2 = new BOIIfrm();
        ZPfrm zpfrm = new ZPfrm();
        public class Connector
        {
            public static void ThreadConnector()
            {
                try
                {
                    if (Connectionfrm.PS3.GetCurrentAPI() == PS3Lib.SelectAPI.TargetManager)
                    {
                        Connectionfrm.PS3.ConnectTarget();
                    }

                }
                catch
                { }
            }
        }
        public Connectionfrm()
        {
            InitializeComponent();
           
            
        }

        private void setBbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bytesCh.Checked)
                {
                    string BIS = this.byteBox.Text.Replace(" ", "");
                    int num = BIS.Length / 2;
                    byte[] buffer = new byte[num];
                    using (StringReader reader = new StringReader(BIS))
                    {
                        for (int i = 0; i < num; i++)
                        {
                            char[] chArray = new char[] { (char)reader.Read(), (char)reader.Read() };
                            buffer[i] = Convert.ToByte(new string(chArray), 0x10);
                        }
                    }
                    PS3.SetMemory(uint.Parse(this.offsetBox.Text.Remove(0, 2), NumberStyles.HexNumber), buffer);
                }
                if (strCh.Checked)
                {
                    PS3.Extension.WriteString(uint.Parse(offsetBox.Text.Remove(0, 2), NumberStyles.HexNumber), byteBox.Text);
                }
            }
            catch { }
        }

        private void commandBtn_Click(object sender, EventArgs e)
        {
            if (cbufCheck.Checked)
            {
                RPC.cbuf_addtext(commandBox.Text);
            }
            if (svCheck.Checked)
            {
                RPC.SV_GameSendServerCommand((int)clientNum.Value, commandBox.Text);
            }
        }

        private void svCheck_CheckedChanged(object sender, EventArgs e)
        {
            clientNum.Visible = true;
        }

        private void cbufCheck_CheckedChanged(object sender, EventArgs e)
        {
            clientNum.Visible = false;
        }
        private void ringBuzCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ringBuzCombo.SelectedIndex == 0)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
            }
            if (ringBuzCombo.SelectedIndex == 1)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            }
            if (ringBuzCombo.SelectedIndex == 2)
            {
                PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Continuous);
            }
        }

        private void comandCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comandCombo.SelectedIndex == 0)
            {
                string defaultResponse = "Your Console";
                string input = Interaction.InputBox("Enter your Console id below", "Enter CID", defaultResponse, -1, -1);
                if (input.Length == 32)
                {
                    Connectionfrm.PS3.CCAPI.SetConsoleID(defaultResponse);
                }
                else
                {
                    MessageBox.Show("Not 32 Chars !!", "Error");
                }
            }
            if (comandCombo.SelectedIndex == 1)
            {
                PS3.CCAPI.ShutDown(CCAPI.RebootFlags.SoftReboot);
                PS3.TMAPI.ResetToXMB(TMAPI.ResetTarget.Soft);
            }
            if (comandCombo.SelectedIndex == 2)
            {
                PS3.CCAPI.ShutDown(CCAPI.RebootFlags.HardReboot);
                PS3.TMAPI.ResetToXMB(TMAPI.ResetTarget.Hard);
            }
            if (comandCombo.SelectedIndex == 3)
            {
                PS3.CCAPI.ShutDown(CCAPI.RebootFlags.ShutDown);
                PS3.TMAPI.PowerOff(true);
            }
        }

        private void ledCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ledCombo.SelectedIndex == 0)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Off);
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Off);
            }
            if (ledCombo.SelectedIndex == 1)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Blink);
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Off);
            }
            if (ledCombo.SelectedIndex == 2)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.On);
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.On);
            }
            if (ledCombo.SelectedIndex == 3)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Blink);
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Off);
            }
            if (ledCombo.SelectedIndex == 4)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.On);
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.Off);
            }
            if (ledCombo.SelectedIndex == 5)
            {
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Red, CCAPI.LedMode.Off);
                PS3.CCAPI.SetConsoleLed(CCAPI.LedColor.Green, CCAPI.LedMode.On);
            }
        }

        private void notifyBtn_Click(object sender, EventArgs e)
        {
            if (notifyCombo.SelectedIndex == 0)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, (notifyBox.Text));
            }

            if (notifyCombo.SelectedIndex == 1)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.CAUTION, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 2)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 3)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.SLIDER, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 4)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.WRONGWAY, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 5)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.DIALOG, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 6)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.DIALOGSHADOW, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 7)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TEXT, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 8)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.POINTER, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 9)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.GRAB, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 10)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.HAND, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 11)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 12)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 13)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.ARROW, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 14)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.ARROWRIGHT, (notifyBox.Text));
            }
            if (notifyCombo.SelectedIndex == 15)
            {
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PROGRESS, (notifyBox.Text));
            }
        }
        private void rfInfo_Click(object sender, EventArgs e)
        {
            cellLbl.Text = PS3.CCAPI.GetTemperatureCELL();
            verLbl.Text = PS3.CCAPI.GetFirmwareVersion();
        }

        bool API = false;
        private void conBtnCex_Click(object sender, EventArgs e)
        {
            try
            {
                API = false;
                if (API == false)
                {
                    PS3.ChangeAPI(SelectAPI.ControlConsole);
                }
                if (conBtnCex.Text == "Connect [ CEX ]")
                {
                    if (PS3.ConnectTarget())
                    {
                        conBtnCex.Text = "Attach";
                        alertBox1.kind = theme.FlatAlertBox._Kind.Success;
                        alertBox1.Text = "Connected";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();

                    }
                    else
                    {
                        alertBox1.kind = theme.FlatAlertBox._Kind.Error;
                        alertBox1.Text = "Error";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();
                    }
                }
                else if (conBtnCex.Text == "Attach")
                {
                    if (PS3.AttachProcess())
                    {
                        RPC.Init();
                        if (antiBanCh.Checked)
                        {
                            Func.Antiban.EnableAntiBan();
                        }
                        antiBanBtn.Visible = false;
                        antiBanCh.Visible = false;
                        userName = Functions.ReadStr(Offsets.NonHost.LocalName);
                        userClan = Func.Clan.GetClan();
                        nameLbl.Text = "Welcome : " + userName;
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, "Welcome : \n\n" + userName + "\n\nThx for using \nBISOON's RTM Tool <3");
                        Func.changeStr.ChangeString(false);
                        Functions.WriteStr(Offsets.NonHost.FPSText, "^1BISOON ^3<3");
                        Func.NonHost.FPS(true);
                        this.BISOON.Icon = this.Icon;
                        this.BISOON.BalloonTipIcon = ToolTipIcon.Info;
                        this.BISOON.BalloonTipText = "Welcome  \n\n  " + (userName) + "\n\nHave Fun :)\n";
                        this.BISOON.BalloonTipTitle = "BISOON RTM Tool";
                        this.BISOON.ShowBalloonTip(20);
                        openRtmBtn.Visible = true;
                        alertBox1.kind = theme.FlatAlertBox._Kind.Success;
                        alertBox1.Text = "Attached";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();
                        conBtnCex.Text = "Disconnect";
                    }
                    else
                    {
                        alertBox1.kind = theme.FlatAlertBox._Kind.Error;
                        alertBox1.Text = "Error";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();
                        conBtnCex.Text = "Connect [ CEX ]";
                    }
                }
                else if (conBtnCex.Text == "Disconnect")
                {
                    PS3.DisconnectTarget();
                    conBtnCex.Text = "Connect [ CEX ]";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is something error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void conBtnDex_Click(object sender, EventArgs e)
        {
            try
            {
                API = true;
                if (API == true)
                {
                    PS3.ChangeAPI(SelectAPI.TargetManager);
                }
                if (conBtnDex.Text == "Connect [ DEX ]")
                {
                    if (PS3.ConnectTarget())
                    {
                        conBtnDex.Text = "Attach";
                        alertBox1.kind = theme.FlatAlertBox._Kind.Success;
                        alertBox1.Text = "Connected";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();

                    }
                    else
                    {
                        alertBox1.kind = theme.FlatAlertBox._Kind.Error;
                        alertBox1.Text = "Error";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();
                    }
                }
                else if (conBtnDex.Text == "Attach")
                {
                    if (PS3.AttachProcess())
                    {
                        RPC.Init();
                        if (antiBanCh.Checked)
                        {
                            Func.Antiban.EnableAntiBan();
                        }

                        antiBanBtn.Visible = false;
                        antiBanCh.Visible = false;
                        userName = Functions.ReadStr(Offsets.NonHost.LocalName);
                        nameLbl.Text = "Welcome : " + userName;
                        Func.changeStr.ChangeString(false);
                        Functions.WriteStr(Offsets.NonHost.FPSText, "^1BISOON ^5<3");
                        Func.NonHost.FPS(true);
                        openRtmBtn.Visible = true;
                        alertBox1.kind = theme.FlatAlertBox._Kind.Success;
                        alertBox1.Text = "Attached";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();
                        this.BISOON.Icon = this.Icon;
                        this.BISOON.BalloonTipIcon = ToolTipIcon.Info;
                        this.BISOON.BalloonTipText = "Welcome  \n\n  " + (userName) + "\n\nHave Fun :)\n";
                        this.BISOON.BalloonTipTitle = "BISOON RTM Tool";
                        this.BISOON.ShowBalloonTip(20);
                        conBtnDex.Text = "Disconnect";
                    }
                    else
                    {
                        alertBox1.kind = theme.FlatAlertBox._Kind.Error;
                        alertBox1.Text = "Error";
                        alertBox1.Visible = true;
                        alertBox1.Refresh();
                        conBtnDex.Text = "Connect [ DEX ]";
                    }
                }
                else if (conBtnDex.Text == "Disconnect")
                {
                    PS3.DisconnectTarget();
                    conBtnDex.Text = "Connect [ DEX ]";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is something error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openRtmBtn_Click(object sender, EventArgs e)
        {
            Notify("RTM Tool By BISOON", "Opening MultiPlayer Form\nWait !! It Takes A Few Seconds");
            
            frm2.Show();
            this.Hide();
        
        }

        private void bisBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Skype:\nBISOON-B7\nEmergency :]");
            Process.Start("https://www.youtube.com/channel/UCwFmpPW6wKmp47KXSPTVjnA");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "|- BISOON RTM Tool";
                save.FileName = "Crisis Mode Menu Ver1.5";
                save.Filter = "RAR File|*.rar";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    WebClient Crisis = new WebClient();
                    Crisis.DownloadFileAsync(new Uri("https://www.dropbox.com/s/fv1wvzwypstfsmm/Crisis%20Menu%20Ver%201.5.rar?dl=1"), save.FileName);
                    Crisis.DownloadFileCompleted += Crisis_DownloadFileCompleted;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was error !!\n" + ex.Message);
            }
        }

        void Crisis_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloaded Successfully", "Crisis");
        }

        private void arpicBox_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.arabmodding.com/ar/members/2/");
        }

        private void getBbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bytesCh.Checked)
                {
                    string BISO = BitConverter.ToString(PS3.Extension.ReadBytes(uint.Parse(offsetBox.Text.Remove(0, 2), NumberStyles.HexNumber), 12)).Replace("-", " ");
                    byteBox.Text = BISO;
                }

                if (strCh.Checked)
                {
                    string BIS = (PS3.Extension.ReadString(uint.Parse(offsetBox.Text.Remove(0, 2), NumberStyles.HexNumber)));
                    byteBox.Text = BIS;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zmBtn_Click(object sender, EventArgs e)
        {
            Notify("RTM Tool By BISOON", "Opening Zombie Form\nWait !! It Takes A Few Seconds");
            zpfrm.Show();
        }
        void Notify(string Title, string Text)
        {
            this.BISOON.Icon = this.Icon;
            this.BISOON.BalloonTipIcon = ToolTipIcon.Info;
            this.BISOON.BalloonTipText = Text;
            this.BISOON.BalloonTipTitle = Title;
            this.BISOON.ShowBalloonTip(40);
        }
    }
}
