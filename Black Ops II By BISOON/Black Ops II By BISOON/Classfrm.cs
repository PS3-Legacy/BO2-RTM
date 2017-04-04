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
    public partial class Classfrm : Form
    {
        public Classfrm()
        {
            InitializeComponent();
        }

        private void Classfrm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            BOIIfrm.ClassFrm = false;
        }

        private void primaryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            priTimer.Start();
        }

        private void priTimer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Primary, BIS.ClassModsMP.MultiPlayer.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Primary, BIS.ClassModsMP.MultiPlayer.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
                if (class5Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Primary, BIS.ClassModsMP.MultiPlayer.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
                if (class7Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Primary, BIS.ClassModsMP.MultiPlayer.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
                if (class9Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Primary, BIS.ClassModsMP.MultiPlayer.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
            }
            //
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class1Offsets.Primary, BIS.ClassModsMP.League.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class3Offsets.Primary, BIS.ClassModsMP.League.Primary.PrimaIndex[primaryCombo.SelectedIndex]);
                }
            }
        }

        private void secondaryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            secTimer.Start();
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Secondary, BIS.ClassModsMP.MultiPlayer.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Secondary, BIS.ClassModsMP.MultiPlayer.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
                if (class5Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Secondary, BIS.ClassModsMP.MultiPlayer.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
                if (class7Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Secondary, BIS.ClassModsMP.MultiPlayer.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
                if (class9Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Secondary, BIS.ClassModsMP.MultiPlayer.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
            }
            //
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class1Offsets.Secondary, BIS.ClassModsMP.League.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class3Offsets.Secondary, BIS.ClassModsMP.League.Secondary.SeconIndex[secondaryCombo.SelectedIndex]);
                }
            }
        }

        private void greed1Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pG1Timer.Start();
        }

        private void pG1Timer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.PerkGreed1, BIS.ClassModsMP.MultiPlayer.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.PerkGreed1, BIS.ClassModsMP.MultiPlayer.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
                if (class5Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.PerkGreed1, BIS.ClassModsMP.MultiPlayer.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
                if (class7Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.PerkGreed1, BIS.ClassModsMP.MultiPlayer.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
                if (class9Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.PerkGreed1, BIS.ClassModsMP.MultiPlayer.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
            }
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class1Offsets.PerkGreed1, BIS.ClassModsMP.League.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class3Offsets.PerkGreed1, BIS.ClassModsMP.League.Greed1.Greed1_Index[greed1Combo.SelectedIndex]);
                }
            }
        }

        private void greed2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pG2Timer.Start();
        }

        private void pG2Timer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class1Offsets.PerkGreed2, BIS.ClassModsMP.MultiPlayer.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.PerkGreed2, BIS.ClassModsMP.MultiPlayer.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
                if (class5Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.PerkGreed2, BIS.ClassModsMP.MultiPlayer.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
                if (class7Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.PerkGreed2, BIS.ClassModsMP.MultiPlayer.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
                if (class9Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.PerkGreed2, BIS.ClassModsMP.MultiPlayer.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
            }
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class1Offsets.PerkGreed2, BIS.ClassModsMP.League.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class3Offsets.PerkGreed2, BIS.ClassModsMP.League.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
                }
            }
        }

        private void greed3Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pG3Timer.Start();
        }

        private void pG3Timer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.PerkGreed3, BIS.ClassModsMP.MultiPlayer.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.PerkGreed3, BIS.ClassModsMP.MultiPlayer.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
                if (class5Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.PerkGreed3, BIS.ClassModsMP.MultiPlayer.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
                if (class7Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.PerkGreed3, BIS.ClassModsMP.MultiPlayer.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
                if (class9Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.PerkGreed3, BIS.ClassModsMP.MultiPlayer.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
            }
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class1Offsets.PerkGreed3, BIS.ClassModsMP.League.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.League.Class3Offsets.PerkGreed3, BIS.ClassModsMP.League.Greed3.Greed3_Index[greed3Combo.SelectedIndex]);
                }
            }
        }

        private void lethalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lethTimer.Start();
        }

        private void lethTimer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Lethal, BIS.ClassModsMP.MultiPlayer.Lethal.Lethal_Index[lethalCombo.SelectedIndex]);
                }
                if (class3Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Lethal, BIS.ClassModsMP.MultiPlayer.Lethal.Lethal_Index[lethalCombo.SelectedIndex]);
                }
                if (class5Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Lethal, BIS.ClassModsMP.MultiPlayer.Lethal.Lethal_Index[lethalCombo.SelectedIndex]);
                }
                if (class7Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Lethal, BIS.ClassModsMP.MultiPlayer.Lethal.Lethal_Index[lethalCombo.SelectedIndex]);
                }
                if (class9Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Lethal, BIS.ClassModsMP.MultiPlayer.Lethal.Lethal_Index[lethalCombo.SelectedIndex]);
                }
            }
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    if (lethalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.Magnom);
                    }
                    if (lethalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.An94);
                    }
                    if (lethalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.Lsat);
                    }
                    if (lethalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.Ballista);
                    }
                    if (lethalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.M12M16);
                    }
                    if (lethalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.FlashBang);
                    }
                    if (lethalCombo.SelectedIndex == 6)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Lethal, BIS.ClassModsMP.League.Lethal.EMB);
                    }
                   
                }
                if (class3Ch.Checked)
                {
                    if (lethalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.Magnom);
                    }
                    if (lethalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.An94);
                    }
                    if (lethalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.Lsat);
                    }
                    if (lethalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.Ballista);
                    }
                    if (lethalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.M12M16);
                    }
                    if (lethalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.FlashBang);
                    }
                    if (lethalCombo.SelectedIndex == 6)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class3Offsets.Lethal, BIS.ClassModsMP.League.Lethal.EMB);
                    }
                }
            }
        }

        private void tacticalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tacTimer.Start();
        }

        private void tacTimer_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Grenade_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Assault_Shield);
                    }
                }
                if (class3Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Grenade_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Assault_Shield);
                    }
                }
                if (class5Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Grenade_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class5Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Assault_Shield);
                    }
                }
                if (class7Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Grenade_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class7Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Assault_Shield);
                    }
                }
                if (class9Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.League.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.League.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.League.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.League.Tactical.C4_x2);
                    }
                }
            }
            if (leagueCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Tactical, BIS.ClassModsMP.League.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Tactical, BIS.ClassModsMP.League.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Tactical, BIS.ClassModsMP.League.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.League.Class1Offsets.Tactical, BIS.ClassModsMP.League.Tactical.Claymore_x2);
                    }
                }
                if (class3Ch.Checked)
                {
                    if (tacticalCombo.SelectedIndex == 0)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Grenade_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class3Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Assault_Shield);
                    }
                }
            }

        }

        private void multiCh_CheckedChanged(object sender)
        {
            priTimer.Stop();
            secTimer.Stop();
            pG1Timer.Stop();
            pG2Timer.Stop();
            pG3Timer.Stop();
            lethTimer.Stop();
            tacTimer.Stop();
            class5Ch.Visible = true;
            class7Ch.Visible = true;
            class9Ch.Visible = true;
            primaryCombo.Items.Clear();
            secondaryCombo.Items.Clear();
            greed1Combo.Items.Clear();
            greed2Combo.Items.Clear();
            greed3Combo.Items.Clear();
            lethalCombo.Items.Clear();
            tacticalCombo.Items.Clear();
            string[] Pri = { "Five-Seven", "Five-Seven D.W", "Tac-45", "Tac-45 D.W", "B23R", "B23R D.W", "KAP-40", "KAP-40 D.W", "Executioner", "Executioner D.W", "Crossbow", "Ballistic Knife", "RPG", "SMAW" };
            string[] Sec = { "MSMC", "SCAR-H", "KSG", "Mk 48", "Ballista", "AN-94", "SWAT-556", "M8A1", "Peacekeeper", "Chicom CQB" };
            string[] Perk1 = { "Lightweight", "Hardline", "Blind Eye", "Flak Jacket", "Ghost" };
            string[] Perk2 = { "Toughness", "Cold Blooded", "Fast Hands", "Hard Wired", "Scavenger" };
            string[] Perk3 = { "Dexterity", "Extreme Conditioning", "Engineer", "Tactical Mask", "Dead Silence", "Awareness" };
            string[] Leathal = { "FIVE-7 D.W", "MP7", "PDW-57", "Skorpion EVO", "Vector K10", "LSAT", "M1216", "RPG", "DSR-50", "SVU-AS", "HAMR", "Assault Shield", "SMR", "R870 MCS" };
            string[] Tactical = { "Claymore x2", "Combat Axe x2", "Semtex x2", "C4 x2", "Grenade x2", "Assault Shield" };
            primaryCombo.Items.AddRange(Pri);
            secondaryCombo.Items.AddRange(Sec);
            greed1Combo.Items.AddRange(Perk1);
            greed2Combo.Items.AddRange(Perk2);
            greed3Combo.Items.AddRange(Perk3);
            lethalCombo.Items.AddRange(Leathal);
            tacticalCombo.Items.AddRange(Tactical);
        }

        private void leagueCh_CheckedChanged(object sender)
        {
            priTimer.Stop();
            secTimer.Stop();
            pG1Timer.Stop();
            pG2Timer.Stop();
            pG3Timer.Stop();
            lethTimer.Stop();
            tacTimer.Stop();
            class5Ch.Visible = false;
            class7Ch.Visible = false;
            class9Ch.Visible = false;
            primaryCombo.Items.Clear();
            secondaryCombo.Items.Clear();
            greed1Combo.Items.Clear();
            greed2Combo.Items.Clear();
            greed3Combo.Items.Clear();
            lethalCombo.Items.Clear();
            tacticalCombo.Items.Clear();
            string[] Pri = { "Five-Seven", "Five-Seven D.W", "Tac-45", "Tac-45 D.W", "B23R", "B23R D.W", "KAP-40", "KAP-40 D.W", "Executioner", "Executioner D.W", "Crossbow", "Ballistic Knife", "RPG", "SMAW" };
            string[] Sec = { "MSMC", "SCAR-H", "Assault Shield", "AN-94", "KAP-40 D.W", "M8A1", "PDW-57", "MP7" };
            string[] Perk1 = { "Lightweight", "Blind Eye", "Ghost" };
            string[] Perk2 = {"Fast Hands", "Scavenger" };
            string[] Perk3 = { "Dexterity", "Tactical Mask", "Dead Silence" };
            string[] Leathal = { "Executioner D.W", "AN-94", "LSAT", "Ballista", "M1216", "Flashbang", "EMP Grenade" };
            string[] Tactical = { "Combat Axe x2", "Semtex x2", "C4 x2", "Claymore x2" };
            primaryCombo.Items.AddRange(Pri);
            secondaryCombo.Items.AddRange(Sec);
            greed1Combo.Items.AddRange(Perk1);
            greed2Combo.Items.AddRange(Perk2);
            greed3Combo.Items.AddRange(Perk3);
            lethalCombo.Items.AddRange(Leathal);
            tacticalCombo.Items.AddRange(Tactical);
        }

        private void classBudBtn_Click(object sender, EventArgs e)
        {
            if (classBudBtn.Text == "20 / 10")
            {
                if (multiCh.Checked)
                {
                    if (class1Ch.Checked)
                    {
                        budget.Start();
                    }
                    if (class3Ch.Checked)
                    {
                        budget.Start();
                    }
                    if (class5Ch.Checked)
                    {
                        budget.Start();
                    }
                    if (class7Ch.Checked)
                    {
                        budget.Start();
                    }
                    if (class9Ch.Checked)
                    {
                        budget.Start();
                    }
                }
                classBudBtn.Text = "Default";
            }
            else if (classBudBtn.Text == "Default")
            {
                budget.Stop();
                classBudBtn.Text = "20 / 10";
            }
        }

        private void budget_Tick(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    byte[] cl12010 = new byte[] { 0x0B, 0x14 };
                    Functions.SetMem(0x27078DC, cl12010);
                }
                if (class3Ch.Checked)
                {
                    byte[] cl12010 = new byte[] { 0x0B, 0x14 };
                    Functions.SetMem(0x27078DC + 0x69, cl12010);
                }
                if (class5Ch.Checked)
                {
                    byte[] cl12010 = new byte[] { 0x0B, 0x14 };
                    Functions.SetMem(0x27078DC + 0xD2, cl12010);
                }
                if (class7Ch.Checked)
                {
                    byte[] cl12010 = new byte[] { 0x0B, 0x14 };
                    Functions.SetMem(0x27078DC + 0x13B, cl12010);
                }
                if (class9Ch.Checked)
                {
                    byte[] cl12010 = new byte[] { 0x0B, 0x14 };
                    Functions.SetMem(0x27078DC + 0x1A4, cl12010);
                }
            }
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            SaveFile.SaveBinFile(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Primary, 0x409, "Classes", "Classes");
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            SaveFile.LoadBinFile(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.Primary, "Classes", "Classes");
        }
    }
}
