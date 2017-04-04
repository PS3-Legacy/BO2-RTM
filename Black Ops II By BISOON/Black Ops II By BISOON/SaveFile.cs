using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    class SaveFile
    {
        public static void SaveBinFile(uint Offset,int Length, string Title, string FileName)
        {
            try
            {
                SaveFileDialog SaveBin = new SaveFileDialog();
                SaveBin.FileName = "My BO II " + FileName;
                SaveBin.Filter = "Bin Files|*.bin";
                SaveBin.Title = "|- BISOON's " + Title + " -|  Save As ";
                if (SaveBin.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(SaveBin.FileName, Connectionfrm.PS3.Extension.ReadBytes(Offset, Length));
                    MessageBox.Show("Your " + FileName + " Successfully Saved ", "Stats", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Unable To Save", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadBinFile(uint Offset,string Title, string FileName)
        {
            try
            {
                OpenFileDialog Loadbin = new OpenFileDialog();
                Loadbin.FileName = "My BO II " + FileName;
                Loadbin.Filter = "BIN Files |*.bin";
                Loadbin.Title = "|- BISOON's " + Title + " -|  Load Stats File ";
                if (Loadbin.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = File.ReadAllBytes(Loadbin.FileName);
                    Connectionfrm.PS3.Extension.WriteBytes(Offset, buffer);
                    MessageBox.Show("Your " + FileName + " Successfully Loaded ", "Stats", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Unable To Load", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
