using FNCS_PickAxe_Swapper.Properties;
using JustJosh_Swapper_NOT_THE_NAME;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNCS_PickAxe_Swapper
{
    public partial class Form1 : Form
    {
        public static void SwapBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }
        bool showswaptime = true;
        private long offset1 = 351158272;
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = (Properties.Settings.Default.pakspath + @"\pakchunk10-WindowsClient.ucas");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwapBytes(filePath, offset1, API.ShodowSlicer);
            SwapBytes(filePath, offset1, API.Champions);
            richTextBox1.AppendText("\n[LOG] added Pickaxe 1/1");
            richTextBox1.AppendText("\n[LOG] Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            SwapBytes(filePath, offset1, API.Champions);
            SwapBytes(filePath, offset1, API.ShodowSlicer);
            richTextBox1.AppendText("\n[LOG] removed Pickaxe 1/1");
            richTextBox1.AppendText("\n[LOG] Done");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
        }
    }
}
