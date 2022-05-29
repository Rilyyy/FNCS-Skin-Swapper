using FNCS_PickAxe_Swapper.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNCS_PickAxe_Swapper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Settings.Default.pakspath;
        }
        public static string GetPaksFolder
        {
            get { return Settings.Default.pakspath; }

        }
        public static string GetStrechedFolder
        {
            get { return Settings.Default.strechedFolder; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Settings.Default.pakspath = dialog.FileName;
                Settings.Default.Save();
                textBox1.Text = Settings.Default.pakspath;
            }
        }
    }
}
