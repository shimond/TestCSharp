using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCancel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtLogs.Clear();
            AddToLog("btnStart_Click Started.");
            await MethodA();
            AddToLog("btnStart_Click Finished.");
        }

        private async Task MethodA()
        {
            for (int i = 1; i <= 3; i++)
            {
                await Task.Delay(2000);
                AddToLog($"Method A {i}");
            }
        }

        private void AddToLog(string str)
        {
            txtLogs.AppendText($"{str}{Environment.NewLine}");
        }


    }
}
