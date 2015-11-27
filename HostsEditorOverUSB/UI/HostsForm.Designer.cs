namespace HostsEditorOverUSB
{
    partial class HostsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hostsBox = new System.Windows.Forms.RichTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.iPadPicture = new System.Windows.Forms.PictureBox();
            this.iPhonePicture = new System.Windows.Forms.PictureBox();
            this.iPodPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iOSVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cpuArch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.installedApps = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPadPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPodPicture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please pay attention while editing the hosts file! \r\n Remember leaving           " +
    "       at the end of the file!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hostsBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 298);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hostsfile";
            // 
            // hostsBox
            // 
            this.hostsBox.Location = new System.Drawing.Point(6, 19);
            this.hostsBox.Name = "hostsBox";
            this.hostsBox.Size = new System.Drawing.Size(410, 273);
            this.hostsBox.TabIndex = 0;
            this.hostsBox.Text = "";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(127, 454);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(181, 47);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit changes";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // iPadPicture
            // 
            this.iPadPicture.Image = ((System.Drawing.Image)(resources.GetObject("iPadPicture.Image")));
            this.iPadPicture.Location = new System.Drawing.Point(448, 1);
            this.iPadPicture.Name = "iPadPicture";
            this.iPadPicture.Size = new System.Drawing.Size(208, 212);
            this.iPadPicture.TabIndex = 6;
            this.iPadPicture.TabStop = false;
            // 
            // iPhonePicture
            // 
            this.iPhonePicture.Image = ((System.Drawing.Image)(resources.GetObject("iPhonePicture.Image")));
            this.iPhonePicture.Location = new System.Drawing.Point(448, 1);
            this.iPhonePicture.Name = "iPhonePicture";
            this.iPhonePicture.Size = new System.Drawing.Size(208, 208);
            this.iPhonePicture.TabIndex = 7;
            this.iPhonePicture.TabStop = false;
            // 
            // iPodPicture
            // 
            this.iPodPicture.Image = ((System.Drawing.Image)(resources.GetObject("iPodPicture.Image")));
            this.iPodPicture.Location = new System.Drawing.Point(448, 1);
            this.iPodPicture.Name = "iPodPicture";
            this.iPodPicture.Size = new System.Drawing.Size(208, 208);
            this.iPodPicture.TabIndex = 8;
            this.iPodPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Device Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "__________________________";
            // 
            // deviceName
            // 
            this.deviceName.AutoSize = true;
            this.deviceName.Location = new System.Drawing.Point(122, 19);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(38, 13);
            this.deviceName.TabIndex = 12;
            this.deviceName.Tag = "";
            this.deviceName.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "iOS Version:";
            // 
            // iOSVersion
            // 
            this.iOSVersion.AutoSize = true;
            this.iOSVersion.Location = new System.Drawing.Point(122, 47);
            this.iOSVersion.Name = "iOSVersion";
            this.iOSVersion.Size = new System.Drawing.Size(25, 13);
            this.iOSVersion.TabIndex = 14;
            this.iOSVersion.Text = "IOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "CPU Arch:";
            // 
            // cpuArch
            // 
            this.cpuArch.AutoSize = true;
            this.cpuArch.Location = new System.Drawing.Point(122, 80);
            this.cpuArch.Name = "cpuArch";
            this.cpuArch.Size = new System.Drawing.Size(59, 13);
            this.cpuArch.TabIndex = 16;
            this.cpuArch.Text = "CPUARCH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(15, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Installed Apps:";
            // 
            // installedApps
            // 
            this.installedApps.AccessibleDescription = "g";
            this.installedApps.AutoSize = true;
            this.installedApps.Location = new System.Drawing.Point(122, 113);
            this.installedApps.Name = "installedApps";
            this.installedApps.Size = new System.Drawing.Size(53, 13);
            this.installedApps.TabIndex = 18;
            this.installedApps.Text = "INSAPPS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.installedApps);
            this.groupBox3.Controls.Add(this.deviceName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cpuArch);
            this.groupBox3.Controls.Add(this.iOSVersion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(448, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 147);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "__________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(158, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "one line";
            // 
            // HostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 507);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iPodPicture);
            this.Controls.Add(this.iPhonePicture);
            this.Controls.Add(this.iPadPicture);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HostsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "r";
            this.Text = "Hostsfile-Editor";
            this.Shown += new System.EventHandler(this.HostsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iPadPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPhonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPodPicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox hostsBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox iPadPicture;
        private System.Windows.Forms.PictureBox iPhonePicture;
        private System.Windows.Forms.PictureBox iPodPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deviceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label iOSVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cpuArch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label installedApps;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}