using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    public partial class BOIIfrm : Form
    {
        public static void SetName(string name)
        {
            Functions.WriteStr(Offsets.NonHost.LocalName, name);
            Functions.WriteStr(Offsets.NonHost.Name, name);
        }
        public BOIIfrm()
        {
            InitializeComponent();
        }

        private void BOIIfrm_Load(object sender, EventArgs e)
        {
            nameBox.Text = Connectionfrm.userName;
            clanBox.Text = Connectionfrm.userClan;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (prestigeCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.Prestige, BitConverter.GetBytes(Convert.ToInt32(prestigeNum.Value)));
            }
            if (levelCh.Checked)
            {
                if (levelNum.Value == 55)
                {
                    Func.Level55();
                }
                else
                {
                    Func.SetLevel((int)levelNum.Value);
                }
            }
            if (winsCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.Wins, BitConverter.GetBytes(Convert.ToInt32(winsNum.Value)));
            }
            if (lossesCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.Losses, BitConverter.GetBytes(Convert.ToInt32(lossesNum.Value)));
            }
            if (killsCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.Kills, BitConverter.GetBytes(Convert.ToInt32(killsNum.Value)));
            }
            if (deathsCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.Deaths, BitConverter.GetBytes(Convert.ToInt32(deathsNum.Value)));
            }
            if (scoreCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.Score, BitConverter.GetBytes(Convert.ToInt32(scoreNum.Value)));
            }
            if (tokensCh.Checked)
            {
                Functions.WriteUInt16(0x2706938, (ushort)(tokensNum.Value * 64M));
            }
            if (headSCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.HeadShots, BitConverter.GetBytes(Convert.ToInt32(headSNum.Value)));
            }
            if (nuclearCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.NuClear, BitConverter.GetBytes(Convert.ToInt32(nuclearNum.Value)));
            }
            if (unstoCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.Unstoppable, BitConverter.GetBytes(Convert.ToInt32(unstoNum.Value)));
            }
            if (brutalCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.Brutal, BitConverter.GetBytes(Convert.ToInt32(brutalNum.Value)));
            }
            if (relentCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.Relentless, BitConverter.GetBytes(Convert.ToInt32(relentNum.Value)));
            }
            if (mercCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.Merciless, BitConverter.GetBytes(Convert.ToInt32(mercNum.Value)));
            }
            if (ultraCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.UltraKill, BitConverter.GetBytes(Convert.ToInt32(ultraNum.Value)));
            }
            if (bloodCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.BloodThirsty, BitConverter.GetBytes(Convert.ToInt32(bloodNum.Value)));
            }
            if (doubleCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.DoubleKill, BitConverter.GetBytes(Convert.ToInt32(doubleNum.Value)));
            }
            if (firstCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Medals.FirstBlood,BitConverter.GetBytes(Convert.ToInt32(firstNum.Value)));
            }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            prestigeNum.Value = 8;
            levelNum.Value = 55;
            winsNum.Value = 986;
            lossesNum.Value = 785;
            killsNum.Value = 23458;
            deathsNum.Value = 20145;
            scoreNum.Value = 125586;
            tokensNum.Value = 100;
            headSNum.Value = 11544;
            nuclearNum.Value = 4;
            unstoNum.Value = 3;
            brutalNum.Value = 5;
            relentNum.Value = 8;
            mercNum.Value = 9;
            ultraNum.Value = 11;
            bloodNum.Value = 13;
            doubleNum.Value = 311;
            firstNum.Value = 206;
        }

        private void legitSt_Click(object sender, EventArgs e)
        {
            prestigeNum.Value = 9;
            levelNum.Value = 55;
            winsNum.Value = 1699;
            lossesNum.Value = 1599;
            killsNum.Value = 33458;
            deathsNum.Value = 31258;
            scoreNum.Value = 8569547;
            tokensNum.Value = 200;
            headSNum.Value = 18589;
            nuclearNum.Value = 19;
            unstoNum.Value = 18;
            brutalNum.Value = 22;
            relentNum.Value = 33;
            mercNum.Value = 56;
            ultraNum.Value = 106;
            bloodNum.Value = 845;
            doubleNum.Value = 2056;
            firstNum.Value = 3011;
        }

        private void highSt_Click(object sender, EventArgs e)
        {
            prestigeNum.Value = 11;
            levelNum.Value = 55;
            winsNum.Value = 3256;
            lossesNum.Value = 2500;
            killsNum.Value = 185694;
            deathsNum.Value = 180256;
            scoreNum.Value = 1025568;
            tokensNum.Value = 255;
            headSNum.Value = 66859;
            nuclearNum.Value = 66;
            unstoNum.Value = 56;
            brutalNum.Value = 311;
            relentNum.Value = 503;
            mercNum.Value = 633;
            ultraNum.Value = 1695;
            bloodNum.Value = 3526;
            doubleNum.Value = 13258;
            firstNum.Value = 9586;
        }

        private void allCh_CheckedChanged(object sender)
        {
            if (allCh.Checked)
            {
                prestigeCh.Checked = true;
                levelCh.Checked = true;
                winsCh.Checked = true;
                lossesCh.Checked = true;
                killsCh.Checked = true;
                deathsCh.Checked = true;
                scoreCh.Checked = true;
                tokensCh.Checked = true;
                headSCh.Checked = true;
                nuclearCh.Checked = true;
                unstoCh.Checked = true;
                brutalCh.Checked = true;
                relentCh.Checked = true;
                mercCh.Checked = true;
                bloodCh.Checked = true;
                ultraCh.Checked = true;
                doubleCh.Checked = true;
                firstCh.Checked = true;
            }
            else
            {
                prestigeCh.Checked = false;
                levelCh.Checked = false;
                winsCh.Checked = false;
                lossesCh.Checked = false;
                killsCh.Checked = false;
                deathsCh.Checked = false;
                scoreCh.Checked = false;
                tokensCh.Checked = false;
                headSCh.Checked = false;
                nuclearCh.Checked = false;
                unstoCh.Checked = false;
                brutalCh.Checked = false;
                relentCh.Checked = false;
                mercCh.Checked = false;
                bloodCh.Checked = false;
                ultraCh.Checked = false;
                doubleCh.Checked = false;
                firstCh.Checked = false;
            }
        }

        private void level55btn_Click(object sender, EventArgs e)
        {
            Func.Level55();
        }

        private void unlockAllbtn_Click(object sender, EventArgs e)
        {
            UnlockAll.Unlock();
        }

        private void _10classesbtn_Click(object sender, EventArgs e)
        {
            Functions.SetMem(Offsets.Stats.Unlock10Classes, BIS.NonHost.Unlock10Classes);
        }

        private void ghostCardBtn_Click(object sender, EventArgs e)
        {
            Functions.SetMem(Offsets.Stats.GhostCard, new byte[] { 0xFF });
        }

        private void awCardBtn_Click(object sender, EventArgs e)
        {
            Functions.SetMem(Offsets.Stats.RoxannCard, new byte[] { 0xFF });
        }

        private void noRecoilCh_CheckedChanged(object sender)
        {
            if (noRecoilCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.NoRecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.NoRecoil, new byte[] { 0x48, 0x50, 0x6D, 0x65 });
            }
        }

        private void uavCh_CheckedChanged(object sender)
        {
            if (uavCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.UAV, BIS.NonHost.UAVOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.UAV, BIS.NonHost.UAVOff);
            }
        }

        private void redBoxCh_CheckedChanged(object sender)
        {
            if (redBoxCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.RedBox1, BIS.NonHost.RedBoxOffset1On);
                Functions.SetMem(Offsets.NonHost.RedBox2, BIS.NonHost.RedBoxOffset2On);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.RedBox1, BIS.NonHost.RedBoxOffset1Off);
                Functions.SetMem(Offsets.NonHost.RedBox2, BIS.NonHost.RedBoxOffset2Off);
            }
        }

        private void steadyCh_CheckedChanged(object sender)
        {
            if (steadyCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.SteadyAim, BIS.NonHost.SteadyAimOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.SteadyAim, BIS.NonHost.SteadyAimOff);
            }
        }

        private void vsatCh_CheckedChanged(object sender)
        {
            if (vsatCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.VSAT, BIS.NonHost.VSATOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.VSAT, BIS.NonHost.VSATOff);
            }
        }

        private void fovCh_CheckedChanged(object sender)
        {
            if (fovCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.FOV, new byte[] { 0x42, 0xDC });
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.FOV, new byte[] { 0x41, 0x20 });
            }
        }

        private void laserCh_CheckedChanged(object sender)
        {
            if (laserCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.Laser, BIS.NonHost.LaserOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.Laser, BIS.NonHost.LaserOff);
            }
        }
        
        private void wallHackCh_CheckedChanged(object sender)
        {
            Func.NonHost.WallHack();
        }

        private void bigNameCh_CheckedChanged(object sender)
        {
            if (bigNameCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.BigName,BIS.NonHost.BigNameOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.BigName, BIS.NonHost.BigNameOff);
            }
        }

        private void floatingCh_CheckedChanged(object sender)
        {
            if (floatingCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.FloatingBodies, BIS.NonHost.FloatingBodiesOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.FloatingBodies, BIS.NonHost.FloatingBodiesOff);
            }
        }

        private void targitFinderCh_CheckedChanged(object sender)
        {
            if (targitFinderCh.Checked)
            {
                Functions.SetMem(Offsets.NonHost.TargetFinder, BIS.NonHost.TargetFinderOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.TargetFinder, BIS.NonHost.TargetFinderOff);
            }
        }

        private void skyColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skyColor.SelectedIndex == 0)
            {
                Functions.SetMem(Offsets.NonHost.SkyColor, BIS.NonHost.SkyColor.Black);
            }
            if (skyColor.SelectedIndex == 1)
            {
                Functions.SetMem(Offsets.NonHost.SkyColor, BIS.NonHost.SkyColor.Bright);
            }
            if (skyColor.SelectedIndex == 2)
            {
                Functions.SetMem(Offsets.NonHost.SkyColor, BIS.NonHost.SkyColor.Fog);
            }
            if (skyColor.SelectedIndex == 3)
            {
                Functions.SetMem(Offsets.NonHost.SkyColor, BIS.NonHost.SkyColor.Shine);
            }
            if (skyColor.SelectedIndex == 4)
            {
                Functions.SetMem(Offsets.NonHost.SkyColor, BIS.NonHost.SkyColor.VeryLight);
            }
            if (skyColor.SelectedIndex == 5)
            {
                Functions.SetMem(Offsets.NonHost.SkyColor, BIS.NonHost.SkyColor.Defualt);
            }
        }

        private void bodyColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodyColor.SelectedIndex == 0)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Green);
            }
            if (bodyColor.SelectedIndex == 1)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.LightGreen);
            }
            if (bodyColor.SelectedIndex == 2)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Blue);
            }
            if (bodyColor.SelectedIndex == 3)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.LightBlue);
            }
            if (bodyColor.SelectedIndex == 4)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Purple);
            }
            if (bodyColor.SelectedIndex == 5)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Pink);
            }
            if (bodyColor.SelectedIndex == 6)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.LightPink);
            }
            if (bodyColor.SelectedIndex == 7)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.StrongRed);
            }
            if (bodyColor.SelectedIndex == 8)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Yellow);
            }
            if (bodyColor.SelectedIndex == 9)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Orange);
            }
            if (bodyColor.SelectedIndex == 10)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Brown);
            }
            if (bodyColor.SelectedIndex == 11)
            {
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Normal);
            }
        }

        private void flashinBodies_CheckedChanged(object sender)
        {
            if (flashinBodies.Checked)
            {
                flashBodies.Start();
            }
            else
            {
                flashBodies.Stop();
                Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Normal);
            }
        }
        int FlBodies;
        private void flashBodies_Tick(object sender, EventArgs e)
        {
            if (flashinBodies.Checked)
            {
                FlBodies++;
                switch (FlBodies)
                {
                    case 1:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Green);
                        break;

                    case 2:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.LightGreen);
                        break;

                    case 3:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Blue);
                        break;

                    case 4:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.LightBlue);
                        break;

                    case 5:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Purple);
                        break;

                    case 6:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Pink);
                        break;
                    case 7:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.LightPink);
                        break;
                    case 8:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.StrongRed);
                        break;
                    case 9:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Yellow);
                        break;
                    case 10:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Orange);
                        break;
                    case 11:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Brown);
                        break;
                    case 12:
                        Functions.SetMem(Offsets.NonHost.BodyColor, BIS.NonHost.BodyColor.Normal);
                        break;
                }
                if (FlBodies == 12)
                {
                    FlBodies = 0;
                }
            }
        }

        private void FovXNum_Click(object sender, EventArgs e)
        {
            Functions.WriteFlo(Offsets.NonHost.FovX, FovXNum.Value);
        }

        private void FovYNum_Click(object sender, EventArgs e)
        {
            Functions.WriteFlo(Offsets.NonHost.FovY, FovYNum.Value);
        }

        private void FovZNum_Click(object sender, EventArgs e)
        {
            Functions.WriteFlo(Offsets.NonHost.FovZ, FovZNum.Value);
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            float Reset = 0;
            Functions.WriteFlo(Offsets.NonHost.FovX, Reset);
            Functions.WriteFlo(Offsets.NonHost.FovY, Reset);
            Functions.WriteFlo(Offsets.NonHost.FovZ, Reset);
            FovXNum.Value = 0;
            FovYNum.Value = 0;
            FovZNum.Value = 0;
        }

        private void probBtn_Click(object sender, EventArgs e)
        {
            Functions.SetMem(Offsets.NonHost.EndProbation, new byte[] { 0x00 }); //0x52FC6C 
            Functions.SetMem(0x52FC6C, new byte[] { 0x41, 0x80 }); 
            Functions.SetMem(0x097047C, new byte[] { 0x00 });
            MessageBox.Show("Probation Ended\nGo Back To Refresh", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void disFPSbtn_Click(object sender, EventArgs e)
        {
            if (disFPSbtn.Text == "Disable")
            {
                Func.NonHost.FPS(false);
                disFPSbtn.Text = "Enable";
                flashingFpsCh.Checked = false;
                rainBowFpsCh.Checked = false;
            }
            else if (disFPSbtn.Text == "Enable")
            {
                Func.NonHost.FPS(true);
                disFPSbtn.Text = "Disable";
            }
        }

        private void sndFPSbtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr(Offsets.NonHost.FPSText, fpsBox.Text);
        }

        private void rainBowFpsCh_CheckedChanged(object sender)
        {
            if (rainBowFpsCh.Checked)
            {
                fpstimer.Start();
            }
        }

        private void flashingFpsCh_CheckedChanged(object sender)
        {
            if (flashingFpsCh.Checked)
            {
                fpstimer.Start();
            }
            else
            {
                Func.NonHost.FPS(true);
            }
        }
        int FpsT = 0;
        private void fpstimer_Tick(object sender, EventArgs e)
        {
            if (rainBowFpsCh.Checked)
            {
                int BIS = new Random().Next(0, 9);
                Functions.WriteStr(Offsets.NonHost.FPSText, "^" + BIS + fpsBox.Text);
            }
            if (flashingFpsCh.Checked)
            {
                FpsT++;
                switch (FpsT)
                {
                    case 1:
                        Func.NonHost.FPS(true);
                        break;
                    case 2:
                        Func.NonHost.FPS(false);
                        break;
                }
                if (FpsT == 2)
                {
                    FpsT = 0;
                }
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr(0x30934206, subBox.Text);
        }

        private void msgBtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr(0x30934223, msgBox.Text);
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {
            SetName(nameBox.Text);
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = Connectionfrm.userName;
            SetName(Connectionfrm.userName);
        }

        private void flashName_CheckedChanged(object sender)
        {
            if (flashName.Checked)
            {
                nameTimer.Start();
            }
            else
            {
                nameTimer.Stop();
                SetName(nameBox.Text);
            }
        }

        private void nameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetName(BIS.Names.Names_Index[nameCombo.SelectedIndex]);
        }

        private void clanBtn_Click(object sender, EventArgs e)
        {
            Func.Clan.SetClan(clanBox.Text);
        }

        private void rstClanBtn_Click(object sender, EventArgs e)
        {
            Func.Clan.SetClan("");
        }

        private void nameTimer_Tick(object sender, EventArgs e)
        {
            if (flashName.Checked)
            {
                int BIS = new Random().Next(0, 9);
                SetName("^" + BIS + nameBox.Text);
            }
        }

        private void lobbyJump_Scroll(object sender)
        {
            #region LobbyJump
            //if (lobbyJump.Value == 0)
            //{
            //    Functions.SetMem(Offsets.Lobby.Jump, new byte[] { 0x42, 0x9C });
            //}
            //if (lobbyJump.Value == 1)
            //{
            //    Functions.SetMem(Offsets.Lobby.Jump, new byte[] { 0x47, 0x00 });
            //}
            //if (lobbyJump.Value == 2)
            //{
            //    Functions.SetMem(Offsets.Lobby.Jump, new byte[] { 0x51, 0x00 });
            //}
            #endregion
            
            Functions.WriteByte(Offsets.Lobby.Jump, BIS.Lobby.Jump_Index[lobbyJump.Value]);
        }

        private void lobbySpeed_Scroll(object sender)
        {
            #region LobbySpeed
            //if (lobbySpeed.Value == 0)
            //{
            //    byte[] buffer = new byte[3];
            //    Functions.SetMem(Offsets.Lobby.Speed, buffer);
            //}
            //if (lobbySpeed.Value == 1)
            //{
            //    Functions.SetMem(Offsets.Lobby.Speed, new byte[] { 0x00, 0x00, 0x01 });
            //}
            //if (lobbySpeed.Value == 2)
            //{
            //    Functions.SetMem(Offsets.Lobby.Speed, new byte[] { 0x00, 0x00, 0x02 });
            //}
            #endregion
            
            RPC.cbuf_addtext("g_speed " + BIS.Lobby.Speed_Index[lobbySpeed.Value]);
        }

        private void noclipLobby_Scroll(object sender)
        {
            if (noclipLobby.Value == 0)
            {
                Functions.SetMem(0x01CA4ED8, new byte[] { 0x44 });
            }
            if (noclipLobby.Value == 1)
            {
                Functions.SetMem(0x01CA4ED8, new byte[] { 0x47 });
            }
        }

        private void meleeLobby_Scroll(object sender)
        {
            if (meleeLobby.Value == 0)
            {
                Functions.SetMem(0x1CAF0D8, new byte[] { 0x42, 0x5C, 0x00 });
                Functions.SetMem(0x1CAF138, new byte[] { 0x41, 0x20, 0x00 });
                Functions.SetMem(0x1CAF198, new byte[] { 0x41, 0x20, 0x00 });
            }
            if (meleeLobby.Value == 1)
            {
                Functions.SetMem(0x1caf0d8, new byte[] { 0x49, 0xff, 0xff });
                Functions.SetMem(0x1caf138, new byte[] { 0x49, 0xff, 0xff });
                Functions.SetMem(0x1caf198, new byte[] { 0x49, 0xff, 0xff });
            }
        }

        private void gravityLobby_Scroll(object sender)
        {
            RPC.cbuf_addtext("bg_gravity " + BIS.Lobby.Gravity_Index[gravityLobby.Value]);
        }

        private void timescaleLobby_Scroll(object sender)
        { 
            Func.TimeScale(BIS.Lobby.TS_Index[timescaleLobby.Value]);  
        }
        private void primaryCombo_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void secondaryCombo_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void greed1Combo_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void greed2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (multiCh.Checked)
            {
                if (class1Ch.Checked)
                {
                    Functions.WriteByte(Offsets.ClassModsOffsets.MultiPlayer.Class1Offsets.PerkGreed2, BIS.ClassModsMP.MultiPlayer.Greed2.Greed2_Index[greed2Combo.SelectedIndex]);
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
        }

        private void greed3Combo_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void lethalCombo_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void tacticalCombo_SelectedIndexChanged(object sender, EventArgs e)
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
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Claymore_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 1)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Combat_Axe_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 2)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Semtex_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 3)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.C4_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 4)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Grenade_x2);
                    }
                    if (tacticalCombo.SelectedIndex == 5)
                    {
                        Functions.SetMem(Offsets.ClassModsOffsets.MultiPlayer.Class9Offsets.Tactical, BIS.ClassModsMP.MultiPlayer.Tactical.Assault_Shield);
                    }
                }
            }
        }
        bool scr;
        private void scrBtn_Click(object sender, EventArgs e)
        {
            if (!scr)
            {
                MessageBox.Show("Will take effect Next Game or you have to restart game");
                scr = true;
            }
            Func.ScorePerKil(scrPerKillLimitBox.Text);
        }
        
        private void timeBtn_Click(object sender, EventArgs e)
        {
            Func.TimeLimit(timeBox.Text);
        }
        bool live;
        private void liveBtn_Click(object sender, EventArgs e)
        {
            if (!live)
            {
                MessageBox.Show("Will take effect Next Round");
                live = true;
            }
            Func.LiveNum(liveNumBox.Text);
        }
        bool bombT;
        private void bombTBtn_Click(object sender, EventArgs e)
        {
            if (!bombT)
            {
                MessageBox.Show("Will take effect Next Round");
                bombT = true;
            }
            Func.BombTimer(bombTimerBox.Text);
        }
        bool plant;
        private void plantTBtn_Click(object sender, EventArgs e)
        {
            if (!plant)
            {
                MessageBox.Show("Will take effect Next Round");
                plant = true;
            }
            Func.PlantBomb(plantBombBox.Text);
        }
        bool defuse;
        private void defuseTBtn_Click(object sender, EventArgs e)
        {
            if (!defuse)
            {
                MessageBox.Show("Will take effect Next Round");
                defuse = true;
            }
            Func.DefuseBomb(defuseBombBox.Text);
        }
        bool capture;
        private void captureBtn_Click(object sender, EventArgs e)
        {
            if (!capture)
            {
                MessageBox.Show("Will take effect Next Round");
                capture = true;
            }
            Func.CaptureTime(captureTimeBox.Text);
        }

        private void domnRBtn_Click(object sender, EventArgs e)
        {
            if (Func.ServerInfo.GameInfo() == "sd")
            {
                Func.ScoreLimit(roundLimitBox.Text);
            }
            else
            {
                Func.RoundLimit(roundLimitBox.Text);
            }
        }
        bool multi;
        private void multiBombBtn_Click(object sender, EventArgs e)
        {
            if (!multi)
            {
                MessageBox.Show("Will take effect Next Round");
                multi = true;
            }
            if (multiBombBtn.Text == "MultiBomb [ On ]")
            {
                Func.MultiBomb(true);
                multiBombBtn.Text = "MultiBomb [ Off ]";
            }
            else if (multiBombBtn.Text == "MultiBomb [ Off ]")
            {
                Func.MultiBomb(false);
                multiBombBtn.Text = "MultiBomb [ On ]";
            }
        }
        #region GodMod
        private void flatCheckBox48_CheckedChanged(object sender)
        {
            if (flatCheckBox48.Checked)
            {
                Func.ClientMods.GodMod(0, true);
            }
            else
            {
                Func.ClientMods.GodMod(0, false);
            }
        }

        private void flatCheckBox49_CheckedChanged(object sender)
        {
            if (flatCheckBox49.Checked)
            {
                Func.ClientMods.GodMod(1, true);
            }
            else
            {
                Func.ClientMods.GodMod(1, false);
            }
        }

        private void flatCheckBox50_CheckedChanged(object sender)
        {
            if (flatCheckBox50.Checked)
            {
                Func.ClientMods.GodMod(2, true);
            }
            else
            {
                Func.ClientMods.GodMod(2, false);
            }
        }

        private void flatCheckBox51_CheckedChanged(object sender)
        {
            if (flatCheckBox51.Checked)
            {
                Func.ClientMods.GodMod(3, true);
            }
            else
            {
                Func.ClientMods.GodMod(3, false);
            }
        }

        private void flatCheckBox52_CheckedChanged(object sender)
        {
            if (flatCheckBox52.Checked)
            {
                Func.ClientMods.GodMod(4, true);
            }
            else
            {
                Func.ClientMods.GodMod(4, false);
            }
        }

        private void flatCheckBox53_CheckedChanged(object sender)
        {
            if (flatCheckBox53.Checked)
            {
                Func.ClientMods.GodMod(5, true);
            }
            else
            {
                Func.ClientMods.GodMod(5, false);
            }
        }

        private void flatCheckBox54_CheckedChanged(object sender)
        {
            if (flatCheckBox54.Checked)
            {
                Func.ClientMods.GodMod(6, true);
            }
            else
            {
                Func.ClientMods.GodMod(6, false);
            }
        }

        private void flatCheckBox55_CheckedChanged(object sender)
        {
            if (flatCheckBox55.Checked)
            {
                Func.ClientMods.GodMod(7, true);
            }
            else
            {
                Func.ClientMods.GodMod(7, false);
            }
        }

        private void flatCheckBox56_CheckedChanged(object sender)
        {
            if (flatCheckBox56.Checked)
            {
                Func.ClientMods.GodMod(8, true);
            }
            else
            {
                Func.ClientMods.GodMod(8, false);
            }
        }

        private void flatCheckBox57_CheckedChanged(object sender)
        {
            if (flatCheckBox57.Checked)
            {
                Func.ClientMods.GodMod(9, true);
            }
            else
            {
                Func.ClientMods.GodMod(9, false);
            }
        }

        private void flatCheckBox58_CheckedChanged(object sender)
        {
            if (flatCheckBox58.Checked)
            {
                Func.ClientMods.GodMod(10, true);
            }
            else
            {
                Func.ClientMods.GodMod(10, false);
            }
        }

        private void flatCheckBox59_CheckedChanged(object sender)
        {
            if (flatCheckBox59.Checked)
            {
                Func.ClientMods.GodMod(11, true);
            }
            else
            {
                Func.ClientMods.GodMod(11, false);
            }
        }

        private void flatCheckBox338_CheckedChanged(object sender)
        {
            if (flatCheckBox338.Checked)
            {
                flatCheckBox48.Checked = true;
                flatCheckBox49.Checked = true;
                flatCheckBox50.Checked = true;
                flatCheckBox51.Checked = true;
                flatCheckBox52.Checked = true;
                flatCheckBox53.Checked = true;
                flatCheckBox54.Checked = true;
                flatCheckBox55.Checked = true;
                flatCheckBox56.Checked = true;
                flatCheckBox57.Checked = true;
                flatCheckBox58.Checked = true;
                flatCheckBox59.Checked = true;
                Func.ClientMods.GodMod(0, true);
                Func.ClientMods.GodMod(1, true);
                Func.ClientMods.GodMod(2, true);
                Func.ClientMods.GodMod(3, true);
                Func.ClientMods.GodMod(4, true);
                Func.ClientMods.GodMod(5, true);
                Func.ClientMods.GodMod(6, true);
                Func.ClientMods.GodMod(7, true);
                Func.ClientMods.GodMod(8, true);
                Func.ClientMods.GodMod(9, true);
                Func.ClientMods.GodMod(10, true);
                Func.ClientMods.GodMod(11, true);
            }
            else
            {
                flatCheckBox48.Checked = false;
                flatCheckBox49.Checked = false;
                flatCheckBox50.Checked = false;
                flatCheckBox51.Checked = false;
                flatCheckBox52.Checked = false;
                flatCheckBox53.Checked = false;
                flatCheckBox54.Checked = false;
                flatCheckBox55.Checked = false;
                flatCheckBox56.Checked = false;
                flatCheckBox57.Checked = false;
                flatCheckBox58.Checked = false;
                flatCheckBox59.Checked = false;
                Func.ClientMods.GodMod(0, false);
                Func.ClientMods.GodMod(1, false);
                Func.ClientMods.GodMod(2, false);
                Func.ClientMods.GodMod(3, false);
                Func.ClientMods.GodMod(4, false);
                Func.ClientMods.GodMod(5, false);
                Func.ClientMods.GodMod(6, false);
                Func.ClientMods.GodMod(7, false);
                Func.ClientMods.GodMod(8, false);
                Func.ClientMods.GodMod(9, false);
                Func.ClientMods.GodMod(10, false);
                Func.ClientMods.GodMod(11, false);
            }
        }
        #endregion
        #region VSAT
        private void flatCheckBox71_CheckedChanged(object sender)
        {
            if (flatCheckBox71.Checked)
            {
                Func.ClientMods.VSAT(0, true);
            }
            else
            {
                Func.ClientMods.VSAT(0, false);
            }
        }

        private void flatCheckBox70_CheckedChanged(object sender)
        {
            if (flatCheckBox70.Checked)
            {
                Func.ClientMods.VSAT(1, true);
            }
            else
            {
                Func.ClientMods.VSAT(1, false);
            }
        }

        private void flatCheckBox69_CheckedChanged(object sender)
        {
            if (flatCheckBox69.Checked)
            {
                Func.ClientMods.VSAT(2, true);
            }
            else
            {
                Func.ClientMods.VSAT(2, false);
            }
        }

        private void flatCheckBox68_CheckedChanged(object sender)
        {
            if (flatCheckBox68.Checked)
            {
                Func.ClientMods.VSAT(3, true);
            }
            else
            {
                Func.ClientMods.VSAT(3, false);
            }
        }

        private void flatCheckBox67_CheckedChanged(object sender)
        {
            if (flatCheckBox67.Checked)
            {
                Func.ClientMods.VSAT(4, true);
            }
            else
            {
                Func.ClientMods.VSAT(4, false);
            }
        }

        private void flatCheckBox66_CheckedChanged(object sender)
        {
            if (flatCheckBox66.Checked)
            {
                Func.ClientMods.VSAT(5, true);
            }
            else
            {
                Func.ClientMods.VSAT(5, false);
            }
        }

        private void flatCheckBox65_CheckedChanged(object sender)
        {
            if (flatCheckBox65.Checked)
            {
                Func.ClientMods.VSAT(6, true);
            }
            else
            {
                Func.ClientMods.VSAT(6, false);
            }
        }

        private void flatCheckBox64_CheckedChanged(object sender)
        {
            if (flatCheckBox64.Checked)
            {
                Func.ClientMods.VSAT(7, true);
            }
            else
            {
                Func.ClientMods.VSAT(7, false);
            }
        }

        private void flatCheckBox63_CheckedChanged(object sender)
        {
            if (flatCheckBox63.Checked)
            {
                Func.ClientMods.VSAT(8, true);
            }
            else
            {
                Func.ClientMods.VSAT(8, false);
            }
        }

        private void flatCheckBox62_CheckedChanged(object sender)
        {
            if (flatCheckBox62.Checked)
            {
                Func.ClientMods.VSAT(9, true);
            }
            else
            {
                Func.ClientMods.VSAT(9, false);
            }
        }

        private void flatCheckBox61_CheckedChanged(object sender)
        {
            if (flatCheckBox61.Checked)
            {
                Func.ClientMods.VSAT(10, true);
            }
            else
            {
                Func.ClientMods.VSAT(10, false);
            }
        }

        private void flatCheckBox60_CheckedChanged(object sender)
        {
            if (flatCheckBox60.Checked)
            {
                Func.ClientMods.VSAT(11, true);
            }
            else
            {
                Func.ClientMods.VSAT(11, false);
            }
        }

        private void flatCheckBox337_CheckedChanged(object sender)
        {
            if (flatCheckBox337.Checked)
            {
                flatCheckBox71.Checked = true;
                flatCheckBox70.Checked = true;
                flatCheckBox69.Checked = true;
                flatCheckBox68.Checked = true;
                flatCheckBox67.Checked = true;
                flatCheckBox66.Checked = true;
                flatCheckBox65.Checked = true;
                flatCheckBox64.Checked = true;
                flatCheckBox63.Checked = true;
                flatCheckBox62.Checked = true;
                flatCheckBox61.Checked = true;
                flatCheckBox60.Checked = true;
                Func.ClientMods.VSAT(0, true);
                Func.ClientMods.VSAT(1, true);
                Func.ClientMods.VSAT(2, true);
                Func.ClientMods.VSAT(3, true);
                Func.ClientMods.VSAT(4, true);
                Func.ClientMods.VSAT(5, true);
                Func.ClientMods.VSAT(6, true);
                Func.ClientMods.VSAT(7, true);
                Func.ClientMods.VSAT(8, true);
                Func.ClientMods.VSAT(9, true);
                Func.ClientMods.VSAT(10, true);
                Func.ClientMods.VSAT(11, true);
            }
            else
            {
                flatCheckBox71.Checked = false;
                flatCheckBox70.Checked = false;
                flatCheckBox69.Checked = false;
                flatCheckBox68.Checked = false;
                flatCheckBox67.Checked = false;
                flatCheckBox66.Checked = false;
                flatCheckBox65.Checked = false;
                flatCheckBox64.Checked = false;
                flatCheckBox63.Checked = false;
                flatCheckBox62.Checked = false;
                flatCheckBox61.Checked = false;
                flatCheckBox60.Checked = false;
                Func.ClientMods.VSAT(0, false);
                Func.ClientMods.VSAT(1, false);
                Func.ClientMods.VSAT(2, false);
                Func.ClientMods.VSAT(3, false);
                Func.ClientMods.VSAT(4, false);
                Func.ClientMods.VSAT(5, false);
                Func.ClientMods.VSAT(6, false);
                Func.ClientMods.VSAT(7, false);
                Func.ClientMods.VSAT(8, false);
                Func.ClientMods.VSAT(9, false);
                Func.ClientMods.VSAT(10, false);
                Func.ClientMods.VSAT(11, false);
            }
        }
        #endregion
        #region Ammo
        private void flatCheckBox83_CheckedChanged(object sender)
        {
            if (flatCheckBox83.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(0, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(0, false);
            }
        }

        private void flatCheckBox82_CheckedChanged(object sender)
        {
            if (flatCheckBox82.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(1, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(1, false);
            }
        }

        private void flatCheckBox81_CheckedChanged(object sender)
        {
            if (flatCheckBox81.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(2, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(2, false);
            }
        }

        private void flatCheckBox80_CheckedChanged(object sender)
        {
            if (flatCheckBox80.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(3, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(3, false);
            }
        }

        private void flatCheckBox79_CheckedChanged(object sender)
        {
            if (flatCheckBox79.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(4, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(4, false);
            }
        }

        private void flatCheckBox78_CheckedChanged(object sender)
        {
            if (flatCheckBox78.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(5, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(5, false);
            }
        }

        private void flatCheckBox77_CheckedChanged(object sender)
        {
            if (flatCheckBox77.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(6, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(6, false);
            }
        }

        private void flatCheckBox76_CheckedChanged(object sender)
        {
            if (flatCheckBox76.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(7, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(7, false);
            }
        }

        private void flatCheckBox75_CheckedChanged(object sender)
        {
            if (flatCheckBox75.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(8, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(8, false);
            }
        }

        private void flatCheckBox74_CheckedChanged(object sender)
        {
            if (flatCheckBox74.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(9, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(9, false);
            }
        }

        private void flatCheckBox73_CheckedChanged(object sender)
        {
            if (flatCheckBox73.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(10, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(10, false);
            }
        }

        private void flatCheckBox72_CheckedChanged(object sender)
        {
            if (flatCheckBox72.Checked)
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(11, true);
            }
            else
            {
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(11, false);
            }
        }
        private void flatCheckBox336_CheckedChanged(object sender)
        {
            if (flatCheckBox336.Checked)
            {
                flatCheckBox83.Checked = true;
                flatCheckBox82.Checked = true;
                flatCheckBox81.Checked = true;
                flatCheckBox80.Checked = true;
                flatCheckBox79.Checked = true;
                flatCheckBox78.Checked = true;
                flatCheckBox77.Checked = true;
                flatCheckBox76.Checked = true;
                flatCheckBox75.Checked = true;
                flatCheckBox74.Checked = true;
                flatCheckBox73.Checked = true;
                flatCheckBox72.Checked = true;
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(0, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(1, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(2, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(3, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(4, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(5, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(6, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(7, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(8, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(9, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(10, true);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(11, true);
                
            }
            else
            {
                flatCheckBox83.Checked = false;
                flatCheckBox82.Checked = false;
                flatCheckBox81.Checked = false;
                flatCheckBox80.Checked = false;
                flatCheckBox79.Checked = false;
                flatCheckBox78.Checked = false;
                flatCheckBox77.Checked = false;
                flatCheckBox76.Checked = false;
                flatCheckBox75.Checked = false;
                flatCheckBox74.Checked = false;
                flatCheckBox73.Checked = false;
                flatCheckBox72.Checked = false;
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(0, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(1, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(2, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(3, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(4, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(5, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(6, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(7, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(8, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(9, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(10, false);
                Func.ClientMods.ClientsAmmo.GiveAmmoTh(11, false);
            }
        }
        #endregion
        #region AllPerks
        private void flatCheckBox95_CheckedChanged(object sender)
        {
            if (flatCheckBox95.Checked)
            {
                Func.ClientMods.AllPerks(0, true);
            }
            else
            {
                Func.ClientMods.AllPerks(0, false);
            }
        }

        private void flatCheckBox94_CheckedChanged(object sender)
        {
            if (flatCheckBox94.Checked)
            {
                Func.ClientMods.AllPerks(1, true);
            }
            else
            {
                Func.ClientMods.AllPerks(1, false);
            }
        }

        private void flatCheckBox93_CheckedChanged(object sender)
        {
            if (flatCheckBox93.Checked)
            {
                Func.ClientMods.AllPerks(2, true);
            }
            else
            {
                Func.ClientMods.AllPerks(2, false);
            }
        }

        private void flatCheckBox92_CheckedChanged(object sender)
        {
            if (flatCheckBox92.Checked)
            {
                Func.ClientMods.AllPerks(3, true);
            }
            else
            {
                Func.ClientMods.AllPerks(3, false);
            }
        }

        private void flatCheckBox91_CheckedChanged(object sender)
        {
            if (flatCheckBox91.Checked)
            {
                Func.ClientMods.AllPerks(4, true);
            }
            else
            {
                Func.ClientMods.AllPerks(4, false);
            }
        }

        private void flatCheckBox90_CheckedChanged(object sender)
        {
            if (flatCheckBox90.Checked)
            {
                Func.ClientMods.AllPerks(5, true);
            }
            else
            {
                Func.ClientMods.AllPerks(5, false);
            }
        }

        private void flatCheckBox89_CheckedChanged(object sender)
        {
            if (flatCheckBox89.Checked)
            {
                Func.ClientMods.AllPerks(6, true);
            }
            else
            {
                Func.ClientMods.AllPerks(6, false);
            }
        }

        private void flatCheckBox88_CheckedChanged(object sender)
        {
            if (flatCheckBox88.Checked)
            {
                Func.ClientMods.AllPerks(7, true);
            }
            else
            {
                Func.ClientMods.AllPerks(7, false);
            }
        }

        private void flatCheckBox87_CheckedChanged(object sender)
        {
            if (flatCheckBox87.Checked)
            {
                Func.ClientMods.AllPerks(8, true);
            }
            else
            {
                Func.ClientMods.AllPerks(8, false);
            }
        }

        private void flatCheckBox86_CheckedChanged(object sender)
        {
            if (flatCheckBox86.Checked)
            {
                Func.ClientMods.AllPerks(9, true);
            }
            else
            {
                Func.ClientMods.AllPerks(9, false);
            }
        }

        private void flatCheckBox85_CheckedChanged(object sender)
        {
            if (flatCheckBox85.Checked)
            {
                Func.ClientMods.AllPerks(10, true);
            }
            else
            {
                Func.ClientMods.AllPerks(10, false);
            }
        }

        private void flatCheckBox84_CheckedChanged(object sender)
        {
            if (flatCheckBox84.Checked)
            {
                Func.ClientMods.AllPerks(11, true);
            }
            else
            {
                Func.ClientMods.AllPerks(11, false);
            }
        }

        private void flatCheckBox335_CheckedChanged(object sender)
        {
            if (flatCheckBox335.Checked)
            {
                flatCheckBox95.Checked = true;
                flatCheckBox94.Checked = true;
                flatCheckBox93.Checked = true;
                flatCheckBox92.Checked = true;
                flatCheckBox91.Checked = true;
                flatCheckBox90.Checked = true;
                flatCheckBox89.Checked = true;
                flatCheckBox88.Checked = true;
                flatCheckBox87.Checked = true;
                flatCheckBox86.Checked = true;
                flatCheckBox85.Checked = true;
                flatCheckBox84.Checked = true;
                Func.ClientMods.AllPerks(0, true);
                Func.ClientMods.AllPerks(1, true);
                Func.ClientMods.AllPerks(2, true);
                Func.ClientMods.AllPerks(3, true);
                Func.ClientMods.AllPerks(4, true);
                Func.ClientMods.AllPerks(5, true);
                Func.ClientMods.AllPerks(6, true);
                Func.ClientMods.AllPerks(7, true);
                Func.ClientMods.AllPerks(8, true);
                Func.ClientMods.AllPerks(9, true);
                Func.ClientMods.AllPerks(10, true);
                Func.ClientMods.AllPerks(11, true);
            }
            else
            {
                flatCheckBox95.Checked = false;
                flatCheckBox94.Checked = false;
                flatCheckBox93.Checked = false;
                flatCheckBox92.Checked = false;
                flatCheckBox91.Checked = false;
                flatCheckBox90.Checked = false;
                flatCheckBox89.Checked = false;
                flatCheckBox88.Checked = false;
                flatCheckBox87.Checked = false;
                flatCheckBox86.Checked = false;
                flatCheckBox85.Checked = false;
                flatCheckBox84.Checked = false;
                Func.ClientMods.AllPerks(0, false);
                Func.ClientMods.AllPerks(1, false);
                Func.ClientMods.AllPerks(2, false);
                Func.ClientMods.AllPerks(3, false);
                Func.ClientMods.AllPerks(4, false);
                Func.ClientMods.AllPerks(5, false);
                Func.ClientMods.AllPerks(6, false);
                Func.ClientMods.AllPerks(7, false);
                Func.ClientMods.AllPerks(8, false);
                Func.ClientMods.AllPerks(9, false);
                Func.ClientMods.AllPerks(10, false);
                Func.ClientMods.AllPerks(11, false);
            }
        }
        #endregion
        #region ScoreStreak
        private void flatCheckBox107_CheckedChanged(object sender)
        {
            if (flatCheckBox107.Checked)
            {
                flatCheckBox323.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(0, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(0, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(0, false);
            }
        }

        private void flatCheckBox106_CheckedChanged(object sender)
        {
            if (flatCheckBox106.Checked)
            {
                flatCheckBox322.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(1, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(1, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(1, false);
            }
        }

        private void flatCheckBox105_CheckedChanged(object sender)
        {
            if (flatCheckBox105.Checked)
            {
                flatCheckBox321.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(2, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(2, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(2, false);
            }
        }

        private void flatCheckBox104_CheckedChanged(object sender)
        {
            if (flatCheckBox104.Checked)
            {
                flatCheckBox320.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(3, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(3, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(3, false);
            }
        }

        private void flatCheckBox103_CheckedChanged(object sender)
        {
            if (flatCheckBox103.Checked)
            {
                flatCheckBox319.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(4, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(4, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(4, false);
            }
        }

        private void flatCheckBox102_CheckedChanged(object sender)
        {
            if (flatCheckBox102.Checked)
            {
                flatCheckBox318.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(5, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(5, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(5, false);
            }
        }

        private void flatCheckBox101_CheckedChanged(object sender)
        {
            if (flatCheckBox101.Checked)
            {
                flatCheckBox317.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(6, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(6, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(6, false);
            }
        }

        private void flatCheckBox100_CheckedChanged(object sender)
        {
            if (flatCheckBox100.Checked)
            {
                flatCheckBox316.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(7, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(7, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(7, false);
            }
        }

        private void flatCheckBox99_CheckedChanged(object sender)
        {
            if (flatCheckBox99.Checked)
            {
                flatCheckBox315.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(8, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(8, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(8, false);
            }
        }

        private void flatCheckBox98_CheckedChanged(object sender)
        {
            if (flatCheckBox98.Checked)
            {
                flatCheckBox316.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(9, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(9, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(9, false);
            }
        }

        private void flatCheckBox97_CheckedChanged(object sender)
        {
            if (flatCheckBox97.Checked)
            {
                flatCheckBox315.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(10, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(10, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(10, false);
            }
        }

        private void flatCheckBox96_CheckedChanged(object sender)
        {
            if (flatCheckBox100.Checked)
            {
                flatCheckBox314.Checked = false;
                if (!Func.inThread)
                { Func.Notify_C.Notify_Cl(11, "ScoreStreak : ^2On"); }
                Func.ClientMods.ScoreStreak(11, true);
            }
            else
            {
                Func.ClientMods.ScoreStreak(11, false);
            }
        }

        private void flatCheckBox334_CheckedChanged(object sender)
        {
            flatCheckBox344.Checked = false;
            if (flatCheckBox334.Checked)
            {
                flatCheckBox107.Checked = true;
                flatCheckBox106.Checked = true;
                flatCheckBox105.Checked = true;
                flatCheckBox104.Checked = true;
                flatCheckBox103.Checked = true;
                flatCheckBox102.Checked = true;
                flatCheckBox101.Checked = true;
                flatCheckBox100.Checked = true;
                flatCheckBox99.Checked = true;
                flatCheckBox98.Checked = true;
                flatCheckBox97.Checked = true;
                flatCheckBox96.Checked = true;
                Func.ClientMods.ScoreStreak(0, true);
                Func.ClientMods.ScoreStreak(1, true);
                Func.ClientMods.ScoreStreak(2, true);
                Func.ClientMods.ScoreStreak(3, true);
                Func.ClientMods.ScoreStreak(4, true);
                Func.ClientMods.ScoreStreak(5, true);
                Func.ClientMods.ScoreStreak(6, true);
                Func.ClientMods.ScoreStreak(7, true);
                Func.ClientMods.ScoreStreak(8, true);
                Func.ClientMods.ScoreStreak(9, true);
                Func.ClientMods.ScoreStreak(10, true);
                Func.ClientMods.ScoreStreak(11, true);

            }
            else
            {
                flatCheckBox107.Checked = false;
                flatCheckBox106.Checked = false;
                flatCheckBox105.Checked = false;
                flatCheckBox104.Checked = false;
                flatCheckBox103.Checked = false;
                flatCheckBox102.Checked = false;
                flatCheckBox101.Checked = false;
                flatCheckBox100.Checked = false;
                flatCheckBox99.Checked = false;
                flatCheckBox98.Checked = false;
                flatCheckBox97.Checked = false;
                flatCheckBox96.Checked = false;
                Func.ClientMods.ScoreStreak(0, false);
                Func.ClientMods.ScoreStreak(1, false);
                Func.ClientMods.ScoreStreak(2, false);
                Func.ClientMods.ScoreStreak(3, false);
                Func.ClientMods.ScoreStreak(4, false);
                Func.ClientMods.ScoreStreak(5, false);
                Func.ClientMods.ScoreStreak(6, false);
                Func.ClientMods.ScoreStreak(7, false);
                Func.ClientMods.ScoreStreak(8, false);
                Func.ClientMods.ScoreStreak(9, false);
                Func.ClientMods.ScoreStreak(10, false);
                Func.ClientMods.ScoreStreak(11, false);
            }
        }
        #endregion
        #region Invisible
        private void flatCheckBox119_CheckedChanged(object sender)
        {
            if (flatCheckBox119.Checked)
            {
                Func.ClientMods.InvisiblePlayer(0, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(0, false);
            }
        }

        private void flatCheckBox118_CheckedChanged(object sender)
        {
            if (flatCheckBox118.Checked)
            {
                Func.ClientMods.InvisiblePlayer(1, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(1, false);
            }
        }

        private void flatCheckBox117_CheckedChanged(object sender)
        {
            if (flatCheckBox117.Checked)
            {
                Func.ClientMods.InvisiblePlayer(2, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(2, false);
            }
        }

        private void flatCheckBox116_CheckedChanged(object sender)
        {
            if (flatCheckBox116.Checked)
            {
                Func.ClientMods.InvisiblePlayer(3, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(3, false);
            }
        }

        private void flatCheckBox115_CheckedChanged(object sender)
        {
            if (flatCheckBox115.Checked)
            {
                Func.ClientMods.InvisiblePlayer(4, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(4, false);
            }
        }

        private void flatCheckBox114_CheckedChanged(object sender)
        {
            if (flatCheckBox114.Checked)
            {
                Func.ClientMods.InvisiblePlayer(5, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(5, false);
            }
        }

        private void flatCheckBox113_CheckedChanged(object sender)
        {
            if (flatCheckBox113.Checked)
            {
                Func.ClientMods.InvisiblePlayer(6, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(6, false);
            }
        }

        private void flatCheckBox112_CheckedChanged(object sender)
        {
            if (flatCheckBox112.Checked)
            {
                Func.ClientMods.InvisiblePlayer(7, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(7, false);
            }
        }

        private void flatCheckBox111_CheckedChanged(object sender)
        {
            if (flatCheckBox111.Checked)
            {
                Func.ClientMods.InvisiblePlayer(8, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(8, false);
            }
        }

        private void flatCheckBox110_CheckedChanged(object sender)
        {
            if (flatCheckBox110.Checked)
            {
                Func.ClientMods.InvisiblePlayer(9, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(9, false);
            }
        }

        private void flatCheckBox109_CheckedChanged(object sender)
        {
            if (flatCheckBox109.Checked)
            {
                Func.ClientMods.InvisiblePlayer(10, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(10, false);
            }
        }

        private void flatCheckBox108_CheckedChanged(object sender)
        {
            if (flatCheckBox108.Checked)
            {
                Func.ClientMods.InvisiblePlayer(11, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(11, false);
            }
        }

        private void flatCheckBox333_CheckedChanged(object sender)
        {
            if (flatCheckBox333.Checked)
            {
                flatCheckBox119.Checked = true;
                flatCheckBox118.Checked = true;
                flatCheckBox117.Checked = true;
                flatCheckBox116.Checked = true;
                flatCheckBox115.Checked = true;
                flatCheckBox114.Checked = true;
                flatCheckBox113.Checked = true;
                flatCheckBox112.Checked = true;
                flatCheckBox111.Checked = true;
                flatCheckBox110.Checked = true;
                flatCheckBox109.Checked = true;
                flatCheckBox108.Checked = true;
                Func.ClientMods.InvisiblePlayer(0, true);
                Func.ClientMods.InvisiblePlayer(1, true);
                Func.ClientMods.InvisiblePlayer(2, true);
                Func.ClientMods.InvisiblePlayer(3, true);
                Func.ClientMods.InvisiblePlayer(4, true);
                Func.ClientMods.InvisiblePlayer(5, true);
                Func.ClientMods.InvisiblePlayer(6, true);
                Func.ClientMods.InvisiblePlayer(7, true);
                Func.ClientMods.InvisiblePlayer(8, true);
                Func.ClientMods.InvisiblePlayer(9, true);
                Func.ClientMods.InvisiblePlayer(10, true);
                Func.ClientMods.InvisiblePlayer(11, true);
            }
            else
            {
                flatCheckBox119.Checked = false;
                flatCheckBox118.Checked = false;
                flatCheckBox117.Checked = false;
                flatCheckBox116.Checked = false;
                flatCheckBox115.Checked = false;
                flatCheckBox114.Checked = false;
                flatCheckBox113.Checked = false;
                flatCheckBox112.Checked = false;
                flatCheckBox111.Checked = false;
                flatCheckBox110.Checked = false;
                flatCheckBox109.Checked = false;
                flatCheckBox108.Checked = false;
                Func.ClientMods.InvisiblePlayer(0, false);
                Func.ClientMods.InvisiblePlayer(1, false);
                Func.ClientMods.InvisiblePlayer(2, false);
                Func.ClientMods.InvisiblePlayer(3, false);
                Func.ClientMods.InvisiblePlayer(4, false);
                Func.ClientMods.InvisiblePlayer(5, false);
                Func.ClientMods.InvisiblePlayer(6, false);
                Func.ClientMods.InvisiblePlayer(7, false);
                Func.ClientMods.InvisiblePlayer(8, false);
                Func.ClientMods.InvisiblePlayer(9, false);
                Func.ClientMods.InvisiblePlayer(10, false);
                Func.ClientMods.InvisiblePlayer(11, false);
            }
        }
        #endregion
        #region Third Person
        private void flatCheckBox131_CheckedChanged(object sender)
        {
            if (flatCheckBox131.Checked)
            {
                Func.ClientMods.ThirdPerson(0, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(0, false);
            }
        }

        private void flatCheckBox130_CheckedChanged(object sender)
        {
            if (flatCheckBox130.Checked)
            {
                Func.ClientMods.ThirdPerson(1, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(1, false);
            }
        }

        private void flatCheckBox129_CheckedChanged(object sender)
        {
            if (flatCheckBox129.Checked)
            {
                Func.ClientMods.ThirdPerson(2, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(2, false);
            }
        }

        private void flatCheckBox128_CheckedChanged(object sender)
        {
            if (flatCheckBox128.Checked)
            {
                Func.ClientMods.ThirdPerson(3, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(3, false);
            }
        }

        private void flatCheckBox127_CheckedChanged(object sender)
        {
            if (flatCheckBox127.Checked)
            {
                Func.ClientMods.ThirdPerson(4, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(4, false);
            }
        }

        private void flatCheckBox126_CheckedChanged(object sender)
        {
            if (flatCheckBox126.Checked)
            {
                Func.ClientMods.ThirdPerson(5, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(5, false);
            }
        }

        private void flatCheckBox125_CheckedChanged(object sender)
        {
            if (flatCheckBox125.Checked)
            {
                Func.ClientMods.ThirdPerson(6, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(6, false);
            }
        }

        private void flatCheckBox124_CheckedChanged(object sender)
        {
            if (flatCheckBox124.Checked)
            {
                Func.ClientMods.ThirdPerson(7, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(7, false);
            }
        }

        private void flatCheckBox123_CheckedChanged(object sender)
        {
            if (flatCheckBox123.Checked)
            {
                Func.ClientMods.ThirdPerson(8, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(8, false);
            }
        }

        private void flatCheckBox122_CheckedChanged(object sender)
        {
            if (flatCheckBox122.Checked)
            {
                Func.ClientMods.ThirdPerson(9, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(9, false);
            }
        }

        private void flatCheckBox121_CheckedChanged(object sender)
        {
            if (flatCheckBox121.Checked)
            {
                Func.ClientMods.ThirdPerson(10, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(10, false);
            }
        }

        private void flatCheckBox120_CheckedChanged(object sender)
        {
            if (flatCheckBox120.Checked)
            {
                Func.ClientMods.ThirdPerson(11, true);
            }
            else
            {
                Func.ClientMods.ThirdPerson(11, false);
            }
        }

        private void flatCheckBox332_CheckedChanged(object sender)
        {
            if (flatCheckBox332.Checked)
            {
                flatCheckBox131.Checked = true;
                flatCheckBox130.Checked = true;
                flatCheckBox129.Checked = true;
                flatCheckBox128.Checked = true;
                flatCheckBox127.Checked = true;
                flatCheckBox126.Checked = true;
                flatCheckBox125.Checked = true;
                flatCheckBox124.Checked = true;
                flatCheckBox123.Checked = true;
                flatCheckBox122.Checked = true;
                flatCheckBox121.Checked = true;
                flatCheckBox120.Checked = true;
                Func.ClientMods.ThirdPerson(0, true);
                Func.ClientMods.ThirdPerson(1, true);
                Func.ClientMods.ThirdPerson(2, true);
                Func.ClientMods.ThirdPerson(3, true);
                Func.ClientMods.ThirdPerson(4, true);
                Func.ClientMods.ThirdPerson(5, true);
                Func.ClientMods.ThirdPerson(6, true);
                Func.ClientMods.ThirdPerson(7, true);
                Func.ClientMods.ThirdPerson(8, true);
                Func.ClientMods.ThirdPerson(9, true);
                Func.ClientMods.ThirdPerson(10, true);
                Func.ClientMods.ThirdPerson(11, true);
            }
            else
            {
                flatCheckBox131.Checked = false;
                flatCheckBox130.Checked = false;
                flatCheckBox129.Checked = false;
                flatCheckBox128.Checked = false;
                flatCheckBox127.Checked = false;
                flatCheckBox126.Checked = false;
                flatCheckBox125.Checked = false;
                flatCheckBox124.Checked = false;
                flatCheckBox123.Checked = false;
                flatCheckBox122.Checked = false;
                flatCheckBox121.Checked = false;
                flatCheckBox120.Checked = false;
                Func.ClientMods.ThirdPerson(0, false);
                Func.ClientMods.ThirdPerson(1, false);
                Func.ClientMods.ThirdPerson(2, false);
                Func.ClientMods.ThirdPerson(3, false);
                Func.ClientMods.ThirdPerson(4, false);
                Func.ClientMods.ThirdPerson(5, false);
                Func.ClientMods.ThirdPerson(6, false);
                Func.ClientMods.ThirdPerson(7, false);
                Func.ClientMods.ThirdPerson(8, false);
                Func.ClientMods.ThirdPerson(9, false);
                Func.ClientMods.ThirdPerson(10, false);
                Func.ClientMods.ThirdPerson(11, false);
            }
        }
        #endregion
        #region SpeedPlayer
        private void flatCheckBox143_CheckedChanged(object sender)
        {
            if (flatCheckBox143.Checked)
            {
                Func.ClientMods.SpeedPlayer(0, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(0, false);
            }
        }

        private void flatCheckBox142_CheckedChanged(object sender)
        {
            if (flatCheckBox142.Checked)
            {
                Func.ClientMods.SpeedPlayer(1, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(1, false);
            }
        }

        private void flatCheckBox141_CheckedChanged(object sender)
        {
            if (flatCheckBox141.Checked)
            {
                Func.ClientMods.SpeedPlayer(2, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(2, false);
            }
        }

        private void flatCheckBox140_CheckedChanged(object sender)
        {
            if (flatCheckBox140.Checked)
            {
                Func.ClientMods.SpeedPlayer(3, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(3, false);
            }
        }

        private void flatCheckBox139_CheckedChanged(object sender)
        {
            if (flatCheckBox139.Checked)
            {
                Func.ClientMods.SpeedPlayer(4, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(4, false);
            }
        }

        private void flatCheckBox138_CheckedChanged(object sender)
        {
            if (flatCheckBox138.Checked)
            {
                Func.ClientMods.SpeedPlayer(5, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(5, false);
            }
        }

        private void flatCheckBox137_CheckedChanged(object sender)
        {
            if (flatCheckBox137.Checked)
            {
                Func.ClientMods.SpeedPlayer(6, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(6, false);
            }
        }

        private void flatCheckBox136_CheckedChanged(object sender)
        {
            if (flatCheckBox136.Checked)
            {
                Func.ClientMods.SpeedPlayer(7, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(7, false);
            }
        }

        private void flatCheckBox135_CheckedChanged(object sender)
        {
            if (flatCheckBox135.Checked)
            {
                Func.ClientMods.SpeedPlayer(8, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(8, false);
            }
        }

        private void flatCheckBox134_CheckedChanged(object sender)
        {
            if (flatCheckBox134.Checked)
            {
                Func.ClientMods.SpeedPlayer(9, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(9, false);
            }
        }

        private void flatCheckBox133_CheckedChanged(object sender)
        {
            if (flatCheckBox133.Checked)
            {
                Func.ClientMods.SpeedPlayer(10, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(10, false);
            }
        }

        private void flatCheckBox132_CheckedChanged(object sender)
        {
            if (flatCheckBox132.Checked)
            {
                Func.ClientMods.SpeedPlayer(11, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(11, false);
            }
        }

        private void flatCheckBox331_CheckedChanged(object sender)
        {
            if (flatCheckBox331.Checked)
            {
                flatCheckBox143.Checked = true;
                flatCheckBox142.Checked = true;
                flatCheckBox141.Checked = true;
                flatCheckBox140.Checked = true;
                flatCheckBox139.Checked = true;
                flatCheckBox138.Checked = true;
                flatCheckBox137.Checked = true;
                flatCheckBox136.Checked = true;
                flatCheckBox135.Checked = true;
                flatCheckBox134.Checked = true;
                flatCheckBox133.Checked = true;
                flatCheckBox132.Checked = true;
                Func.ClientMods.SpeedPlayer(0, true);
                Func.ClientMods.SpeedPlayer(1, true);
                Func.ClientMods.SpeedPlayer(2, true);
                Func.ClientMods.SpeedPlayer(3, true);
                Func.ClientMods.SpeedPlayer(4, true);
                Func.ClientMods.SpeedPlayer(5, true);
                Func.ClientMods.SpeedPlayer(6, true);
                Func.ClientMods.SpeedPlayer(7, true);
                Func.ClientMods.SpeedPlayer(8, true);
                Func.ClientMods.SpeedPlayer(9, true);
                Func.ClientMods.SpeedPlayer(10, true);
                Func.ClientMods.SpeedPlayer(11, true);
            }
            else
            {
                flatCheckBox143.Checked = false;
                flatCheckBox142.Checked = false;
                flatCheckBox141.Checked = false;
                flatCheckBox140.Checked = false;
                flatCheckBox139.Checked = false;
                flatCheckBox138.Checked = false;
                flatCheckBox137.Checked = false;
                flatCheckBox136.Checked = false;
                flatCheckBox135.Checked = false;
                flatCheckBox134.Checked = false;
                flatCheckBox133.Checked = false;
                flatCheckBox132.Checked = false;
                Func.ClientMods.SpeedPlayer(0, false);
                Func.ClientMods.SpeedPlayer(1, false);
                Func.ClientMods.SpeedPlayer(2, false);
                Func.ClientMods.SpeedPlayer(3, false);
                Func.ClientMods.SpeedPlayer(4, false);
                Func.ClientMods.SpeedPlayer(5, false);
                Func.ClientMods.SpeedPlayer(6, false);
                Func.ClientMods.SpeedPlayer(7, false);
                Func.ClientMods.SpeedPlayer(8, false);
                Func.ClientMods.SpeedPlayer(9, false);
                Func.ClientMods.SpeedPlayer(10, false);
                Func.ClientMods.SpeedPlayer(11, false);
            }
        }
        #endregion
        #region EMP
        private void flatCheckBox155_CheckedChanged(object sender)
        {
            if (flatCheckBox155.Checked)
            {
                Func.ClientMods.EMP(0, true);
            }
            else
            {
                Func.ClientMods.EMP(0, false);
            }
        }

        private void flatCheckBox154_CheckedChanged(object sender)
        {
            if (flatCheckBox154.Checked)
            {
                Func.ClientMods.EMP(1, true);
            }
            else
            {
                Func.ClientMods.EMP(1, false);
            }
        }

        private void flatCheckBox153_CheckedChanged(object sender)
        {
            if (flatCheckBox153.Checked)
            {
                Func.ClientMods.EMP(2, true);
            }
            else
            {
                Func.ClientMods.EMP(2, false);
            }
        }

        private void flatCheckBox152_CheckedChanged(object sender)
        {
            if (flatCheckBox152.Checked)
            {
                Func.ClientMods.EMP(3, true);
            }
            else
            {
                Func.ClientMods.EMP(3, false);
            }
        }

        private void flatCheckBox151_CheckedChanged(object sender)
        {
            if (flatCheckBox151.Checked)
            {
                Func.ClientMods.EMP(4, true);
            }
            else
            {
                Func.ClientMods.EMP(4, false);
            }
        }

        private void flatCheckBox150_CheckedChanged(object sender)
        {
            if (flatCheckBox150.Checked)
            {
                Func.ClientMods.EMP(5, true);
            }
            else
            {
                Func.ClientMods.EMP(5, false);
            }
        }

        private void flatCheckBox149_CheckedChanged(object sender)
        {
            if (flatCheckBox149.Checked)
            {
                Func.ClientMods.EMP(6, true);
            }
            else
            {
                Func.ClientMods.EMP(6, false);
            }
        }

        private void flatCheckBox148_CheckedChanged(object sender)
        {
            if (flatCheckBox148.Checked)
            {
                Func.ClientMods.EMP(7, true);
            }
            else
            {
                Func.ClientMods.EMP(7, false);
            }
        }

        private void flatCheckBox147_CheckedChanged(object sender)
        {
            if (flatCheckBox147.Checked)
            {
                Func.ClientMods.EMP(8, true);
            }
            else
            {
                Func.ClientMods.EMP(8, false);
            }
        }

        private void flatCheckBox146_CheckedChanged(object sender)
        {
            if (flatCheckBox146.Checked)
            {
                Func.ClientMods.EMP(9, true);
            }
            else
            {
                Func.ClientMods.EMP(9, false);
            }
        }

        private void flatCheckBox145_CheckedChanged(object sender)
        {
            if (flatCheckBox145.Checked)
            {
                Func.ClientMods.EMP(10, true);
            }
            else
            {
                Func.ClientMods.EMP(10, false);
            }
        }

        private void flatCheckBox144_CheckedChanged(object sender)
        {
            if (flatCheckBox144.Checked)
            {
                Func.ClientMods.EMP(11, true);
            }
            else
            {
                Func.ClientMods.EMP(11, false);
            }
        }

        private void flatCheckBox330_CheckedChanged(object sender)
        {
            if (flatCheckBox330.Checked)
            {
                flatCheckBox155.Checked = true;
                flatCheckBox154.Checked = true;
                flatCheckBox153.Checked = true;
                flatCheckBox152.Checked = true;
                flatCheckBox151.Checked = true;
                flatCheckBox150.Checked = true;
                flatCheckBox149.Checked = true;
                flatCheckBox148.Checked = true;
                flatCheckBox147.Checked = true;
                flatCheckBox146.Checked = true;
                flatCheckBox145.Checked = true;
                flatCheckBox144.Checked = true;
                Func.ClientMods.EMP(0, true);
                Func.ClientMods.EMP(1, true);
                Func.ClientMods.EMP(2, true);
                Func.ClientMods.EMP(3, true);
                Func.ClientMods.EMP(4, true);
                Func.ClientMods.EMP(5, true);
                Func.ClientMods.EMP(6, true);
                Func.ClientMods.EMP(7, true);
                Func.ClientMods.EMP(8, true);
                Func.ClientMods.EMP(9, true);
                Func.ClientMods.EMP(10, true);
                Func.ClientMods.EMP(11, true);
            }
            else
            {
                flatCheckBox155.Checked = false;
                flatCheckBox154.Checked = false;
                flatCheckBox153.Checked = false;
                flatCheckBox152.Checked = false;
                flatCheckBox151.Checked = false;
                flatCheckBox150.Checked = false;
                flatCheckBox149.Checked = false;
                flatCheckBox148.Checked = false;
                flatCheckBox147.Checked = false;
                flatCheckBox146.Checked = false;
                flatCheckBox145.Checked = false;
                flatCheckBox144.Checked = false;
                Func.ClientMods.EMP(0, false);
                Func.ClientMods.EMP(1, false);
                Func.ClientMods.EMP(2, false);
                Func.ClientMods.EMP(3, false);
                Func.ClientMods.EMP(4, false);
                Func.ClientMods.EMP(5, false);
                Func.ClientMods.EMP(6, false);
                Func.ClientMods.EMP(7, false);
                Func.ClientMods.EMP(8, false);
                Func.ClientMods.EMP(9, false);
                Func.ClientMods.EMP(10, false);
                Func.ClientMods.EMP(11, false);
            }
        }
        #endregion
        #region Night Vision
        private void flatCheckBox167_CheckedChanged(object sender)
        {
            if (flatCheckBox167.Checked)
            {
                Func.ClientMods.NightVision(0, true);
            }
            else
            {
                Func.ClientMods.NightVision(0, false);
            }
        }

        private void flatCheckBox166_CheckedChanged(object sender)
        {
            if (flatCheckBox166.Checked)
            {
                Func.ClientMods.NightVision(1, true);
            }
            else
            {
                Func.ClientMods.NightVision(1, false);
            }
        }

        private void flatCheckBox165_CheckedChanged(object sender)
        {
            if (flatCheckBox165.Checked)
            {
                Func.ClientMods.NightVision(2, true);
            }
            else
            {
                Func.ClientMods.NightVision(2, false);
            }
        }

        private void flatCheckBox164_CheckedChanged(object sender)
        {
            if (flatCheckBox164.Checked)
            {
                Func.ClientMods.NightVision(3, true);
            }
            else
            {
                Func.ClientMods.NightVision(3, false);
            }
        }

        private void flatCheckBox163_CheckedChanged(object sender)
        {
            if (flatCheckBox163.Checked)
            {
                Func.ClientMods.NightVision(4, true);
            }
            else
            {
                Func.ClientMods.NightVision(4, false);
            }
        }

        private void flatCheckBox162_CheckedChanged(object sender)
        {
            if (flatCheckBox162.Checked)
            {
                Func.ClientMods.NightVision(5, true);
            }
            else
            {
                Func.ClientMods.NightVision(5, false);
            }
        }

        private void flatCheckBox161_CheckedChanged(object sender)
        {
            if (flatCheckBox161.Checked)
            {
                Func.ClientMods.NightVision(6, true);
            }
            else
            {
                Func.ClientMods.NightVision(6, false);
            }
        }

        private void flatCheckBox160_CheckedChanged(object sender)
        {
            if (flatCheckBox160.Checked)
            {
                Func.ClientMods.NightVision(7, true);
            }
            else
            {
                Func.ClientMods.NightVision(7, false);
            }
        }

        private void flatCheckBox159_CheckedChanged(object sender)
        {
            if (flatCheckBox159.Checked)
            {
                Func.ClientMods.NightVision(8, true);
            }
            else
            {
                Func.ClientMods.NightVision(8, false);
            }
        }

        private void flatCheckBox158_CheckedChanged(object sender)
        {
            if (flatCheckBox158.Checked)
            {
                Func.ClientMods.NightVision(9, true);
            }
            else
            {
                Func.ClientMods.NightVision(9, false);
            }
        }

        private void flatCheckBox157_CheckedChanged(object sender)
        {
            if (flatCheckBox157.Checked)
            {
                Func.ClientMods.NightVision(10, true);
            }
            else
            {
                Func.ClientMods.NightVision(10, false);
            }
        }

        private void flatCheckBox156_CheckedChanged(object sender)
        {
            if (flatCheckBox156.Checked)
            {
                Func.ClientMods.NightVision(11, true);
            }
            else
            {
                Func.ClientMods.NightVision(11, false);
            }
        }

        private void flatCheckBox329_CheckedChanged(object sender)
        {
            if (flatCheckBox329.Checked)
            {
                flatCheckBox167.Checked = true;
                flatCheckBox166.Checked = true;
                flatCheckBox165.Checked = true;
                flatCheckBox164.Checked = true;
                flatCheckBox163.Checked = true;
                flatCheckBox162.Checked = true;
                flatCheckBox161.Checked = true;
                flatCheckBox160.Checked = true;
                flatCheckBox159.Checked = true;
                flatCheckBox158.Checked = true;
                flatCheckBox157.Checked = true;
                flatCheckBox156.Checked = true;
                Func.ClientMods.NightVision(0, true);
                Func.ClientMods.NightVision(1, true);
                Func.ClientMods.NightVision(2, true);
                Func.ClientMods.NightVision(3, true);
                Func.ClientMods.NightVision(4, true);
                Func.ClientMods.NightVision(5, true);
                Func.ClientMods.NightVision(6, true);
                Func.ClientMods.NightVision(7, true);
                Func.ClientMods.NightVision(8, true);
                Func.ClientMods.NightVision(9, true);
                Func.ClientMods.NightVision(10, true);
                Func.ClientMods.NightVision(11, true);
            }
            else
            {
                flatCheckBox167.Checked = false;
                flatCheckBox166.Checked = false;
                flatCheckBox165.Checked = false;
                flatCheckBox164.Checked = false;
                flatCheckBox163.Checked = false;
                flatCheckBox162.Checked = false;
                flatCheckBox161.Checked = false;
                flatCheckBox160.Checked = false;
                flatCheckBox159.Checked = false;
                flatCheckBox158.Checked = false;
                flatCheckBox157.Checked = false;
                flatCheckBox156.Checked = false;
                Func.ClientMods.NightVision(0, false);
                Func.ClientMods.NightVision(1, false);
                Func.ClientMods.NightVision(2, false);
                Func.ClientMods.NightVision(3, false);
                Func.ClientMods.NightVision(4, false);
                Func.ClientMods.NightVision(5, false);
                Func.ClientMods.NightVision(6, false);
                Func.ClientMods.NightVision(7, false);
                Func.ClientMods.NightVision(8, false);
                Func.ClientMods.NightVision(9, false);
                Func.ClientMods.NightVision(10, false);
                Func.ClientMods.NightVision(11, false);
            }
        }
        #endregion
        #region BlackScreen
        private void flatCheckBox179_CheckedChanged(object sender)
        {
            if (flatCheckBox179.Checked)
            {
                Func.ClientMods.BlackScreen(0, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(0, false);
            }
        }

        private void flatCheckBox178_CheckedChanged(object sender)
        {
            if (flatCheckBox178.Checked)
            {
                Func.ClientMods.BlackScreen(1, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(1, false);
            }
        }

        private void flatCheckBox177_CheckedChanged(object sender)
        {
            if (flatCheckBox177.Checked)
            {
                Func.ClientMods.BlackScreen(2, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(2, false);
            }
        }

        private void flatCheckBox176_CheckedChanged(object sender)
        {
            if (flatCheckBox176.Checked)
            {
                Func.ClientMods.BlackScreen(3, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(3, false);
            }
        }

        private void flatCheckBox175_CheckedChanged(object sender)
        {
            if (flatCheckBox175.Checked)
            {
                Func.ClientMods.BlackScreen(4, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(4, false);
            }
        }

        private void flatCheckBox174_CheckedChanged(object sender)
        {
            if (flatCheckBox174.Checked)
            {
                Func.ClientMods.BlackScreen(5, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(5, false);
            }
        }

        private void flatCheckBox173_CheckedChanged(object sender)
        {
            if (flatCheckBox175.Checked)
            {
                Func.ClientMods.BlackScreen(6, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(6, false);
            }
        }

        private void flatCheckBox172_CheckedChanged(object sender)
        {
            if (flatCheckBox172.Checked)
            {
                Func.ClientMods.BlackScreen(7, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(7, false);
            }
        }

        private void flatCheckBox171_CheckedChanged(object sender)
        {
            if (flatCheckBox171.Checked)
            {
                Func.ClientMods.BlackScreen(8, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(8, false);
            }
        }

        private void flatCheckBox170_CheckedChanged(object sender)
        {
            if (flatCheckBox170.Checked)
            {
                Func.ClientMods.BlackScreen(9, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(9, false);
            }
        }

        private void flatCheckBox169_CheckedChanged(object sender)
        {
            if (flatCheckBox169.Checked)
            {
                Func.ClientMods.BlackScreen(10, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(10, false);
            }
        }

        private void flatCheckBox168_CheckedChanged(object sender)
        {
            if (flatCheckBox168.Checked)
            {
                Func.ClientMods.BlackScreen(11, true);
            }
            else
            {
                Func.ClientMods.BlackScreen(11, false);
            }
        }

        private void flatCheckBox328_CheckedChanged(object sender)
        {
            if (flatCheckBox328.Checked)
            {
                flatCheckBox179.Checked = true;
                flatCheckBox178.Checked = true;
                flatCheckBox177.Checked = true;
                flatCheckBox176.Checked = true;
                flatCheckBox175.Checked = true;
                flatCheckBox174.Checked = true;
                flatCheckBox173.Checked = true;
                flatCheckBox172.Checked = true;
                flatCheckBox171.Checked = true;
                flatCheckBox170.Checked = true;
                flatCheckBox169.Checked = true;
                flatCheckBox168.Checked = true;
                Func.ClientMods.BlackScreen(0, true);
                Func.ClientMods.BlackScreen(1, true);
                Func.ClientMods.BlackScreen(2, true);
                Func.ClientMods.BlackScreen(3, true);
                Func.ClientMods.BlackScreen(4, true);
                Func.ClientMods.BlackScreen(5, true);
                Func.ClientMods.BlackScreen(6, true);
                Func.ClientMods.BlackScreen(7, true);
                Func.ClientMods.BlackScreen(8, true);
                Func.ClientMods.BlackScreen(9, true);
                Func.ClientMods.BlackScreen(10, true);
                Func.ClientMods.BlackScreen(11, true);
            }
            else
            {
                flatCheckBox179.Checked = false;
                flatCheckBox178.Checked = false;
                flatCheckBox177.Checked = false;
                flatCheckBox176.Checked = false;
                flatCheckBox175.Checked = false;
                flatCheckBox174.Checked = false;
                flatCheckBox173.Checked = false;
                flatCheckBox172.Checked = false;
                flatCheckBox171.Checked = false;
                flatCheckBox170.Checked = false;
                flatCheckBox169.Checked = false;
                flatCheckBox168.Checked = false;
                Func.ClientMods.BlackScreen(0, false);
                Func.ClientMods.BlackScreen(1, false);
                Func.ClientMods.BlackScreen(2, false);
                Func.ClientMods.BlackScreen(3, false);
                Func.ClientMods.BlackScreen(4, false);
                Func.ClientMods.BlackScreen(5, false);
                Func.ClientMods.BlackScreen(6, false);
                Func.ClientMods.BlackScreen(7, false);
                Func.ClientMods.BlackScreen(8, false);
                Func.ClientMods.BlackScreen(9, false);
                Func.ClientMods.BlackScreen(10, false);
                Func.ClientMods.BlackScreen(11, false);
            }
        }
        #endregion
        #region Posion
        private void flatCheckBox191_CheckedChanged(object sender)
        {
            if (flatCheckBox191.Checked)
            {
                Func.ClientMods.Posion(0, true);
            }
            else
            {
                Func.ClientMods.Posion(0, false);
            }
        }

        private void flatCheckBox190_CheckedChanged(object sender)
        {
            if (flatCheckBox190.Checked)
            {
                Func.ClientMods.Posion(1, true);
            }
            else
            {
                Func.ClientMods.Posion(1, false);
            }
        }

        private void flatCheckBox189_CheckedChanged(object sender)
        {
            if (flatCheckBox189.Checked)
            {
                Func.ClientMods.Posion(2, true);
            }
            else
            {
                Func.ClientMods.Posion(2, false);
            }
        }

        private void flatCheckBox188_CheckedChanged(object sender)
        {
            if (flatCheckBox188.Checked)
            {
                Func.ClientMods.Posion(3, true);
            }
            else
            {
                Func.ClientMods.Posion(3, false);
            }
        }

        private void flatCheckBox187_CheckedChanged(object sender)
        {
            if (flatCheckBox187.Checked)
            {
                Func.ClientMods.Posion(4, true);
            }
            else
            {
                Func.ClientMods.Posion(4, false);
            }
        }

        private void flatCheckBox186_CheckedChanged(object sender)
        {
            if (flatCheckBox186.Checked)
            {
                Func.ClientMods.Posion(5, true);
            }
            else
            {
                Func.ClientMods.Posion(5, false);
            }
        }

        private void flatCheckBox185_CheckedChanged(object sender)
        {
            if (flatCheckBox185.Checked)
            {
                Func.ClientMods.Posion(6, true);
            }
            else
            {
                Func.ClientMods.Posion(6, false);
            }
        }

        private void flatCheckBox184_CheckedChanged(object sender)
        {
            if (flatCheckBox184.Checked)
            {
                Func.ClientMods.Posion(7, true);
            }
            else
            {
                Func.ClientMods.Posion(7, false);
            }
        }

        private void flatCheckBox183_CheckedChanged(object sender)
        {
            if (flatCheckBox183.Checked)
            {
                Func.ClientMods.Posion(8, true);
            }
            else
            {
                Func.ClientMods.Posion(8, false);
            }
        }

        private void flatCheckBox182_CheckedChanged(object sender)
        {
            if (flatCheckBox182.Checked)
            {
                Func.ClientMods.Posion(9, true);
            }
            else
            {
                Func.ClientMods.Posion(9, false);
            }
        }

        private void flatCheckBox181_CheckedChanged(object sender)
        {
            if (flatCheckBox181.Checked)
            {
                Func.ClientMods.Posion(10, true);
            }
            else
            {
                Func.ClientMods.Posion(10, false);
            }
        }

        private void flatCheckBox180_CheckedChanged(object sender)
        {
            if (flatCheckBox180.Checked)
            {
                Func.ClientMods.Posion(11, true);
            }
            else
            {
                Func.ClientMods.Posion(11, false);
            }
        }

        private void flatCheckBox327_CheckedChanged(object sender)
        {
            if (flatCheckBox327.Checked)
            {
                flatCheckBox191.Checked = true;
                flatCheckBox190.Checked = true;
                flatCheckBox189.Checked = true;
                flatCheckBox188.Checked = true;
                flatCheckBox187.Checked = true;
                flatCheckBox186.Checked = true;
                flatCheckBox185.Checked = true;
                flatCheckBox184.Checked = true;
                flatCheckBox183.Checked = true;
                flatCheckBox182.Checked = true;
                flatCheckBox181.Checked = true;
                flatCheckBox180.Checked = true;
                Func.ClientMods.Posion(0, true);
                Func.ClientMods.Posion(1, true);
                Func.ClientMods.Posion(2, true);
                Func.ClientMods.Posion(3, true);
                Func.ClientMods.Posion(4, true);
                Func.ClientMods.Posion(5, true);
                Func.ClientMods.Posion(6, true);
                Func.ClientMods.Posion(7, true);
                Func.ClientMods.Posion(8, true);
                Func.ClientMods.Posion(9, true);
                Func.ClientMods.Posion(10, true);
                Func.ClientMods.Posion(11, true);
            }
            else
            {
                flatCheckBox191.Checked = false;
                flatCheckBox190.Checked = false;
                flatCheckBox189.Checked = false;
                flatCheckBox188.Checked = false;
                flatCheckBox187.Checked = false;
                flatCheckBox186.Checked = false;
                flatCheckBox185.Checked = false;
                flatCheckBox184.Checked = false;
                flatCheckBox183.Checked = false;
                flatCheckBox182.Checked = false;
                flatCheckBox181.Checked = false;
                flatCheckBox180.Checked = false;
                Func.ClientMods.Posion(0, false);
                Func.ClientMods.Posion(1, false);
                Func.ClientMods.Posion(2, false);
                Func.ClientMods.Posion(3, false);
                Func.ClientMods.Posion(4, false);
                Func.ClientMods.Posion(5, false);
                Func.ClientMods.Posion(6, false);
                Func.ClientMods.Posion(7, false);
                Func.ClientMods.Posion(8, false);
                Func.ClientMods.Posion(9, false);
                Func.ClientMods.Posion(10, false);
                Func.ClientMods.Posion(11, false);
            }
        }
        #endregion
        #region SkipTimer
        private void flatCheckBox203_CheckedChanged(object sender)
        {
            if (flatCheckBox203.Checked)
            {
                Func.ClientMods.SkipTimer(0, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(0, false);
            }
        }

        private void flatCheckBox202_CheckedChanged(object sender)
        {
            if (flatCheckBox202.Checked)
            {
                Func.ClientMods.SkipTimer(1, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(1, false);
            }
        }

        private void flatCheckBox201_CheckedChanged(object sender)
        {
            if (flatCheckBox201.Checked)
            {
                Func.ClientMods.SkipTimer(2, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(2, false);
            }
        }

        private void flatCheckBox200_CheckedChanged(object sender)
        {
            if (flatCheckBox200.Checked)
            {
                Func.ClientMods.SkipTimer(3, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(3, false);
            }
        }

        private void flatCheckBox199_CheckedChanged(object sender)
        {
            if (flatCheckBox199.Checked)
            {
                Func.ClientMods.SkipTimer(4, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(4, false);
            }
        }

        private void flatCheckBox198_CheckedChanged(object sender)
        {
            if (flatCheckBox198.Checked)
            {
                Func.ClientMods.SkipTimer(5, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(5, false);
            }
        }

        private void flatCheckBox197_CheckedChanged(object sender)
        {
            if (flatCheckBox197.Checked)
            {
                Func.ClientMods.SkipTimer(6, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(6, false);
            }
        }

        private void flatCheckBox196_CheckedChanged(object sender)
        {
            if (flatCheckBox196.Checked)
            {
                Func.ClientMods.SkipTimer(7, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(7, false);
            }
        }

        private void flatCheckBox195_CheckedChanged(object sender)
        {
            if (flatCheckBox195.Checked)
            {
                Func.ClientMods.SkipTimer(8, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(8, false);
            }
        }

        private void flatCheckBox194_CheckedChanged(object sender)
        {
            if (flatCheckBox194.Checked)
            {
                Func.ClientMods.SkipTimer(9, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(9, false);
            }
        }

        private void flatCheckBox193_CheckedChanged(object sender)
        {
            if (flatCheckBox193.Checked)
            {
                Func.ClientMods.SkipTimer(10, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(10, false);
            }
        }

        private void flatCheckBox192_CheckedChanged(object sender)
        {
            if (flatCheckBox192.Checked)
            {
                Func.ClientMods.SkipTimer(11, true);
            }
            else
            {
                Func.ClientMods.SkipTimer(11, false);
            }
        }

        private void flatCheckBox326_CheckedChanged(object sender)
        {
            if (flatCheckBox326.Checked)
            {
                flatCheckBox203.Checked = true;
                flatCheckBox202.Checked = true;
                flatCheckBox201.Checked = true;
                flatCheckBox200.Checked = true;
                flatCheckBox199.Checked = true;
                flatCheckBox198.Checked = true;
                flatCheckBox197.Checked = true;
                flatCheckBox196.Checked = true;
                flatCheckBox195.Checked = true;
                flatCheckBox194.Checked = true;
                flatCheckBox193.Checked = true;
                flatCheckBox192.Checked = true;
                Func.ClientMods.SkipTimer(0, true);
                Func.ClientMods.SkipTimer(1, true);
                Func.ClientMods.SkipTimer(2, true);
                Func.ClientMods.SkipTimer(3, true);
                Func.ClientMods.SkipTimer(4, true);
                Func.ClientMods.SkipTimer(5, true);
                Func.ClientMods.SkipTimer(6, true);
                Func.ClientMods.SkipTimer(7, true);
                Func.ClientMods.SkipTimer(8, true);
                Func.ClientMods.SkipTimer(9, true);
                Func.ClientMods.SkipTimer(10, true);
                Func.ClientMods.SkipTimer(11, true);
            }
            else
            {
                flatCheckBox203.Checked = false;
                flatCheckBox202.Checked = false;
                flatCheckBox201.Checked = false;
                flatCheckBox200.Checked = false;
                flatCheckBox199.Checked = false;
                flatCheckBox198.Checked = false;
                flatCheckBox197.Checked = false;
                flatCheckBox196.Checked = false;
                flatCheckBox195.Checked = false;
                flatCheckBox194.Checked = false;
                flatCheckBox193.Checked = false;
                flatCheckBox192.Checked = false;
                Func.ClientMods.SkipTimer(0, false);
                Func.ClientMods.SkipTimer(1, false);
                Func.ClientMods.SkipTimer(2, false);
                Func.ClientMods.SkipTimer(3, false);
                Func.ClientMods.SkipTimer(4, false);
                Func.ClientMods.SkipTimer(5, false);
                Func.ClientMods.SkipTimer(6, false);
                Func.ClientMods.SkipTimer(7, false);
                Func.ClientMods.SkipTimer(8, false);
                Func.ClientMods.SkipTimer(9, false);
                Func.ClientMods.SkipTimer(10, false);
                Func.ClientMods.SkipTimer(11, false);
            }
        }

        private void skipTimer_Tick(object sender, EventArgs e)
        {
            //if (flatCheckBox203.Checked)
            //{
            //    Func.ClientMods.SkipTimer(0);
            //}
            //if (flatCheckBox202.Checked)
            //{
            //    Func.ClientMods.SkipTimer(1);
            //}
            //if (flatCheckBox201.Checked)
            //{
            //    Func.ClientMods.SkipTimer(2);
            //}
            //if (flatCheckBox200.Checked)
            //{
            //    Func.ClientMods.SkipTimer(3);
            //}
            //if (flatCheckBox199.Checked)
            //{
            //    Func.ClientMods.SkipTimer(4);
            //}
            //if (flatCheckBox198.Checked)
            //{
            //    Func.ClientMods.SkipTimer(5);
            //}
            //if (flatCheckBox197.Checked)
            //{
            //    Func.ClientMods.SkipTimer(6);
            //}
            //if (flatCheckBox196.Checked)
            //{
            //    Func.ClientMods.SkipTimer(7);
            //}
            //if (flatCheckBox195.Checked)
            //{
            //    Func.ClientMods.SkipTimer(8);
            //}
            //if (flatCheckBox194.Checked)
            //{
            //    Func.ClientMods.SkipTimer(9);
            //}
            //if (flatCheckBox193.Checked)
            //{
            //    Func.ClientMods.SkipTimer(10);
            //}
            //if (flatCheckBox192.Checked)
            //{
            //    Func.ClientMods.SkipTimer(11);
            //}
        }
        #endregion
        #region Prone
        private void flatCheckBox215_CheckedChanged(object sender)
        {
            if (flatCheckBox215.Checked)
            {
                Func.ClientMods.Prone(0, true);
            }
            else
            {
                Func.ClientMods.Prone(0, false);
            }
        }

        private void flatCheckBox214_CheckedChanged(object sender)
        {
            if (flatCheckBox214.Checked)
            {
                Func.ClientMods.Prone(1, true);
            }
            else
            {
                Func.ClientMods.Prone(1, false);
            }
        }

        private void flatCheckBox213_CheckedChanged(object sender)
        {
            if (flatCheckBox213.Checked)
            {
                Func.ClientMods.Prone(2, true);
            }
            else
            {
                Func.ClientMods.Prone(2, false);
            }
        }

        private void flatCheckBox212_CheckedChanged(object sender)
        {
            if (flatCheckBox212.Checked)
            {
                Func.ClientMods.Prone(3, true);
            }
            else
            {
                Func.ClientMods.Prone(3, false);
            }
        }

        private void flatCheckBox211_CheckedChanged(object sender)
        {
            if (flatCheckBox211.Checked)
            {
                Func.ClientMods.Prone(4, true);
            }
            else
            {
                Func.ClientMods.Prone(4, false);
            }
        }

        private void flatCheckBox210_CheckedChanged(object sender)
        {
            if (flatCheckBox210.Checked)
            {
                Func.ClientMods.Prone(5, true);
            }
            else
            {
                Func.ClientMods.Prone(5, false);
            }
        }

        private void flatCheckBox209_CheckedChanged(object sender)
        {
            if (flatCheckBox209.Checked)
            {
                Func.ClientMods.Prone(6, true);
            }
            else
            {
                Func.ClientMods.Prone(6, false);
            }
        }

        private void flatCheckBox208_CheckedChanged(object sender)
        {
            if (flatCheckBox208.Checked)
            {
                Func.ClientMods.Prone(7, true);
            }
            else
            {
                Func.ClientMods.Prone(7, false);
            }
        }

        private void flatCheckBox207_CheckedChanged(object sender)
        {
            if (flatCheckBox207.Checked)
            {
                Func.ClientMods.Prone(8, true);
            }
            else
            {
                Func.ClientMods.Prone(8, false);
            }
        }

        private void flatCheckBox206_CheckedChanged(object sender)
        {
            if (flatCheckBox206.Checked)
            {
                Func.ClientMods.Prone(9, true);
            }
            else
            {
                Func.ClientMods.Prone(9, false);
            }
        }

        private void flatCheckBox205_CheckedChanged(object sender)
        {
            if (flatCheckBox205.Checked)
            {
                Func.ClientMods.Prone(10, true);
            }
            else
            {
                Func.ClientMods.Prone(10, false);
            }
        }

        private void flatCheckBox204_CheckedChanged(object sender)
        {
            if (flatCheckBox204.Checked)
            {
                Func.ClientMods.Prone(11, true);
            }
            else
            {
                Func.ClientMods.Prone(11, false);
            }
        }

        private void flatCheckBox325_CheckedChanged(object sender)
        {
            if (flatCheckBox325.Checked)
            {
                flatCheckBox215.Checked = true;
                flatCheckBox214.Checked = true;
                flatCheckBox213.Checked = true;
                flatCheckBox212.Checked = true;
                flatCheckBox211.Checked = true;
                flatCheckBox210.Checked = true;
                flatCheckBox209.Checked = true;
                flatCheckBox208.Checked = true;
                flatCheckBox207.Checked = true;
                flatCheckBox206.Checked = true;
                flatCheckBox205.Checked = true;
                flatCheckBox204.Checked = true;
                Func.ClientMods.Prone(0, true);
                Func.ClientMods.Prone(1, true);
                Func.ClientMods.Prone(2, true);
                Func.ClientMods.Prone(3, true);
                Func.ClientMods.Prone(4, true);
                Func.ClientMods.Prone(5, true);
                Func.ClientMods.Prone(6, true);
                Func.ClientMods.Prone(7, true);
                Func.ClientMods.Prone(8, true);
                Func.ClientMods.Prone(9, true);
                Func.ClientMods.Prone(10, true);
                Func.ClientMods.Prone(11, true);
            }
            else
            {
                flatCheckBox215.Checked = false;
                flatCheckBox214.Checked = false;
                flatCheckBox213.Checked = false;
                flatCheckBox212.Checked = false;
                flatCheckBox211.Checked = false;
                flatCheckBox210.Checked = false;
                flatCheckBox209.Checked = false;
                flatCheckBox208.Checked = false;
                flatCheckBox207.Checked = false;
                flatCheckBox206.Checked = false;
                flatCheckBox205.Checked = false;
                flatCheckBox204.Checked = false;
                Func.ClientMods.Prone(0, false);
                Func.ClientMods.Prone(1, false);
                Func.ClientMods.Prone(2, false);
                Func.ClientMods.Prone(3, false);
                Func.ClientMods.Prone(4, false);
                Func.ClientMods.Prone(5, false);
                Func.ClientMods.Prone(6, false);
                Func.ClientMods.Prone(7, false);
                Func.ClientMods.Prone(8, false);
                Func.ClientMods.Prone(9, false);
                Func.ClientMods.Prone(10, false);
                Func.ClientMods.Prone(11, false);
            }
        }
        #endregion
        #region Freeze
        private void flatCheckBox227_CheckedChanged(object sender)
        {
            if (flatCheckBox227.Checked)
            {
                Func.ClientMods.Freeze(0, true);
            }
            else
            {
                Func.ClientMods.Freeze(0, false);
            }
        }

        private void flatCheckBox226_CheckedChanged(object sender)
        {
            if (flatCheckBox226.Checked)
            {
                Func.ClientMods.Freeze(1, true);
            }
            else
            {
                Func.ClientMods.Freeze(1, false);
            }
        }

        private void flatCheckBox225_CheckedChanged(object sender)
        {
            if (flatCheckBox225.Checked)
            {
                Func.ClientMods.Freeze(2, true);
            }
            else
            {
                Func.ClientMods.Freeze(2, false);
            }
        }

        private void flatCheckBox224_CheckedChanged(object sender)
        {
            if (flatCheckBox224.Checked)
            {
                Func.ClientMods.Freeze(3, true);
            }
            else
            {
                Func.ClientMods.Freeze(3, false);
            }
        }

        private void flatCheckBox223_CheckedChanged(object sender)
        {
            if (flatCheckBox223.Checked)
            {
                Func.ClientMods.Freeze(4, true);
            }
            else
            {
                Func.ClientMods.Freeze(4, false);
            }
        }

        private void flatCheckBox222_CheckedChanged(object sender)
        {
            if (flatCheckBox222.Checked)
            {
                Func.ClientMods.Freeze(5, true);
            }
            else
            {
                Func.ClientMods.Freeze(5, false);
            }
        }

        private void flatCheckBox221_CheckedChanged(object sender)
        {
            if (flatCheckBox221.Checked)
            {
                Func.ClientMods.Freeze(6, true);
            }
            else
            {
                Func.ClientMods.Freeze(6, false);
            }
        }

        private void flatCheckBox220_CheckedChanged(object sender)
        {
            if (flatCheckBox220.Checked)
            {
                Func.ClientMods.Freeze(7, true);
            }
            else
            {
                Func.ClientMods.Freeze(7, false);
            }
        }

        private void flatCheckBox219_CheckedChanged(object sender)
        {
            if (flatCheckBox219.Checked)
            {
                Func.ClientMods.Freeze(8, true);
            }
            else
            {
                Func.ClientMods.Freeze(8, false);
            }
        }

        private void flatCheckBox218_CheckedChanged(object sender)
        {
            if (flatCheckBox218.Checked)
            {
                Func.ClientMods.Freeze(9, true);
            }
            else
            {
                Func.ClientMods.Freeze(9, false);
            }
        }

        private void flatCheckBox217_CheckedChanged(object sender)
        {
            if (flatCheckBox217.Checked)
            {
                Func.ClientMods.Freeze(10, true);
            }
            else
            {
                Func.ClientMods.Freeze(10, false);
            }
        }

        private void flatCheckBox216_CheckedChanged(object sender)
        {
            if (flatCheckBox216.Checked)
            {
                Func.ClientMods.Freeze(11, true);
            }
            else
            {
                Func.ClientMods.Freeze(11, false);
            }
        }

        private void flatCheckBox324_CheckedChanged(object sender)
        {
            if (flatCheckBox324.Checked)
            {
                flatCheckBox227.Checked = true;
                flatCheckBox226.Checked = true;
                flatCheckBox225.Checked = true;
                flatCheckBox224.Checked = true;
                flatCheckBox223.Checked = true;
                flatCheckBox222.Checked = true;
                flatCheckBox221.Checked = true;
                flatCheckBox220.Checked = true;
                flatCheckBox219.Checked = true;
                flatCheckBox218.Checked = true;
                flatCheckBox217.Checked = true;
                flatCheckBox216.Checked = true;
                Func.ClientMods.Freeze(0, true);
                Func.ClientMods.Freeze(1, true);
                Func.ClientMods.Freeze(2, true);
                Func.ClientMods.Freeze(3, true);
                Func.ClientMods.Freeze(4, true);
                Func.ClientMods.Freeze(5, true);
                Func.ClientMods.Freeze(6, true);
                Func.ClientMods.Freeze(7, true);
                Func.ClientMods.Freeze(8, true);
                Func.ClientMods.Freeze(9, true);
                Func.ClientMods.Freeze(10, true);
                Func.ClientMods.Freeze(11, true);
            }
            else
            {
                flatCheckBox227.Checked = false;
                flatCheckBox226.Checked = false;
                flatCheckBox225.Checked = false;
                flatCheckBox224.Checked = false;
                flatCheckBox223.Checked = false;
                flatCheckBox222.Checked = false;
                flatCheckBox221.Checked = false;
                flatCheckBox220.Checked = false;
                flatCheckBox219.Checked = false;
                flatCheckBox218.Checked = false;
                flatCheckBox217.Checked = false;
                flatCheckBox216.Checked = false;
                Func.ClientMods.Freeze(0, false);
                Func.ClientMods.Freeze(1, false);
                Func.ClientMods.Freeze(2, false);
                Func.ClientMods.Freeze(3, false);
                Func.ClientMods.Freeze(4, false);
                Func.ClientMods.Freeze(5, false);
                Func.ClientMods.Freeze(6, false);
                Func.ClientMods.Freeze(7, false);
                Func.ClientMods.Freeze(8, false);
                Func.ClientMods.Freeze(9, false);
                Func.ClientMods.Freeze(10, false);
                Func.ClientMods.Freeze(11, false);
            }
        }
        #endregion
        #region SkateMode
        private void flatCheckBox239_CheckedChanged(object sender)
        {
            if (flatCheckBox239.Checked)
            {
                Func.ClientMods.SkateMode(0, true);
            }
            else
            {
                Func.ClientMods.SkateMode(0, false);
            }
        }

        private void flatCheckBox238_CheckedChanged(object sender)
        {
            if (flatCheckBox238.Checked)
            {
                Func.ClientMods.SkateMode(1, true);
            }
            else
            {
                Func.ClientMods.SkateMode(1, false);
            }
        }

        private void flatCheckBox237_CheckedChanged(object sender)
        {
            if (flatCheckBox237.Checked)
            {
                Func.ClientMods.SkateMode(2, true);
            }
            else
            {
                Func.ClientMods.SkateMode(2, false);
            }
        }

        private void flatCheckBox236_CheckedChanged(object sender)
        {
            if (flatCheckBox236.Checked)
            {
                Func.ClientMods.SkateMode(3, true);
            }
            else
            {
                Func.ClientMods.SkateMode(3, false);
            }
        }

        private void flatCheckBox235_CheckedChanged(object sender)
        {
            if (flatCheckBox235.Checked)
            {
                Func.ClientMods.SkateMode(4, true);
            }
            else
            {
                Func.ClientMods.SkateMode(4, false);
            }
        }

        private void flatCheckBox234_CheckedChanged(object sender)
        {
            if (flatCheckBox234.Checked)
            {
                Func.ClientMods.SkateMode(5, true);
            }
            else
            {
                Func.ClientMods.SkateMode(5, false);
            }
        }

        private void flatCheckBox233_CheckedChanged(object sender)
        {
            if (flatCheckBox233.Checked)
            {
                Func.ClientMods.SkateMode(6, true);
            }
            else
            {
                Func.ClientMods.SkateMode(6, false);
            }
        }

        private void flatCheckBox232_CheckedChanged(object sender)
        {
            if (flatCheckBox232.Checked)
            {
                Func.ClientMods.SkateMode(7, true);
            }
            else
            {
                Func.ClientMods.SkateMode(7, false);
            }
        }

        private void flatCheckBox231_CheckedChanged(object sender)
        {
            if (flatCheckBox231.Checked)
            {
                Func.ClientMods.SkateMode(8, true);
            }
            else
            {
                Func.ClientMods.SkateMode(8, false);
            }
        }

        private void flatCheckBox230_CheckedChanged(object sender)
        {
            if (flatCheckBox230.Checked)
            {
                Func.ClientMods.SkateMode(9, true);
            }
            else
            {
                Func.ClientMods.SkateMode(9, false);
            }
        }

        private void flatCheckBox229_CheckedChanged(object sender)
        {
            if (flatCheckBox229.Checked)
            {
                Func.ClientMods.SkateMode(10, true);
            }
            else
            {
                Func.ClientMods.SkateMode(10, false);
            }
        }

        private void flatCheckBox228_CheckedChanged(object sender)
        {
            if (flatCheckBox228.Checked)
            {
                Func.ClientMods.SkateMode(11, true);
            }
            else
            {
                Func.ClientMods.SkateMode(11, false);
            }
        }

        private void flatCheckBox343_CheckedChanged(object sender)
        {
            if (flatCheckBox343.Checked)
            {
                flatCheckBox239.Checked = true;
                flatCheckBox238.Checked = true;
                flatCheckBox237.Checked = true;
                flatCheckBox236.Checked = true;
                flatCheckBox235.Checked = true;
                flatCheckBox234.Checked = true;
                flatCheckBox233.Checked = true;
                flatCheckBox232.Checked = true;
                flatCheckBox231.Checked = true;
                flatCheckBox230.Checked = true;
                flatCheckBox229.Checked = true;
                flatCheckBox228.Checked = true;
                Func.ClientMods.SkateMode(0, true);
                Func.ClientMods.SkateMode(1, true);
                Func.ClientMods.SkateMode(2, true);
                Func.ClientMods.SkateMode(3, true);
                Func.ClientMods.SkateMode(4, true);
                Func.ClientMods.SkateMode(5, true);
                Func.ClientMods.SkateMode(6, true);
                Func.ClientMods.SkateMode(7, true);
                Func.ClientMods.SkateMode(8, true);
                Func.ClientMods.SkateMode(9, true);
                Func.ClientMods.SkateMode(10, true);
                Func.ClientMods.SkateMode(11, true);

            }
            else
            {
                flatCheckBox239.Checked = false;
                flatCheckBox238.Checked = false;
                flatCheckBox237.Checked = false;
                flatCheckBox236.Checked = false;
                flatCheckBox235.Checked = false;
                flatCheckBox234.Checked = false;
                flatCheckBox233.Checked = false;
                flatCheckBox232.Checked = false;
                flatCheckBox231.Checked = false;
                flatCheckBox230.Checked = false;
                flatCheckBox229.Checked = false;
                flatCheckBox228.Checked = false;
                Func.ClientMods.SkateMode(0, false);
                Func.ClientMods.SkateMode(1, false);
                Func.ClientMods.SkateMode(2, false);
                Func.ClientMods.SkateMode(3, false);
                Func.ClientMods.SkateMode(4, false);
                Func.ClientMods.SkateMode(5, false);
                Func.ClientMods.SkateMode(6, false);
                Func.ClientMods.SkateMode(7, false);
                Func.ClientMods.SkateMode(8, false);
                Func.ClientMods.SkateMode(9, false);
                Func.ClientMods.SkateMode(10, false);
                Func.ClientMods.SkateMode(11, false);
            }
        }

        private void skateMode_Tick(object sender, EventArgs e)
        {
            //if (flatCheckBox239.Checked)
            //{
            //    Func.ClientMods.SkateMode(0, true);
            //}
            //if (flatCheckBox238.Checked)
            //{
            //    Func.ClientMods.SkateMode(1, true);
            //}
            //if (flatCheckBox237.Checked)
            //{
            //    Func.ClientMods.SkateMode(2, true);
            //}
            //if (flatCheckBox236.Checked)
            //{
            //    Func.ClientMods.SkateMode(3, true);
            //}
            //if (flatCheckBox235.Checked)
            //{
            //    Func.ClientMods.SkateMode(4, true);
            //}
            //if (flatCheckBox234.Checked)
            //{
            //    Func.ClientMods.SkateMode(5, true);
            //}
            //if (flatCheckBox233.Checked)
            //{
            //    Func.ClientMods.SkateMode(6, true);
            //}
            //if (flatCheckBox232.Checked)
            //{
            //    Func.ClientMods.SkateMode(7, true);
            //}
            //if (flatCheckBox231.Checked)
            //{
            //    Func.ClientMods.SkateMode(8, true);
            //}
            //if (flatCheckBox230.Checked)
            //{
            //    Func.ClientMods.SkateMode(9, true);
            //}
            //if (flatCheckBox229.Checked)
            //{
            //    Func.ClientMods.SkateMode(10, true);
            //}
            //if (flatCheckBox228.Checked)
            //{
            //    Func.ClientMods.SkateMode(11, true);
            //}
        }
        #endregion
        #region Give Lag
        private void flatCheckBox251_CheckedChanged(object sender)
        {
            if (flatCheckBox251.Checked)
            {
                Func.ClientMods.Lag(0, true);
            }
            else
            {
                Func.ClientMods.Lag(0, false);
            }
        }

        private void flatCheckBox250_CheckedChanged(object sender)
        {
            if (flatCheckBox250.Checked)
            {
                Func.ClientMods.Lag(1, true);
            }
            else
            {
                Func.ClientMods.Lag(1, false);
            }
        }

        private void flatCheckBox249_CheckedChanged(object sender)
        {
            if (flatCheckBox249.Checked)
            {
                Func.ClientMods.Lag(2, true);
            }
            else
            {
                Func.ClientMods.Lag(2, false);
            }
        }

        private void flatCheckBox248_CheckedChanged(object sender)
        {
            if (flatCheckBox248.Checked)
            {
                Func.ClientMods.Lag(3, true);
            }
            else
            {
                Func.ClientMods.Lag(3, false);
            }
        }

        private void flatCheckBox247_CheckedChanged(object sender)
        {
            if (flatCheckBox247.Checked)
            {
                Func.ClientMods.Lag(4, true);
            }
            else
            {
                Func.ClientMods.Lag(4, false);
            }
        }

        private void flatCheckBox246_CheckedChanged(object sender)
        {
            if (flatCheckBox246.Checked)
            {
                Func.ClientMods.Lag(5, true);
            }
            else
            {
                Func.ClientMods.Lag(5, false);
            }
        }

        private void flatCheckBox245_CheckedChanged(object sender)
        {
            if (flatCheckBox245.Checked)
            {
                Func.ClientMods.Lag(6, true);
            }
            else
            {
                Func.ClientMods.Lag(6, false);
            }
        }

        private void flatCheckBox244_CheckedChanged(object sender)
        {
            if (flatCheckBox244.Checked)
            {
                Func.ClientMods.Lag(7, true);
            }
            else
            {
                Func.ClientMods.Lag(7, false);
            }
        }

        private void flatCheckBox243_CheckedChanged(object sender)
        {
            if (flatCheckBox243.Checked)
            {
                Func.ClientMods.Lag(8, true);
            }
            else
            {
                Func.ClientMods.Lag(8, false);
            }
        }

        private void flatCheckBox242_CheckedChanged(object sender)
        {
            if (flatCheckBox242.Checked)
            {
                Func.ClientMods.Lag(9, true);
            }
            else
            {
                Func.ClientMods.Lag(9, false);
            }
        }

        private void flatCheckBox241_CheckedChanged(object sender)
        {
            if (flatCheckBox241.Checked)
            {
                Func.ClientMods.Lag(10, true);
            }
            else
            {
                Func.ClientMods.Lag(10, false);
            }
        }

        private void flatCheckBox240_CheckedChanged(object sender)
        {
            if (flatCheckBox240.Checked)
            {
                Func.ClientMods.Lag(11, true);
            }
            else
            {
                Func.ClientMods.Lag(11, false);
            }
        }

        private void flatCheckBox342_CheckedChanged(object sender)
        {
            if (flatCheckBox342.Checked)
            {
                flatCheckBox251.Checked = true;
                flatCheckBox250.Checked = true;
                flatCheckBox249.Checked = true;
                flatCheckBox248.Checked = true;
                flatCheckBox247.Checked = true;
                flatCheckBox246.Checked = true;
                flatCheckBox245.Checked = true;
                flatCheckBox244.Checked = true;
                flatCheckBox243.Checked = true;
                flatCheckBox242.Checked = true;
                flatCheckBox241.Checked = true;
                flatCheckBox240.Checked = true;
            }
            else
            {
                flatCheckBox251.Checked = false;
                flatCheckBox250.Checked = false;
                flatCheckBox249.Checked = false;
                flatCheckBox248.Checked = false;
                flatCheckBox247.Checked = false;
                flatCheckBox246.Checked = false;
                flatCheckBox245.Checked = false;
                flatCheckBox244.Checked = false;
                flatCheckBox243.Checked = false;
                flatCheckBox242.Checked = false;
                flatCheckBox241.Checked = false;
                flatCheckBox240.Checked = false;
            }
        }
        #endregion
        #region WeaponFuckedUp
        private void flatCheckBox263_CheckedChanged(object sender)
        {
            if (flatCheckBox263.Checked)
            {
                Func.ClientMods.WeaponFuckedup(0, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(0, false);
            }
        }

        private void flatCheckBox262_CheckedChanged(object sender)
        {
            if (flatCheckBox262.Checked)
            {
                Func.ClientMods.WeaponFuckedup(1, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(1, false);
            }
        }

        private void flatCheckBox261_CheckedChanged(object sender)
        {
            if (flatCheckBox261.Checked)
            {
                Func.ClientMods.WeaponFuckedup(2, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(2, false);
            }
        }

        private void flatCheckBox260_CheckedChanged(object sender)
        {
            if (flatCheckBox260.Checked)
            {
                Func.ClientMods.WeaponFuckedup(3, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(3, false);
            }
        }

        private void flatCheckBox259_CheckedChanged(object sender)
        {
            if (flatCheckBox259.Checked)
            {
                Func.ClientMods.WeaponFuckedup(4, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(4, false);
            }
        }

        private void flatCheckBox258_CheckedChanged(object sender)
        {
            if (flatCheckBox258.Checked)
            {
                Func.ClientMods.WeaponFuckedup(5, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(5, false);
            }
        }

        private void flatCheckBox257_CheckedChanged(object sender)
        {
            if (flatCheckBox257.Checked)
            {
                Func.ClientMods.WeaponFuckedup(6, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(6, false);
            }
        }

        private void flatCheckBox256_CheckedChanged(object sender)
        {
            if (flatCheckBox256.Checked)
            {
                Func.ClientMods.WeaponFuckedup(7, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(7, false);
            }
        }

        private void flatCheckBox255_CheckedChanged(object sender)
        {
            if (flatCheckBox255.Checked)
            {
                Func.ClientMods.WeaponFuckedup(8, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(8, false);
            }
        }

        private void flatCheckBox254_CheckedChanged(object sender)
        {
            if (flatCheckBox254.Checked)
            {
                Func.ClientMods.WeaponFuckedup(9, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(9, false);
            }
        }

        private void flatCheckBox253_CheckedChanged(object sender)
        {
            if (flatCheckBox253.Checked)
            {
                Func.ClientMods.WeaponFuckedup(10, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(10, false);
            }
        }

        private void flatCheckBox252_CheckedChanged(object sender)
        {
            if (flatCheckBox252.Checked)
            {
                Func.ClientMods.WeaponFuckedup(11, true);
            }
            else
            {
                Func.ClientMods.WeaponFuckedup(11, false);
            }
        }

        private void flatCheckBox341_CheckedChanged(object sender)
        {
            if (flatCheckBox341.Checked)
            {
                flatCheckBox263.Checked = true;
                flatCheckBox262.Checked = true;
                flatCheckBox261.Checked = true;
                flatCheckBox260.Checked = true;
                flatCheckBox259.Checked = true;
                flatCheckBox258.Checked = true;
                flatCheckBox257.Checked = true;
                flatCheckBox256.Checked = true;
                flatCheckBox255.Checked = true;
                flatCheckBox254.Checked = true;
                flatCheckBox253.Checked = true;
                flatCheckBox252.Checked = true;
                Func.ClientMods.WeaponFuckedup(0, true);
                Func.ClientMods.WeaponFuckedup(1, true);
                Func.ClientMods.WeaponFuckedup(2, true);
                Func.ClientMods.WeaponFuckedup(3, true);
                Func.ClientMods.WeaponFuckedup(4, true);
                Func.ClientMods.WeaponFuckedup(5, true);
                Func.ClientMods.WeaponFuckedup(6, true);
                Func.ClientMods.WeaponFuckedup(7, true);
                Func.ClientMods.WeaponFuckedup(8, true);
                Func.ClientMods.WeaponFuckedup(9, true);
                Func.ClientMods.WeaponFuckedup(10, true);
                Func.ClientMods.WeaponFuckedup(11, true);
            }
            else
            {
                flatCheckBox263.Checked = false;
                flatCheckBox262.Checked = false;
                flatCheckBox261.Checked = false;
                flatCheckBox260.Checked = false;
                flatCheckBox259.Checked = false;
                flatCheckBox258.Checked = false;
                flatCheckBox257.Checked = false;
                flatCheckBox256.Checked = false;
                flatCheckBox255.Checked = false;
                flatCheckBox254.Checked = false;
                flatCheckBox253.Checked = false;
                flatCheckBox252.Checked = false;
                Func.ClientMods.WeaponFuckedup(0, false);
                Func.ClientMods.WeaponFuckedup(1, false);
                Func.ClientMods.WeaponFuckedup(2, false);
                Func.ClientMods.WeaponFuckedup(3, false);
                Func.ClientMods.WeaponFuckedup(4, false);
                Func.ClientMods.WeaponFuckedup(5, false);
                Func.ClientMods.WeaponFuckedup(6, false);
                Func.ClientMods.WeaponFuckedup(7, false);
                Func.ClientMods.WeaponFuckedup(8, false);
                Func.ClientMods.WeaponFuckedup(9, false);
                Func.ClientMods.WeaponFuckedup(10, false);
                Func.ClientMods.WeaponFuckedup(11, false);
            }
        }
        #endregion
        #region Jumper
        private void flatCheckBox275_CheckedChanged(object sender)
        {
            if (flatCheckBox275.Checked)
            {
                Func.ClientMods.Jumper(0, true);
            }
            else
            {
                Func.ClientMods.Jumper(0, false);
            }
        }

        private void flatCheckBox274_CheckedChanged(object sender)
        {
            if (flatCheckBox274.Checked)
            {
                Func.ClientMods.Jumper(1, true);
            }
            else
            {
                Func.ClientMods.Jumper(1, false);
            }
        }

        private void flatCheckBox273_CheckedChanged(object sender)
        {
            if (flatCheckBox273.Checked)
            {
                Func.ClientMods.Jumper(2, true);
            }
            else
            {
                Func.ClientMods.Jumper(2, false);
            }
        }

        private void flatCheckBox272_CheckedChanged(object sender)
        {
            if (flatCheckBox272.Checked)
            {
                Func.ClientMods.Jumper(3, true);
            }
            else
            {
                Func.ClientMods.Jumper(3, false);
            }
        }

        private void flatCheckBox271_CheckedChanged(object sender)
        {
            if (flatCheckBox271.Checked)
            {
                Func.ClientMods.Jumper(4, true);
            }
            else
            {
                Func.ClientMods.Jumper(4, false);
            }
        }

        private void flatCheckBox270_CheckedChanged(object sender)
        {
            if (flatCheckBox270.Checked)
            {
                Func.ClientMods.Jumper(5, true);
            }
            else
            {
                Func.ClientMods.Jumper(5, false);
            }
        }

        private void flatCheckBox269_CheckedChanged(object sender)
        {
            if (flatCheckBox269.Checked)
            {
                Func.ClientMods.Jumper(6, true);
            }
            else
            {
                Func.ClientMods.Jumper(6, false);
            }
        }

        private void flatCheckBox268_CheckedChanged(object sender)
        {
            if (flatCheckBox268.Checked)
            {
                Func.ClientMods.Jumper(7, true);
            }
            else
            {
                Func.ClientMods.Jumper(7, false);
            }
        }

        private void flatCheckBox267_CheckedChanged(object sender)
        {
            if (flatCheckBox267.Checked)
            {
                Func.ClientMods.Jumper(8, true);
            }
            else
            {
                Func.ClientMods.Jumper(8, false);
            }
        }

        private void flatCheckBox266_CheckedChanged(object sender)
        {
            if (flatCheckBox266.Checked)
            {
                Func.ClientMods.Jumper(9, true);
            }
            else
            {
                Func.ClientMods.Jumper(9, false);
            }
        }

        private void flatCheckBox265_CheckedChanged(object sender)
        {
            if (flatCheckBox265.Checked)
            {
                Func.ClientMods.Jumper(10, true);
            }
            else
            {
                Func.ClientMods.Jumper(10, false);
            }
        }

        private void flatCheckBox264_CheckedChanged(object sender)
        {
            if (flatCheckBox264.Checked)
            {
                Func.ClientMods.Jumper(11, true);
            }
            else
            {
                Func.ClientMods.Jumper(11, false);
            }
        }

        private void flatCheckBox340_CheckedChanged(object sender)
        {
            if (flatCheckBox340.Checked)
            {
                flatCheckBox275.Checked = true;
                flatCheckBox274.Checked = true;
                flatCheckBox273.Checked = true;
                flatCheckBox272.Checked = true;
                flatCheckBox271.Checked = true;
                flatCheckBox270.Checked = true;
                flatCheckBox269.Checked = true;
                flatCheckBox268.Checked = true;
                flatCheckBox267.Checked = true;
                flatCheckBox266.Checked = true;
                flatCheckBox265.Checked = true;
                flatCheckBox264.Checked = true;
                Func.ClientMods.Jumper(0, true);
                Func.ClientMods.Jumper(1, true);
                Func.ClientMods.Jumper(2, true);
                Func.ClientMods.Jumper(3, true);
                Func.ClientMods.Jumper(4, true);
                Func.ClientMods.Jumper(5, true);
                Func.ClientMods.Jumper(6, true);
                Func.ClientMods.Jumper(7, true);
                Func.ClientMods.Jumper(8, true);
                Func.ClientMods.Jumper(9, true);
                Func.ClientMods.Jumper(10, true);
                Func.ClientMods.Jumper(11, true);
            }
            else
            {
                flatCheckBox275.Checked = false;
                flatCheckBox274.Checked = false;
                flatCheckBox273.Checked = false;
                flatCheckBox272.Checked = false;
                flatCheckBox271.Checked = false;
                flatCheckBox270.Checked = false;
                flatCheckBox269.Checked = false;
                flatCheckBox268.Checked = false;
                flatCheckBox267.Checked = false;
                flatCheckBox266.Checked = false;
                flatCheckBox265.Checked = false;
                flatCheckBox264.Checked = false;
                Func.ClientMods.Jumper(0, false);
                Func.ClientMods.Jumper(1, false);
                Func.ClientMods.Jumper(2, false);
                Func.ClientMods.Jumper(3, false);
                Func.ClientMods.Jumper(4, false);
                Func.ClientMods.Jumper(5, false);
                Func.ClientMods.Jumper(6, false);
                Func.ClientMods.Jumper(7, false);
                Func.ClientMods.Jumper(8, false);
                Func.ClientMods.Jumper(9, false);
                Func.ClientMods.Jumper(10, false);
                Func.ClientMods.Jumper(11, false);
            }
        }
        #endregion
        #region AntiQuit
        private void flatCheckBox287_CheckedChanged(object sender)
        {
            if (flatCheckBox287.Checked)
            {
                Func.ClientMods.AntiQuitTh(0, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(0, false);
            }
        }

        private void flatCheckBox286_CheckedChanged(object sender)
        {
            if (flatCheckBox286.Checked)
            {
                Func.ClientMods.AntiQuitTh(1, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(1, false);
            }
        }

        private void flatCheckBox285_CheckedChanged(object sender)
        {
            if (flatCheckBox285.Checked)
            {
                Func.ClientMods.AntiQuitTh(2, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(2, false);
            }
        }

        private void flatCheckBox284_CheckedChanged(object sender)
        {
            if (flatCheckBox284.Checked)
            {
                Func.ClientMods.AntiQuitTh(3, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(3, false);
            }
        }

        private void flatCheckBox283_CheckedChanged(object sender)
        {
            if (flatCheckBox283.Checked)
            {
                Func.ClientMods.AntiQuitTh(4, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(4, false);
            }
        }

        private void flatCheckBox282_CheckedChanged(object sender)
        {
            if (flatCheckBox282.Checked)
            {
                Func.ClientMods.AntiQuitTh(5, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(5, false);
            }
        }

        private void flatCheckBox281_CheckedChanged(object sender)
        {
            if (flatCheckBox281.Checked)
            {
                Func.ClientMods.AntiQuitTh(6, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(6, false);
            }
        }

        private void flatCheckBox280_CheckedChanged(object sender)
        {
            if (flatCheckBox280.Checked)
            {
                Func.ClientMods.AntiQuitTh(7, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(7, false);
            }
        }

        private void flatCheckBox279_CheckedChanged(object sender)
        {
            if (flatCheckBox279.Checked)
            {
                Func.ClientMods.AntiQuitTh(8, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(8, false);
            }
        }

        private void flatCheckBox278_CheckedChanged(object sender)
        {
            if (flatCheckBox278.Checked)
            {
                Func.ClientMods.AntiQuitTh(9, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(9, false);
            }
        }

        private void flatCheckBox277_CheckedChanged(object sender)
        {
            if (flatCheckBox277.Checked)
            {
                Func.ClientMods.AntiQuitTh(10, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(10, false);
            }
        }

        private void flatCheckBox276_CheckedChanged(object sender)
        {
            if (flatCheckBox276.Checked)
            {
                Func.ClientMods.AntiQuitTh(11, true);
            }
            else
            {
                Func.ClientMods.AntiQuitTh(11, false);
            }
        }
        #endregion
        #region PlayerDie
        private void flatButton11_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 0);
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 1);
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 2);
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 3);
        }

        private void flatButton15_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 4);
        }

        private void flatButton16_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 5);
        }

        private void flatButton17_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 6);
        }

        private void flatButton18_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 7);
        }

        private void flatButton19_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 8);
        }

        private void flatButton20_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 9);
        }

        private void flatButton21_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 10);
        }

        private void flatButton22_Click(object sender, EventArgs e)
        {
            RPC.Player_Die((int)killerNum.Value, 11);
        }
        #endregion
        #region Kill Player
        private void flatButton34_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(0);
        }

        private void flatButton33_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(1);
        }

        private void flatButton32_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(2);
        }

        private void flatButton31_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(3);
        }

        private void flatButton30_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(4);
        }

        private void flatButton29_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(5);
        }

        private void flatButton28_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(6);
        }

        private void flatButton27_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(7);
        }

        private void flatButton26_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(8);
        }

        private void flatButton25_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(9);
        }

        private void flatButton24_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(10);
        }

        private void flatButton23_Click(object sender, EventArgs e)
        {
            Func.ClientMods.KillPlayer(11);
        }
        #endregion
        #region Kick Sv
        private void flatButton46_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox38.Text))
            {
                RPC.KickClient(0);
            }
            else
            {
                RPC.iPrintln(0, "^1Trying To Kick You");
            }
        }

        private void flatButton45_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox37.Text))
            {
                RPC.KickClient(1);
            }
            else
            {
                RPC.iPrintln(1, "^1Trying To Kick You");
            }
        }

        private void flatButton44_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox36.Text))
            {
                RPC.KickClient(2);
            }
            else
            {
                RPC.iPrintln(2, "^1Trying To Kick You");
            }
        }

        private void flatButton43_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox35.Text))
            {
                RPC.KickClient(3);
            }
            else
            {
                RPC.iPrintln(3, "^1Trying To Kick You");
            }
        }

        private void flatButton42_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox34.Text))
            {
                RPC.KickClient(4);
            }
            else
            {
                RPC.iPrintln(4, "^1Trying To Kick You");
            }
        }

        private void flatButton41_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox33.Text))
            {
                RPC.KickClient(5);
            }
            else
            {
                RPC.iPrintln(5, "^1Trying To Kick You");
            }
        }

        private void flatButton40_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox32.Text))
            {
                RPC.KickClient(6);
            }
            else
            {
                RPC.iPrintln(6, "^1Trying To Kick You");
            }
        }

        private void flatButton39_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox31.Text))
            {
                RPC.KickClient(7);
            }
            else
            {
                RPC.iPrintln(7, "^1Trying To Kick You");
            }
        }

        private void flatButton38_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox30.Text))
            {
                RPC.KickClient(8);
            }
            else
            {
                RPC.iPrintln(8, "^1Trying To Kick You");
            }
        }

        private void flatButton37_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox29.Text))
            {
                RPC.KickClient(9);
            }
            else
            {
                RPC.iPrintln(9, "^1Trying To Kick You");
            }
        }

        private void flatButton36_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox28.Text))
            {
                RPC.KickClient(10);
            }
            else
            {
                RPC.iPrintln(10, "^1Trying To Kick You");
            }
        }

        private void flatButton35_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox27.Text))
            {
                RPC.KickClient(11);
            }
            else
            {
                RPC.iPrintln(11, "^1Trying To Kick You");
            }
        }
        #endregion
        #region _Freze Console
        private void flatButton58_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox38.Text)) //  != Mine[0] && textBox38.Text != Mine[1] && textBox38.Text != ""
            {
                Func.ClientMods.FreezeConsole(0);
            }
            else
            {
                RPC.iPrintln(0, "^1Trying To Freeze You");
            }
        }

        private void flatButton57_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox37.Text))
            {
                Func.ClientMods.FreezeConsole(1);
            }
            else
            {
                RPC.iPrintln(1, "^1Trying To Freeze You");
            }
        }

        private void flatButton56_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox36.Text))
            {
                Func.ClientMods.FreezeConsole(2);
            }
            else
            {
                RPC.iPrintln(2, "^1Trying To Freeze You");
            }
        }

        private void flatButton55_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox35.Text))
            {
                Func.ClientMods.FreezeConsole(3);
            }
            else
            {
                RPC.iPrintln(3, "^1Trying To Freeze You");
            }
        }

        private void flatButton54_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox34.Text))
            {
                Func.ClientMods.FreezeConsole(4);
            }
            else
            {
                RPC.iPrintln(4, "^1Trying To Freeze You");
            }
        }

        private void flatButton53_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox33.Text))
            {
                Func.ClientMods.FreezeConsole(5);
            }
            else
            {
                RPC.iPrintln(5, "^1Trying To Freeze You");
            }
        }

        private void flatButton52_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox32.Text))
            {
                Func.ClientMods.FreezeConsole(6);
            }
            else
            {
                RPC.iPrintln(6, "^1Trying To Freeze You");
            }
        }

        private void flatButton51_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox31.Text))
            {
                Func.ClientMods.FreezeConsole(7);
            }
            else
            {
                RPC.iPrintln(7, "^1Trying To Freeze You");
            }
        }

        private void flatButton50_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox30.Text))
            {
                Func.ClientMods.FreezeConsole(8);
            }
            else
            {
                RPC.iPrintln(8, "^1Trying To Freeze You");
            }
        }

        private void flatButton49_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox29.Text))
            {
                Func.ClientMods.FreezeConsole(9);
            }
            else
            {
                RPC.iPrintln(9, "^1Trying To Freeze You");
            }
        }

        private void flatButton48_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox28.Text))
            {
                Func.ClientMods.FreezeConsole(10);
            }
            else
            {
                RPC.iPrintln(10, "^1Trying To Freeze You");
            }
        }

        private void flatButton47_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox27.Text))
            {
                Func.ClientMods.FreezeConsole(11);
            }
            else
            {
                RPC.iPrintln(11, "^1Trying To Freeze You");
            }
        }
        #endregion
        #region BlureClient
        private void flatCheckBox299_CheckedChanged(object sender)
        {
            if (flatCheckBox299.Checked)
            {
                RPC.BlurClient(0, true);
            }
            else
            {
                RPC.BlurClient(0, false);
            }
        }

        private void flatCheckBox298_CheckedChanged(object sender)
        {
            if (flatCheckBox298.Checked)
            {
                RPC.BlurClient(1, true);
            }
            else
            {
                RPC.BlurClient(1, false);
            }
        }

        private void flatCheckBox297_CheckedChanged(object sender)
        {
            if (flatCheckBox297.Checked)
            {
                RPC.BlurClient(2, true);
            }
            else
            {
                RPC.BlurClient(2, false);
            }
        }

        private void flatCheckBox296_CheckedChanged(object sender)
        {
            if (flatCheckBox296.Checked)
            {
                RPC.BlurClient(3, true);
            }
            else
            {
                RPC.BlurClient(3, false);
            }
        }

        private void flatCheckBox295_CheckedChanged(object sender)
        {
            if (flatCheckBox295.Checked)
            {
                RPC.BlurClient(4, true);
            }
            else
            {
                RPC.BlurClient(4, false);
            }
        }

        private void flatCheckBox294_CheckedChanged(object sender)
        {
            if (flatCheckBox294.Checked)
            {
                RPC.BlurClient(5, true);
            }
            else
            {
                RPC.BlurClient(5, false);
            }
        }

        private void flatCheckBox293_CheckedChanged(object sender)
        {
            if (flatCheckBox293.Checked)
            {
                RPC.BlurClient(6, true);
            }
            else
            {
                RPC.BlurClient(6, false);
            }
        }

        private void flatCheckBox292_CheckedChanged(object sender)
        {
            if (flatCheckBox292.Checked)
            {
                RPC.BlurClient(7, true);
            }
            else
            {
                RPC.BlurClient(7, false);
            }
        }

        private void flatCheckBox291_CheckedChanged(object sender)
        {
            if (flatCheckBox291.Checked)
            {
                RPC.BlurClient(8, true);
            }
            else
            {
                RPC.BlurClient(8, false);
            }
        }

        private void flatCheckBox290_CheckedChanged(object sender)
        {
            if (flatCheckBox290.Checked)
            {
                RPC.BlurClient(9, true);
            }
            else
            {
                RPC.BlurClient(9, false);
            }
        }

        private void flatCheckBox289_CheckedChanged(object sender)
        {
            if (flatCheckBox289.Checked)
            {
                RPC.BlurClient(10, true);
            }
            else
            {
                RPC.BlurClient(10, false);
            }
        }

        private void flatCheckBox288_CheckedChanged(object sender)
        {
            if (flatCheckBox288.Checked)
            {
                RPC.BlurClient(11, true);
            }
            else
            {
                RPC.BlurClient(11, false);
            }
        }

        private void flatCheckBox346_CheckedChanged(object sender)
        {
            if (flatCheckBox346.Checked)
            {
                RPC.BlurClient(-1, true);
                flatCheckBox299.Checked = true;
                flatCheckBox298.Checked = true;
                flatCheckBox297.Checked = true;
                flatCheckBox296.Checked = true;
                flatCheckBox295.Checked = true;
                flatCheckBox294.Checked = true;
                flatCheckBox293.Checked = true;
                flatCheckBox292.Checked = true;
                flatCheckBox291.Checked = true;
                flatCheckBox290.Checked = true;
                flatCheckBox289.Checked = true;
                flatCheckBox288.Checked = true;
            }
            else
            {
                RPC.BlurClient(-1, false);
                flatCheckBox299.Checked = false;
                flatCheckBox298.Checked = false;
                flatCheckBox297.Checked = false;
                flatCheckBox296.Checked = false;
                flatCheckBox295.Checked = false;
                flatCheckBox294.Checked = false;
                flatCheckBox293.Checked = false;
                flatCheckBox292.Checked = false;
                flatCheckBox291.Checked = false;
                flatCheckBox290.Checked = false;
                flatCheckBox289.Checked = false;
                flatCheckBox288.Checked = false;
            }
        }
        #endregion
        #region Remove ScoreStreak
        private void flatCheckBox323_CheckedChanged(object sender)
        {
            if (flatCheckBox323.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(0, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(0, false);
            }
        }

        private void flatCheckBox322_CheckedChanged(object sender)
        {
            if (flatCheckBox322.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(1, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(1, false);
            }
        }

        private void flatCheckBox321_CheckedChanged(object sender)
        {
            if (flatCheckBox321.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(2, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(2, false);
            }
        }

        private void flatCheckBox320_CheckedChanged(object sender)
        {
            if (flatCheckBox320.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(3, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(3, false);
            }
        }

        private void flatCheckBox319_CheckedChanged(object sender)
        {
            if (flatCheckBox319.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(4, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(4, false);
            }
        }

        private void flatCheckBox318_CheckedChanged(object sender)
        {
            if (flatCheckBox318.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(5, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(5, false);
            }
        }

        private void flatCheckBox317_CheckedChanged(object sender)
        {
            if (flatCheckBox317.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(6, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(6, false);
            }
        }

        private void flatCheckBox316_CheckedChanged(object sender)
        {
            if (flatCheckBox316.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(7, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(7, false);
            }
        }

        private void flatCheckBox315_CheckedChanged(object sender)
        {
            if (flatCheckBox315.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(8, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(8, false);
            }
        }

        private void flatCheckBox314_CheckedChanged(object sender)
        {
            if (flatCheckBox314.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(9, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(9, false);
            }
        }

        private void flatCheckBox313_CheckedChanged(object sender)
        {
            if (flatCheckBox313.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(10, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(10, false);
            }
        }

        private void flatCheckBox312_CheckedChanged(object sender)
        {
            if (flatCheckBox312.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(11, true);
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(11, false);
            }
        }

        private void flatCheckBox344_CheckedChanged(object sender)
        {
            if (flatCheckBox344.Checked)
            {
                Func.ClientMods.RemoveScoreStreak(0, true);
                Func.ClientMods.RemoveScoreStreak(1, true);
                Func.ClientMods.RemoveScoreStreak(2, true);
                Func.ClientMods.RemoveScoreStreak(3, true);
                Func.ClientMods.RemoveScoreStreak(4, true);
                Func.ClientMods.RemoveScoreStreak(5, true);
                Func.ClientMods.RemoveScoreStreak(6, true);
                Func.ClientMods.RemoveScoreStreak(7, true);
                Func.ClientMods.RemoveScoreStreak(8, true);
                Func.ClientMods.RemoveScoreStreak(9, true);
                Func.ClientMods.RemoveScoreStreak(10, true);
                Func.ClientMods.RemoveScoreStreak(11, true);
                flatCheckBox223.Checked = true;
                flatCheckBox222.Checked = true;
                flatCheckBox221.Checked = true;
                flatCheckBox220.Checked = true;
                flatCheckBox219.Checked = true;
                flatCheckBox218.Checked = true;
                flatCheckBox217.Checked = true;
                flatCheckBox216.Checked = true;
                flatCheckBox215.Checked = true;
                flatCheckBox214.Checked = true;
                flatCheckBox213.Checked = true;
                flatCheckBox212.Checked = true;
                flatCheckBox211.Checked = true;
            }
            else
            {
                Func.ClientMods.RemoveScoreStreak(0, false);
                Func.ClientMods.RemoveScoreStreak(1, false);
                Func.ClientMods.RemoveScoreStreak(2, false);
                Func.ClientMods.RemoveScoreStreak(3, false);
                Func.ClientMods.RemoveScoreStreak(4, false);
                Func.ClientMods.RemoveScoreStreak(5, false);
                Func.ClientMods.RemoveScoreStreak(6, false);
                Func.ClientMods.RemoveScoreStreak(7, false);
                Func.ClientMods.RemoveScoreStreak(8, false);
                Func.ClientMods.RemoveScoreStreak(9, false);
                Func.ClientMods.RemoveScoreStreak(10, false);
                Func.ClientMods.RemoveScoreStreak(11, false);
                flatCheckBox223.Checked = false;
                flatCheckBox222.Checked = false;
                flatCheckBox221.Checked = false;
                flatCheckBox220.Checked = false;
                flatCheckBox219.Checked = false;
                flatCheckBox218.Checked = false;
                flatCheckBox217.Checked = false;
                flatCheckBox216.Checked = false;
                flatCheckBox215.Checked = false;
                flatCheckBox214.Checked = false;
                flatCheckBox213.Checked = false;
                flatCheckBox212.Checked = false;
                flatCheckBox211.Checked = false;
            }
        }
        #endregion
        #region SpawnPlayer
        private void flatButton106_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(0);
        }

        private void flatButton105_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(1);
        }

        private void flatButton104_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(2);
        }

        private void flatButton103_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(3);
        }

        private void flatButton102_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(4);
        }

        private void flatButton101_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(5);
        }

        private void flatButton100_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(6);
        }

        private void flatButton99_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(7);
        }

        private void flatButton98_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(8);
        }

        private void flatButton97_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(9);
        }

        private void flatButton96_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(10);
        }

        private void flatButton95_Click(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnPlayer(11);
        }
        #endregion
        #region TeleportToCenter
        private void flatButton70_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(0);
        }

        private void flatButton69_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(1);
        }

        private void flatButton68_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(2);
        }

        private void flatButton67_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(3);
        }

        private void flatButton66_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(4);
        }

        private void flatButton65_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(5);
        }

        private void flatButton64_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(6);
        }

        private void flatButton63_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(7);
        }

        private void flatButton62_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(8);
        }

        private void flatButton61_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(9);
        }

        private void flatButton60_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(10);
        }

        private void flatButton59_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToCenter(11);
        }
        #endregion
        private void flatButton82_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(0);
        }

        private void flatButton81_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(1);
        }

        private void flatButton80_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(2);
        }

        private void flatButton79_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(3);
        }

        private void flatButton78_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(4);
        }

        private void flatButton77_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(5);
        }

        private void flatButton76_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(6);
        }

        private void flatButton75_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(7);
        }

        private void flatButton74_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(8);
        }

        private void flatButton73_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(9);
        }

        private void flatButton72_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(10);
        }

        private void flatButton71_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSky(11);
        }
        
        private void flatButton94_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox50.Text))
            {
                RPC.SvKick(0, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(0, "^1Trying To Kick You");
            }
        }

        private void flatButton93_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox49.Text))
            {
                RPC.SvKick(1, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(1, "^1Trying To Kick You");
            }
        }

        private void flatButton92_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox48.Text))
            {
                RPC.SvKick(2, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(2, "^1Trying To Kick You");
            }
        }

        private void flatButton91_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox47.Text))
            {
                RPC.SvKick(3, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(3, "^1Trying To Kick You");
            }
        }

        private void flatButton90_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox46.Text))
            {
                RPC.SvKick(4, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(4, "^1Trying To Kick You");
            }
        }

        private void flatButton89_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox45.Text))
            {
                RPC.SvKick(5, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(5, "^1Trying To Kick You");
            }
        }

        private void flatButton88_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox44.Text))
            {
                RPC.SvKick(6, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(6, "^1Trying To Kick You");
            }
        }

        private void flatButton87_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox43.Text))
            {
                RPC.SvKick(7, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(7, "^1Trying To Kick You");
            }
        }

        private void flatButton86_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox42.Text))
            {
                RPC.SvKick(8, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(8, "^1Trying To Kick You");
            }
        }

        private void flatButton85_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox41.Text))
            {
                RPC.SvKick(9, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(9, "^1Trying To Kick You");
            }
        }

        private void flatButton84_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox40.Text))
            {
                RPC.SvKick(10, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(10, "^1Trying To Kick You");
            }
        }

        private void flatButton83_Click(object sender, EventArgs e)
        {
            if (!BIS.MyNames().Contains(textBox39.Text))
            {
                RPC.SvKick(11, msgKikBox.Text);
            }
            else
            {
                RPC.iPrintln(11, "^1Trying To Kick You");
            }
        }

        private void ClientNames1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Func.ClientMods.GetPlayerName(0);
            textBox4.Text = Func.ClientMods.GetPlayerName(1);
            textBox5.Text = Func.ClientMods.GetPlayerName(2);
            textBox6.Text = Func.ClientMods.GetPlayerName(3);
            textBox7.Text = Func.ClientMods.GetPlayerName(4);
            textBox8.Text = Func.ClientMods.GetPlayerName(5);
            textBox9.Text = Func.ClientMods.GetPlayerName(6);
            textBox10.Text = Func.ClientMods.GetPlayerName(7);
            textBox11.Text = Func.ClientMods.GetPlayerName(8);
            textBox12.Text = Func.ClientMods.GetPlayerName(9);
            textBox13.Text = Func.ClientMods.GetPlayerName(10);
            textBox14.Text = Func.ClientMods.GetPlayerName(11);
            Application.DoEvents();
        }

        private void ClientNames2_Click(object sender, EventArgs e)
        {
            textBox38.Text = Func.ClientMods.GetPlayerName(0);
            textBox37.Text = Func.ClientMods.GetPlayerName(1);
            textBox36.Text = Func.ClientMods.GetPlayerName(2);
            textBox35.Text = Func.ClientMods.GetPlayerName(3);
            textBox34.Text = Func.ClientMods.GetPlayerName(4);
            textBox33.Text = Func.ClientMods.GetPlayerName(5);
            textBox32.Text = Func.ClientMods.GetPlayerName(6);
            textBox31.Text = Func.ClientMods.GetPlayerName(7);
            textBox30.Text = Func.ClientMods.GetPlayerName(8);
            textBox29.Text = Func.ClientMods.GetPlayerName(9);
            textBox28.Text = Func.ClientMods.GetPlayerName(10);
            textBox27.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void ClientNames3_Click(object sender, EventArgs e)
        {
            textBox50.Text = Func.ClientMods.GetPlayerName(0);
            textBox49.Text = Func.ClientMods.GetPlayerName(1);
            textBox48.Text = Func.ClientMods.GetPlayerName(2);
            textBox47.Text = Func.ClientMods.GetPlayerName(3);
            textBox46.Text = Func.ClientMods.GetPlayerName(4);
            textBox45.Text = Func.ClientMods.GetPlayerName(5);
            textBox44.Text = Func.ClientMods.GetPlayerName(6);
            textBox43.Text = Func.ClientMods.GetPlayerName(7);
            textBox42.Text = Func.ClientMods.GetPlayerName(8);
            textBox41.Text = Func.ClientMods.GetPlayerName(9);
            textBox40.Text = Func.ClientMods.GetPlayerName(10);
            textBox39.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void ClientNames4_Click(object sender, EventArgs e)
        {
            textBox26.Text = Func.ClientMods.GetPlayerName(0);
            textBox25.Text = Func.ClientMods.GetPlayerName(1);
            textBox24.Text = Func.ClientMods.GetPlayerName(2);
            textBox23.Text = Func.ClientMods.GetPlayerName(3);
            textBox22.Text = Func.ClientMods.GetPlayerName(4);
            textBox21.Text = Func.ClientMods.GetPlayerName(5);
            textBox20.Text = Func.ClientMods.GetPlayerName(6);
            textBox19.Text = Func.ClientMods.GetPlayerName(7);
            textBox18.Text = Func.ClientMods.GetPlayerName(8);
            textBox17.Text = Func.ClientMods.GetPlayerName(9);
            textBox16.Text = Func.ClientMods.GetPlayerName(10);
            textBox15.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void flatComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(0, BIS.Client.CamoByte.Camos[flatComboBox4.SelectedIndex],"Camo Set to : " + flatComboBox4.Text);
        }

        private void flatComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(1, BIS.Client.CamoByte.Camos[flatComboBox6.SelectedIndex],"Camo Set to : " + flatComboBox6.Text);
        }

        private void flatComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(2, BIS.Client.CamoByte.Camos[flatComboBox8.SelectedIndex],"Camo Set to : " + flatComboBox8.Text);

        }

        private void flatComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(3, BIS.Client.CamoByte.Camos[flatComboBox11.SelectedIndex],"Camo Set to : " + flatComboBox11.Text);
        }

        private void flatComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(4, BIS.Client.CamoByte.Camos[flatComboBox12.SelectedIndex],"Camo Set to : " + flatComboBox12.Text);
        }

        private void flatComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(5, BIS.Client.CamoByte.Camos[flatComboBox13.SelectedIndex],"Camo Set to : " + flatComboBox13.Text);
        }

        private void flatComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(6, BIS.Client.CamoByte.Camos[flatComboBox14.SelectedIndex], "Camo Set to : " + flatComboBox14.Text);
        }

        private void flatComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(7, BIS.Client.CamoByte.Camos[flatComboBox15.SelectedIndex],"Camo Set to : " + flatComboBox15.Text);
        }

        private void flatComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(8, BIS.Client.CamoByte.Camos[flatComboBox16.SelectedIndex],"Camo Set to : " + flatComboBox16.Text);
        }

        private void flatComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(9, BIS.Client.CamoByte.Camos[flatComboBox17.SelectedIndex],"Camo Set to : " + flatComboBox17.Text);
        }

        private void flatComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(10, BIS.Client.CamoByte.Camos[flatComboBox18.SelectedIndex],"Camo Set to : " + flatComboBox18.Text);
        }

        private void flatComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeCamos(11, BIS.Client.CamoByte.Camos[flatComboBox19.SelectedIndex], "Camo Set to : " + flatComboBox19.Text);
        }

        private void flatComboBox74_SelectedIndexChanged(object sender, EventArgs e)
        {
                Func.ClientMods.ChangeCamos(0, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex],"Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(1, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(2, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(3, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(4, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(5, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(6, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(7, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(8, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(9, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(10, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
                Func.ClientMods.ChangeCamos(11, BIS.Client.CamoByte.Camos[flatComboBox74.SelectedIndex], "Camo Set to : " + flatComboBox74.Text);
        }

        private void flatComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(0, BIS.Client.TeamBytes.Teams[flatComboBox31.SelectedIndex], "Your new Team is ^2 " + flatComboBox31.Text);
        }

        private void flatComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(1, BIS.Client.TeamBytes.Teams[flatComboBox30.SelectedIndex], "Your new Team is ^2 " + flatComboBox30.Text);
        }

        private void flatComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(2, BIS.Client.TeamBytes.Teams[flatComboBox29.SelectedIndex], "Your new Team is ^2 " + flatComboBox29.Text);
        }

        private void flatComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(3, BIS.Client.TeamBytes.Teams[flatComboBox28.SelectedIndex], "Your new Team is ^2 " + flatComboBox28.Text);
        }

        private void flatComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(4, BIS.Client.TeamBytes.Teams[flatComboBox27.SelectedIndex], "Your new Team is ^2 " + flatComboBox27.Text);
        }

        private void flatComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(5, BIS.Client.TeamBytes.Teams[flatComboBox26.SelectedIndex], "Your new Team is ^2 " + flatComboBox26.Text);
        }

        private void flatComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(6, BIS.Client.TeamBytes.Teams[flatComboBox25.SelectedIndex], "Your new Team is ^2 " + flatComboBox25.Text);
        }

        private void flatComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(7, BIS.Client.TeamBytes.Teams[flatComboBox24.SelectedIndex], "Your new Team is ^2 " + flatComboBox24.Text);
        }

        private void flatComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(8, BIS.Client.TeamBytes.Teams[flatComboBox23.SelectedIndex], "Your new Team is ^2 " + flatComboBox23.Text);
        }

        private void flatComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(9, BIS.Client.TeamBytes.Teams[flatComboBox22.SelectedIndex], "Your new Team is ^2 " + flatComboBox22.Text);
        }

        private void flatComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(10, BIS.Client.TeamBytes.Teams[flatComboBox21.SelectedIndex], "Your new Team is ^2 " + flatComboBox21.Text);
        }

        private void flatComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(11, BIS.Client.TeamBytes.Teams[flatComboBox20.SelectedIndex], "Your new Team is ^2 " + flatComboBox20.Text);
        }

        private void flatComboBox73_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeTeam(0, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(1, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(2, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(3, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(4, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(5, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(6, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(7, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(8, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(9, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(10, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
            Func.ClientMods.ChangeTeam(11, BIS.Client.TeamBytes.Teams[flatComboBox73.SelectedIndex], "Your new Team is ^2 " + flatComboBox73.Text);
        }

        private void flatComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(0, BIS.Client.PlayerVision.Visions[flatComboBox43.SelectedIndex]);
        }

        private void flatComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(1, BIS.Client.PlayerVision.Visions[flatComboBox42.SelectedIndex]);
        }

        private void flatComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(2, BIS.Client.PlayerVision.Visions[flatComboBox41.SelectedIndex]);
        }

        private void flatComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(3, BIS.Client.PlayerVision.Visions[flatComboBox40.SelectedIndex]);
        }

        private void flatComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(4, BIS.Client.PlayerVision.Visions[flatComboBox39.SelectedIndex]);
        }

        private void flatComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(5, BIS.Client.PlayerVision.Visions[flatComboBox38.SelectedIndex]);
        }

        private void flatComboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(6, BIS.Client.PlayerVision.Visions[flatComboBox37.SelectedIndex]);
        }

        private void flatComboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(7, BIS.Client.PlayerVision.Visions[flatComboBox36.SelectedIndex]);
        }

        private void flatComboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(8, BIS.Client.PlayerVision.Visions[flatComboBox35.SelectedIndex]);
        }

        private void flatComboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(9, BIS.Client.PlayerVision.Visions[flatComboBox34.SelectedIndex]);
        }

        private void flatComboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(10, BIS.Client.PlayerVision.Visions[flatComboBox33.SelectedIndex]);
        }

        private void flatComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(11, BIS.Client.PlayerVision.Visions[flatComboBox32.SelectedIndex]);
        }

        private void flatComboBox72_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeVision(0, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(1, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(2, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(3, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(4, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(5, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(6, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(7, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(8, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(9, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(10, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
            Func.ClientMods.ChangeVision(11, BIS.Client.PlayerVision.Visions[flatComboBox72.SelectedIndex]);
        }

        private void flatComboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(0, BIS.Client.PlayerStatus.Status[flatComboBox55.SelectedIndex]);
        }

        private void flatComboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(1, BIS.Client.PlayerStatus.Status[flatComboBox54.SelectedIndex]);
        }

        private void flatComboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(2, BIS.Client.PlayerStatus.Status[flatComboBox53.SelectedIndex]);
        }

        private void flatComboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(3, BIS.Client.PlayerStatus.Status[flatComboBox52.SelectedIndex]);
        }

        private void flatComboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(4, BIS.Client.PlayerStatus.Status[flatComboBox51.SelectedIndex]);
        }

        private void flatComboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(5, BIS.Client.PlayerStatus.Status[flatComboBox50.SelectedIndex]);
        }

        private void flatComboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(6, BIS.Client.PlayerStatus.Status[flatComboBox49.SelectedIndex]);
        }

        private void flatComboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(7, BIS.Client.PlayerStatus.Status[flatComboBox48.SelectedIndex]);
        }

        private void flatComboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(8, BIS.Client.PlayerStatus.Status[flatComboBox47.SelectedIndex]);
        }

        private void flatComboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(9, BIS.Client.PlayerStatus.Status[flatComboBox46.SelectedIndex]);
        }

        private void flatComboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(10, BIS.Client.PlayerStatus.Status[flatComboBox45.SelectedIndex]);
        }

        private void flatComboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(11, BIS.Client.PlayerStatus.Status[flatComboBox44.SelectedIndex]);
        }

        private void flatComboBox71_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.PlayerStatus(0, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(1, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(2, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(3, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(4, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(5, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(6, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(7, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(8, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(9, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(10, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
            Func.ClientMods.PlayerStatus(11, BIS.Client.PlayerStatus.Status[flatComboBox71.SelectedIndex]);
        }

        private void flatComboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(0, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox66_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(1, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox65_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(2, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox64_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(3, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox63_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(4, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(5, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(6, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(7, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(8, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(9, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(10, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(11, BIS.Client.PlayerModel.Model[flatComboBox67.SelectedIndex]);
        }

        private void flatComboBox70_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.G_SetModel(0, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(1, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(2, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(3, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(4, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(5, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(6, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(7, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(8, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(9, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(10, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
            RPC.G_SetModel(11, BIS.Client.PlayerModel.Model[flatComboBox70.SelectedIndex]);
        }

        private void svLocationsBtn_Click(object sender, EventArgs e)
        {
            Func.MapNameLocation = Func.ServerInfo.MapName();
            mapSta.Text = Func.MapNameLocation;
            BIS.Client.SvTeleportByte = Func.ClientMods.SaveLocation((int)svClientNum.Value);
            teleportGroubBox.Enabled = true;
            mapStaTi.Start();
        }

        private void flatButton129_Click(object sender, EventArgs e)
        {
            textBox68.Text = Func.ClientMods.GetPlayerName(0);
            textBox67.Text = Func.ClientMods.GetPlayerName(1);
            textBox66.Text = Func.ClientMods.GetPlayerName(2);
            textBox65.Text = Func.ClientMods.GetPlayerName(3);
            textBox64.Text = Func.ClientMods.GetPlayerName(4);
            textBox61.Text = Func.ClientMods.GetPlayerName(5);
            textBox54.Text = Func.ClientMods.GetPlayerName(6);
            textBox53.Text = Func.ClientMods.GetPlayerName(7);
            textBox52.Text = Func.ClientMods.GetPlayerName(8);
            textBox51.Text = Func.ClientMods.GetPlayerName(9);
            textBox2.Text = Func.ClientMods.GetPlayerName(10);
            textBox1.Text = Func.ClientMods.GetPlayerName(11);
        }
        #region Teleport To me
        private void flatComboBox77_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(0, flatComboBox77.SelectedIndex);
        }

        private void flatComboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(1, flatComboBox76.SelectedIndex);
        }

        private void flatComboBox75_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(2, flatComboBox75.SelectedIndex);
        }

        private void flatComboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(3, flatComboBox69.SelectedIndex);
        }

        private void flatComboBox68_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(4, flatComboBox68.SelectedIndex);
        }

        private void flatComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(5, flatComboBox10.SelectedIndex);
        }

        private void flatComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(6, flatComboBox9.SelectedIndex);
        }

        private void flatComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(7, flatComboBox7.SelectedIndex);
        }

        private void flatComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(8, flatComboBox5.SelectedIndex);
        }

        private void flatComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(9, flatComboBox3.SelectedIndex);
        }

        private void flatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(10, flatComboBox2.SelectedIndex);
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(11, flatComboBox1.SelectedIndex);
        }
        #endregion
        #region Teleport Me To
        private void flatComboBox89_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox89.SelectedIndex, 0);
        }

        private void flatComboBox88_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox88.SelectedIndex, 1);
        }

        private void flatComboBox87_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox87.SelectedIndex, 2);
        }

        private void flatComboBox86_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox86.SelectedIndex, 3);
        }

        private void flatComboBox85_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox85.SelectedIndex, 4);
        }

        private void flatComboBox84_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox84.SelectedIndex, 5);
        }

        private void flatComboBox83_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox83.SelectedIndex, 6);
        }

        private void flatComboBox82_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox82.SelectedIndex, 7);
        }

        private void flatComboBox81_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox81.SelectedIndex, 8);
        }

        private void flatComboBox80_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox80.SelectedIndex, 9);
        }

        private void flatComboBox79_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox79.SelectedIndex, 10);
        }

        private void flatComboBox78_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(flatComboBox78.SelectedIndex, 11);
        }
        #endregion

        private void flatButton116_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(0, BISOON);
            }
        }

        private void flatButton115_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(1, BISOON);
            }
        }

        private void flatButton114_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(2, BISOON);
            }
        }

        private void flatButton113_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(3, BISOON);
            }
        }

        private void flatButton112_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(4, BISOON);
            }
        }

        private void flatButton111_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(5, BISOON);
            }
        }

        private void flatButton110_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(6, BISOON);
            }
        }

        private void flatButton109_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(7, BISOON);
            }
        }

        private void flatButton108_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(8, BISOON);
            }
        }

        private void flatButton107_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(9, BISOON);
            }
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(10, BISOON);
            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 12; BISOON++)
            {
                Func.ClientMods.TeleportClient(11, BISOON);
            }
        }

        private void flatButton128_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(0);
        }

        private void flatButton127_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(1);
        }

        private void flatButton126_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(2);
        }

        private void flatButton125_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(3);
        }

        private void flatButton124_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(4);
        }

        private void flatButton123_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(5);
        }

        private void flatButton122_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(6);
        }

        private void flatButton121_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(7);
        }

        private void flatButton120_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(8);
        }

        private void flatButton119_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(9);
        }

        private void flatButton118_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(10);
        }

        private void flatButton117_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportToSaved(11);
        }

        private void clientTeleport_Tick(object sender, EventArgs e)
        {
                //if (flatCheckBox13.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(0);
                //}
                //if (flatCheckBox12.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(1);
                //}
                //if (flatCheckBox11.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(2);
                //}
                //if (flatCheckBox10.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(3);
                //}
                //if (flatCheckBox9.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(4);
                //}
                //if (flatCheckBox8.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(5);
                //}
                //if (flatCheckBox7.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(6);
                //}
                //if (flatCheckBox6.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(7);
                //}
                //if (flatCheckBox5.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(8);
                //}
                //if (flatCheckBox4.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(9);
                //}
                //if (flatCheckBox3.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(10);
                //}
                //if (flatCheckBox2.Checked)
                //{
                //    Func.ClientMods.TeleportToSaved(11);
                //}
            }

        private void flatCheckBox13_CheckedChanged(object sender)
        {
            if (flatCheckBox13.Checked)
            {
                Func.ClientMods.TeleportToSaved(0, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(0, false);
            }
        }

        private void flatCheckBox12_CheckedChanged(object sender)
        {
            if (flatCheckBox12.Checked)
            {
                Func.ClientMods.TeleportToSaved(1, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(1, false);
            }
        }

        private void flatCheckBox11_CheckedChanged(object sender)
        {
            if (flatCheckBox11.Checked)
            {
                Func.ClientMods.TeleportToSaved(2, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(2, false);
            }
        }

        private void flatCheckBox10_CheckedChanged(object sender)
        {
            if (flatCheckBox10.Checked)
            {
                Func.ClientMods.TeleportToSaved(3, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(3, false);
            }
        }

        private void flatCheckBox9_CheckedChanged(object sender)
        {
            if (flatCheckBox9.Checked)
            {
                Func.ClientMods.TeleportToSaved(4, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(4, false);
            }
        }

        private void flatCheckBox8_CheckedChanged(object sender)
        {
            if (flatCheckBox8.Checked)
            {
                Func.ClientMods.TeleportToSaved(5, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(5, false);
            }
        }

        private void flatCheckBox7_CheckedChanged(object sender)
        {
            if (flatCheckBox7.Checked)
            {
                Func.ClientMods.TeleportToSaved(6, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(6, false);
            }
        }

        private void flatCheckBox6_CheckedChanged(object sender)
        {
            if (flatCheckBox6.Checked)
            {
                Func.ClientMods.TeleportToSaved(7, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(7, false);
            }
        }

        private void flatCheckBox5_CheckedChanged(object sender)
        {
            if (flatCheckBox5.Checked)
            {
                Func.ClientMods.TeleportToSaved(8, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(8, false);
            }
        }

        private void flatCheckBox4_CheckedChanged(object sender)
        {
            if (flatCheckBox4.Checked)
            {
                Func.ClientMods.TeleportToSaved(9, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(9, false);
            }
        }

        private void flatCheckBox3_CheckedChanged(object sender)
        {
            if (flatCheckBox3.Checked)
            {
                Func.ClientMods.TeleportToSaved(10, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(10, false);
            }
        }

        private void flatCheckBox2_CheckedChanged(object sender)
        {
            if (flatCheckBox2.Checked)
            {
                Func.ClientMods.TeleportToSaved(11, true);
            }
            else
            {
                Func.ClientMods.TeleportToSaved(11, false);
            }
        }

        private void clientNames6_Click(object sender, EventArgs e)
        {
            textBox80.Text = Func.ClientMods.GetPlayerName(0);
            textBox79.Text = Func.ClientMods.GetPlayerName(1);
            textBox78.Text = Func.ClientMods.GetPlayerName(2);
            textBox77.Text = Func.ClientMods.GetPlayerName(3);
            textBox76.Text = Func.ClientMods.GetPlayerName(4);
            textBox75.Text = Func.ClientMods.GetPlayerName(5);
            textBox74.Text = Func.ClientMods.GetPlayerName(6);
            textBox73.Text = Func.ClientMods.GetPlayerName(7);
            textBox72.Text = Func.ClientMods.GetPlayerName(8);
            textBox71.Text = Func.ClientMods.GetPlayerName(9);
            textBox70.Text = Func.ClientMods.GetPlayerName(10);
            textBox69.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void flatButton142_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(0, textBox92.Text);
        }

        private void flatButton141_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(1, textBox91.Text);
        }

        private void flatButton140_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(2, textBox90.Text);
        }

        private void flatButton139_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(3, textBox89.Text);
        }

        private void flatButton138_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(4, textBox88.Text);
        }

        private void flatButton137_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(5, textBox87.Text);
        }

        private void flatButton136_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(6, textBox86.Text);
        }

        private void flatButton135_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(7, textBox85.Text);
        }

        private void flatButton134_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(8, textBox84.Text);
        }

        private void flatButton133_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(9, textBox83.Text);
        }

        private void flatButton132_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(10, textBox82.Text);
        }

        private void flatButton131_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(11, textBox81.Text);
        }

        private void flatButton143_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsName(0, textBox93.Text);
            Func.ClientMods.ChangeClientsName(1, textBox93.Text);
            Func.ClientMods.ChangeClientsName(2, textBox93.Text);
            Func.ClientMods.ChangeClientsName(3, textBox93.Text);
            Func.ClientMods.ChangeClientsName(4, textBox93.Text);
            Func.ClientMods.ChangeClientsName(5, textBox93.Text);
            Func.ClientMods.ChangeClientsName(6, textBox93.Text);
            Func.ClientMods.ChangeClientsName(7, textBox93.Text);
            Func.ClientMods.ChangeClientsName(8, textBox93.Text);
            Func.ClientMods.ChangeClientsName(9, textBox93.Text);
            Func.ClientMods.ChangeClientsName(10, textBox93.Text);
            Func.ClientMods.ChangeClientsName(11, textBox93.Text);
            Func.ClientMods.ChangeClientsName(12, textBox93.Text);
        }

        private void flatButton156_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(0, textBox106.Text);
        }

        private void flatButton155_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(1, textBox105.Text);
        }

        private void flatButton154_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(2, textBox104.Text);
        }

        private void flatButton153_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(3, textBox103.Text);
        }

        private void flatButton152_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(4, textBox102.Text);
        }

        private void flatButton151_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(5, textBox101.Text);
        }

        private void flatButton150_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(6, textBox100.Text);
        }

        private void flatButton149_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(7, textBox99.Text);
        }

        private void flatButton148_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(8, textBox98.Text);
        }

        private void flatButton147_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(9, textBox97.Text);
        }

        private void flatButton146_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(10, textBox96.Text);
        }

        private void flatButton145_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(11, textBox95.Text);
        }

        private void flatButton144_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ChangeClientsClan(0, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(1, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(2, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(3, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(4, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(5, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(6, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(7, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(8, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(9, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(10, textBox94.Text);
            Func.ClientMods.ChangeClientsClan(11, textBox94.Text);
        }

        private void flatButton169_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(0, textBox119.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(0, textBox119.Text);
            }
        }

        private void flatButton168_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(1, textBox118.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(1, textBox118.Text);
            }
        }

        private void flatButton167_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(2, textBox117.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(2, textBox117.Text);
            }
        }

        private void flatButton166_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(3, textBox116.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(3, textBox116.Text);
            }
        }

        private void flatButton165_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(4, textBox115.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(4, textBox115.Text);
            }
        }

        private void flatButton164_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(5, textBox114.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(5, textBox114.Text);
            }
        }

        private void flatButton163_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(6, textBox113.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(6, textBox113.Text);
            }
        }

        private void flatButton162_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(7, textBox112.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(7, textBox112.Text);
            }
        }

        private void flatButton161_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(8, textBox111.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(8, textBox111.Text);
            }
        }

        private void flatButton160_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(9, textBox110.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(9, textBox110.Text);
            }
        }

        private void flatButton159_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(10, textBox109.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(10, textBox109.Text);
            }
        }

        private void flatButton158_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(11, textBox108.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(11, textBox108.Text);
            }
        }

        private void flatButton157_Click(object sender, EventArgs e)
        {
            if (printType.Value == 0)
            {
                RPC.iPrintln(-1, textBox107.Text);
            }
            if (printType.Value == 1)
            {
                RPC.iPrintlnBold(-1, textBox107.Text);
            }
        }

        private void clientAmmo_Tick(object sender, EventArgs e)
        {
            if (flatCheckBox83.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client0Ammo();
            }
            if (flatCheckBox82.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client1Ammo();
            }
            if (flatCheckBox81.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client2Ammo();
            }
            if (flatCheckBox80.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client3Ammo();
            }
            if (flatCheckBox79.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client4Ammo();
            }
            if (flatCheckBox78.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client5Ammo();
            }
            if (flatCheckBox77.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client6Ammo();
            }
            if (flatCheckBox76.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client7Ammo();
            }
            if (flatCheckBox75.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client8Ammo();
            }
            if (flatCheckBox74.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client9Ammo();
            }
            if (flatCheckBox73.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client10Ammo();
            }
            if (flatCheckBox72.Checked)
            {
                Func.ClientMods.ClientsAmmo.Client11Ammo();
            }
        }

        private void clientVsat_Tick(object sender, EventArgs e)
        {
            //if (flatCheckBox71.Checked)
            //{
            //    Func.ClientMods.VSAT(0, true);
            //}
            //if (flatCheckBox70.Checked)
            //{
            //    Func.ClientMods.VSAT(1, true);
            //}
            //if (flatCheckBox69.Checked)
            //{
            //    Func.ClientMods.VSAT(2, true);
            //}
            //if (flatCheckBox68.Checked)
            //{
            //    Func.ClientMods.VSAT(3, true);
            //}
            //if (flatCheckBox67.Checked)
            //{
            //    Func.ClientMods.VSAT(4, true);
            //}
            //if (flatCheckBox66.Checked)
            //{
            //    Func.ClientMods.VSAT(5, true);
            //}
            //if (flatCheckBox65.Checked)
            //{
            //    Func.ClientMods.VSAT(6, true);
            //}
            //if (flatCheckBox64.Checked)
            //{
            //    Func.ClientMods.VSAT(7, true);
            //}
            //if (flatCheckBox63.Checked)
            //{
            //    Func.ClientMods.VSAT(8, true);
            //}
            //if (flatCheckBox62.Checked)
            //{
            //    Func.ClientMods.VSAT(9, true);
            //}
            //if (flatCheckBox61.Checked)
            //{
            //    Func.ClientMods.VSAT(10, true);
            //}
            //if (flatCheckBox60.Checked)
            //{
            //    Func.ClientMods.VSAT(11, true);
            //}
        }

        private void clientAllPerks_Tick(object sender, EventArgs e)
        {
            //if (flatCheckBox95.Checked)
            //{
            //    Func.ClientMods.AllPerks(0, true);
            //}
            //if (flatCheckBox94.Checked)
            //{
            //    Func.ClientMods.AllPerks(1, true);
            //}
            //if (flatCheckBox93.Checked)
            //{
            //    Func.ClientMods.AllPerks(2, true);
            //}
            //if (flatCheckBox92.Checked)
            //{
            //    Func.ClientMods.AllPerks(3, true);
            //}
            //if (flatCheckBox91.Checked)
            //{
            //    Func.ClientMods.AllPerks(4, true);
            //}
            //if (flatCheckBox90.Checked)
            //{
            //    Func.ClientMods.AllPerks(5, true);
            //}
            //if (flatCheckBox89.Checked)
            //{
            //    Func.ClientMods.AllPerks(6, true);
            //}
            //if (flatCheckBox88.Checked)
            //{
            //    Func.ClientMods.AllPerks(7, true);
            //}
            //if (flatCheckBox87.Checked)
            //{
            //    Func.ClientMods.AllPerks(8, true);
            //}
            //if (flatCheckBox86.Checked)
            //{
            //    Func.ClientMods.AllPerks(9, true);
            //}
            //if (flatCheckBox85.Checked)
            //{
            //    Func.ClientMods.AllPerks(10, true);
            //}
            //if (flatCheckBox84.Checked)
            //{
            //    Func.ClientMods.AllPerks(11, true);
            //}
        }

        private void scoreStreak_Tick(object sender, EventArgs e)
        {
            //if (flatCheckBox107.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(0, true);
            //}
            //if (flatCheckBox106.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(1, true);
            //}
            //if (flatCheckBox105.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(2, true);
            //}
            //if (flatCheckBox104.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(3, true);
            //}
            //if (flatCheckBox103.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(4, true);
            //}
            //if (flatCheckBox102.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(5, true);
            //}
            //if (flatCheckBox101.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(6, true);
            //}
            //if (flatCheckBox100.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(7, true);
            //}
            //if (flatCheckBox99.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(8, true);
            //}
            //if (flatCheckBox98.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(9, true);
            //}
            //if (flatCheckBox97.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(10, true);
            //}
            //if (flatCheckBox96.Checked)
            //{
            //    Func.ClientMods.ScoreStreak(11, true);
            //}
        }

        private void flatButton129_Click_1(object sender, EventArgs e)
        {
            flatCheckBox338.Checked = false;
            flatCheckBox48.Checked = false;
            flatCheckBox49.Checked = false;
            flatCheckBox50.Checked = false;
            flatCheckBox51.Checked = false;
            flatCheckBox52.Checked = false;
            flatCheckBox53.Checked = false;
            flatCheckBox54.Checked = false;
            flatCheckBox55.Checked = false;
            flatCheckBox56.Checked = false;
            flatCheckBox57.Checked = false;
            flatCheckBox58.Checked = false;
            flatCheckBox59.Checked = false;
            flatCheckBox71.Checked = false;
            flatCheckBox70.Checked = false;
            flatCheckBox69.Checked = false;
            flatCheckBox68.Checked = false;
            flatCheckBox67.Checked = false;
            flatCheckBox66.Checked = false;
            flatCheckBox65.Checked = false;
            flatCheckBox64.Checked = false;
            flatCheckBox63.Checked = false;
            flatCheckBox62.Checked = false;
            flatCheckBox61.Checked = false;
            flatCheckBox60.Checked = false;
            flatCheckBox337.Checked = false;
            flatCheckBox83.Checked = false;
            flatCheckBox82.Checked = false;
            flatCheckBox81.Checked = false;
            flatCheckBox80.Checked = false;
            flatCheckBox79.Checked = false;
            flatCheckBox78.Checked = false;
            flatCheckBox77.Checked = false;
            flatCheckBox76.Checked = false;
            flatCheckBox75.Checked = false;
            flatCheckBox74.Checked = false;
            flatCheckBox73.Checked = false;
            flatCheckBox72.Checked = false;
            flatCheckBox336.Checked = false;
            flatCheckBox95.Checked = false;
            flatCheckBox94.Checked = false;
            flatCheckBox93.Checked = false;
            flatCheckBox92.Checked = false;
            flatCheckBox91.Checked = false;
            flatCheckBox90.Checked = false;
            flatCheckBox89.Checked = false;
            flatCheckBox88.Checked = false;
            flatCheckBox87.Checked = false;
            flatCheckBox86.Checked = false;
            flatCheckBox85.Checked = false;
            flatCheckBox84.Checked = false;
            flatCheckBox335.Checked = false;
            flatCheckBox107.Checked = false;
            flatCheckBox106.Checked = false;
            flatCheckBox105.Checked = false;
            flatCheckBox104.Checked = false;
            flatCheckBox103.Checked = false;
            flatCheckBox102.Checked = false;
            flatCheckBox101.Checked = false;
            flatCheckBox100.Checked = false;
            flatCheckBox99.Checked = false;
            flatCheckBox98.Checked = false;
            flatCheckBox97.Checked = false;
            flatCheckBox96.Checked = false;
            flatCheckBox334.Checked = false;
            flatCheckBox119.Checked = false;
            flatCheckBox118.Checked = false;
            flatCheckBox117.Checked = false;
            flatCheckBox116.Checked = false;
            flatCheckBox115.Checked = false;
            flatCheckBox114.Checked = false;
            flatCheckBox113.Checked = false;
            flatCheckBox112.Checked = false;
            flatCheckBox111.Checked = false;
            flatCheckBox110.Checked = false;
            flatCheckBox109.Checked = false;
            flatCheckBox108.Checked = false;
            flatCheckBox108.Checked = false;
            flatCheckBox333.Checked = false;
            flatCheckBox131.Checked = false;
            flatCheckBox130.Checked = false;
            flatCheckBox129.Checked = false;
            flatCheckBox128.Checked = false;
            flatCheckBox127.Checked = false;
            flatCheckBox126.Checked = false;
            flatCheckBox125.Checked = false;
            flatCheckBox124.Checked = false;
            flatCheckBox123.Checked = false;
            flatCheckBox122.Checked = false;
            flatCheckBox121.Checked = false;
            flatCheckBox120.Checked = false;
            flatCheckBox332.Checked = false;
            flatCheckBox143.Checked = false;
            flatCheckBox142.Checked = false;
            flatCheckBox141.Checked = false;
            flatCheckBox140.Checked = false;
            flatCheckBox139.Checked = false;
            flatCheckBox138.Checked = false;
            flatCheckBox137.Checked = false;
            flatCheckBox136.Checked = false;
            flatCheckBox135.Checked = false;
            flatCheckBox134.Checked = false;
            flatCheckBox133.Checked = false;
            flatCheckBox132.Checked = false;
            flatCheckBox331.Checked = false;
            flatCheckBox155.Checked = false;
            flatCheckBox154.Checked = false;
            flatCheckBox153.Checked = false;
            flatCheckBox152.Checked = false;
            flatCheckBox151.Checked = false;
            flatCheckBox150.Checked = false;
            flatCheckBox149.Checked = false;
            flatCheckBox148.Checked = false;
            flatCheckBox147.Checked = false;
            flatCheckBox146.Checked = false;
            flatCheckBox145.Checked = false;
            flatCheckBox144.Checked = false;
            flatCheckBox330.Checked = false;
            flatCheckBox167.Checked = false;
            flatCheckBox166.Checked = false;
            flatCheckBox165.Checked = false;
            flatCheckBox164.Checked = false;
            flatCheckBox163.Checked = false;
            flatCheckBox162.Checked = false;
            flatCheckBox161.Checked = false;
            flatCheckBox160.Checked = false;
            flatCheckBox159.Checked = false;
            flatCheckBox158.Checked = false;
            flatCheckBox157.Checked = false;
            flatCheckBox156.Checked = false;
            flatCheckBox329.Checked = false;
            flatCheckBox179.Checked = false;
            flatCheckBox178.Checked = false;
            flatCheckBox177.Checked = false;
            flatCheckBox176.Checked = false;
            flatCheckBox175.Checked = false;
            flatCheckBox174.Checked = false;
            flatCheckBox173.Checked = false;
            flatCheckBox172.Checked = false;
            flatCheckBox171.Checked = false;
            flatCheckBox170.Checked = false;
            flatCheckBox169.Checked = false;
            flatCheckBox168.Checked = false;
            flatCheckBox328.Checked = false;
            flatCheckBox191.Checked = false;
            flatCheckBox190.Checked = false;
            flatCheckBox189.Checked = false;
            flatCheckBox188.Checked = false;
            flatCheckBox187.Checked = false;
            flatCheckBox186.Checked = false;
            flatCheckBox185.Checked = false;
            flatCheckBox184.Checked = false;
            flatCheckBox183.Checked = false;
            flatCheckBox182.Checked = false;
            flatCheckBox181.Checked = false;
            flatCheckBox180.Checked = false;
            flatCheckBox327.Checked = false;
            flatCheckBox203.Checked = false;
            flatCheckBox202.Checked = false;
            flatCheckBox201.Checked = false;
            flatCheckBox200.Checked = false;
            flatCheckBox199.Checked = false;
            flatCheckBox198.Checked = false;
            flatCheckBox197.Checked = false;
            flatCheckBox196.Checked = false;
            flatCheckBox195.Checked = false;
            flatCheckBox194.Checked = false;
            flatCheckBox193.Checked = false;
            flatCheckBox192.Checked = false;
            flatCheckBox326.Checked = false;
            flatCheckBox215.Checked = false;
            flatCheckBox214.Checked = false;
            flatCheckBox213.Checked = false;
            flatCheckBox212.Checked = false;
            flatCheckBox211.Checked = false;
            flatCheckBox210.Checked = false;
            flatCheckBox209.Checked = false;
            flatCheckBox208.Checked = false;
            flatCheckBox207.Checked = false;
            flatCheckBox206.Checked = false;
            flatCheckBox205.Checked = false;
            flatCheckBox204.Checked = false;
            flatCheckBox325.Checked = false;
            flatCheckBox227.Checked = false;
            flatCheckBox226.Checked = false;
            flatCheckBox225.Checked = false;
            flatCheckBox224.Checked = false;
            flatCheckBox223.Checked = false;
            flatCheckBox222.Checked = false;
            flatCheckBox221.Checked = false;
            flatCheckBox220.Checked = false;
            flatCheckBox219.Checked = false;
            flatCheckBox218.Checked = false;
            flatCheckBox217.Checked = false;
            flatCheckBox216.Checked = false;
            flatCheckBox324.Checked = false;
            flatCheckBox239.Checked = false;
            flatCheckBox238.Checked = false;
            flatCheckBox237.Checked = false;
            flatCheckBox236.Checked = false;
            flatCheckBox235.Checked = false;
            flatCheckBox234.Checked = false;
            flatCheckBox233.Checked = false;
            flatCheckBox232.Checked = false;
            flatCheckBox231.Checked = false;
            flatCheckBox230.Checked = false;
            flatCheckBox229.Checked = false;
            flatCheckBox228.Checked = false;
            flatCheckBox343.Checked = false;
            flatCheckBox251.Checked = false;
            flatCheckBox250.Checked = false;
            flatCheckBox249.Checked = false;
            flatCheckBox248.Checked = false;
            flatCheckBox247.Checked = false;
            flatCheckBox246.Checked = false;
            flatCheckBox245.Checked = false;
            flatCheckBox244.Checked = false;
            flatCheckBox243.Checked = false;
            flatCheckBox242.Checked = false;
            flatCheckBox241.Checked = false;
            flatCheckBox240.Checked = false;
            flatCheckBox342.Checked = false;
            flatCheckBox263.Checked = false;
            flatCheckBox262.Checked = false;
            flatCheckBox261.Checked = false;
            flatCheckBox260.Checked = false;
            flatCheckBox259.Checked = false;
            flatCheckBox258.Checked = false;
            flatCheckBox257.Checked = false;
            flatCheckBox256.Checked = false;
            flatCheckBox255.Checked = false;
            flatCheckBox254.Checked = false;
            flatCheckBox253.Checked = false;
            flatCheckBox252.Checked = false;
            flatCheckBox341.Checked = false;
            flatCheckBox275.Checked = false;
            flatCheckBox274.Checked = false;
            flatCheckBox273.Checked = false;
            flatCheckBox272.Checked = false;
            flatCheckBox271.Checked = false;
            flatCheckBox270.Checked = false;
            flatCheckBox269.Checked = false;
            flatCheckBox268.Checked = false;
            flatCheckBox267.Checked = false;
            flatCheckBox266.Checked = false;
            flatCheckBox265.Checked = false;
            flatCheckBox264.Checked = false;
            flatCheckBox340.Checked = false;
            flatCheckBox299.Checked = false;
            flatCheckBox298.Checked = false;
            flatCheckBox297.Checked = false;
            flatCheckBox296.Checked = false;
            flatCheckBox295.Checked = false;
            flatCheckBox294.Checked = false;
            flatCheckBox293.Checked = false;
            flatCheckBox292.Checked = false;
            flatCheckBox291.Checked = false;
            flatCheckBox290.Checked = false;
            flatCheckBox289.Checked = false;
            flatCheckBox288.Checked = false;
            flatCheckBox346.Checked = false;
            flatCheckBox223.Checked = false;
            flatCheckBox222.Checked = false;
            flatCheckBox221.Checked = false;
            flatCheckBox220.Checked = false;
            flatCheckBox219.Checked = false;
            flatCheckBox218.Checked = false;
            flatCheckBox217.Checked = false;
            flatCheckBox216.Checked = false;
            flatCheckBox215.Checked = false;
            flatCheckBox214.Checked = false;
            flatCheckBox213.Checked = false;
            flatCheckBox212.Checked = false;
            flatCheckBox211.Checked = false;
            flatCheckBox344.Checked = false;
            flatCheckBox1.Checked = false;
            flatCheckBox287.Checked = false;
            flatCheckBox286.Checked = false;
            flatCheckBox285.Checked = false;
            flatCheckBox284.Checked = false;
            flatCheckBox283.Checked = false;
            flatCheckBox282.Checked = false;
            flatCheckBox281.Checked = false;
            flatCheckBox280.Checked = false;
            flatCheckBox279.Checked = false;
            flatCheckBox278.Checked = false;
            flatCheckBox277.Checked = false;
            flatCheckBox276.Checked = false;
        }

        private void sendTe_Click(object sender, EventArgs e)
        {
            textBox120.Text = "# ^1" + classNameSender.Text;
            textBox121.Text = "# ^2" + classNameSender.Text;
            textBox122.Text = "# ^3" + classNameSender.Text;
            textBox123.Text = "# ^4" + classNameSender.Text;
            textBox124.Text = "# ^5" + classNameSender.Text;
            textBox125.Text = "# ^6" + classNameSender.Text;
            textBox126.Text = "# ^7" + classNameSender.Text;
            textBox127.Text = "# ^8" + classNameSender.Text;
            textBox128.Text = "# ^9" + classNameSender.Text;
            textBox129.Text = "# ^1" + classNameSender.Text;
        }

        private void antiQuit_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(0);
        }

        private void antiQuit_1_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(1);
        }

        private void antiQuit_2_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(2);
        }

        private void antiQuit_3_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(3);
        }

        private void antiQuit_4_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(4);
        }

        private void antiQuit_5_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(5);
        }

        private void antiQuit_6_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(6);
        }

        private void antiQuit_7_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(7);
        }

        private void antiQuit_8_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(8);
        }

        private void antiQuit_9_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(9);
        }

        private void antiQuit_10_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(10);
        }

        private void antiQuit_11_Tick(object sender, EventArgs e)
        {
            AimBot.StartAimBot(11);
        }

        private void notifyCh_CheckedChanged(object sender)
        {
            if (notifyCh.Checked)
            {
                Func.Notify = true;
            }
            else
            {
                Func.Notify = false;
            }
        }

        private void cl1Ghost_CheckedChanged(object sender)
        {
            if (cl1Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl1Aw.Checked = false;
                cl1Nc.Checked = false;
            }
        }

        private void cl2Ghost_CheckedChanged(object sender)
        {
            if (cl2Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl2Aw.Checked = false;
                cl2Nc.Checked = false;
            }
        }

        private void cl3Ghost_CheckedChanged(object sender)
        {
            if (cl3Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl3Aw.Checked = false;
                cl3Nc.Checked = false;
            }
        }

        private void cl4Ghost_CheckedChanged(object sender)
        {
            if (cl4Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl4Aw.Checked = false;
                cl4Nc.Checked = false;
            }
        }

        private void cl5Ghost_CheckedChanged(object sender)
        {
            if (cl5Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl5Aw.Checked = false;
                cl5Nc.Checked = false;
            }
        }

        private void cl6Ghost_CheckedChanged(object sender)
        {
            if (cl6Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl6Aw.Checked = false;
                cl6Nc.Checked = false;
            }
        }

        private void cl7Ghost_CheckedChanged(object sender)
        {
            if (cl7Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl7Aw.Checked = false;
                cl7Nc.Checked = false;
            }
        }

        private void cl8Ghost_CheckedChanged(object sender)
        {
            if (cl8Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl8Aw.Checked = false;
                cl8Nc.Checked = false;
            }
        }

        private void cl9Ghost_CheckedChanged(object sender)
        {
            if (cl9Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl9Aw.Checked = false;
                cl9Nc.Checked = false;
            }
        }

        private void cl10Ghost_CheckedChanged(object sender)
        {
            if (cl10Ghost.Checked)
            {
                ghostCamoTi.Start();
                cl10Aw.Checked = false;
                cl10Nc.Checked = false;
            }
        }

        private void allKnifeGhost_Click(object sender, EventArgs e)
        {
            byte[] ghost21 = new byte[] { 0x40, 0x10 };
            Functions.SetMem(0x27078ED, ghost21);
            byte[] ghost221 = new byte[] { 0x04, 0x01 };
            Functions.SetMem(0x2707922, ghost221);
            byte[] ghost3 = new byte[] { 0x40, 0x10 };
            Functions.SetMem(0x2707956, ghost3);
            byte[] ghost4 = new byte[] { 0x04, 0x01 };
            Functions.SetMem(0x270798B, ghost4);
            byte[] ghost5 = new byte[] { 0x40, 0x10 };
            Functions.SetMem(0x27079BF, ghost5);
            byte[] ghost6 = new byte[] { 0x04, 0x01 };
            Functions.SetMem(0x27079F4, ghost6);
            byte[] ghost7 = new byte[] { 0x40, 0x10 };
            Functions.SetMem(0x2707A28, ghost7);
            byte[] ghost8 = new byte[] { 0x04, 0x01 };
            Functions.SetMem(0x2707A5D, ghost8);
            byte[] ghost9 = new byte[] { 0x40, 0x10 };
            Functions.SetMem(0x2707A91, ghost9);
            byte[] ghost10 = new byte[] { 04, 81, 0x80, 0x78, 0xD5, 0x08, 0x25, 0x4D, 0x3D, 0x3D, 0x39, 0x01, 0xC4 };
            Functions.SetMem(0x2707AC6, ghost10);
        }

        private void cl1Aw_CheckedChanged(object sender)
        {
            if (cl1Aw.Checked)
            {
                awCamoTi.Start();
                cl1Ghost.Checked = false;
                cl1Nc.Checked = false;
            }
        }

        private void cl2Aw_CheckedChanged(object sender)
        {
            if (cl2Aw.Checked)
            {
                awCamoTi.Start();
                cl2Ghost.Checked = false;
                cl2Nc.Checked = false;
            }
        }

        private void cl3Aw_CheckedChanged(object sender)
        {
            if (cl3Aw.Checked)
            {
                awCamoTi.Start();
                cl3Ghost.Checked = false;
                cl3Nc.Checked = false;
            }
        }

        private void cl4Aw_CheckedChanged(object sender)
        {
            if (cl4Aw.Checked)
            {
                awCamoTi.Start();
                cl4Ghost.Checked = false;
                cl4Nc.Checked = false;
            }
        }

        private void cl5Aw_CheckedChanged(object sender)
        {
            if (cl5Aw.Checked)
            {
                awCamoTi.Start();
                cl5Ghost.Checked = false;
                cl5Nc.Checked = false;
            }
        }

        private void cl6Aw_CheckedChanged(object sender)
        {
            if (cl6Aw.Checked)
            {
                awCamoTi.Start();
                cl6Ghost.Checked = false;
                cl6Nc.Checked = false;
            }
        }

        private void cl7Aw_CheckedChanged(object sender)
        {
            if (cl7Aw.Checked)
            {
                awCamoTi.Start();
                cl7Ghost.Checked = false;
                cl7Nc.Checked = false;
            }
        }

        private void cl8Aw_CheckedChanged(object sender)
        {
            if (cl8Aw.Checked)
            {
                awCamoTi.Start();
                cl8Ghost.Checked = false;
                cl8Nc.Checked = false;
            }
        }

        private void cl9Aw_CheckedChanged(object sender)
        {
            if (cl9Aw.Checked)
            {
                awCamoTi.Start();
                cl9Ghost.Checked = false;
                cl9Nc.Checked = false;
            }
        }

        private void cl10Aw_CheckedChanged(object sender)
        {
            if (cl10Aw.Checked)
            {
                awCamoTi.Start();
                cl10Ghost.Checked = false;
                cl10Nc.Checked = false;
            }
        }

        private void allKnifeAw_Click(object sender, EventArgs e)
        {
            Functions.SetMem(0x27078ED, new byte[] { 0x40, 0x18 });
            Functions.SetMem(0x2707922, new byte[] { 0x84, 0x01 });
            Functions.SetMem(0x2707956, new byte[] { 0x40, 0x18 });
            Functions.SetMem(0x270798B, new byte[] { 0x84, 0x01 });
            Functions.SetMem(0x27079BF, new byte[] { 0x40, 0x18 });
            Functions.SetMem(0x27079F4, new byte[] { 0x84, 0x01 });
            Functions.SetMem(0x2707A28, new byte[] { 0x40, 0x18 });
            Functions.SetMem(0x2707A5D, new byte[] { 0x84, 0x01 });
            Functions.SetMem(0x2707A91, new byte[] { 0x40, 0x18 });
            Functions.SetMem(0x2707AC6, new byte[] { 0x84, 81, 0x80, 0x78, 0xD5, 0x08, 0x25, 0x4D, 0x3D, 0x3D, 0x39, 0x01, 0xC4 });
        }

        private void cl1Nc_CheckedChanged(object sender)
        {
            if (cl1Nc.Checked)
            {
                ncCamoTi.Start();
                cl1Ghost.Checked = false;
                cl1Aw.Checked = false;
            }
        }

        private void cl4Nc_CheckedChanged(object sender)
        {
            if (cl4Nc.Checked)
            {
                ncCamoTi.Start();
                cl4Ghost.Checked = false;
                cl4Aw.Checked = false;
            }
        }

        private void cl5Nc_CheckedChanged(object sender)
        {
            if (cl5Nc.Checked)
            {
                ncCamoTi.Start();
                cl5Ghost.Checked = false;
                cl5Aw.Checked = false;
            }
        }

        private void cl3Nc_CheckedChanged(object sender)
        {
            if (cl3Nc.Checked)
            {
                ncCamoTi.Start();
                cl3Ghost.Checked = false;
                cl3Aw.Checked = false;
            }
        }

        private void cl2Nc_CheckedChanged(object sender)
        {
            if (cl2Nc.Checked)
            {
                ncCamoTi.Start();
                cl2Ghost.Checked = false;
                cl2Aw.Checked = false;
            }
        }

        private void cl6Nc_CheckedChanged(object sender)
        {
            if (cl6Nc.Checked)
            {
                ncCamoTi.Start();
                cl6Ghost.Checked = false;
                cl6Aw.Checked = false;
            }
        }

        private void cl7Nc_CheckedChanged(object sender)
        {
            if (cl7Nc.Checked)
            {
                ncCamoTi.Start();
                cl7Ghost.Checked = false;
                cl7Aw.Checked = false;
            }
        }

        private void cl8Nc_CheckedChanged(object sender)
        {
            if (cl8Nc.Checked)
            {
                ncCamoTi.Start();
                cl8Ghost.Checked = false;
                cl8Aw.Checked = false;
            }
        }

        private void cl9Nc_CheckedChanged(object sender)
        {
            if (cl9Nc.Checked)
            {
                ncCamoTi.Start();
                cl9Ghost.Checked = false;
                cl9Aw.Checked = false;
            }
        }

        private void cl10Nc_CheckedChanged(object sender)
        {
            if (cl10Nc.Checked)
            {
                ncCamoTi.Start();
                cl10Ghost.Checked = false;
                cl10Aw.Checked = false;
            }
        }

        private void allKnifeNc_Click(object sender, EventArgs e)
        {
            Functions.SetMem(0x27078ED, new byte[] { 0x80, 0x04 });
            Functions.SetMem(0x2707922, new byte[] { 0x48 });
            Functions.SetMem(0x2707956, new byte[] { 0x80, 0x04 });
            Functions.SetMem(0x270798B, new byte[] { 0x48 });
            Functions.SetMem(0x27079BF, new byte[] { 0x80, 0x04 });
            Functions.SetMem(0x27079F4, new byte[] { 0x48 });
            Functions.SetMem(0x2707A28,  new byte[] { 0x80, 0x04 });
            Functions.SetMem(0x2707A5D, new byte[] { 0x48 });
            Functions.SetMem(0x2707A91, new byte[] { 0x80, 0x04 });
            Functions.SetMem(0x2707AC6, new byte[] { 0x48, 0x80, 0x78, 0xD5, 0x08, 0x25, 0x4D, 0x3D, 0x3D, 0x39, 0x01, 0xC4 });
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl1, textBox120.Text);
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl2, textBox121.Text);
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl3, textBox122.Text);
        }

        private void flatButton130_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl4, textBox123.Text);
        }

        private void flatButton170_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl5, textBox124.Text);
        }

        private void flatButton171_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl6, textBox125.Text);
        }

        private void flatButton172_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl7, textBox126.Text);
        }

        private void flatButton173_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl8, textBox127.Text);
        }

        private void flatButton174_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl9, textBox128.Text);
        }

        private void flatButton175_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl10, textBox129.Text);
        }

        private void flatButton176_Click(object sender, EventArgs e)
        {
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl1, textBox120.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl2, textBox121.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl3, textBox122.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl4, textBox123.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl5, textBox124.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl6, textBox125.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl7, textBox126.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl8, textBox127.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl9, textBox128.Text);
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl10, textBox129.Text);
        }

        private void mapChangerBtn_Click(object sender, EventArgs e)
        {
            try
            { Func.MapCommand(String.Format("set ui_mapname mp_{0};wait 10;map mp_{1}\0", BIS.Lobby.MapNames[mapSelector.SelectedIndex], BIS.Lobby.MapNames[mapSelector.SelectedIndex])); }
            catch
            { MessageBox.Show("Select a map first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }

        private void rstMapBtn_Click(object sender, EventArgs e)
        {
            Func.MapCommand("Fast_restart");
        }
        bool LLobby;
        public static string WeaponNameCombo = "";
        private void loadLoBtn_Click(object sender, EventArgs e)
        {
            if (!LLobby)
            {
                MessageBox.Show("Before using this you have to disable :\n-Client Ammo\n-RapidFire\n-All Perks\n\nOtherwise May Freeze\n\nEnjoy :)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LLobby = true;
            }
            else
            {
                WeaponNameCombo = lobbyWea.Text;
                ballistaAlert.kind = theme.FlatAlertBox._Kind.Info;
                ballistaAlert.Text = "Loading ..."; ballistaAlert.Refresh();
                ballistaAlert.Visible = true;
                flatTabControl1.Enabled = false;

                Func.LobbyMods.WeaponLobby.LoadLobbyinTh(BIS.Client.LobbyWeapon_Index[lobbyWea.SelectedIndex], (byte)bulletsNum.Value, (byte)inClipNum.Value, true);
                flatTabControl1.Enabled = true;
                ballistaAlert.kind = theme.FlatAlertBox._Kind.Success;
                ballistaAlert.Text = "Done"; ballistaAlert.Refresh();
                //RPC.iPrintln(-1, "^5EveryOne Got ^3 [ " + lobbyWea.Text + " ]" + " ^4Enjoy");
            }
            
        }

        private void scoDefprPerKillBtn_Click(object sender, EventArgs e)
        {
            Func.ScorePerKil("100");
        }

        private void scoreLimitBtn_Click(object sender, EventArgs e)
        {
            Func.ScoreLimit(scoreLimitBox.Text);
        }

        private void mapStaTi_Tick(object sender, EventArgs e)
        {
            Func.MapNameinLoop = Func.ServerInfo.MapName();
            if (Func.MapNameinLoop != Func.MapNameLocation)
            {
                mapSta.Text = "New Map";
                mapSta.Refresh();
                teleportGroubBox.Enabled = false;
                flatCheckBox13.Checked = false;
                flatCheckBox12.Checked = false;
                flatCheckBox11.Checked = false;
                flatCheckBox10.Checked = false;
                flatCheckBox9.Checked = false;
                flatCheckBox8.Checked = false;
                flatCheckBox7.Checked = false;
                flatCheckBox6.Checked = false;
                flatCheckBox5.Checked = false;
                flatCheckBox4.Checked = false;
                flatCheckBox3.Checked = false;
                flatCheckBox2.Checked = false;
                mapStaTi.Stop();
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Host : {0} \nMap Name :  " + Func.ServerInfo.MapInfo() + "  /   " + Func.ServerInfo.MapName() + "\nGame Type :  " + Func.ServerInfo.GameInfo() + "  /   " + Func.ServerInfo.GameType(),Func.ServerInfo.GetHostName()));
        }

        private void forceHostBtn_Click(object sender, EventArgs e)
        {
            if (forceHostBtn.Text == "Force Host [ On ]")
            {
                Functions.SetMem(0x01cd6018, new byte[1]);
                RPC.cbuf_addtext("party_connectToOthers 0");
                RPC.cbuf_addtext("partyMigrate_disabled 1");
                RPC.cbuf_addtext("party_mergingEnabled 0");
                RPC.cbuf_addtext("allowAllNAT 1");
                forceHostBtn.Text = "Force Host [ Off ]";
            }
            else if (forceHostBtn.Text == "Force Host [ Off ]")
            {
                RPC.cbuf_addtext("party_connectToOthers 1");
                RPC.cbuf_addtext("partyMigrate_disabled 0");
                RPC.cbuf_addtext("party_mergingEnabled 1");
                RPC.cbuf_addtext("allowAllNAT 0");
                Functions.SetMem(0x01cd6018, new byte[] { 0x01 });
                minPlayersTi.Stop();
                remainingTi.Stop();
                startInTi.Stop();
                timeRemainingNum.Value = 45;
                minPlayersNum.Value = 6;
                startInNum.Value = 10;
                forceHostBtn.Text = "Force Host [ On ]";
            }
        }
        private void forceHostTi_Tick(object sender, EventArgs e)
        {
            Functions.WriteByte(0x01cd649b, (byte)timeRemainingNum.Value);
        }

        private void forceHoptionsTi_Tick(object sender, EventArgs e)
        {
            Functions.WriteByte(0x01cd5a1b, (byte)minPlayersNum.Value);
        }

        private void minPlayersNum_Click(object sender, EventArgs e)
        {
            if (minPlayersNum.Value != 6)
            {
                minPlayersTi.Start();
            }
            else
            {
                minPlayersTi.Stop();
            }
        }

        private void timeRemainingNum_Click(object sender, EventArgs e)
        {
            if (timeRemainingNum.Value != 45)
            {
                remainingTi.Start();
            }
            else
            {
                remainingTi.Stop();
            }
        }

        private void startInNum_Click(object sender, EventArgs e)
        {
            if (startInNum.Value != 10)
            {
                startInTi.Start();
            }
            else
            {
                startInTi.Stop();
            }
        }

        private void startInTi_Tick(object sender, EventArgs e)
        {
            Functions.WriteByte(0x01cd5b3b, (byte)startInNum.Value);
        }

        private void rotMap_CheckedChanged(object sender)
        {
            if (rotMap.Checked)
            {
                Functions.SetMem(Offsets.NonHost.RotateMap, BIS.NonHost.RotateMapOn);
            }
            else
            {
                Functions.SetMem(Offsets.NonHost.RotateMap, BIS.NonHost.RotateMapOff);
            }
        }

        private void clanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Clan_Index = { "DeLw", "WLzx", "Hnyw", "i", "LoVe", "You", "All", ".." };
            Func.Clan.SetClan(Clan_Index[clanCombo.SelectedIndex]);
        }

        private void flatButton178_Click(object sender, EventArgs e)
        {
            SetName("|- ^5iWLz^3");
        }

        private void flatButton179_Click(object sender, EventArgs e)
        {
            SetName("|- ^3CY6RH");
        }

        private void flatButton180_Click(object sender, EventArgs e)
        {
            SetName("|- ^6iiRAR");
        }

        private void flatButton181_Click(object sender, EventArgs e)
        {
            SetName("|- ^1BISOON");
        }

        private void flatButton182_Click(object sender, EventArgs e)
        {
            SetName("|- ^6IM-83^7 ..");
        }

        private void flatButton183_Click(object sender, EventArgs e)
        {
            SetName("^5Dictator^1Hack");
        }

        private void flatButton189_Click(object sender, EventArgs e)
        {
            SetName("^5Arab^7Modding");
        }

        private void flatButton188_Click(object sender, EventArgs e)
        {
            SetName("rRWC ^1<3^7");
        }

        private void flatButton187_Click(object sender, EventArgs e)
        {
            SetName("|- ^2IMx01");
        }

        private void flatButton186_Click(object sender, EventArgs e)
        {
            SetName("^9BoZeX^7");
        }

        private void flatButton185_Click(object sender, EventArgs e)
        {
            SetName("^4o-SkiLL-^7");
        }

        private void flatButton184_Click(object sender, EventArgs e)
        {
            SetName("^5Black ^7Skull");
        }
        frNameFrm frFrm;
        public static bool frFrmbool = false;
        private void friendfrmBtn_Click(object sender, EventArgs e)
        {
            if (!frFrmbool)
            {
                frFrm = new frNameFrm();
                frFrm.Show();
                frFrmbool = true;
            }
            else
            {
                frFrm.Activate();
            }
            
        }

        private void resetLobbyBtn_Click(object sender, EventArgs e)
        {
            gravityLobby.Value = 0;
            noclipLobby.Value = 0;
            lobbyJump.Value = 0;
            lobbySpeed.Value = 5;
            meleeLobby.Value = 0;
            timescaleLobby.Value = 9;
            camDurationtrack.Value = 10;
            noClipBar.Value = 0;
            fovLobbyBar.Value = 65;
            noMeleeBar.Value = 0;
        }

        private void ghostCamoTi_Tick(object sender, EventArgs e)
        {
            if (cl1Ghost.Checked)
            {
                Functions.SetMem(0x27078c0, new byte[] { 4, 1 });
                Functions.SetMem(0x27078ce, new byte[] { 0x82 });
                Functions.SetMem(0x2707CD2, new byte[] { 0x82 });
                Functions.SetMem(0x2707CE0, new byte[] { 0x41 });
                Functions.SetMem(0x2707B74, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707B82, new byte[] { 0x10, 0x04 });
            }
            if (cl2Ghost.Checked)
            {
                Functions.SetMem(0x27078F4, new byte[] { 0x40, 0x10 });
                Functions.SetMem(0x2707902, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707D06, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707D14, new byte[] { 0x10, 0x04 });
                Functions.SetMem(0x2707BA9, new byte[] { 0x82 });
                Functions.SetMem(0x2707BB7, new byte[] { 0x41 });
            }
            if (cl3Ghost.Checked)
            {
                Functions.SetMem(0x2707929,  new byte[] { 0x04, 0x01 });
                Functions.SetMem(0x2707937, new byte[] { 0x82 });
                Functions.SetMem(0x2707D3B, new byte[] { 0x82 });
                Functions.SetMem(0x2707D49, new byte[] { 0x41 });
                Functions.SetMem(0x2707BDD, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707BEB, new byte[] { 0x10, 0x04 });
            }
            if (cl4Ghost.Checked)
            {
                Functions.SetMem(0x270795D, new byte[] { 0x40, 0x10 });
                Functions.SetMem(0x270796B, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707D6F, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707D7D, new byte[] { 0x10, 0x04 });
                Functions.SetMem(0x2707C12, new byte[] { 0x82 });
                Functions.SetMem(0x2707C20, new byte[] { 0x41 });
            }
            if (cl5Ghost.Checked)
            {
                Functions.SetMem(0x2707992, new byte[] { 0x04, 0x01 });
                Functions.SetMem(0x27079A0, new byte[] { 0x82 });
                Functions.SetMem(0x2707DA4, new byte[] { 0x82 });
                Functions.SetMem(0x2707DB2, new byte[] { 0x41 });
                Functions.SetMem(0x2707C46, new byte[] { 0x20, 0x08 });
                Functions.SetMem(0x2707C54, new byte[] { 0x10, 0x04 });
            }
            if (cl6Ghost.Checked)
            {
                Functions.SetMem(0x27079C6, new byte[] { 0x40, 0x10 });
                Functions.SetMem(0x27079D4, new byte[] { 0x20, 0x08 });
            }
            if (cl7Ghost.Checked)
            {
                Functions.SetMem(0x27079FB, new byte[] { 0x04, 0x01 });
                Functions.SetMem(0x2707A09, new byte[] { 0x82 });
            }
            if (cl8Ghost.Checked)
            {
                Functions.SetMem(0x2707A2F, new byte[] { 0x40, 0x10 });
                Functions.SetMem(0x2707A3D,  new byte[] { 0x20, 0x08 });
            }
            if (cl9Ghost.Checked)
            {
                Functions.SetMem(0x2707A64, new byte[] { 0x04, 0x01 });
                Functions.SetMem(0x2707A72, new byte[] { 0x82 });
            }
            if (cl10Ghost.Checked)
            {
                Functions.SetMem(0x2707A98, new byte[] { 0x40, 0x10 });
                Functions.SetMem(0x2707AA6, new byte[] { 0x20, 0x08 });
            }
        }

        private void awCamoTi_Tick(object sender, EventArgs e)
        {
            if (cl1Aw.Checked)
            {
                Functions.SetMem(0x27078c0, new byte[] { 0x84, 1 });
                Functions.SetMem(0x27078CE, new byte[] { 0xC2 });
                Functions.SetMem(0x2707B74, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707B82, new byte[] { 0x10, 0x06 });
                Functions.SetMem(0x2707CD2, new byte[] { 0xC2 });
                Functions.SetMem(0x2707CE0, new byte[] { 0x61 });
            }
            if (cl2Aw.Checked)
            {
                Functions.SetMem(0x27078F4, new byte[] { 0x40, 0x18 });
                Functions.SetMem(0x2707902, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707BA9, new byte[] { 0xC2 });
                Functions.SetMem(0x2707BB7, new byte[] { 0x61 });
                Functions.SetMem(0x2707D06, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707D14, new byte[] { 0x10, 0x06 });
            }
            if (cl3Aw.Checked)
            {
                Functions.SetMem(0x2707929, new byte[] { 0x84, 1 });
                Functions.SetMem(0x2707937, new byte[] { 0xC2 });
                Functions.SetMem(0x2707BDD, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707BEB, new byte[] { 0x10, 0x06 });
                Functions.SetMem(0x2707D3B, new byte[] { 0xC2 });
                Functions.SetMem(0x2707D49, new byte[] { 0x61 });
            }
            if (cl4Aw.Checked)
            {
                Functions.SetMem(0x270795D, new byte[] { 0x40, 0x18 });
                Functions.SetMem(0x270796B, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707C12, new byte[] { 0xC2 });
                Functions.SetMem(0x2707C20, new byte[] { 0x61 });
                Functions.SetMem(0x2707D6F, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707D7D, new byte[] { 0x10, 0x06 });
            }
            if (cl5Aw.Checked)
            {
                Functions.SetMem(0x2707992, new byte[] { 0x84, 1 });
                Functions.SetMem(0x27079A0, new byte[] { 0xC2 });
                Functions.SetMem(0x2707C46, new byte[] { 0x20, 0x0C });
                Functions.SetMem(0x2707C54, new byte[] { 0x10, 0x06 });
                Functions.SetMem(0x2707DA4, new byte[] { 0xC2 });
                Functions.SetMem(0x2707DB2, new byte[] { 0x61 });
            }
            if (cl6Aw.Checked)
            {
                Functions.SetMem(0x27079C6, new byte[] { 0x40, 0x18 });
                Functions.SetMem(0x27079D4, new byte[] { 0x20, 0x0C });
            }
            if (cl7Aw.Checked)
            {
                Functions.SetMem(0x27079FB, new byte[] { 0x84, 1 });
                Functions.SetMem(0x2707A09, new byte[] { 0xC2 });
            }
            if (cl8Aw.Checked)
            {
                Functions.SetMem(0x2707A2F, new byte[] { 0x40, 0x18 });
                Functions.SetMem(0x2707A3D, new byte[] { 0x20, 0x0C });
            }
            if (cl9Aw.Checked)
            {
                Functions.SetMem(0x2707A64, new byte[] { 0x84, 1 });
                Functions.SetMem(0x2707A72, new byte[] { 0xC2 });
            }
            if (cl10Aw.Checked)
            {
                Functions.SetMem(0x2707A98, new byte[] { 0x40, 0x18 });
                Functions.SetMem(0x2707AA6, new byte[] { 0x20, 0x0C });
            }
        }

        private void ncCamoTi_Tick(object sender, EventArgs e)
        {
            if (cl1Nc.Checked)
            {
                Functions.SetMem(0x27078c0, new byte[] { 0x48 });
                Functions.SetMem(0x27078CE, new byte[] { 0x24 });
                Functions.SetMem(0x2707B74, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707B82, new byte[] { 0x20, 0x01 });
                Functions.SetMem(0x2707CD2, new byte[] { 0x24 });
                Functions.SetMem(0x2707CE0, new byte[] { 0x12 });
            }
            if (cl2Nc.Checked)
            {
                Functions.SetMem(0x27078F4, new byte[] { 0x80, 0x04 });
                Functions.SetMem(0x2707902, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707BA9, new byte[] { 0x24 });
                Functions.SetMem(0x2707BB7, new byte[] { 0x12 });
                Functions.SetMem(0x2707D06, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707D14, new byte[] { 0x20, 0x01 });
            }
            if (cl3Nc.Checked)
            {
                Functions.SetMem(0x2707929, new byte[] { 0x48 });
                Functions.SetMem(0x2707937, new byte[] { 0x24 });
                Functions.SetMem(0x2707BDD, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707BEB, new byte[] { 0x20, 0x01 });
                Functions.SetMem(0x2707D3B, new byte[] { 0x24 });
                Functions.SetMem(0x2707D49, new byte[] { 0x12 });
            }
            if (cl4Nc.Checked)
            {
                Functions.SetMem(0x270795D, new byte[] { 0x80, 0x04 });
                Functions.SetMem(0x270796B, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707C12, new byte[] { 0x24 });
                Functions.SetMem(0x2707C20, new byte[] { 0x12 });
                Functions.SetMem(0x2707D6F, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707D7D, new byte[] { 0x20, 0x01 });
            }
            if (cl5Nc.Checked)
            {
                Functions.SetMem(0x2707992, new byte[] { 0x48 });
                Functions.SetMem(0x27079A0, new byte[] { 0x24 });
                Functions.SetMem(0x2707C46, new byte[] { 0x40, 0x02 });
                Functions.SetMem(0x2707C54, new byte[] { 0x20, 0x01 });
                Functions.SetMem(0x2707DA4, new byte[] { 0x24 });
                Functions.SetMem(0x2707DB2, new byte[] { 0x12 });
            }
            if (cl6Nc.Checked)
            {
                Functions.SetMem(0x27079C6, new byte[] { 0x80, 0x04 });
                Functions.SetMem(0x27079D4, new byte[] { 0x40, 0x02 }); 
            }
            if (cl7Nc.Checked)
            {
                Functions.SetMem(0x27079FB, new byte[] { 0x48 });
                Functions.SetMem(0x2707A09, new byte[] { 0x24 });  
            }
            if (cl8Nc.Checked)
            {
                Functions.SetMem(0x2707A2F, new byte[] { 0x80, 0x04 });
                Functions.SetMem(0x2707A3D, new byte[] { 0x40, 0x02 });
            }
            if (cl9Nc.Checked)
            {
                Functions.SetMem(0x2707A64, new byte[] { 0x48 });
                Functions.SetMem(0x2707A72, new byte[] { 0x24 });
            }
            if (cl10Nc.Checked)
            {
                Functions.SetMem(0x2707A98, new byte[] { 0x80, 0x04 });
                Functions.SetMem(0x2707AA6, new byte[] { 0x40, 0x02 });   
            }
        }

        private void playerMaxBtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.InPartyMaxPlayer, playerXMaxBox.Text);
        }

        private void xOnlineBtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Online, xOnlineBox.Text);

        }

        private void addConBtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.AddControler, addCoBox.Text);
        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.OPTIONS, optionBox.Text);
        }

        private void defplayerMax_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.InPartyMaxPlayer, "&&1 Player (&&2 Max)");
        }

        private void defAddCo_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.AddControler, "Add controller For Split Screen");
        }

        private void defxOnline_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.Online, "&&1 Online");
        }

        private void defOptions_Click(object sender, EventArgs e)
        {
            Functions.WriteStr((uint)Offsets.ChangeStr.StrOffset.OPTIONS, "OPTIONS");
        }

        private void rapidFireBtn_Click(object sender, EventArgs e)
        {
            if (rapidFireBtn.Text == "RapidFire [ On ]")
            {
                Func.LobbyMods.RapidFire(true);
                rapidFireBtn.Text = "RapidFire [ Off ]";
            }
            else if (rapidFireBtn.Text == "RapidFire [ Off ]")
            {
                Func.LobbyMods.RapidFire(false);
                rapidFireBtn.Text = "RapidFire [ On ]";
            }
        }

        private void bisoonClassBtn_Click(object sender, EventArgs e)
        {
            byte[] _bisoon = new byte[] { 0xB0 };
            Functions.SetMem(0x27078BA, _bisoon);
            _bisoon = new byte[] { 0x22 };
            Functions.SetMem(0x27078C8, _bisoon);
            _bisoon = new byte[] { 0x94, 0x95, 0x9D, 0x9C, 0xA1, 0xA2 };
            Functions.SetMem(0x27078D6, _bisoon);
            _bisoon = new byte[] { 0x4B, 0x02, 0x93, 0x12, 0x59 };
            Functions.SetMem(0x27078DC, _bisoon);
            _bisoon = new byte[] { 0x00, 0x41, 0x01 };
            Functions.SetMem(0x27078E7, _bisoon);
            _bisoon = new byte[] { 0xC0, 0x01, 0x01 };
            Functions.SetMem(0x27078EA, _bisoon);
        }

        private void im83ClassBtn_Click(object sender, EventArgs e)
        {
            byte[] im83s1 = new byte[] { 0x10 };
            Functions.SetMem(0x27078BA, im83s1);
            byte[] im83s2 = new byte[] { 0x72 };
            Functions.SetMem(0x27078C8, im83s2);
            byte[] im83s3 = new byte[] { 0x94, 0x9A, 0xA2, 0x95, 0x9C, 0x9E };
            Functions.SetMem(0x27078D6, im83s3);
            byte[] im83s4 = new byte[] { 0x40, 0x04, 0x90, 0x12, 0x59 };
            Functions.SetMem(0x27078DC, im83s4);
            byte[] im83s5 = new byte[] { 0xC0, 0x01, 0x82, 0x01 };
            Functions.SetMem(0x27078E7, im83s5);
            byte[] im83s6 = new byte[] { 0x00, 0x00, 0x00 };
            Functions.SetMem(0x27078EA, im83s6);
        }

        private void o_skillClassBtn_Click(object sender, EventArgs e)
        {
            byte[] skill1 = new byte[] { 0x90 };
            Functions.SetMem(0x27078BA, skill1);
            byte[] skill2 = new byte[] { 0x32 };
            Functions.SetMem(0x27078C8, skill2);
            byte[] skill3 = new byte[] { 0x9C, 0x9A, 0x9E, 0x95, 0x9D, 0xA2 };
            Functions.SetMem(0x27078D6, skill3);
            byte[] skill4 = new byte[] { 0x0B, 0x06, 0x11, 0x12, 0x58 };
            Functions.SetMem(0x27078DC, skill4);
            byte[] skill5 = new byte[] { 0xC0, 0x81, 0xC2, 0x80, 0x80 };
            Functions.SetMem(0x27078E7, skill5);
            byte[] skill6 = new byte[] { 0x80, 0x80, 0x01, 0x40 };
            Functions.SetMem(0x27078EA, skill6);
        }
        public static bool ClassFrm = false;
        Classfrm Cfrm;
        private void flatButton5_Click(object sender, EventArgs e)
        {
            if (!ClassFrm)
            {
                Cfrm = new Classfrm();
                Cfrm.Show();
                ClassFrm = true;
            }
            else
            {
                Cfrm.Activate();
            }
        }
        bool frHbool = false;
        private void frHbtn_Click(object sender, EventArgs e)
        {
            if (!frHbool)
            {
                MessageBox.Show("I added this again ", "Important", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("رجعتها وأعتذر للجميع بس كان غصب عني لاني  غلطت وعطيتها ناس وماابي افرق بين الضعيف والقوي\nلاتسخدمها ع إخوانك اللهم إني بريء وتذكر انك داخل تستمع  :)", "Important", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frHbool = true;
            }
            Functions.SetMem(0x026C0658, new byte[] { 0x5E, 0x49, 0x99, 0x99, 0x99 });
            Thread.Sleep(30);
            Functions.WriteStr(0x026C0658, Connectionfrm.userName);
        }

        private void clientNames_Weapon_P_Click(object sender, EventArgs e)
        {
            textBox133.Text = Func.ClientMods.GetPlayerName(0);
            textBox132.Text = Func.ClientMods.GetPlayerName(1);
            textBox131.Text = Func.ClientMods.GetPlayerName(2);
            textBox130.Text = Func.ClientMods.GetPlayerName(3);
            textBox63.Text = Func.ClientMods.GetPlayerName(4);
            textBox62.Text = Func.ClientMods.GetPlayerName(5);
            textBox60.Text = Func.ClientMods.GetPlayerName(6);
            textBox59.Text = Func.ClientMods.GetPlayerName(7);
            textBox58.Text = Func.ClientMods.GetPlayerName(8);
            textBox57.Text = Func.ClientMods.GetPlayerName(9);
            textBox56.Text = Func.ClientMods.GetPlayerName(10);
            textBox55.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void flatComboBox90_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(0, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox90.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(0, "^3" + flatComboBox90.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }
        

        private void flatComboBox91_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(1, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox91.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(1, "^3" + flatComboBox91.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox92_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(2, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox92.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(2, "^3" + flatComboBox92.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox93_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(3, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox93.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(3, "^3" + flatComboBox93.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox94_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(4, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox94.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(4, "^3" + flatComboBox94.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox95_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(5, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox95.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(5, "^3" + flatComboBox95.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox96_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(6, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox96.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(6, "^3" + flatComboBox96.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox97_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(7, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox97.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(7, "^3" + flatComboBox97.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox98_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(8, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox98.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(8, "^3" + flatComboBox98.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox99_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(9, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox99.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(9, "^3" + flatComboBox99.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox100_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(10, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox100.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(10, "^3" + flatComboBox100.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox101_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon1(11, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox101.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(11, "^3" + flatComboBox101.Text + "^7  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void lobbyWea_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLoBtn.Enabled = true;
        }

        private void flatComboBox102_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(0, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox102.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(0, "^7" + flatComboBox102.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox103_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(1, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox103.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(1, "^7" + flatComboBox103.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox104_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(2, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox104.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(2, "^7" + flatComboBox104.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox105_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(3, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox105.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(3, "^7" + flatComboBox105.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox106_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(4, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox106.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(4, "^7" + flatComboBox106.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox107_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(5, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox107.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(5, "^7" + flatComboBox107.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox108_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(6, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox108.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(6, "^7" + flatComboBox108.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox109_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(7, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox109.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(7, "^7" + flatComboBox109.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox110_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(8, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox110.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(8, "^7" + flatComboBox110.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox111_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(9, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox111.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(9, "^7" + flatComboBox111.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox112_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(10, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox112.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(10, "^7" + flatComboBox112.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox113_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveWeapon2(11, Convert.ToByte(BIS.Client.Weapon_Index[flatComboBox113.SelectedIndex]), (byte)flatNumeric1.Value);
            RPC.iPrintln(11, "^7" + flatComboBox113.Text + "^3  Given");
            Func.ClientMods.GiveWBool = false;
        }

        private void flatComboBox114_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(0, BIS.Client.Weapon_Index_RPC[flatComboBox114.SelectedIndex], "Weapon Given :  ^2" + flatComboBox114.Text);
        }

        private void flatComboBox115_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(1, BIS.Client.Weapon_Index_RPC[flatComboBox115.SelectedIndex], "Weapon Given :  ^2" + flatComboBox115.Text);
        }

        private void flatComboBox116_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(2, BIS.Client.Weapon_Index_RPC[flatComboBox116.SelectedIndex], "Weapon Given :  ^2" + flatComboBox116.Text);
        }

        private void flatComboBox117_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(3, BIS.Client.Weapon_Index_RPC[flatComboBox117.SelectedIndex], "Weapon Given :  ^2" + flatComboBox117.Text);
        }

        private void flatComboBox118_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(4, BIS.Client.Weapon_Index_RPC[flatComboBox118.SelectedIndex], "Weapon Given :  ^2" + flatComboBox118.Text);
        }

        private void flatComboBox119_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(5, BIS.Client.Weapon_Index_RPC[flatComboBox119.SelectedIndex], "Weapon Given :  ^2" + flatComboBox119.Text);
        }

        private void flatComboBox120_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(6, BIS.Client.Weapon_Index_RPC[flatComboBox120.SelectedIndex], "Weapon Given :  ^2" + flatComboBox120.Text);
        }

        private void flatComboBox121_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(7, BIS.Client.Weapon_Index_RPC[flatComboBox121.SelectedIndex], "Weapon Given :  ^2" + flatComboBox121.Text);
        }

        private void flatComboBox122_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(8, BIS.Client.Weapon_Index_RPC[flatComboBox122.SelectedIndex], "Weapon Given :  ^2" + flatComboBox122.Text);
        }

        private void flatComboBox123_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(9, BIS.Client.Weapon_Index_RPC[flatComboBox123.SelectedIndex], "Weapon Given :  ^2" + flatComboBox123.Text);
        }

        private void flatComboBox124_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(10, BIS.Client.Weapon_Index_RPC[flatComboBox124.SelectedIndex], "Weapon Given :  ^2" + flatComboBox124.Text);
        }

        private void flatComboBox125_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.GiveAdditionalWeapon(11, BIS.Client.Weapon_Index_RPC[flatComboBox125.SelectedIndex], "Weapon Given :  ^2" + flatComboBox125.Text);
        }

        private void gameModesBtn_Click(object sender, EventArgs e)
        {
            try
            { Func.MapCommand(BIS.Lobby.GameModes[gameModesCombo.SelectedIndex]); }
            catch
            { MessageBox.Show("Select a game mode first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }

        private void allPlayerAntiQTi_Tick(object sender, EventArgs e)
        {
            RPC.SV_GameSendServerCommand(-1, "@ 1");
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (flatCheckBox1.Checked)
            {
                allPlayerAntiQTi.Start();
                flatCheckBox287.Checked = false;
                flatCheckBox286.Checked = false;
                flatCheckBox285.Checked = false;
                flatCheckBox284.Checked = false;
                flatCheckBox283.Checked = false;
                flatCheckBox282.Checked = false;
                flatCheckBox281.Checked = false;
                flatCheckBox280.Checked = false;
                flatCheckBox279.Checked = false;
                flatCheckBox278.Checked = false;
                flatCheckBox277.Checked = false;
                flatCheckBox276.Checked = false;
            }
            else
            {
                allPlayerAntiQTi.Stop();
            }
        }

        private void frshaccBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to reset your stats ?","Fresh Start",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Func.ClientInGame())
                {
                    RPC.cbuf_addtext("resetstats 1");
                }
                Functions.SetMem(0x26FC870, UnlockAll.ResetAcc.Reset);
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Inject.Injects(Inject.InjectMod.MultiPlayer);
        }

        private void camDurationtrack_Scroll(object sender)
        {
            RPC.KillCamDuration((int)camDurationtrack.Value);
        }

        private void fovLobbyBar_Scroll(object sender)
        {
            RPC.Fov((int)fovLobbyBar.Value);
        }

        private void noClipBar_Scroll(object sender)
        {
            if (noClipBar.Value == 0)
                Func.LobbyMods.NoClip(false);
            else if (noClipBar.Value == 1)
                Func.LobbyMods.NoClip(true);
        }

        private void antijoinBtn_On_Click(object sender, EventArgs e)
        {
            RPC.cbuf_addtext("set g_password 123456");
            RPC.cbuf_addtext("gametype_setting capturetime 11");
            antiJoinLbl.Text = "Anti Join [ On ]";
        }

        private void antijoinBtn_Off_Click(object sender, EventArgs e)
        {
            RPC.cbuf_addtext("reset g_password");
            RPC.cbuf_addtext("gametype_setting capturetime 10");
            antiJoinLbl.Text = "Anti Join [ Off ]";
        }

        private void visionLobbyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPC.Vision(-1, BIS.Lobby.Visions[visionLobbyBox.SelectedIndex]);
            RPC.iPrintln(-1, "Vision Set To : ^3  " + visionLobbyBox.Text);
        }

        private void flatButton198_Click(object sender, EventArgs e)
        {
            RPC.Clone(0);
        }

        private void flatButton197_Click(object sender, EventArgs e)
        {
            RPC.Clone(1);
        }

        private void flatButton196_Click(object sender, EventArgs e)
        {
            RPC.Clone(2);
        }

        private void flatButton195_Click(object sender, EventArgs e)
        {
            RPC.Clone(3);
        }

        private void flatButton194_Click(object sender, EventArgs e)
        {
            RPC.Clone(4);
        }

        private void flatButton193_Click(object sender, EventArgs e)
        {
            RPC.Clone(5);
        }

        private void flatButton192_Click(object sender, EventArgs e)
        {
            RPC.Clone(6);
        }

        private void flatButton191_Click(object sender, EventArgs e)
        {
            RPC.Clone(7);
        }

        private void flatButton190_Click(object sender, EventArgs e)
        {
            RPC.Clone(8);
        }

        private void flatButton177_Click(object sender, EventArgs e)
        {
            RPC.Clone(9);
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            RPC.Clone(10);
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            RPC.Clone(11);
        }

        private void noMeleeBar_Scroll(object sender)
        {
            if (noMeleeBar.Value == 0)
                Func.LobbyMods.NoMelee(false);
            else if (noMeleeBar.Value == 1)
                Func.LobbyMods.NoMelee(true);
        }

        private void cmpassNum_Scroll(object sender)
        {
            Func.NonHost.CompassSize((int)cmpassNum.Value);
        }

        private void flatButton199_Click(object sender, EventArgs e)
        {
            if (cmpassNum.Value < 6000)
            { cmpassNum.Value += 100; }
            
        }

        private void flatButton200_Click(object sender, EventArgs e)
        {
            if (cmpassNum.Value > 0)
            { cmpassNum.Value -= 100; }
        }

        private void flatButton201_Click(object sender, EventArgs e)
        {
            RPC.cbuf_addtext("reset compassMaxRange");
            cmpassNum.Value = 2500;
        }

        private void rst_Sub_BodyBtn_Click(object sender, EventArgs e)
        {
            byte[] Sub = new byte[] { 0x47, 0x61, 0x6D, 0x65, 0x20, 0x49, 0x6E, 0x76, 0x69, 0x74, 0x65 };
            byte[] Body =  new byte[] { 0x26, 0x26, 0x31, 0x20, 0x69, 0x6E, 0x76, 0x69, 0x74,0x65,
                0x73, 0x20, 0x79, 0x6F, 0x75, 0x20, 0x74,
                0x6F, 0x20, 0x70, 0x6C, 0x61, 0x79, 0x20,
                0x43, 0x61,0x6C, 0x6C, 0x20, 0x6F, 0x66, 0x20, 0x44,
                0x75, 0x74, 0x79, 0xC2, 0xAE, 0x3A, 0x20,
                0x42, 0x6C, 0x61, 0x63, 0x6B, 0x20, 0x4F,
                0x70, 0x73, 0x20, 0x49, 0x49, 0x2E };
            Functions.SetMem(0x30934206, Sub);
            Functions.SetMem(0x30934223, Body);

            subBox.Text = Encoding.UTF8.GetString(Sub);
            msgBox.Text = Encoding.UTF8.GetString(Body).Replace("&&1", Connectionfrm.userName);
        }

        private void targetFinder_CheckedChanged(object sender)
        {
            if (targetFinder.Checked)
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.TargetFinder_On);
            }
            else
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.TargetFinder_Off);
            }
        }

        private void noAimCh_CheckedChanged(object sender)
        {
            if (noAimCh.Checked)
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.NoAim_On);
            }
            else
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.NoAim_Off);
            }
        }

        private void splitScreenCh_CheckedChanged(object sender)
        {
            if (splitScreenCh.Checked)
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.SplitScreen_On);
            }
            else
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.SplitScreen_Off);
            }
        }

        private void blackHoleCh_CheckedChanged(object sender)
        {
            if (blackHoleCh.Checked)
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.WeirdView_On);
            }
            else
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.WeirdView_Off);
            }
        }

        private void invisibleWeaponCh_CheckedChanged(object sender)
        {
            if (invisibleWeaponCh.Checked)
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.InvisibleWeapon_On);
            }
            else
            {
                Func.NonHost.SetModz(Func.NonHost.NonHostModz.InvisibleWeapon_Off);
            }
        }

        private void blurNum_Click(object sender, EventArgs e)
        {
            Func.NonHost.Blur((int)blurNum.Value);
        }

        private void visionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.NonHost.Vision(Func.NonHost.Visionss[visionCombo.SelectedIndex]);
        }
        private void flatButton202_Click(object sender, EventArgs e)
        {
            SaveFile.SaveBinFile(0x26FC870, 0x1C270, "Stats", "Stats");
        }

        private void flatButton203_Click(object sender, EventArgs e)
        {
            SaveFile.LoadBinFile(0x26FC870, "Stats", "Stats");
            ClassNames.SetClass(ClassNames.ClassNamesOffsets.Cl10, "[^8 BISOON ^7]");
            Functions.SetMem(0x2707C75, new byte[]{ 0xB2, 0xA8, 0x40, 0x74, 0x00, 0x6E, 0x6E, 0xF0, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x84, 0x92, 0xA6, 0x9E, 0x9E, 0x9C, 0x00, 0xF0,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xA6, 0xEA, 0x84, 0x40, 0xF8, 0x40, 0xA6,
                0xD0, 0xC2, 0xE4, 0xCA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x82, 0xE4, 0xC2, 0xC4, 0x9A, 0xDE,
                0xC8, 0xC8, 0xD2, 0xDC, 0xCE, 0x5C, 0xC6, 0xDE, 0xDA, 0x00, 0x92, 0x40, 0x98, 0xDE, 0xEC,
                0xCA, 0x40, 0xF2, 0xDE, 0xEA, 0x40, 0x78, 0x66, 0x00 });
        }

        private void rstAllBtn_Click(object sender, EventArgs e)
        {
            Func.changeStr.ChangeString(false);
        }

        private void setText_SW_Click(object sender, EventArgs e)
        {
            if (leftCh.Checked)
                DoHeartWriter.location = 80;
            else if (middleCh.Checked)
                DoHeartWriter.location = 260;
            else if (rightCh.Checked)
                DoHeartWriter.location = 500;
            if (setText_SW.Text == "Send")
            {
                flatAlertBox1.Text = "Sending";
                flatAlertBox1.kind = theme.FlatAlertBox._Kind.Info;
                flatAlertBox1.Visible = true;
                flatTabControl1.Enabled = false;
                DText.TypeText(textBox_SW.Text);
                ////flatAlertBox1.Text = "Done";
                //flatAlertBox1.kind = theme.FlatAlertBox._Kind.Success;
                //flatAlertBox1.Visible = true;
                flatTabControl1.Enabled = true;
            }
        }
        public class DText
        {
            static string TEXT = "";
            static void RunText()
            {
                try
                {
                    Connectionfrm.Connector.ThreadConnector();
                    DoHeartWriter.SetText_SW(0, TEXT, true);
                    DoHeartWriter.SetText_SW(1, TEXT, true);
                    DoHeartWriter.SetText_SW(2, TEXT, true);
                    DoHeartWriter.SetText_SW(3, TEXT, true);
                    DoHeartWriter.SetText_SW(4, TEXT, true);
                    DoHeartWriter.SetText_SW(5, TEXT, true);
                    DoHeartWriter.SetText_SW(6, TEXT, true);
                    DoHeartWriter.SetText_SW(7, TEXT, true);
                    DoHeartWriter.SetText_SW(8, TEXT, true);
                    DoHeartWriter.SetText_SW(9, TEXT, true);
                    DoHeartWriter.SetText_SW(10, TEXT, true);
                    DoHeartWriter.SetText_SW(11, TEXT, true);
                }
                catch
                {

                }
            }
            static Thread TypeThread;
            public static void TypeText(string newText)
            {
                try
                {
                    TypeThread = new Thread(() => RunText());
                    TEXT = newText;
                    TypeThread.Start();
                }
                catch { TypeThread.Abort(); MessageBox.Show("There was Error\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void zmInject_Click(object sender, EventArgs e)
        {
            Inject.Injects(Inject.InjectMod.Zombie);
        }

        private void imageInjector_Click(object sender, EventArgs e)
        {
            flatTabControl1.Enabled = false;
            BG.ChangeBG();
            flatTabControl1.Enabled = true;
        }

        private void nuEndBtn_Click(object sender, EventArgs e)
        {
            if (Func.ServerInfo.MapName() == "Nuketown 2025")
            {
                RPC.SV_GameSendServerCommand(-1, ": 1");
            }
            else
            {
                MessageBox.Show("The Map isn't Nuketown 2025", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rstClanBtn_Click_1(object sender, EventArgs e)
        {
            clanBox.Text = Connectionfrm.userClan;
            Func.Clan.SetClan(clanBox.Text);
        }

        private void TWDHfrmBtn_Click(object sender, EventArgs e)
        {
            TWDH tfrm = new TWDH();
            tfrm.Show();
        }

        private void flatCheckBox14_CheckedChanged(object sender)
        {
            if (flatCheckBox14.Checked)
            {
                Func.inThread = true;
            }
            else
            {
                Func.inThread = false;
            }
        }

        private void BOIIfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Func.ClientMods.GMTHR.();
        }

        private void antiFBtn_Click(object sender, EventArgs e)
        {
            if (antiFBtn.Text == "AntiFreeze [ On ]")
            {
                Func.NonHost.ADAntiFreeze(false);
                Func.NonHost.AntiFreez(true);
                MessageBox.Show("AntiFreeze Enabled \n- No Freeze\n\nEnjoy", "RTM By BISOON", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                antiFBtn.Text = "AntiFreeze [ Off ]";
                aAntiFBtn.Text = "AntiFreeze [ On ]";
                aAntiFBtn.Refresh();
            }
            else if (antiFBtn.Text == "AntiFreeze [ Off ]")
            {
                Func.NonHost.AntiFreez(false);
                antiFBtn.Text = "AntiFreeze [ On ]";
            }
        }

        private void aAntFBtn_Click(object sender, EventArgs e)
        {
            if (aAntiFBtn.Text == "AntiFreeze [ On ]")
            {
                Func.NonHost.ADAntiFreeze(true);
                Func.NonHost.AntiFreez(true);
                MessageBox.Show("Advanced AntiFreeze Enabled \n- No Lag\n- No Freeze\n\nEnjoy ~ ", "RTM By BISOON", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                aAntiFBtn.Text = "AntiFreeze [ Off ]";
                antiFBtn.Text = "AntiFreeze [ On ]";
                antiFBtn.Refresh();
            }
            else if (aAntiFBtn.Text == "AntiFreeze [ Off ]")
            {
                Func.NonHost.AntiFreez(false);
                aAntiFBtn.Text = "AntiFreeze [ On ]";
            }
        }

        private void flatComboBox126_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox126.Text, 0);
        }

        private void flatComboBox127_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox127.Text, 1);
        }

        private void flatComboBox128_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox128.Text, 2);
        }

        private void flatComboBox129_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox129.Text, 3);
        }

        private void flatComboBox130_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox130.Text, 4);
        }

        private void flatComboBox131_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox131.Text, 5);
        }

        private void flatComboBox132_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox132.Text, 6);
        }

        private void flatComboBox133_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox133.Text, 7);
        }

        private void flatComboBox134_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox134.Text, 8);
        }

        private void flatComboBox135_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox135.Text, 9);
        }

        private void flatComboBox136_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox136.Text, 10);
        }

        private void flatComboBox137_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.SpawnEntity(flatComboBox137.Text, 11);
        }

        private void clientNames7_Click(object sender, EventArgs e)
        {
            textBox145.Text = Func.ClientMods.GetPlayerName(0);
            textBox144.Text = Func.ClientMods.GetPlayerName(1);
            textBox143.Text = Func.ClientMods.GetPlayerName(2);
            textBox142.Text = Func.ClientMods.GetPlayerName(3);
            textBox141.Text = Func.ClientMods.GetPlayerName(4);
            textBox140.Text = Func.ClientMods.GetPlayerName(5);
            textBox139.Text = Func.ClientMods.GetPlayerName(6);
            textBox138.Text = Func.ClientMods.GetPlayerName(7);
            textBox137.Text = Func.ClientMods.GetPlayerName(8);
            textBox136.Text = Func.ClientMods.GetPlayerName(9);
            textBox135.Text = Func.ClientMods.GetPlayerName(10);
            textBox134.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void flatCheckBox38_CheckedChanged(object sender)
        {
            if (flatCheckBox38.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(0, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(0, false);
            }
        }

        private void flatCheckBox37_CheckedChanged(object sender)
        {
            if (flatCheckBox37.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(1, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(1, false);
            }
        }

        private void flatCheckBox36_CheckedChanged(object sender)
        {
            if (flatCheckBox36.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(2, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(2, false);
            }
        }

        private void flatCheckBox35_CheckedChanged(object sender)
        {
            if (flatCheckBox35.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(3, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(3, false);
            }
        }

        private void flatCheckBox34_CheckedChanged(object sender)
        {
            if (flatCheckBox34.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(4, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(4, false);
            }
        }

        private void flatCheckBox33_CheckedChanged(object sender)
        {
            if (flatCheckBox33.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(5, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(5, false);
            }
        }

        private void flatCheckBox32_CheckedChanged(object sender)
        {
            if (flatCheckBox38.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(6, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(6, false);
            }
        }

        private void flatCheckBox31_CheckedChanged(object sender)
        {
            if (flatCheckBox31.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(7, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(7, false);
            }
        }

        private void flatCheckBox30_CheckedChanged(object sender)
        {
            if (flatCheckBox30.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(8, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(8, false);
            }
        }

        private void flatCheckBox29_CheckedChanged(object sender)
        {
            if (flatCheckBox29.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(9, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(9, false);
            }
        }

        private void flatCheckBox28_CheckedChanged(object sender)
        {
            if (flatCheckBox28.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(10, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(10, false);
            }
        }

        private void flatCheckBox27_CheckedChanged(object sender)
        {
            if (flatCheckBox27.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(11, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(11, false);
            }
        }

        private void flatCheckBox26_CheckedChanged(object sender)
        {
            if (flatCheckBox26.Checked)
            {
                Func.ClientMods.T_Bag.TBag(0, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(0, false);
            }
        }

        private void flatCheckBox25_CheckedChanged(object sender)
        {
            if (flatCheckBox25.Checked)
            {
                Func.ClientMods.T_Bag.TBag(1, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(1, false);
            }
        }

        private void flatCheckBox24_CheckedChanged(object sender)
        {
            if (flatCheckBox24.Checked)
            {
                Func.ClientMods.T_Bag.TBag(2, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(2, false);
            }
        }

        private void flatCheckBox23_CheckedChanged(object sender)
        {
            if (flatCheckBox23.Checked)
            {
                Func.ClientMods.T_Bag.TBag(3, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(3, false);
            }
        }

        private void flatCheckBox22_CheckedChanged(object sender)
        {
            if (flatCheckBox22.Checked)
            {
                Func.ClientMods.T_Bag.TBag(4, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(4, false);
            }
        }

        private void flatCheckBox21_CheckedChanged(object sender)
        {
            if (flatCheckBox21.Checked)
            {
                Func.ClientMods.T_Bag.TBag(5, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(5, false);
            }
        }

        private void flatCheckBox20_CheckedChanged(object sender)
        {
            if (flatCheckBox20.Checked)
            {
                Func.ClientMods.T_Bag.TBag(6, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(6, false);
            }
        }

        private void flatCheckBox19_CheckedChanged(object sender)
        {
            if (flatCheckBox19.Checked)
            {
                Func.ClientMods.T_Bag.TBag(7, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(7, false);
            }
        }

        private void flatCheckBox18_CheckedChanged(object sender)
        {
            if (flatCheckBox18.Checked)
            {
                Func.ClientMods.T_Bag.TBag(8, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(8, false);
            }
        }

        private void flatCheckBox17_CheckedChanged(object sender)
        {
            if (flatCheckBox17.Checked)
            {
                Func.ClientMods.T_Bag.TBag(9, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(9, false);
            }
        }

        private void flatCheckBox16_CheckedChanged(object sender)
        {
            if (flatCheckBox16.Checked)
            {
                Func.ClientMods.T_Bag.TBag(10, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(10, false);
            }
        }

        private void flatCheckBox15_CheckedChanged(object sender)
        {
            if (flatCheckBox15.Checked)
            {
                Func.ClientMods.T_Bag.TBag(11, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(11, false);
            }
        }

        private void flatCheckBox39_CheckedChanged(object sender)
        {
            if (flatCheckBox39.Checked)
            {
                MyClientBinds.GM.GodMod(0, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(0, false);
            }
        }

        private void flatCheckBox40_CheckedChanged(object sender)
        {
            if (flatCheckBox40.Checked)
            {
                MyClientBinds.GM.GodMod(1, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(1, false);
            }
        }

        private void flatCheckBox41_CheckedChanged(object sender)
        {
            if (flatCheckBox41.Checked)
            {
                MyClientBinds.GM.GodMod(2, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(2, false);
            }
        }

        private void flatCheckBox42_CheckedChanged(object sender)
        {
            if (flatCheckBox42.Checked)
            {
                MyClientBinds.GM.GodMod(3, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(3, false);
            }
        }

        private void flatCheckBox43_CheckedChanged(object sender)
        {
            if (flatCheckBox43.Checked)
            {
                MyClientBinds.GM.GodMod(4, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(4, false);
            }
        }

        private void flatCheckBox44_CheckedChanged(object sender)
        {
            if (flatCheckBox44.Checked)
            {
                MyClientBinds.GM.GodMod(5, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(5, false);
            }
        }

        private void flatCheckBox45_CheckedChanged(object sender)
        {
            if (flatCheckBox45.Checked)
            {
                MyClientBinds.GM.GodMod(6, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(6, false);
            }
        }

        private void flatCheckBox46_CheckedChanged(object sender)
        {
            if (flatCheckBox46.Checked)
            {
                MyClientBinds.GM.GodMod(7, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(7, false);
            }
        }

        private void flatCheckBox47_CheckedChanged(object sender)
        {
            if (flatCheckBox47.Checked)
            {
                MyClientBinds.GM.GodMod(8, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(8, false);
            }
        }

        private void flatCheckBox300_CheckedChanged(object sender)
        {
            if (flatCheckBox300.Checked)
            {
                MyClientBinds.GM.GodMod(9, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(9, false);
            }
        }

        private void flatCheckBox301_CheckedChanged(object sender)
        {
            if (flatCheckBox301.Checked)
            {
                MyClientBinds.GM.GodMod(10, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(10, false);
            }
        }

        private void flatCheckBox302_CheckedChanged(object sender)
        {
            if (flatCheckBox302.Checked)
            {
                MyClientBinds.GM.GodMod(11, true);
            }
            else
            {
                MyClientBinds.GM.GodMod(11, false);
            }
        }

        private void flatCheckBox347_CheckedChanged(object sender)
        {
            if (flatCheckBox347.Checked)
            {
                MyClientBinds.Speed.TheMod(0, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(0, false);
            }
        }

        private void flatCheckBox345_CheckedChanged(object sender)
        {
            if (flatCheckBox345.Checked)
            {
                MyClientBinds.Speed.TheMod(1, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(1, false);
            }
        }

        private void flatCheckBox339_CheckedChanged(object sender)
        {
            if (flatCheckBox339.Checked)
            {
                MyClientBinds.Speed.TheMod(2, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(2, false);
            }
        }

        private void flatCheckBox311_CheckedChanged(object sender)
        {
            if (flatCheckBox311.Checked)
            {
                MyClientBinds.Speed.TheMod(3, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(3, false);
            }
        }

        private void flatCheckBox310_CheckedChanged(object sender)
        {
            if (flatCheckBox310.Checked)
            {
                MyClientBinds.Speed.TheMod(4, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(4, false);
            }
        }

        private void flatCheckBox309_CheckedChanged(object sender)
        {
            if (flatCheckBox309.Checked)
            {
                MyClientBinds.Speed.TheMod(5, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(5, false);
            }
        }

        private void flatCheckBox308_CheckedChanged(object sender)
        {
            if (flatCheckBox308.Checked)
            {
                MyClientBinds.Speed.TheMod(6, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(6, false);
            }
        }

        private void flatCheckBox307_CheckedChanged(object sender)
        {
            if (flatCheckBox307.Checked)
            {
                MyClientBinds.Speed.TheMod(7, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(7, false);
            }
        }

        private void flatCheckBox306_CheckedChanged(object sender)
        {
            if (flatCheckBox306.Checked)
            {
                MyClientBinds.Speed.TheMod(8, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(8, false);
            }
        }

        private void flatCheckBox305_CheckedChanged(object sender)
        {
            if (flatCheckBox305.Checked)
            {
                MyClientBinds.Speed.TheMod(9, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(9, false);
            }
        }

        private void flatCheckBox304_CheckedChanged(object sender)
        {
            if (flatCheckBox304.Checked)
            {
                MyClientBinds.Speed.TheMod(10, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(10, false);
            }
        }

        private void flatCheckBox303_CheckedChanged(object sender)
        {
            if (flatCheckBox303.Checked)
            {
                MyClientBinds.Speed.TheMod(11, true);
            }
            else
            {
                MyClientBinds.Speed.TheMod(11, false);
            }
        }

        private void flatCheckBox359_CheckedChanged(object sender)
        {
            if (flatCheckBox359.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(0, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(0, false);
            }
        }

        private void flatCheckBox358_CheckedChanged(object sender)
        {
            if (flatCheckBox358.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(1, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(1, false);
            }
        }

        private void flatCheckBox357_CheckedChanged(object sender)
        {
            if (flatCheckBox357.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(2, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(2, false);
            }
        }

        private void flatCheckBox356_CheckedChanged(object sender)
        {
            if (flatCheckBox356.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(3, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(3, false);
            }
        }

        private void flatCheckBox355_CheckedChanged(object sender)
        {
            if (flatCheckBox355.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(4, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(4, false);
            }
        }

        private void flatCheckBox354_CheckedChanged(object sender)
        {
            if (flatCheckBox354.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(5, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(5, false);
            }
        }

        private void flatCheckBox353_CheckedChanged(object sender)
        {
            if (flatCheckBox353.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(6, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(6, false);
            }
        }

        private void flatCheckBox352_CheckedChanged(object sender)
        {
            if (flatCheckBox352.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(7, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(7, false);
            }
        }

        private void flatCheckBox351_CheckedChanged(object sender)
        {
            if (flatCheckBox351.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(8, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(8, false);
            }
        }

        private void flatCheckBox350_CheckedChanged(object sender)
        {
            if (flatCheckBox350.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(9, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(9, false);
            }
        }

        private void flatCheckBox349_CheckedChanged(object sender)
        {
            if (flatCheckBox349.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(10, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(10, false);
            }
        }

        private void flatCheckBox348_CheckedChanged(object sender)
        {
            if (flatCheckBox348.Checked)
            {
                MyClientBinds.RandomWeapon.TheMod(11, true);
            }
            else
            {
                MyClientBinds.RandomWeapon.TheMod(11, false);
            }
        }

        private void flatCheckBox371_CheckedChanged(object sender)
        {
            if (flatCheckBox371.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(0, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(0, false);
            }
        }

        private void flatCheckBox370_CheckedChanged(object sender)
        {
            if (flatCheckBox370.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(1, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(1, false);
            }
        }

        private void flatCheckBox369_CheckedChanged(object sender)
        {
            if (flatCheckBox369.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(2, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(2, false);
            }
        }

        private void flatCheckBox368_CheckedChanged(object sender)
        {
            if (flatCheckBox368.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(3, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(3, false);
            }
        }

        private void flatCheckBox367_CheckedChanged(object sender)
        {
            if (flatCheckBox367.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(4, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(4, false);
            }
        }

        private void flatCheckBox366_CheckedChanged(object sender)
        {
            if (flatCheckBox366.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(5, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(5, false);
            }
        }

        private void flatCheckBox365_CheckedChanged(object sender)
        {
            if (flatCheckBox365.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(6, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(6, false);
            }
        }

        private void flatCheckBox364_CheckedChanged(object sender)
        {
            if (flatCheckBox364.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(7, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(7, false);
            }
        }

        private void flatCheckBox363_CheckedChanged(object sender)
        {
            if (flatCheckBox363.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(8, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(8, false);
            }
        }

        private void flatCheckBox362_CheckedChanged(object sender)
        {
            if (flatCheckBox363.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(9, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(9, false);
            }
        }

        private void flatCheckBox361_CheckedChanged(object sender)
        {
            if (flatCheckBox361.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(10, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(10, false);
            }
        }

        private void flatCheckBox360_CheckedChanged(object sender)
        {
            if (flatCheckBox360.Checked)
            {
                MyClientBinds.RandomCamo.TheMod(11, true);
            }
            else
            {
                MyClientBinds.RandomCamo.TheMod(11, false);
            }
        }

        private void clientNames8_Click(object sender, EventArgs e)
        {
            textBox157.Text = Func.ClientMods.GetPlayerName(0);
            textBox156.Text = Func.ClientMods.GetPlayerName(1);
            textBox155.Text = Func.ClientMods.GetPlayerName(2);
            textBox154.Text = Func.ClientMods.GetPlayerName(3);
            textBox153.Text = Func.ClientMods.GetPlayerName(4);
            textBox152.Text = Func.ClientMods.GetPlayerName(5);
            textBox151.Text = Func.ClientMods.GetPlayerName(6);
            textBox150.Text = Func.ClientMods.GetPlayerName(7);
            textBox149.Text = Func.ClientMods.GetPlayerName(8);
            textBox148.Text = Func.ClientMods.GetPlayerName(9);
            textBox147.Text = Func.ClientMods.GetPlayerName(10);
            textBox146.Text = Func.ClientMods.GetPlayerName(11);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ClientsAmmo.EndAmmo();
            MyClientBinds.EndMyClientsBind();
            Func.ClientMods.EndAntiQuit();
            Func.ClientMods.EndGodMod();
            Func.ClientMods.EndPerks();
            Func.ClientMods.EndScoreStreak();
            Func.ClientMods.EndSkateMod();
            Func.ClientMods.EndSkipTimer();
            Func.ClientMods.EndTeleportToSaved();
            Func.ClientMods.EndVSAT();
            Func.LobbyMods.AllPerks.AllPlayerPerks(false);
            Func.LobbyMods.DisableScore.DisPlayerScoreStreak(false);
            Func.LobbyMods.WeaponLobby.LoadLobbyinTh(10, 10, 10, false);
          
            Func.NonHost.SuperForceHost.SuperFH(false);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();

        }

        private void defWeapon_Click(object sender, EventArgs e)
        {
            Func.LobbyMods.WeaponLobby.LoadLobbyinTh(BIS.Client.LobbyWeapon_Index[lobbyWea.SelectedIndex], (byte)bulletsNum.Value, (byte)inClipNum.Value, false);
            Func.LobbyMods.AllPerks.AllPlayerPerks(false);
            Func.LobbyMods.DisableScore.DisPlayerScoreStreak(false);
            allPerksCh.Checked = false;
            disscCh.Checked = false;
        }

        private void allPerksCh_CheckedChanged(object sender)
        {
            if (allPerksCh.Checked)
            {
                Func.LobbyMods.AllPerks.AllPlayerPerks(true);
            }
            else
            {
                Func.LobbyMods.AllPerks.AllPlayerPerks(false);
            }
        }

        private void disscCh_CheckedChanged(object sender)
        {
            if (disscCh.Checked)
            {
                Func.LobbyMods.DisableScore.DisPlayerScoreStreak(true);
            }
            else
            {
                Func.LobbyMods.DisableScore.DisPlayerScoreStreak(false);
            }
        }

        private void sfhBtn_Click(object sender, EventArgs e)
        {
            if (sfhBtn.Text == "Super Force Host [ On ]")
            {
                sfhBtn.Text = "Super Force Host [ Off ]";
                Functions.SetMem(0x01cd6018, new byte[1]);
                Func.NonHost.SuperForceHost.SuperFH(true);
                minPlayersTi.Stop();
                remainingTi.Stop();
                startInTi.Stop();
                timeRemainingNum.Value = 45;
                minPlayersNum.Value = 6;
                startInNum.Value = 10;
            }
            else if (sfhBtn.Text == "Super Force Host [ Off ]")
            {
                sfhBtn.Text = "Super Force Host [ On ]";
                Func.NonHost.SuperForceHost.SuperFH(false);
                Functions.SetMem(0x01cd6018, new byte[] { 0x01 });
                minPlayersTi.Stop();
                remainingTi.Stop();
                startInTi.Stop();
                timeRemainingNum.Value = 45;
                minPlayersNum.Value = 6;
                startInNum.Value = 10;
            }
        }

        private void flatCheckBox383_CheckedChanged(object sender)
        {
            if (flatCheckBox383.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(0, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(0, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox382_CheckedChanged(object sender)
        {
            if (flatCheckBox382.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(1, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(1, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox381_CheckedChanged(object sender)
        {
            if (flatCheckBox381.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(2, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(2, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox380_CheckedChanged(object sender)
        {
            if (flatCheckBox380.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(3, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(3, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox379_CheckedChanged(object sender)
        {
            if (flatCheckBox379.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(4, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(4, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox378_CheckedChanged(object sender)
        {
            if (flatCheckBox378.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(5, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(5, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox377_CheckedChanged(object sender)
        {
            if (flatCheckBox377.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(6, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(6, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox376_CheckedChanged(object sender)
        {
            if (flatCheckBox376.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(7, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(7, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox375_CheckedChanged(object sender)
        {
            if (flatCheckBox375.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(8, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(8, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox374_CheckedChanged(object sender)
        {
            if (flatCheckBox374.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(9, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(9, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox373_CheckedChanged(object sender)
        {
            if (flatCheckBox373.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(10, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(10, jumpLevelNum.Value, false);
            }
        }

        private void flatCheckBox372_CheckedChanged(object sender)
        {
            if (flatCheckBox372.Checked)
            {
                Func.ClientMods.JETPACK.DoJetpack(11, jumpLevelNum.Value, true);
            }
            else
            {
                Func.ClientMods.JETPACK.DoJetpack(11, jumpLevelNum.Value, false);
            }
        }

        private void flatButton215_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(0);
        }

        private void flatButton214_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(1);
        }

        private void flatButton213_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(2);
        }

        private void flatButton212_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(3);
        }

        private void flatButton211_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(4);
        }

        private void flatButton210_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(5);
        }

        private void flatButton209_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(6);
        }

        private void flatButton208_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(7);
        }

        private void flatButton207_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(8);
        }

        private void flatButton206_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(9);
        }

        private void flatButton205_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(10);
        }

        private void flatButton204_Click(object sender, EventArgs e)
        {
            Func.ClientMods.TakeWeapon(11);
        }

        private void flatCheckBox395_CheckedChanged(object sender)
        {
            if (flatCheckBox395.Checked)
            {
                flatCheckBox407.Checked = false;
                Func.Notify_C.Notify_Cl(0, "AimBot : ^2On");
                ab0.Stop();
                antiQuit_0.Start();
            }
            else
            {
                Func.Notify_C.Notify_Cl(0, "AimBot : ^1Off");
                antiQuit_0.Stop();
            }
        }

        private void flatCheckBox394_CheckedChanged(object sender)
        {
            if (flatCheckBox394.Checked)
            {
                flatCheckBox406.Checked = false;
                ab1.Stop();
                antiQuit_1.Start();
                Func.Notify_C.Notify_Cl(1, "AimBot : ^2On");
            }
            else
            {
                antiQuit_1.Stop();
                Func.Notify_C.Notify_Cl(1, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox393_CheckedChanged(object sender)
        {
            if (flatCheckBox393.Checked)
            {
                flatCheckBox405.Checked = false;
                ab2.Stop();
                antiQuit_2.Start();
                Func.Notify_C.Notify_Cl(2, "AimBot : ^2On");
            }
            else
            {
                antiQuit_2.Stop();
                Func.Notify_C.Notify_Cl(2, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox392_CheckedChanged(object sender)
        {
            if (flatCheckBox392.Checked)
            {
                flatCheckBox404.Checked = false;
                ab3.Stop();
                antiQuit_3.Start();
                Func.Notify_C.Notify_Cl(3, "AimBot : ^2On");
            }
            else
            {
                antiQuit_3.Stop();
                Func.Notify_C.Notify_Cl(3, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox391_CheckedChanged(object sender)
        {
            if (flatCheckBox391.Checked)
            {
                flatCheckBox403.Checked = false;
                ab4.Stop();
                antiQuit_4.Start();
                Func.Notify_C.Notify_Cl(4, "AimBot : ^2On");
            }
            else
            {
                antiQuit_4.Stop();
                Func.Notify_C.Notify_Cl(4, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox390_CheckedChanged(object sender)
        {
            if (flatCheckBox390.Checked)
            {
                flatCheckBox402.Checked = false;
                ab5.Stop();
                antiQuit_5.Start();
                Func.Notify_C.Notify_Cl(5, "AimBot : ^2On");
            }
            else
            {
                antiQuit_5.Stop();
                Func.Notify_C.Notify_Cl(5, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox389_CheckedChanged(object sender)
        {
            if (flatCheckBox389.Checked)
            {
                flatCheckBox401.Checked = false;
                ab6.Stop();
                antiQuit_6.Start();
                Func.Notify_C.Notify_Cl(6, "AimBot : ^2On");
            }
            else
            {
                antiQuit_6.Stop();
                Func.Notify_C.Notify_Cl(6, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox388_CheckedChanged(object sender)
        {
            if (flatCheckBox388.Checked)
            {
                flatCheckBox400.Checked = false;
                ab7.Stop();
                antiQuit_7.Start();
                Func.Notify_C.Notify_Cl(7, "AimBot : ^2On");
            }
            else
            {
                antiQuit_7.Stop();
                Func.Notify_C.Notify_Cl(7, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox387_CheckedChanged(object sender)
        {
            if (flatCheckBox387.Checked)
            {
                flatCheckBox399.Checked = false;
                ab8.Stop();
                antiQuit_8.Start();
                Func.Notify_C.Notify_Cl(8, "AimBot : ^2On");
            }
            else
            {
                antiQuit_8.Stop();
                Func.Notify_C.Notify_Cl(8, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox386_CheckedChanged(object sender)
        {
            if (flatCheckBox386.Checked)
            {
                flatCheckBox398.Checked = false;
                ab9.Stop();
                antiQuit_9.Start();
                Func.Notify_C.Notify_Cl(9, "AimBot : ^2On");
            }
            else
            {
                antiQuit_9.Stop();
                Func.Notify_C.Notify_Cl(9, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox385_CheckedChanged(object sender)
        {
            if (flatCheckBox385.Checked)
            {
                flatCheckBox397.Checked = false;
                ab10.Stop();
                antiQuit_10.Start();
                Func.Notify_C.Notify_Cl(10, "AimBot : ^2On");
            }
            else
            {
                antiQuit_10.Stop();
                Func.Notify_C.Notify_Cl(10, "AimBot : ^1Off");
            }
        }

        private void flatCheckBox384_CheckedChanged(object sender)
        {
            if (flatCheckBox384.Checked)
            {
                flatCheckBox396.Checked = false;
                ab11.Stop();
                antiQuit_11.Start();
                Func.Notify_C.Notify_Cl(11, "AimBot : ^2On");
            }
            else
            {
                antiQuit_11.Stop();
                Func.Notify_C.Notify_Cl(11, "AimBot : ^1Off");
            }
        }

        private void ab0_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(0);
        }

        private void ab1_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(1);
        }

        private void ab2_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(2);
        }

        private void ab3_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(3);
        }

        private void ab4_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(4);
        }

        private void ab5_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(5);
        }

        private void ab6_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(6);
        }

        private void ab7_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(7);
        }

        private void ab8_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(8);
        }

        private void ab9_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(9);
        }

        private void ab10_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(10);
        }

        private void ab11_Tick(object sender, EventArgs e)
        {
            AimBot.StartUnfairAimBot(11);
        }

        private void flatCheckBox407_CheckedChanged(object sender)
        {
            if (flatCheckBox407.Checked)
            {
                antiQuit_0.Stop();
                flatCheckBox395.Checked = false;
                ab0.Start();
                Func.Notify_C.Notify_Cl(0, "Unfair AimBot : ^2On");
            }
            else
            {
                ab0.Stop();
                Func.Notify_C.Notify_Cl(0, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox406_CheckedChanged(object sender)
        {
            if (flatCheckBox406.Checked)
            {
                antiQuit_1.Stop();
                flatCheckBox394.Checked = false;
                ab1.Start();
                Func.Notify_C.Notify_Cl(1, "Unfair AimBot : ^2On");
            }
            else
            {
                ab1.Stop();
                Func.Notify_C.Notify_Cl(1, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox405_CheckedChanged(object sender)
        {
            if (flatCheckBox405.Checked)
            {
                antiQuit_2.Stop();
                flatCheckBox393.Checked = false;
                ab2.Start();
                Func.Notify_C.Notify_Cl(2, "Unfair AimBot : ^2On");
            }
            else
            {
                ab2.Stop();
                Func.Notify_C.Notify_Cl(2, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox404_CheckedChanged(object sender)
        {
            if (flatCheckBox404.Checked)
            {
                antiQuit_3.Stop();
                flatCheckBox392.Checked = false;
                ab3.Start();
                Func.Notify_C.Notify_Cl(3, "Unfair AimBot : ^2On");
            }
            else
            {
                ab3.Stop();
                Func.Notify_C.Notify_Cl(3, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox403_CheckedChanged(object sender)
        {
            if (flatCheckBox403.Checked)
            {
                antiQuit_4.Stop();
                flatCheckBox391.Checked = false;
                ab4.Start();
                Func.Notify_C.Notify_Cl(4, "Unfair AimBot : ^2On");
            }
            else
            {
                ab4.Stop();
                Func.Notify_C.Notify_Cl(4, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox402_CheckedChanged(object sender)
        {
            if (flatCheckBox402.Checked)
            {
                antiQuit_5.Stop();
                flatCheckBox390.Checked = false;
                ab5.Start();
                Func.Notify_C.Notify_Cl(5, "Unfair AimBot : ^2On");
            }
            else
            {
                ab5.Stop();
                Func.Notify_C.Notify_Cl(5, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox401_CheckedChanged(object sender)
        {
            if (flatCheckBox401.Checked)
            {
                antiQuit_6.Stop();
                flatCheckBox389.Checked = false;
                ab6.Start();
                Func.Notify_C.Notify_Cl(6, "Unfair AimBot : ^2On");
            }
            else
            {
                ab6.Stop();
                Func.Notify_C.Notify_Cl(6, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox400_CheckedChanged(object sender)
        {
            if (flatCheckBox400.Checked)
            {
                antiQuit_7.Stop();
                flatCheckBox388.Checked = false;
                ab7.Start();
                Func.Notify_C.Notify_Cl(7, "Unfair AimBot : ^2On");
            }
            else
            {
                ab7.Stop();
                Func.Notify_C.Notify_Cl(7, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox399_CheckedChanged(object sender)
        {
            if (flatCheckBox399.Checked)
            {
                antiQuit_8.Stop();
                flatCheckBox387.Checked = false;
                ab8.Start();
                Func.Notify_C.Notify_Cl(8, "Unfair AimBot : ^2On");
            }
            else
            {
                ab8.Stop();
                Func.Notify_C.Notify_Cl(8, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox398_CheckedChanged(object sender)
        {
            if (flatCheckBox398.Checked)
            {
                antiQuit_9.Stop();
                flatCheckBox386.Checked = false;
                ab9.Start();
                Func.Notify_C.Notify_Cl(9, "Unfair AimBot : ^2On");
            }
            else
            {
                ab9.Stop();
                Func.Notify_C.Notify_Cl(9, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox397_CheckedChanged(object sender)
        {
            if (flatCheckBox397.Checked)
            {
                antiQuit_10.Stop();
                flatCheckBox385.Checked = false;
                ab10.Start();
                Func.Notify_C.Notify_Cl(10, "Unfair AimBot : ^2On");
            }
            else
            {
                ab10.Stop();
                Func.Notify_C.Notify_Cl(10, "Unfair AimBot : ^1Off");
            }
        }

        private void flatCheckBox396_CheckedChanged(object sender)
        {
            if (flatCheckBox396.Checked)
            {
                antiQuit_11.Stop();
                flatCheckBox384.Checked = false;
                ab11.Start();
                Func.Notify_C.Notify_Cl(11, "Unfair AimBot : ^2On");
            }
            else
            {
                ab11.Stop();
                Func.Notify_C.Notify_Cl(11, "Unfair AimBot : ^1Off");
            }
        }

        private void refreshClientsBtn_Click(object sender, EventArgs e)
        {
            clientsNameCombo.Items.Clear();
            for (int i = 0; i <= 11; i++)
            {
                clientsNameCombo.Items.Add(String.Format("{0}  - {1}", i, Func.ClientMods.GetPlayerName(i)));
            }
            clientsNameCombo.Items.Add("All Clients");
        }

        private void playSoundBtn_Click(object sender, EventArgs e)
        {
            if (clientsNameCombo.SelectedIndex < 0 || soundListCombo.SelectedIndex < 0)
            {
                MessageBox.Show("You Have To Choose One Of Clients And One Item Of Sounds List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clientsNameCombo.SelectedIndex != 12)
                {
                    RPC.playSound((int)clientsNameCombo.SelectedIndex, soundListCombo.Text);
                }
                else
                {
                    RPC.playSound(-1, soundListCombo.Text);
                }
            }
        }

        private void attachEntityBtn_Click(object sender, EventArgs e)
        {
            if (clientsNameCombo.SelectedIndex < 0 || tagListCombo.SelectedIndex < 0 || entityListCombo.SelectedIndex < 0)
            {
                MessageBox.Show("You Have To Choose One Of Clients And One Item Of These Combo Tag / Entity ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clientsNameCombo.SelectedIndex != 12)
                {
                    RPC.G_EntAttach((int)clientsNameCombo.SelectedIndex, entityListCombo.Text, tagListCombo.Text);
                }
                else
                {
                    MessageBox.Show("You Can't Apply This Options On All Clients", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void spawnHeliBtn_Click(object sender, EventArgs e)
        {
            if (clientsNameCombo.SelectedIndex < 0 || heliCombo.SelectedIndex < 0)
            {
                MessageBox.Show("You Have To Choose One Of Clients And One Item Of The Combo List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clientsNameCombo.SelectedIndex != 12)
                {
                    SpawnHelicopter.G_SpawnHelicopter(SpawnHelicopter.G_Entity((int)clientsNameCombo.SelectedIndex), "heli_guard_mp", heliCombo.Text, SpawnHelicopter.GetTagOrigin((int)clientsNameCombo.SelectedIndex), SpawnHelicopter.getViewAngles((int)clientsNameCombo.SelectedIndex));
                }
                else
                {
                    MessageBox.Show("You Can't Apply This Options On All Clients", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void flatCheckBox419_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(0);
        }

        private void flatCheckBox418_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(1);
        }

        private void flatCheckBox417_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(2);
        }

        private void flatCheckBox416_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(3);
        }

        private void flatCheckBox415_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(4);
        }

        private void flatCheckBox414_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(5);
        }

        private void flatCheckBox413_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(6);
        }

        private void flatCheckBox412_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(7);
        }

        private void flatCheckBox411_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(8);
        }

        private void flatCheckBox410_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(9);
        }

        private void flatCheckBox409_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(10);
        }

        private void flatCheckBox408_CheckedChanged(object sender)
        {
            Func.ClientMods.SpinMod.SpiningMod(11);
        }

        private void flatCheckBox431_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(0);
        }

        private void flatCheckBox430_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(1);
        }

        private void flatCheckBox429_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(2);
        }

        private void flatCheckBox428_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(3);
        }

        private void flatCheckBox427_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(4);
        }

        private void flatCheckBox426_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(5);
        }

        private void flatCheckBox425_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(6);
        }

        private void flatCheckBox424_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(7);
        }

        private void flatCheckBox423_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(8);
        }

        private void flatCheckBox422_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(9);
        }

        private void flatCheckBox421_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(10);
        }

        private void flatCheckBox420_CheckedChanged(object sender)
        {
            Func.ClientMods.AdvancedNOClip.NoClip(11);
        }
    }
}
