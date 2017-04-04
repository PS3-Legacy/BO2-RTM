using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Ops_II_By_BISOON
{
    class BG
    {
        public static void ChangeBG()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "DDS File|*.dds";
            op.Title = "BISOON's Image Injector";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Functions.SetMem(0xcad88480, File.ReadAllBytes(op.FileName));
            }
        }
    }
}
