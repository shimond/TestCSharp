using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCancel
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource _tokenSource;
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            _tokenSource = new CancellationTokenSource();
            txtLogs.Clear();
            AddToLog("btnStart_Click Started.");
            try
            {
                await MethodA(_tokenSource.Token);
            }
            catch (TaskCanceledException)
            {
                AddToLog("MethodA Canceld.");
            }
            AddToLog("btnStart_Click Finished.");
        }

        private async Task MethodA(CancellationToken token)
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(2000, token);
                AddToLog($"Method A {i}");
            }
        }

        private void AddToLog(string str)
        {
            txtLogs.AppendText($"{str}{Environment.NewLine}");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }
    }
}
