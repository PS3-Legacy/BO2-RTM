using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    public partial class frNameFrm : Form
    {
        public frNameFrm()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(0, nameBox1.Text);
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(1, nameBox2.Text);
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(2, nameBox3.Text);
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(3, nameBox4.Text);
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(4, nameBox5.Text);
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(5, nameBox6.Text);
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(6, nameBox7.Text);
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            timer8.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(7, nameBox8.Text);
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            timer9.Start();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(8, nameBox9.Text);
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            timer10.Start();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(9, nameBox10.Text);
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            timer11.Start();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(10, nameBox11.Text);
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            timer12.Start();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(11, nameBox12.Text);
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {
            timer13.Start();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(12, nameBox13.Text);
        }

        private void flatButton15_Click(object sender, EventArgs e)
        {
            timer14.Start();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(13, nameBox14.Text);
        }

        private void flatButton16_Click(object sender, EventArgs e)
        {
            timer15.Start();
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(14, nameBox15.Text);
        }

        private void flatButton17_Click(object sender, EventArgs e)
        {
            timer16.Start();
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            Func.FriendsName.ChangeFriendName(15, nameBox16.Text);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            timer9.Stop();
            timer10.Stop();
            timer11.Stop();
            timer12.Stop();
            timer13.Stop();
            timer14.Stop();
            timer15.Stop();
            timer16.Stop();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            BOIIfrm.frFrmbool = false;
        }
    }
}
