using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    public partial class TWDH : Form
    {
        Thread Doh;
        bool doDoh = true;
        int clientDoh;
        public TWDH()
        {
            InitializeComponent();
        }

        private void doHeartBtn_Click(object sender, EventArgs e)
        {
            if (doHeartBtn.Text == "Send")
            {
                DoHeart((int)clientNum_DH.Value, textBox_DH.Text, true);
                //DhTimer.Start();
                StartDoheartTi(true);
                doHeartBtn.Text = "Stop";
            }
            else if (doHeartBtn.Text == "Stop")
            {
                StartDoheartTi(false);
                DoHeart((int)clientNum_DH.Value, textBox_DH.Text, false);
                doHeartBtn.Text = "Send";
            }
        }

        private void typeWrBtn_Click(object sender, EventArgs e)
        {
            BO2TypeWriter.Hudelem.HUD.doTypeWriter(100, (int)clientNum_TW.Value, textBox_TW.Text, 0, 3, 150, 155, 100, (ushort)duration_TW.Value, (ushort)decayDur_TW.Value, 255, 255, 255, 255, 94, 42, 85, 200);
        }

        private void TWDH_Load(object sender, EventArgs e)
        {
        }
        double Mod;
        private void DhTimer_Tick(object sender, EventArgs e)
        {
            DoHeartWriter.Huds.FontScaleOverTime(Heart, Mod, 100);
            DoHeartWriter.Huds.FadeOverTime(Heart, 100, 94, 42, 85, 200);
            Thread.Sleep(250);
            DoHeartWriter.Huds.FontScaleOverTime(Heart, 0.4, 100);
            DoHeartWriter.Huds.FadeOverTime(Heart, 100, 1, 1, 1, 200);
            Thread.Sleep(250);
        }
        public static uint Heart;
        void DoHeart(int Client, string Text, bool Bool)
        {
            if (Bool == true)
            {
                Heart = DoHeartWriter.Huds.SetText(Client, Text, 0, 3, 120, 15, 255, 255, 255, 255, 94, 42, 85, 200);
            }
            if (Bool == false)
            {

                DoHeartWriter.Huds.DestroyElement(Heart);
            }
        }

         private void radioButton1_CheckedChanged(object sender)
         {
             Mod = 0.8;
         }

         private void radioButton2_CheckedChanged(object sender)
         {
             Mod = 5;
         }

         private void radioButton3_CheckedChanged(object sender)
         {
             Mod = 2;
         }

         private void closeBtn_Click(object sender, EventArgs e)
         {
             this.Close();
         }

        void DoheartTi()
         {
             Connectionfrm.Connector.ThreadConnector();
             while (doDoh == true)
             {

                 DoHeartWriter.Huds.FontScaleOverTime(Heart, Mod, 100);
                 DoHeartWriter.Huds.FadeOverTime(Heart, 100, 94, 42, 85, 200);
                 Thread.Sleep(250);
                 DoHeartWriter.Huds.FontScaleOverTime(Heart, 0.4, 100);
                 DoHeartWriter.Huds.FadeOverTime(Heart, 100, 1, 1, 1, 200);
                 Thread.Sleep(250);
             }
         }
        void StartDoheartTi(bool True)
        {
            Doh = new Thread(() => DoheartTi());
            try
            {
                if (True)
                {
                    doDoh = true;
                    Doh.Start();
                }
                else
                {
                    doDoh = false;
                    Doh.Abort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
