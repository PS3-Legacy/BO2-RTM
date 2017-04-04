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
    public partial class ZPfrm : Form
    {
        public ZPfrm()
        {
            InitializeComponent();
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {
            BOIIfrm.SetName(nameBox.Text);
        }

        private void rstNameBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = Connectionfrm.userName;
            BOIIfrm.SetName(Connectionfrm.userName);
        }

        private void nameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BOIIfrm.SetName(BIS.Names.Names_Index[nameCombo.SelectedIndex]);
        }

        private void lobbyJump_Scroll(object sender)
        {
            Functions.WriteByte(Offsets.Lobby.Jump, BIS.Lobby.Jump_Index[lobbyJump.Value]);
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

        private void gravityLobby_Scroll(object sender)
        {
            RPC.cbuf_addtext("bg_gravity " + BIS.Lobby.Gravity_Index[gravityLobby.Value]);
        }

        private void lobbySpeed_Scroll(object sender)
        {
            RPC.cbuf_addtext("g_speed " + BIS.Lobby.Speed_Index[lobbySpeed.Value]);
            Func.Notify_C.Notify_Cl(-1, "Speed Lobby  =  ^2" + BIS.Lobby.Speed_Index[lobbySpeed.Value]);
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

        private void timescaleLobby_Scroll(object sender)
        {
            Func.TimeScale(BIS.Lobby.TS_Index[timescaleLobby.Value]);
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

        private void rstMapBtn_Click(object sender, EventArgs e)
        {
            Func.MapCommand("Fast_restart");
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            if (flatButton4.Text == "Force Host [ On ]")
            {
                Functions.SetMem(0x01cd6553, new byte[1]);
                flatButton4.Text = "Force Host [ Off ]";
            }
            else if (flatButton4.Text == "Force Host [ Off ]")
            {
                Functions.SetMem(0x01cd6553, new byte[] { 0x01 });
                flatButton4.Text = "Force Host [ On ]";
            }
        }

        private void fovLobbyBar_Scroll(object sender)
        {
            RPC.Fov((int)fovLobbyBar.Value);
        }
        public static string MapWeapon = "";
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
            mapLbl.Text = "Map : " + Func.ServerInfo.MapName();
            gameLbl.Text = "GMod : " + Func.ServerInfo.GameType();

            #region *** 
            //if (Func.ServerInfo.MapName() == "Tranzit")
            //{
            //    flatComboBox1.Items.Clear();
            //    flatComboBox1.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.Models);
            //    flatComboBox34.Items.Clear();
            //    flatComboBox34.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.Models);
            //}
            //    griefBox.Visible = true;
            //    flatComboBox2.Items.Clear();
            //    flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox3.Items.Clear();
            //    flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox4.Items.Clear();
            //    flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox5.Items.Clear();
            //    flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox6.Items.Clear();
            //    flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox7.Items.Clear();
            //    flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox8.Items.Clear();
            //    flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox9.Items.Clear();
            //    flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox10.Items.Clear();
            //    flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox11.Items.Clear();
            //    flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox12.Items.Clear();
            //    flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox13.Items.Clear();
            //    flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox14.Items.Clear();
            //    flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox15.Items.Clear();
            //    flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox16.Items.Clear();
            //    flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox17.Items.Clear();
            //    flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox18.Items.Clear();
            //    flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox19.Items.Clear();
            //    flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox20.Items.Clear();
            //    flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox21.Items.Clear();
            //    flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox22.Items.Clear();
            //    flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox23.Items.Clear();
            //    flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox24.Items.Clear();
            //    flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox25.Items.Clear();
            //    flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);

            //    flatComboBox26.Items.Clear();
            //    flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox27.Items.Clear();
            //    flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox28.Items.Clear();
            //    flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox29.Items.Clear();
            //    flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox30.Items.Clear();
            //    flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox31.Items.Clear();
            //    flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox32.Items.Clear();
            //    flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    flatComboBox33.Items.Clear();
            //    flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
            //    infoBtn.Text = "Tranzit";
            //    MapWeapon = "Tranzit";
            //    infoBtn.Refresh();


            //}
            //else if (Func.ServerInfo.MapName() == "Die Rise")
            //{
            //    infoBtn.Text = "Die Rise";
            //    MapWeapon = "Die Rise";
            //    infoBtn.Refresh();
            //    griefBox.Visible = false;
            //    flatComboBox2.Items.Clear();
            //    flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox3.Items.Clear();
            //    flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox4.Items.Clear();
            //    flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox5.Items.Clear();
            //    flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox6.Items.Clear();
            //    //flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox7.Items.Clear();
            //    //flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox8.Items.Clear();
            //    //flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox9.Items.Clear();
            //    //flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox10.Items.Clear();
            //    flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox11.Items.Clear();
            //    flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox12.Items.Clear();
            //    flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox13.Items.Clear();
            //    flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
            //    flatComboBox14.Items.Clear();
            //    //flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox15.Items.Clear();
            //    //flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox16.Items.Clear();
            //    //flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
            //    flatComboBox17.Items.Clear();
            //    //flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());

            //    flatComboBox18.Items.Clear();
            //    flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
            //    flatComboBox19.Items.Clear();
            //    flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
            //    flatComboBox20.Items.Clear();
            //    flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
            //    flatComboBox21.Items.Clear();
            //    flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
            //    flatComboBox22.Items.Clear();
            //    //flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox23.Items.Clear();
            //    //flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox24.Items.Clear();
            //    //flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
            //    flatComboBox25.Items.Clear();
            //    //flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);

            //    flatComboBox26.Items.Clear();
            //    flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox27.Items.Clear();
            //    flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox28.Items.Clear();
            //    flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox29.Items.Clear();
            //    flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox30.Items.Clear();
            //    //flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox31.Items.Clear();
            //    //flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox32.Items.Clear();
            //    //flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
            //    flatComboBox33.Items.Clear();
            //    //flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);

            //}
            //else if (Func.ServerInfo.MapName() == "MOTD")
            //{
            //    griefBox.Visible = true;
            //    infoBtn.Text = "MOTD";
            //    MapWeapon = "MOTD";
            //    infoBtn.Refresh();
            //    flatComboBox2.Items.Clear();
            //    flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox3.Items.Clear();
            //    flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox4.Items.Clear();
            //    flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox5.Items.Clear();
            //    flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox6.Items.Clear();
            //    flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox7.Items.Clear();
            //    flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox8.Items.Clear();
            //    flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox9.Items.Clear();
            //    flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox10.Items.Clear();
            //    flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox11.Items.Clear();
            //    flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox12.Items.Clear();
            //    flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox13.Items.Clear();
            //    flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox14.Items.Clear();
            //    flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox15.Items.Clear();
            //    flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox16.Items.Clear();
            //    flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
            //    flatComboBox17.Items.Clear();
            //    flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());

            //    flatComboBox18.Items.Clear();
            //    flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox19.Items.Clear();
            //    flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox20.Items.Clear();
            //    flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox21.Items.Clear();
            //    flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox22.Items.Clear();
            //    flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox23.Items.Clear();
            //    flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox24.Items.Clear();
            //    flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox25.Items.Clear();
            //    flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);

            //    flatComboBox26.Items.Clear();
            //    flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox27.Items.Clear();
            //    flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox28.Items.Clear();
            //    flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox29.Items.Clear();
            //    flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox30.Items.Clear();
            //    flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox31.Items.Clear();
            //    flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox32.Items.Clear();
            //    flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox33.Items.Clear();
            //    flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //}
            //else if (Func.ServerInfo.MapName() == "Buried")
            //{
            //    griefBox.Visible = true;
            //    infoBtn.Text = "Buried";
            //    MapWeapon = "Buried";
            //    infoBtn.Refresh();
            //    flatComboBox2.Items.Clear();
            //    flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox3.Items.Clear();
            //    flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox4.Items.Clear();
            //    flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox5.Items.Clear();
            //    flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox6.Items.Clear();
            //    flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox7.Items.Clear();
            //    flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox8.Items.Clear();
            //    flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox9.Items.Clear();
            //    flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox10.Items.Clear();
            //    flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox11.Items.Clear();
            //    flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox12.Items.Clear();
            //    flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox13.Items.Clear();
            //    flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox14.Items.Clear();
            //    flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox15.Items.Clear();
            //    flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox16.Items.Clear();
            //    flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
            //    flatComboBox17.Items.Clear();
            //    flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());

            //    flatComboBox18.Items.Clear();

            //    flatComboBox19.Items.Clear();

            //    flatComboBox20.Items.Clear();

            //    flatComboBox21.Items.Clear();

            //    flatComboBox22.Items.Clear();

            //    flatComboBox23.Items.Clear();

            //    flatComboBox24.Items.Clear();

            //    flatComboBox25.Items.Clear();


            //    flatComboBox26.Items.Clear();
            //    flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox27.Items.Clear();
            //    flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox28.Items.Clear();
            //    flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox29.Items.Clear();
            //    flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox30.Items.Clear();
            //    flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox31.Items.Clear();
            //    flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox32.Items.Clear();
            //    flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //    flatComboBox33.Items.Clear();
            //    flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            //}
            //else if (Func.ServerInfo.MapName() == "Origins")
            //{
            //    infoBtn.Text = "Origins";
            //    MapWeapon = "Origins";
            //    infoBtn.Refresh();
            //    flatComboBox2.Items.Clear();
            //    flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox3.Items.Clear();
            //    flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox4.Items.Clear();
            //    flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox5.Items.Clear();
            //    flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox6.Items.Clear();
            //    //flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox7.Items.Clear();
            //    //flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox8.Items.Clear();
            //    //flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox9.Items.Clear();
            //    //flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox10.Items.Clear();
            //    flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox11.Items.Clear();
            //    flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox12.Items.Clear();
            //    flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    flatComboBox13.Items.Clear();
            //    flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    //flatComboBox14.Items.Clear();
            //    //flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    //flatComboBox15.Items.Clear();
            //    //flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    //flatComboBox16.Items.Clear();
            //    //flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
            //    //flatComboBox17.Items.Clear();
            //    //flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());


            //    flatComboBox18.Items.Clear();
            //    flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
            //    flatComboBox19.Items.Clear();
            //    flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
            //    flatComboBox20.Items.Clear();
            //    flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
            //    flatComboBox21.Items.Clear();
            //    flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
            //    flatComboBox22.Items.Clear();
            //    //flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox23.Items.Clear();
            //    //flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox24.Items.Clear();
            //    //flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
            //    flatComboBox25.Items.Clear();
            //    //flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);

            //    flatComboBox26.Items.Clear();
            //    flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
            //    flatComboBox27.Items.Clear();
            //    flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
            //    flatComboBox28.Items.Clear();
            //    flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
            //    flatComboBox29.Items.Clear();
            //    flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
            //    flatComboBox30.Items.Clear();
            //    //flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox31.Items.Clear();
            //    //flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox32.Items.Clear();
            //    //flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //    flatComboBox33.Items.Clear();
            //    //flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            //}
            #endregion
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            mapLbl.Text = "Map : " + Func.ServerInfo.MapName();
            gameLbl.Text = "GMod : " + Func.ServerInfo.GameType();
            MessageBox.Show("Map Name :  " + Func.ServerInfo.MapInfo() + "  /   " + Func.ServerInfo.MapName() + "\nGame Type :  " + Func.ServerInfo.GameInfo() + "  /   " + Func.ServerInfo.GameType());
        }

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

        private void flatCheckBox71_CheckedChanged(object sender)
        {
            if (flatCheckBox71.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(0, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(0, false);
            }
        }

        private void flatCheckBox70_CheckedChanged(object sender)
        {
            if (flatCheckBox70.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(1, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(1, false);
            }
        }

        private void flatCheckBox69_CheckedChanged(object sender)
        {
            if (flatCheckBox69.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(2, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(2, false);
            }
        }

        private void flatCheckBox68_CheckedChanged(object sender)
        {
            if (flatCheckBox68.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(3, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(3, false);
            }
        }

        private void flatCheckBox67_CheckedChanged(object sender)
        {
            if (flatCheckBox67.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(4, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(4, false);
            }
        }

        private void flatCheckBox66_CheckedChanged(object sender)
        {
            if (flatCheckBox66.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(5, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(5, false);
            }
        }

        private void flatCheckBox65_CheckedChanged(object sender)
        {
            if (flatCheckBox65.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(6, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(6, false);
            }
        }

        private void flatCheckBox64_CheckedChanged(object sender)
        {
            if (flatCheckBox64.Checked)
            {
                Func.ClientMods.ZM.GiveAmmo(7, true);
            }
            else
            {
                Func.ClientMods.ZM.GiveAmmo(7, false);
            }
        }

        private void flatCheckBox83_CheckedChanged(object sender)
        {
            if (flatCheckBox83.Checked)
            {
                Func.ClientMods.ZM.AllPerks(0, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(0, false);
            }
        }

        private void flatCheckBox82_CheckedChanged(object sender)
        {
            if (flatCheckBox82.Checked)
            {
                Func.ClientMods.ZM.AllPerks(1, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(1, false);
            }
        }

        private void flatCheckBox81_CheckedChanged(object sender)
        {
            if (flatCheckBox81.Checked)
            {
                Func.ClientMods.ZM.AllPerks(2, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(2, false);
            }
        }

        private void flatCheckBox80_CheckedChanged(object sender)
        {
            if (flatCheckBox80.Checked)
            {
                Func.ClientMods.ZM.AllPerks(3, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(3, false);
            }
        }

        private void flatCheckBox79_CheckedChanged(object sender)
        {
            if (flatCheckBox79.Checked)
            {
                Func.ClientMods.ZM.AllPerks(4, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(4, false);
            }
        }

        private void flatCheckBox78_CheckedChanged(object sender)
        {
            if (flatCheckBox78.Checked)
            {
                Func.ClientMods.ZM.AllPerks(5, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(5, false);
            }
        }

        private void flatCheckBox77_CheckedChanged(object sender)
        {
            if (flatCheckBox77.Checked)
            {
                Func.ClientMods.ZM.AllPerks(6, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(6, false);
            }
        }

        private void flatCheckBox76_CheckedChanged(object sender)
        {
            if (flatCheckBox76.Checked)
            {
                Func.ClientMods.ZM.AllPerks(7, true);
            }
            else
            {
                Func.ClientMods.ZM.AllPerks(7, false);
            }
        }

        private void flatCheckBox95_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(0);
        }

        private void flatCheckBox94_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(1);
        }

        private void flatCheckBox93_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(2);
        }

        private void flatCheckBox92_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(3);
        }

        private void flatCheckBox91_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(4);
        }

        private void flatCheckBox90_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(5);
        }

        private void flatCheckBox89_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(6);
        }

        private void flatCheckBox88_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.MaxPoint(7);
        }

        private void flatCheckBox107_CheckedChanged(object sender)
        {
            if (flatCheckBox107.Checked)
            {
                Func.ClientMods.SpeedPlayer(0, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(0, false);
            }
        }

        private void flatCheckBox106_CheckedChanged(object sender)
        {
            if (flatCheckBox106.Checked)
            {
                Func.ClientMods.SpeedPlayer(1, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(1, false);
            }
        }

        private void flatCheckBox105_CheckedChanged(object sender)
        {
            if (flatCheckBox105.Checked)
            {
                Func.ClientMods.SpeedPlayer(2, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(2, false);
            }
        }

        private void flatCheckBox104_CheckedChanged(object sender)
        {
            if (flatCheckBox104.Checked)
            {
                Func.ClientMods.SpeedPlayer(3, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(3, false);
            }
        }

        private void flatCheckBox103_CheckedChanged(object sender)
        {
            if (flatCheckBox103.Checked)
            {
                Func.ClientMods.SpeedPlayer(4, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(4, false);
            }
        }

        private void flatCheckBox102_CheckedChanged(object sender)
        {
            if (flatCheckBox102.Checked)
            {
                Func.ClientMods.SpeedPlayer(5, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(5, false);
            }
        }

        private void flatCheckBox101_CheckedChanged(object sender)
        {
            if (flatCheckBox101.Checked)
            {
                Func.ClientMods.SpeedPlayer(6, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(6, false);
            }
        }

        private void flatCheckBox100_CheckedChanged(object sender)
        {
            if (flatCheckBox100.Checked)
            {
                Func.ClientMods.SpeedPlayer(7, true);
            }
            else
            {
                Func.ClientMods.SpeedPlayer(7, false);
            }
        }

        private void flatCheckBox119_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(0);
        }

        private void flatCheckBox118_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(1);
        }

        private void flatCheckBox117_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(2);
        }

        private void flatCheckBox116_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(3);
        }

        private void flatCheckBox115_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(4);
        }

        private void flatCheckBox114_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(5);
        }

        private void flatCheckBox113_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(6);
        }

        private void flatCheckBox112_CheckedChanged(object sender)
        {
            Func.ClientMods.SlowPlayer(7);
        }

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

        private void flatCheckBox143_CheckedChanged(object sender)
        {
            if (flatCheckBox143.Checked)
            {
                Func.ClientMods.InvisiblePlayer(0, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(0, false);
            }
        }

        private void flatCheckBox142_CheckedChanged(object sender)
        {
            if (flatCheckBox142.Checked)
            {
                Func.ClientMods.InvisiblePlayer(1, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(1, false);
            }
        }

        private void flatCheckBox141_CheckedChanged(object sender)
        {
            if (flatCheckBox141.Checked)
            {
                Func.ClientMods.InvisiblePlayer(2, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(2, false);
            }
        }

        private void flatCheckBox140_CheckedChanged(object sender)
        {
            if (flatCheckBox140.Checked)
            {
                Func.ClientMods.InvisiblePlayer(3, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(3, false);
            }
        }

        private void flatCheckBox139_CheckedChanged(object sender)
        {
            if (flatCheckBox139.Checked)
            {
                Func.ClientMods.InvisiblePlayer(4, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(4, false);
            }
        }

        private void flatCheckBox138_CheckedChanged(object sender)
        {
            if (flatCheckBox138.Checked)
            {
                Func.ClientMods.InvisiblePlayer(5, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(5, false);
            }
        }

        private void flatCheckBox137_CheckedChanged(object sender)
        {
            if (flatCheckBox137.Checked)
            {
                Func.ClientMods.InvisiblePlayer(6, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(6, false);
            }
        }

        private void flatCheckBox136_CheckedChanged(object sender)
        {
            if (flatCheckBox136.Checked)
            {
                Func.ClientMods.InvisiblePlayer(7, true);
            }
            else
            {
                Func.ClientMods.InvisiblePlayer(7, false);
            }
        }

        private void flatCheckBox155_CheckedChanged(object sender)
        {
            if (flatCheckBox155.Checked)
            {
                Func.ClientMods.Freeze(0, true);
            }
            else
            {
                Func.ClientMods.Freeze(0, false);
            }
        }

        private void flatCheckBox154_CheckedChanged(object sender)
        {
            if (flatCheckBox154.Checked)
            {
                Func.ClientMods.Freeze(1, true);
            }
            else
            {
                Func.ClientMods.Freeze(1, false);
            }
        }

        private void flatCheckBox153_CheckedChanged(object sender)
        {
            if (flatCheckBox153.Checked)
            {
                Func.ClientMods.Freeze(2, true);
            }
            else
            {
                Func.ClientMods.Freeze(2, false);
            }
        }

        private void flatCheckBox152_CheckedChanged(object sender)
        {
            if (flatCheckBox152.Checked)
            {
                Func.ClientMods.Freeze(3, true);
            }
            else
            {
                Func.ClientMods.Freeze(3, false);
            }
        }

        private void flatCheckBox151_CheckedChanged(object sender)
        {
            if (flatCheckBox151.Checked)
            {
                Func.ClientMods.Freeze(4, true);
            }
            else
            {
                Func.ClientMods.Freeze(4, false);
            }
        }

        private void flatCheckBox150_CheckedChanged(object sender)
        {
            if (flatCheckBox150.Checked)
            {
                Func.ClientMods.Freeze(5, true);
            }
            else
            {
                Func.ClientMods.Freeze(5, false);
            }
        }

        private void flatCheckBox149_CheckedChanged(object sender)
        {
            if (flatCheckBox149.Checked)
            {
                Func.ClientMods.Freeze(6, true);
            }
            else
            {
                Func.ClientMods.Freeze(6, false);
            }
        }

        private void flatCheckBox148_CheckedChanged(object sender)
        {
            if (flatCheckBox148.Checked)
            {
                Func.ClientMods.Freeze(7, true);
            }
            else
            {
                Func.ClientMods.Freeze(7, false);
            }
        }

        private void flatCheckBox167_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(0);
        }

        private void flatCheckBox166_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(1);
        }

        private void flatCheckBox165_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(2);
        }

        private void flatCheckBox164_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(3);
        }

        private void flatCheckBox163_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(4);
        }

        private void flatCheckBox162_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(5);
        }

        private void flatCheckBox161_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(6);
        }

        private void flatCheckBox160_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.LastStanding(7);
        }

        private void flatCheckBox179_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(0);
        }

        private void flatCheckBox178_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(1);
        }

        private void flatCheckBox177_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(2);
        }

        private void flatCheckBox176_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(3);
        }

        private void flatCheckBox175_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(4);
        }

        private void flatCheckBox174_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(5);
        }

        private void flatCheckBox173_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(6);
        }

        private void flatCheckBox172_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(7);
        }

        private void flatCheckBox191_CheckedChanged(object sender)
        {
            if (flatCheckBox191.Checked)
            {
                Func.ClientMods.Lag(0, true);
            }
            else
            {
                Func.ClientMods.Lag(0, false);
            }
        }

        private void flatCheckBox190_CheckedChanged(object sender)
        {
            if (flatCheckBox190.Checked)
            {
                Func.ClientMods.Lag(1, true);
            }
            else
            {
                Func.ClientMods.Lag(1, false);
            }
        }

        private void flatCheckBox189_CheckedChanged(object sender)
        {
            if (flatCheckBox189.Checked)
            {
                Func.ClientMods.Lag(2, true);
            }
            else
            {
                Func.ClientMods.Lag(2, false);
            }
        }

        private void flatCheckBox188_CheckedChanged(object sender)
        {
            if (flatCheckBox188.Checked)
            {
                Func.ClientMods.Lag(3, true);
            }
            else
            {
                Func.ClientMods.Lag(3, false);
            }
        }

        private void flatCheckBox187_CheckedChanged(object sender)
        {
            if (flatCheckBox187.Checked)
            {
                Func.ClientMods.Lag(4, true);
            }
            else
            {
                Func.ClientMods.Lag(4, false);
            }
        }

        private void flatCheckBox186_CheckedChanged(object sender)
        {
            if (flatCheckBox186.Checked)
            {
                Func.ClientMods.Lag(5, true);
            }
            else
            {
                Func.ClientMods.Lag(5, false);
            }
        }

        private void flatCheckBox185_CheckedChanged(object sender)
        {
            if (flatCheckBox185.Checked)
            {
                Func.ClientMods.Lag(6, true);
            }
            else
            {
                Func.ClientMods.Lag(6, false);
            }
        }

        private void flatCheckBox184_CheckedChanged(object sender)
        {
            if (flatCheckBox184.Checked)
            {
                Func.ClientMods.Lag(7, true);
            }
            else
            {
                Func.ClientMods.Lag(7, false);
            }
        }

        private void flatCheckBox120_CheckedChanged(object sender)
        {
            if (flatCheckBox120.Checked)
            {
                Func.ClientMods.Jumper(0, true);
            }
            else
            {
                Func.ClientMods.Jumper(0, false);
            }
        }

        private void flatCheckBox111_CheckedChanged(object sender)
        {
            if (flatCheckBox111.Checked)
            {
                Func.ClientMods.Jumper(1, true);
            }
            else
            {
                Func.ClientMods.Jumper(1, false);
            }
        }

        private void flatCheckBox110_CheckedChanged(object sender)
        {
            if (flatCheckBox110.Checked)
            {
                Func.ClientMods.Jumper(2, true);
            }
            else
            {
                Func.ClientMods.Jumper(2, false);
            }
        }

        private void flatCheckBox109_CheckedChanged(object sender)
        {
            if (flatCheckBox109.Checked)
            {
                Func.ClientMods.Jumper(3, true);
            }
            else
            {
                Func.ClientMods.Jumper(3, false);
            }
        }

        private void flatCheckBox108_CheckedChanged(object sender)
        {
            if (flatCheckBox108.Checked)
            {
                Func.ClientMods.Jumper(4, true);
            }
            else
            {
                Func.ClientMods.Jumper(4, false);
            }
        }

        private void flatCheckBox99_CheckedChanged(object sender)
        {
            if (flatCheckBox99.Checked)
            {
                Func.ClientMods.Jumper(5, true);
            }
            else
            {
                Func.ClientMods.Jumper(5, false);
            }
        }

        private void flatCheckBox98_CheckedChanged(object sender)
        {
            if (flatCheckBox98.Checked)
            {
                Func.ClientMods.Jumper(6, true);
            }
            else
            {
                Func.ClientMods.Jumper(6, false);
            }
        }

        private void flatCheckBox97_CheckedChanged(object sender)
        {
            if (flatCheckBox97.Checked)
            {
                Func.ClientMods.Jumper(7, true);
            }
            else
            {
                Func.ClientMods.Jumper(7, false);
            }
        }

        private void flatCheckBox96_CheckedChanged(object sender)
        {
            if (flatCheckBox96.Checked)
            {
                Func.ClientMods.SkateMode(0, true);
            }
            else
            {
                Func.ClientMods.SkateMode(0, false);
            }
        }

        private void flatCheckBox87_CheckedChanged(object sender)
        {
            if (flatCheckBox87.Checked)
            {
                Func.ClientMods.SkateMode(1, true);
            }
            else
            {
                Func.ClientMods.SkateMode(1, false);
            }
        }

        private void flatCheckBox86_CheckedChanged(object sender)
        {
            if (flatCheckBox86.Checked)
            {
                Func.ClientMods.SkateMode(2, true);
            }
            else
            {
                Func.ClientMods.SkateMode(2, false);
            }
        }

        private void flatCheckBox85_CheckedChanged(object sender)
        {
            if (flatCheckBox85.Checked)
            {
                Func.ClientMods.SkateMode(3, true);
            }
            else
            {
                Func.ClientMods.SkateMode(3, false);
            }
        }

        private void flatCheckBox84_CheckedChanged(object sender)
        {
            if (flatCheckBox84.Checked)
            {
                Func.ClientMods.SkateMode(4, true);
            }
            else
            {
                Func.ClientMods.SkateMode(4, false);
            }
        }

        private void flatCheckBox75_CheckedChanged(object sender)
        {
            if (flatCheckBox75.Checked)
            {
                Func.ClientMods.SkateMode(5, true);
            }
            else
            {
                Func.ClientMods.SkateMode(5, false);
            }
        }

        private void flatCheckBox74_CheckedChanged(object sender)
        {
            if (flatCheckBox74.Checked)
            {
                Func.ClientMods.SkateMode(6, true);
            }
            else
            {
                Func.ClientMods.SkateMode(6, false);
            }
        }

        private void flatCheckBox73_CheckedChanged(object sender)
        {
            if (flatCheckBox73.Checked)
            {
                Func.ClientMods.SkateMode(7, true);
            }
            else
            {
                Func.ClientMods.SkateMode(7, false);
            }
        }

        private void flatCheckBox72_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(0, 4);
        }

        private void flatCheckBox63_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(1, 4);
        }

        private void flatCheckBox62_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(2, 4);
        }

        private void flatCheckBox61_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(3, 4);
        }

        private void flatCheckBox60_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(4, 4);
        }

        private void flatCheckBox59_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(5, 4);
        }

        private void flatCheckBox58_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(6, 4);
        }

        private void flatCheckBox57_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.BlackScreen(7, 4);
        }

        private void flatCheckBox56_CheckedChanged(object sender)
        {
            if (flatCheckBox56.Checked)
            {
                Func.ClientMods.Posion(0, true);
            }
            else
            {
                Func.ClientMods.Posion(0, false);
            }
        }

        private void flatCheckBox47_CheckedChanged(object sender)
        {
            if (flatCheckBox47.Checked)
            {
                Func.ClientMods.Posion(1, true);
            }
            else
            {
                Func.ClientMods.Posion(1, false);
            }
        }

        private void flatCheckBox46_CheckedChanged(object sender)
        {
            if (flatCheckBox46.Checked)
            {
                Func.ClientMods.Posion(2, true);
            }
            else
            {
                Func.ClientMods.Posion(2, false);
            }
        }

        private void flatCheckBox45_CheckedChanged(object sender)
        {
            if (flatCheckBox45.Checked)
            {
                Func.ClientMods.Posion(3, true);
            }
            else
            {
                Func.ClientMods.Posion(3, false);
            }
        }

        private void flatCheckBox44_CheckedChanged(object sender)
        {
            if (flatCheckBox44.Checked)
            {
                Func.ClientMods.Posion(4, true);
            }
            else
            {
                Func.ClientMods.Posion(4, false);
            }
        }

        private void flatCheckBox43_CheckedChanged(object sender)
        {
            if (flatCheckBox43.Checked)
            {
                Func.ClientMods.Posion(5, true);
            }
            else
            {
                Func.ClientMods.Posion(5, false);
            }
        }

        private void flatCheckBox42_CheckedChanged(object sender)
        {
            if (flatCheckBox42.Checked)
            {
                Func.ClientMods.Posion(6, true);
            }
            else
            {
                Func.ClientMods.Posion(6, false);
            }
        }

        private void flatCheckBox41_CheckedChanged(object sender)
        {
            if (flatCheckBox41.Checked)
            {
                Func.ClientMods.Posion(7, true);
            }
            else
            {
                Func.ClientMods.Posion(7, false);
            }
        }

        private void flatCheckBox32_CheckedChanged(object sender)
        {
            if (flatCheckBox32.Checked)
            {
                Func.ClientMods.NightVision(0, true);
            }
            else
            {
                Func.ClientMods.NightVision(0, false);
            }
        }

        private void flatCheckBox31_CheckedChanged(object sender)
        {
            if (flatCheckBox31.Checked)
            {
                Func.ClientMods.NightVision(1, true);
            }
            else
            {
                Func.ClientMods.NightVision(1, false);
            }
        }

        private void flatCheckBox30_CheckedChanged(object sender)
        {
            if (flatCheckBox30.Checked)
            {
                Func.ClientMods.NightVision(2, true);
            }
            else
            {
                Func.ClientMods.NightVision(2, false);
            }
        }

        private void flatCheckBox29_CheckedChanged(object sender)
        {
            if (flatCheckBox29.Checked)
            {
                Func.ClientMods.NightVision(3, true);
            }
            else
            {
                Func.ClientMods.NightVision(3, false);
            }
        }

        private void flatCheckBox28_CheckedChanged(object sender)
        {
            if (flatCheckBox28.Checked)
            {
                Func.ClientMods.NightVision(4, true);
            }
            else
            {
                Func.ClientMods.NightVision(4, false);
            }
        }

        private void flatCheckBox27_CheckedChanged(object sender)
        {
            if (flatCheckBox27.Checked)
            {
                Func.ClientMods.NightVision(5, true);
            }
            else
            {
                Func.ClientMods.NightVision(5, false);
            }
        }

        private void flatCheckBox26_CheckedChanged(object sender)
        {
            if (flatCheckBox26.Checked)
            {
                Func.ClientMods.NightVision(6, true);
            }
            else
            {
                Func.ClientMods.NightVision(6, false);
            }
        }

        private void flatCheckBox25_CheckedChanged(object sender)
        {
            if (flatCheckBox25.Checked)
            {
                Func.ClientMods.NightVision(7, true);
            }
            else
            {
                Func.ClientMods.NightVision(7, false);
            }
        }

        private void flatCheckBox24_CheckedChanged(object sender)
        {
            if (flatCheckBox24.Checked)
            {
                Func.ClientMods.Prone(0, true);
            }
            else
            {
                Func.ClientMods.Prone(0, false);
            }
        }

        private void flatCheckBox23_CheckedChanged(object sender)
        {
            if (flatCheckBox23.Checked)
            {
                Func.ClientMods.Prone(1, true);
            }
            else
            {
                Func.ClientMods.Prone(1, false);
            }
        }

        private void flatCheckBox22_CheckedChanged(object sender)
        {
            if (flatCheckBox22.Checked)
            {
                Func.ClientMods.Prone(2, true);
            }
            else
            {
                Func.ClientMods.Prone(2, false);
            }
        }

        private void flatCheckBox21_CheckedChanged(object sender)
        {
            if (flatCheckBox21.Checked)
            {
                Func.ClientMods.Prone(3, true);
            }
            else
            {
                Func.ClientMods.Prone(3, false);
            }
        }

        private void flatCheckBox20_CheckedChanged(object sender)
        {
            if (flatCheckBox20.Checked)
            {
                Func.ClientMods.Prone(4, true);
            }
            else
            {
                Func.ClientMods.Prone(4, false);
            }
        }

        private void flatCheckBox19_CheckedChanged(object sender)
        {
            if (flatCheckBox19.Checked)
            {
                Func.ClientMods.Prone(5, true);
            }
            else
            {
                Func.ClientMods.Prone(5, false);
            }
        }

        private void flatCheckBox18_CheckedChanged(object sender)
        {
            if (flatCheckBox18.Checked)
            {
                Func.ClientMods.Prone(6, true);
            }
            else
            {
                Func.ClientMods.Prone(6, false);
            }
        }

        private void flatCheckBox17_CheckedChanged(object sender)
        {
            if (flatCheckBox17.Checked)
            {
                Func.ClientMods.Prone(7, true);
            }
            else
            {
                Func.ClientMods.Prone(7, false);
            }
        }

        private void flatCheckBox16_CheckedChanged(object sender)
        {
            if (flatCheckBox16.Checked)
            {
                RPC.BlurClient(0, true);
            }
            else
            {
                RPC.BlurClient(0, false);
            }
        }

        private void flatCheckBox15_CheckedChanged(object sender)
        {
            if (flatCheckBox15.Checked)
            {
                RPC.BlurClient(1, true);
            }
            else
            {
                RPC.BlurClient(1, false);
            }
        }

        private void flatCheckBox14_CheckedChanged(object sender)
        {
            if (flatCheckBox14.Checked)
            {
                RPC.BlurClient(2, true);
            }
            else
            {
                RPC.BlurClient(2, false);
            }
        }

        private void flatCheckBox13_CheckedChanged(object sender)
        {
            if (flatCheckBox13.Checked)
            {
                RPC.BlurClient(3, true);
            }
            else
            {
                RPC.BlurClient(3, false);
            }
        }

        private void flatCheckBox12_CheckedChanged(object sender)
        {
            if (flatCheckBox12.Checked)
            {
                RPC.BlurClient(4, true);
            }
            else
            {
                RPC.BlurClient(4, false);
            }
        }

        private void flatCheckBox11_CheckedChanged(object sender)
        {
            if (flatCheckBox11.Checked)
            {
                RPC.BlurClient(5, true);
            }
            else
            {
                RPC.BlurClient(5, false);
            }
        }

        private void flatCheckBox10_CheckedChanged(object sender)
        {
            if (flatCheckBox10.Checked)
            {
                RPC.BlurClient(6, true);
            }
            else
            {
                RPC.BlurClient(6, false);
            }
        }

        private void flatCheckBox9_CheckedChanged(object sender)
        {
            if (flatCheckBox9.Checked)
            {
                RPC.BlurClient(7, true);
            }
            else
            {
                RPC.BlurClient(7, false);
            }
        }

        private void flatCheckBox8_CheckedChanged(object sender)
        {
            if (flatCheckBox8.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(0, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(0, false);
            }
        }

        private void flatCheckBox7_CheckedChanged(object sender)
        {
            if (flatCheckBox7.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(1, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(1, false);
            }
        }

        private void flatCheckBox6_CheckedChanged(object sender)
        {
            if (flatCheckBox6.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(2, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(2, false);
            }
        }

        private void flatCheckBox5_CheckedChanged(object sender)
        {
            if (flatCheckBox5.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(3, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(3, false);
            }
        }

        private void flatCheckBox4_CheckedChanged(object sender)
        {
            if (flatCheckBox4.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(4, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(4, false);
            }
        }

        private void flatCheckBox3_CheckedChanged(object sender)
        {
            if (flatCheckBox3.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(5, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(5, false);
            }
        }

        private void flatCheckBox2_CheckedChanged(object sender)
        {
            if (flatCheckBox2.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(6, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(6, false);
            }
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (flatCheckBox1.Checked)
            {
                Func.ClientMods.EarthQua.EarthQuake(7, true);
            }
            else
            {
                Func.ClientMods.EarthQua.EarthQuake(7, false);
            }
        }

        private void flatButton46_Click(object sender, EventArgs e)
        {
            RPC.KickClient(0);
        }

        private void flatButton45_Click(object sender, EventArgs e)
        {
            RPC.KickClient(1);
        }

        private void flatButton44_Click(object sender, EventArgs e)
        {
            RPC.KickClient(2);
        }

        private void flatButton43_Click(object sender, EventArgs e)
        {
            RPC.KickClient(3);
        }

        private void flatButton42_Click(object sender, EventArgs e)
        {
            RPC.KickClient(4);
        }

        private void flatButton41_Click(object sender, EventArgs e)
        {
            RPC.KickClient(5);
        }

        private void flatButton40_Click(object sender, EventArgs e)
        {
            RPC.KickClient(6);
        }

        private void flatButton39_Click(object sender, EventArgs e)
        {
            RPC.KickClient(7);
        }

        private void flatButton58_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(0);
        }

        private void flatButton57_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(1);
        }

        private void flatButton56_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(2);
        }

        private void flatButton55_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(3);
        }

        private void flatButton54_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(4);
        }

        private void flatButton53_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(5);
        }

        private void flatButton52_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(6);
        }

        private void flatButton51_Click(object sender, EventArgs e)
        {
            Func.ClientMods.FreezeConsole(7);
        }

        private void flatCheckBox168_CheckedChanged(object sender)
        {
            if (flatCheckBox168.Checked)
            {
                Func.ClientMods.T_Bag.TBag(0, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(0, false);
            }
        }

        private void flatCheckBox159_CheckedChanged(object sender)
        {
            if (flatCheckBox159.Checked)
            {
                Func.ClientMods.T_Bag.TBag(1, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(1, false);
            }
        }

        private void flatCheckBox158_CheckedChanged(object sender)
        {
            if (flatCheckBox158.Checked)
            {
                Func.ClientMods.T_Bag.TBag(2, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(2, false);
            }
        }

        private void flatCheckBox157_CheckedChanged(object sender)
        {
            if (flatCheckBox157.Checked)
            {
                Func.ClientMods.T_Bag.TBag(3, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(3, false);
            }
        }

        private void flatCheckBox156_CheckedChanged(object sender)
        {
            if (flatCheckBox156.Checked)
            {
                Func.ClientMods.T_Bag.TBag(4, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(4, false);
            }
        }

        private void flatCheckBox147_CheckedChanged(object sender)
        {
            if (flatCheckBox147.Checked)
            {
                Func.ClientMods.T_Bag.TBag(5, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(5, false);
            }
        }

        private void flatCheckBox146_CheckedChanged(object sender)
        {
            if (flatCheckBox146.Checked)
            {
                Func.ClientMods.T_Bag.TBag(6, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(6, false);
            }
        }

        private void flatCheckBox145_CheckedChanged(object sender)
        {
            if (flatCheckBox145.Checked)
            {
                Func.ClientMods.T_Bag.TBag(7, true);
            }
            else
            {
                Func.ClientMods.T_Bag.TBag(7, false);
            }
        }

        private void flatCheckBox144_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(0);
        }

        private void flatCheckBox135_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(1);
        }

        private void flatCheckBox134_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(2);
        }

        private void flatCheckBox133_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(3);
        }

        private void flatCheckBox132_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(4);
        }

        private void flatCheckBox123_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(5);
        }

        private void flatCheckBox122_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(6);
        }

        private void flatCheckBox121_CheckedChanged(object sender)
        {
            Func.ClientMods.TakeWeapon(7);
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

        private void flatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(0, flatComboBox2.SelectedIndex, flatComboBox2.Text);
        }

        private void flatComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(1, flatComboBox3.SelectedIndex, flatComboBox3.Text);
        }

        private void flatComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(2, flatComboBox4.SelectedIndex, flatComboBox4.Text);
        }

        private void flatComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(3, flatComboBox5.SelectedIndex, flatComboBox5.Text);
        }

        private void flatComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(4, flatComboBox6.SelectedIndex, flatComboBox6.Text);
        }

        private void flatComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(5, flatComboBox7.SelectedIndex, flatComboBox7.Text);
        }

        private void flatComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(6, flatComboBox8.SelectedIndex, flatComboBox8.Text);
        }

        private void flatComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GivePrimary(7, flatComboBox9.SelectedIndex, flatComboBox9.Text);
        }

        private void flatComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(0, flatComboBox13.SelectedIndex, flatComboBox13.Text);
        }

        private void flatComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(1, flatComboBox12.SelectedIndex, flatComboBox12.Text);
        }

        private void flatComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(2, flatComboBox11.SelectedIndex, flatComboBox11.Text);
        }

        private void flatComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(3, flatComboBox10.SelectedIndex, flatComboBox10.Text);
        }

        private void flatComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(4, flatComboBox17.SelectedIndex, flatComboBox17.Text);
        }

        private void flatComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(5, flatComboBox16.SelectedIndex, flatComboBox16.Text);
        }

        private void flatComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(6, flatComboBox15.SelectedIndex, flatComboBox15.Text);
        }

        private void flatComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveSecondary(7, flatComboBox14.SelectedIndex, flatComboBox14.Text);
        }

        private void flatComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(0, flatComboBox21.SelectedIndex, flatComboBox21.Text);
        }

        private void flatComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(1, flatComboBox20.SelectedIndex, flatComboBox20.Text);
        }

        private void flatComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(2, flatComboBox19.SelectedIndex, flatComboBox19.Text);
        }

        private void flatComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(3, flatComboBox18.SelectedIndex, flatComboBox18.Text);
        }

        private void flatComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(4, flatComboBox25.SelectedIndex, flatComboBox25.Text);
        }

        private void flatComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(5, flatComboBox24.SelectedIndex, flatComboBox24.Text);
        }

        private void flatComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(6, flatComboBox23.SelectedIndex, flatComboBox23.Text);
        }

        private void flatComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveEquip(7, flatComboBox22.SelectedIndex, flatComboBox22.Text);
        }

        private void flatComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(0, flatComboBox29.SelectedIndex, flatComboBox29.Text);
        }

        private void flatComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(1, flatComboBox28.SelectedIndex, flatComboBox28.Text);
        }

        private void flatComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(2, flatComboBox27.SelectedIndex, flatComboBox27.Text);
        }

        private void flatComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(3, flatComboBox26.SelectedIndex, flatComboBox26.Text);
        }

        private void flatComboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(4, flatComboBox33.SelectedIndex, flatComboBox33.Text);
        }

        private void flatComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(5, flatComboBox32.SelectedIndex, flatComboBox32.Text);
        }

        private void flatComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(6, flatComboBox31.SelectedIndex, flatComboBox31.Text);
        }

        private void flatComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.GiveR3(7, flatComboBox30.SelectedIndex, flatComboBox30.Text);
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            weaponBox.Enabled = true;
            mapStaTi.Start();
            weaponBtn.Text = "Get Weapons  |-" + Func.ServerInfo.MapName();
            if (Func.ServerInfo.MapName() == "Tranzit")
            {
                flatButton6.Enabled = true;
                griefBox.Visible = true;
                flatComboBox2.Items.Clear();
                flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox3.Items.Clear();
                flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox4.Items.Clear();
                flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox5.Items.Clear();
                flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox6.Items.Clear();
                flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox7.Items.Clear();
                flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox8.Items.Clear();
                flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox9.Items.Clear();
                flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox10.Items.Clear();
                flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox11.Items.Clear();
                flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox12.Items.Clear();
                flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox13.Items.Clear();
                flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox14.Items.Clear();
                flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox15.Items.Clear();
                flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox16.Items.Clear();
                flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox17.Items.Clear();
                flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox18.Items.Clear();
                flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox19.Items.Clear();
                flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox20.Items.Clear();
                flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox21.Items.Clear();
                flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox22.Items.Clear();
                flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox23.Items.Clear();
                flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox24.Items.Clear();
                flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox25.Items.Clear();
                flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox26.Items.Clear();
                flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox27.Items.Clear();
                flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox28.Items.Clear();
                flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox29.Items.Clear();
                flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox30.Items.Clear();
                flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox31.Items.Clear();
                flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox32.Items.Clear();
                flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                flatComboBox33.Items.Clear();
                flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.R3Name);
                //infoBtn.Text = "Tranzit";
                MapWeapon = "Tranzit";
                infoBtn.Refresh();


            }
            else if (Func.ServerInfo.MapName() == "Die Rise")
            {
                //infoBtn.Text = "Die Rise";
                MapWeapon = "Die Rise";
                flatButton6.Enabled = true;
                infoBtn.Refresh();
                //griefBox.Visible = false;
                flatComboBox2.Items.Clear();
                flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox3.Items.Clear();
                flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox4.Items.Clear();
                flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox5.Items.Clear();
                flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox6.Items.Clear();
                //flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox7.Items.Clear();
                //flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox8.Items.Clear();
                //flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox9.Items.Clear();
                //flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox10.Items.Clear();
                flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox11.Items.Clear();
                flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox12.Items.Clear();
                flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox13.Items.Clear();
                flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.FillCombo());
                flatComboBox14.Items.Clear();
                //flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox15.Items.Clear();
                //flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox16.Items.Clear();
                //flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox17.Items.Clear();
                //flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.FillCombo());
                flatComboBox18.Items.Clear();
                flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
                flatComboBox19.Items.Clear();
                flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
                flatComboBox20.Items.Clear();
                flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
                flatComboBox21.Items.Clear();
                flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.EquipName);
                flatComboBox22.Items.Clear();
                //flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox23.Items.Clear();
                //flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox24.Items.Clear();
                //flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox25.Items.Clear();
                //flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.Tranzit.EquipName);
                flatComboBox26.Items.Clear();
                flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox27.Items.Clear();
                flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox28.Items.Clear();
                flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox29.Items.Clear();
                flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox30.Items.Clear();
                //flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox31.Items.Clear();
                //flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox32.Items.Clear();
                //flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);
                flatComboBox33.Items.Clear();
                //flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.DieRise.R3Name);

            }
            else if (Func.ServerInfo.MapName() == "MOTD")
            {
                griefBox.Visible = true;
                //infoBtn.Text = "MOTD";
                MapWeapon = "MOTD";
                flatButton6.Enabled = true;
                infoBtn.Refresh();
                flatComboBox2.Items.Clear();
                flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox3.Items.Clear();
                flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox4.Items.Clear();
                flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox5.Items.Clear();
                flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox6.Items.Clear();
                flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox7.Items.Clear();
                flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox8.Items.Clear();
                flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox9.Items.Clear();
                flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox10.Items.Clear();
                flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox11.Items.Clear();
                flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox12.Items.Clear();
                flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox13.Items.Clear();
                flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox14.Items.Clear();
                flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox15.Items.Clear();
                flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox16.Items.Clear();
                flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox17.Items.Clear();
                flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.FillCombo());
                flatComboBox18.Items.Clear();
                flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox19.Items.Clear();
                flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox20.Items.Clear();
                flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox21.Items.Clear();
                flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox22.Items.Clear();
                flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox23.Items.Clear();
                flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox24.Items.Clear();
                flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox25.Items.Clear();
                flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox26.Items.Clear();
                flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox27.Items.Clear();
                flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox28.Items.Clear();
                flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox29.Items.Clear();
                flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox30.Items.Clear();
                flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox31.Items.Clear();
                flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox32.Items.Clear();
                flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox33.Items.Clear();
                flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            }
            else if (Func.ServerInfo.MapName() == "Buried")
            {
                griefBox.Visible = true;
                //infoBtn.Text = "Buried";
                MapWeapon = "Buried";
                flatButton6.Enabled = true;
                infoBtn.Refresh();
                flatComboBox2.Items.Clear();
                flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox3.Items.Clear();
                flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox4.Items.Clear();
                flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox5.Items.Clear();
                flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox6.Items.Clear();
                flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox7.Items.Clear();
                flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox8.Items.Clear();
                flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox9.Items.Clear();
                flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox10.Items.Clear();
                flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox11.Items.Clear();
                flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox12.Items.Clear();
                flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox13.Items.Clear();
                flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox14.Items.Clear();
                flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox15.Items.Clear();
                flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox16.Items.Clear();
                flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox17.Items.Clear();
                flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Buried.FillCombo());
                flatComboBox18.Items.Clear();
                flatComboBox19.Items.Clear();
                flatComboBox20.Items.Clear();
                flatComboBox21.Items.Clear();
                flatComboBox22.Items.Clear();
                flatComboBox23.Items.Clear();
                flatComboBox24.Items.Clear();
                flatComboBox25.Items.Clear();
                flatComboBox26.Items.Clear();
                flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox27.Items.Clear();
                flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox28.Items.Clear();
                flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox29.Items.Clear();
                flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox30.Items.Clear();
                flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox31.Items.Clear();
                flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox32.Items.Clear();
                flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
                flatComboBox33.Items.Clear();
                flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.Buried.R3Name);
            }
            else if (Func.ServerInfo.MapName() == "Origins")
            {
                //infoBtn.Text = "Origins";
                MapWeapon = "Origins";
                flatButton6.Enabled = true;
                infoBtn.Refresh();
                flatComboBox2.Items.Clear();
                flatComboBox2.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox3.Items.Clear();
                flatComboBox3.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox4.Items.Clear();
                flatComboBox4.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox5.Items.Clear();
                flatComboBox5.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox6.Items.Clear();
                //flatComboBox6.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox7.Items.Clear();
                //flatComboBox7.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox8.Items.Clear();
                //flatComboBox8.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox9.Items.Clear();
                //flatComboBox9.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox10.Items.Clear();
                flatComboBox10.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox11.Items.Clear();
                flatComboBox11.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox12.Items.Clear();
                flatComboBox12.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox13.Items.Clear();
                flatComboBox13.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                //flatComboBox14.Items.Clear();
                //flatComboBox14.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                //flatComboBox15.Items.Clear();
                //flatComboBox15.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                //flatComboBox16.Items.Clear();
                //flatComboBox16.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                //flatComboBox17.Items.Clear();
                //flatComboBox17.Items.AddRange(BIS.ZM.GiveWeapon.Origins.FillCombo());
                flatComboBox18.Items.Clear();
                flatComboBox18.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
                flatComboBox19.Items.Clear();
                flatComboBox19.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
                flatComboBox20.Items.Clear();
                flatComboBox20.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
                flatComboBox21.Items.Clear();
                flatComboBox21.Items.AddRange(BIS.ZM.GiveWeapon.Origins.EquipName);
                flatComboBox22.Items.Clear();
                //flatComboBox22.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox23.Items.Clear();
                //flatComboBox23.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox24.Items.Clear();
                //flatComboBox24.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox25.Items.Clear();
                //flatComboBox25.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.EquipName);
                flatComboBox26.Items.Clear();
                flatComboBox26.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
                flatComboBox27.Items.Clear();
                flatComboBox27.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
                flatComboBox28.Items.Clear();
                flatComboBox28.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
                flatComboBox29.Items.Clear();
                flatComboBox29.Items.AddRange(BIS.ZM.GiveWeapon.Origins.R3Name);
                flatComboBox30.Items.Clear();
                //flatComboBox30.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox31.Items.Clear();
                //flatComboBox31.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox32.Items.Clear();
                //flatComboBox32.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
                flatComboBox33.Items.Clear();
                //flatComboBox33.Items.AddRange(BIS.ZM.GiveWeapon.MOTD.R3Name);
            }
            else
            {
                MessageBox.Show("You Are Not In Game Or Map Not Supported ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flatCheckBox40_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(0);
        }

        private void flatCheckBox39_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(1);
        }

        private void flatCheckBox38_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(2);
        }

        private void flatCheckBox37_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(3);
        }

        private void flatCheckBox36_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(4);
        }

        private void flatCheckBox35_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(5);
        }

        private void flatCheckBox34_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(6);
        }

        private void flatCheckBox33_CheckedChanged(object sender)
        {
            Func.ClientMods.ZM.Thug(7);
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.RandomCamo(0);
            Func.ClientMods.ZM.RandomCamo(1);
            Func.ClientMods.ZM.RandomCamo(2);
            Func.ClientMods.ZM.RandomCamo(3);
            Func.ClientMods.ZM.RandomCamo(4);
            Func.ClientMods.ZM.RandomCamo(5);
            Func.ClientMods.ZM.RandomCamo(6);
            Func.ClientMods.ZM.RandomCamo(7);
        }

        private void mapStaTi_Tick(object sender, EventArgs e)
        {
            string Map = Func.ServerInfo.MapName();
            if (Map != MapWeapon)
            {
                weaponBtn.Text = "Get Map Weapons";
                weaponBtn.Refresh();
                flatButton6.Enabled = false;
                weaponBox.Enabled = false;
                mapStaTi.Stop();
            }
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(0, flatComboBox1.Text);
        }

        private void flatComboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(1, flatComboBox34.Text);
        }

        private void flatComboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(2, flatComboBox35.Text);
        }

        private void flatComboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(3, flatComboBox36.Text);
        }

        private void flatComboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(4, flatComboBox37.Text);
        }

        private void flatComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(5, flatComboBox38.Text);
        }

        private void flatComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(6, flatComboBox39.Text);
        }

        private void flatComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.SetModel(7, flatComboBox40.Text);
        }

        private void flyModeBar_Scroll(object sender)
        {
            if (noClipBar.Value == 0)
                Func.LobbyMods.NoClip(false);
            else if (noClipBar.Value == 1)
                Func.LobbyMods.NoClip(true);
        }

        private void setSelectedBtn_Click(object sender, EventArgs e)
        {
            if (prestigeCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Kills, BitConverter.GetBytes((int)prestigeNum.Value));
            }
            if (levelCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Deaths, BitConverter.GetBytes((int)levelNum.Value));
            }
            if (winsCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Downs, BitConverter.GetBytes((int)winsNum.Value));
            }
            if (lossesCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Perks, BitConverter.GetBytes((int)lossesNum.Value));
            }
            if (killsCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Miles, BitConverter.GetBytes(Convert.ToInt32(killsNum.Value)));
            }
            if (deathsCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Bullets, BitConverter.GetBytes(Convert.ToInt32(deathsNum.Value)));
            }
            if (scoreCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Grenades, BitConverter.GetBytes(Convert.ToInt32(scoreNum.Value)));
            }
            if (tokensCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.Gibs, BitConverter.GetBytes(Convert.ToInt32(tokensNum.Value)));
            }
            if (headSCh.Checked)
            {
                Functions.SetMem(Offsets.Stats.ZM.HeadShots, BitConverter.GetBytes(Convert.ToInt32(headSNum.Value)));
            }
            if (nuclearCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Stats.ZM.Doors, BitConverter.GetBytes(Convert.ToInt32(nuclearNum.Value)));
            }
            if (nuclearCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Stats.ZM.Hits, BitConverter.GetBytes(Convert.ToInt32(unstoNum.Value)));
            }
            if (nuclearCh.Checked)
            {
                Functions.SetMem((uint)Offsets.Stats.ZM.Revives, BitConverter.GetBytes(Convert.ToInt32(brutalNum.Value)));
            }
        }

        private void prestigeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.Stats.SetPrestige(prestigeCombo.SelectedIndex);
        }

        private void levelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.ZM.Stats.SetLevel(levelCombo.SelectedIndex);
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
                BOIIfrm.DText.TypeText(textBox_SW.Text);
            }
        }

        private void TWDHfrmBtn_Click(object sender, EventArgs e)
        {
            TWDH tfrm = new TWDH();
            tfrm.Show();
        }

        private void lowstatsBtn_Click(object sender, EventArgs e)
        {
            prestigeNum.Value = 11254;
            levelNum.Value = 642;
            winsNum.Value = 1123;
            lossesNum.Value = 1599;
            killsNum.Value = 2156;
            deathsNum.Value = 31258;
            scoreNum.Value = 1032;
            tokensNum.Value = 200;
            headSNum.Value = 8695;
            nuclearNum.Value = 658;
            unstoNum.Value = 2458;
            brutalNum.Value = 1236;
        }

        private void legitSt_Click(object sender, EventArgs e)
        {
            prestigeNum.Value = 16254;
            levelNum.Value = 1642;
            winsNum.Value = 1758;
            lossesNum.Value = 1599;
            killsNum.Value = 2156;
            deathsNum.Value = 44152;
            scoreNum.Value = 1478;
            tokensNum.Value = 200;
            headSNum.Value = 8695;
            nuclearNum.Value = 658;
            unstoNum.Value = 4266;
            brutalNum.Value = 1236;
        }

        private void highSt_Click(object sender, EventArgs e)
        {
            prestigeNum.Value = 216254;
            levelNum.Value = 642;
            winsNum.Value = 859;
            lossesNum.Value = 1599;
            killsNum.Value = 2156;
            deathsNum.Value = 96857;
            scoreNum.Value = 41548;
            tokensNum.Value = 200;
            headSNum.Value = 8695;
            nuclearNum.Value = 658;
            unstoNum.Value = 4266;
            brutalNum.Value = 1236;
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
            }
        }

        private void spawnBar_Scroll(object sender)
        {
            if (spawnBar.Value == 0)
            {
                Func.ClientMods.ZM.ZombieSpawn(true);
            }
            else if (spawnBar.Value == 1)
            {
                Func.ClientMods.ZM.ZombieSpawn(false);
            }
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

        private void flashName_CheckedChanged(object sender)
        {
            if (flashName.Checked)
            {
                nameTimer.Start();
            }
            else
            {
                nameTimer.Stop();
                BOIIfrm.SetName(nameBox.Text);
            }
        }
         

        private void nameTimer_Tick(object sender, EventArgs e)
        {
            if (flashName.Checked)
            {
                int BIS = new Random().Next(0, 9);
                BOIIfrm.SetName("^" + BIS + nameBox.Text);
            }
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

        private void flatComboBox77_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(0, BIS.Client.Client_Index[flatComboBox77.SelectedIndex]);
        }

        private void flatComboBox76_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(1, BIS.Client.Client_Index[flatComboBox76.SelectedIndex]);
        }

        private void flatComboBox75_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(2, BIS.Client.Client_Index[flatComboBox75.SelectedIndex]);
        }

        private void flatComboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(3, BIS.Client.Client_Index[flatComboBox69.SelectedIndex]);
        }

        private void flatComboBox68_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(4, BIS.Client.Client_Index[flatComboBox68.SelectedIndex]);
        }

        private void flatComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(5, BIS.Client.Client_Index[flatComboBox43.SelectedIndex]);
        }

        private void flatComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(6, BIS.Client.Client_Index[flatComboBox42.SelectedIndex]);
        }

        private void flatComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.ClientMods.TeleportClient(7, BIS.Client.Client_Index[flatComboBox41.SelectedIndex]);
        }

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
            Func.ClientMods.TeleportClient(flatComboBox87.SelectedIndex, 3);
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

        private void flatButton2_Click(object sender, EventArgs e)
        {
            textBox16.Text = Func.ClientMods.GetPlayerName(0);
            textBox15.Text = Func.ClientMods.GetPlayerName(1);
            textBox14.Text = Func.ClientMods.GetPlayerName(2);
            textBox13.Text = Func.ClientMods.GetPlayerName(3);
            textBox12.Text = Func.ClientMods.GetPlayerName(4);
            textBox11.Text = Func.ClientMods.GetPlayerName(5);
            textBox2.Text = Func.ClientMods.GetPlayerName(6);
            textBox1.Text = Func.ClientMods.GetPlayerName(7);
            mapLbl1.Text = "Map : " + Func.ServerInfo.MapName();
            gameLbl1.Text = "GMod : " + Func.ServerInfo.GameType();
        }

        private void flatButton116_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(0, BISOON);
            }
        }

        private void flatButton115_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(1, BISOON);
            }
        }

        private void flatButton114_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(2, BISOON);
            }
        }

        private void flatButton113_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(3, BISOON);
            }
        }

        private void flatButton112_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(4, BISOON);
            }
        }

        private void flatButton111_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(5, BISOON);
            }
        }

        private void flatButton110_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(6, BISOON);
            }
        }

        private void flatButton109_Click(object sender, EventArgs e)
        {
            for (int BISOON = 0; BISOON < 8; BISOON++)
            {
                Func.ClientMods.TeleportClient(7, BISOON);
            }
        }

        private void zmInject_Click(object sender, EventArgs e)
        {
            Inject.Injects(Inject.InjectMod.Zombie);
        }
        private void setRoundsBtn_Click(object sender, EventArgs e)
        {
            Connectionfrm.PS3.SetMemory(0x26FCA80, BitConverter.GetBytes(Convert.ToInt32(roundsNum.Value)));
        }
    }
}
