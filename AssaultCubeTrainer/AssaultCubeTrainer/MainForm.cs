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
using Memory;

// AssaultCube Trainer created by Steven Long Nguyen z5319929 2022

namespace AssaultCubeTrainer
{
    public partial class MainForm : Form
    {
        // this Mem structure are from the package Memory.dll
        public Mem m = new Mem();

        string ammoAddress = "base+0010A280,8,458,70,4e0";
        string healthAddress = "base+0010F418,58,200,48,1e8,8,f8";
        string grenadeAddress = "base+0010F418,58,1d8,48,1f8,40,28";
        public MainForm()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // look for the game processor
            ProcOpen = m.OpenProcess("ac_client.exe");

            // prevent overusing CPU
            Thread.Sleep(500);
            BGWorker.ReportProgress(0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // this function will loop constantly, to ensure that the hacked value will be locked if checked

            if (ProcOpen) {
                // game is found
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Game Found";
            }
            else {
                // game is not yet found or closed
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
            }

            // the following memory address for these are obtained from Cheat Engine
            if (infiniteHealth.Checked) {
                m.WriteMemory(healthAddress, "int", "9999");
            }

            if (infiniteAmmo.Checked) {
                m.WriteMemory(ammoAddress, "int", "9999");
            }

            if (infiniteGrenade.Checked) {
                m.WriteMemory(grenadeAddress, "int", "9999");
            }

        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        // These button function will write the new value into the following addresses
        private void ammoButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory(ammoAddress, "int", ammoInput.Text);
        }

        private void healthButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory(healthAddress, "int", healthInput.Text);
        }

        private void grenadeButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory(grenadeAddress, "int", grenadeInput.Text);
        }
    }
}
