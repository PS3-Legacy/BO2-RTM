using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    class Inject
    {
        static bool ClientInGame()
        {
            return Connectionfrm.PS3.Extension.ReadBool(0x1CB68E8);
        }
        public enum InjectMod
        {
            MultiPlayer = 0,
            Zombie = 1
        }
        public static void Injects(InjectMod Mod)
        {
            if (ClientInGame())
            {
                int start_offset = 0x10040000;
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "GSC File|*.gsc";
                open.Title = "BISOON's Injector";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int input = 0;
                        UInt32 num = 0;
                        byte[] Bytes = null;
                        byte[] buffer = null;
                        input = start_offset;
                        if (Mod == 0)
                        {
                            RPC.Call(0x18ac04, new object[] {
			Convert.ToUInt32(input),
			0x33,
			"maps/mp/gametypes/_clientids.gsc",
			1,
			-1
		});
                        }

                        else if ((int)Mod == 1)
                        {
                            RPC.Call(0x18ac04, new object[] {
			Convert.ToUInt32(input),
			0x33,
			"maps/mp/gametypes_zm/_clientids.gsc",
			1,
			-1
		});
                        }
                        num = Connectionfrm.PS3.Extension.ReadUInt32(Convert.ToUInt32(input));
                        buffer = File.ReadAllBytes(open.FileName);
                        Bytes = new byte[buffer.Length];
                        Array.Copy(buffer, Bytes, buffer.Length);
                        if (((num != 0) && (input != 0)))
                        {
                            Connectionfrm.PS3.Extension.WriteInt32((num + 8), input);
                            Connectionfrm.PS3.SetMemory(Convert.ToUInt32(input), Bytes);
                            start_offset = (input + Bytes.Length + 8);
                            MessageBox.Show("GSC Successfully Loaded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Couldn't Load The Menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("ERROR: " + Ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Need To Be In Game To Load The GSC File","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
