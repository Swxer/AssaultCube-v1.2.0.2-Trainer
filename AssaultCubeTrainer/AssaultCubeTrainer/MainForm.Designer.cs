
namespace AssaultCubeTrainer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.infiniteAmmo = new System.Windows.Forms.CheckBox();
            this.infiniteHealth = new System.Windows.Forms.CheckBox();
            this.infiniteGrenade = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ammoInput = new System.Windows.Forms.TextBox();
            this.healthInput = new System.Windows.Forms.TextBox();
            this.grenadeInput = new System.Windows.Forms.TextBox();
            this.ammoButton = new System.Windows.Forms.Button();
            this.healthButton = new System.Windows.Forms.Button();
            this.grenadeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(68, 13);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // infiniteAmmo
            // 
            this.infiniteAmmo.AutoSize = true;
            this.infiniteAmmo.Location = new System.Drawing.Point(16, 75);
            this.infiniteAmmo.Name = "infiniteAmmo";
            this.infiniteAmmo.Size = new System.Drawing.Size(89, 17);
            this.infiniteAmmo.TabIndex = 2;
            this.infiniteAmmo.Text = "Infinite Ammo";
            this.infiniteAmmo.UseVisualStyleBackColor = true;
            // 
            // infiniteHealth
            // 
            this.infiniteHealth.AutoSize = true;
            this.infiniteHealth.Location = new System.Drawing.Point(16, 113);
            this.infiniteHealth.Name = "infiniteHealth";
            this.infiniteHealth.Size = new System.Drawing.Size(91, 17);
            this.infiniteHealth.TabIndex = 3;
            this.infiniteHealth.Text = "Infinite Health";
            this.infiniteHealth.UseVisualStyleBackColor = true;
            // 
            // infiniteGrenade
            // 
            this.infiniteGrenade.AutoSize = true;
            this.infiniteGrenade.Location = new System.Drawing.Point(16, 153);
            this.infiniteGrenade.Name = "infiniteGrenade";
            this.infiniteGrenade.Size = new System.Drawing.Size(101, 17);
            this.infiniteGrenade.TabIndex = 4;
            this.infiniteGrenade.Text = "Infinite Grenade";
            this.infiniteGrenade.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trainer programmed by Steven Long Nguyen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount will be locked to 9999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Choose any amount you desire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ammo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Health";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Grenade";
            // 
            // ammoInput
            // 
            this.ammoInput.Location = new System.Drawing.Point(344, 73);
            this.ammoInput.Name = "ammoInput";
            this.ammoInput.Size = new System.Drawing.Size(80, 20);
            this.ammoInput.TabIndex = 13;
            // 
            // healthInput
            // 
            this.healthInput.Location = new System.Drawing.Point(344, 110);
            this.healthInput.Name = "healthInput";
            this.healthInput.Size = new System.Drawing.Size(80, 20);
            this.healthInput.TabIndex = 14;
            // 
            // grenadeInput
            // 
            this.grenadeInput.Location = new System.Drawing.Point(344, 150);
            this.grenadeInput.Name = "grenadeInput";
            this.grenadeInput.Size = new System.Drawing.Size(80, 20);
            this.grenadeInput.TabIndex = 15;
            // 
            // ammoButton
            // 
            this.ammoButton.Location = new System.Drawing.Point(430, 73);
            this.ammoButton.Name = "ammoButton";
            this.ammoButton.Size = new System.Drawing.Size(52, 19);
            this.ammoButton.TabIndex = 16;
            this.ammoButton.Text = "Set";
            this.ammoButton.UseVisualStyleBackColor = true;
            this.ammoButton.Click += new System.EventHandler(this.ammoButton_Click);
            // 
            // healthButton
            // 
            this.healthButton.Location = new System.Drawing.Point(430, 111);
            this.healthButton.Name = "healthButton";
            this.healthButton.Size = new System.Drawing.Size(52, 19);
            this.healthButton.TabIndex = 17;
            this.healthButton.Text = "Set";
            this.healthButton.UseVisualStyleBackColor = true;
            this.healthButton.Click += new System.EventHandler(this.healthButton_Click);
            // 
            // grenadeButton
            // 
            this.grenadeButton.Location = new System.Drawing.Point(430, 150);
            this.grenadeButton.Name = "grenadeButton";
            this.grenadeButton.Size = new System.Drawing.Size(52, 19);
            this.grenadeButton.TabIndex = 18;
            this.grenadeButton.Text = "Set";
            this.grenadeButton.UseVisualStyleBackColor = true;
            this.grenadeButton.Click += new System.EventHandler(this.grenadeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 227);
            this.Controls.Add(this.grenadeButton);
            this.Controls.Add(this.healthButton);
            this.Controls.Add(this.ammoButton);
            this.Controls.Add(this.grenadeInput);
            this.Controls.Add(this.healthInput);
            this.Controls.Add(this.ammoInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infiniteGrenade);
            this.Controls.Add(this.infiniteHealth);
            this.Controls.Add(this.infiniteAmmo);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "AssaultCube v1.2.0.2 Trainer x86";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.CheckBox infiniteAmmo;
        private System.Windows.Forms.CheckBox infiniteHealth;
        private System.Windows.Forms.CheckBox infiniteGrenade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ammoInput;
        private System.Windows.Forms.TextBox healthInput;
        private System.Windows.Forms.TextBox grenadeInput;
        private System.Windows.Forms.Button ammoButton;
        private System.Windows.Forms.Button healthButton;
        private System.Windows.Forms.Button grenadeButton;
    }
}

