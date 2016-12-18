namespace FormatTool
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cb_disk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ref = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_agreed = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_repart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_disk
            // 
            this.cb_disk.FormattingEnabled = true;
            this.cb_disk.Location = new System.Drawing.Point(263, 179);
            this.cb_disk.Name = "cb_disk";
            this.cb_disk.Size = new System.Drawing.Size(74, 20);
            this.cb_disk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择待调整的驱动器";
            // 
            // bt_ref
            // 
            this.bt_ref.Location = new System.Drawing.Point(343, 177);
            this.bt_ref.Name = "bt_ref";
            this.bt_ref.Size = new System.Drawing.Size(75, 23);
            this.bt_ref.TabIndex = 2;
            this.bt_ref.Text = "刷新";
            this.bt_ref.UseVisualStyleBackColor = true;
            this.bt_ref.Click += new System.EventHandler(this.bt_ref_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "2、请确保所选择的移动设备上的一个或多个逻辑磁盘的所有数据，都可以被完全格式化！";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "3、此工具有损坏移动存储器的风险，请一定要备份好数据后使用！";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "4、此工具开发者不会承担任何因为使用此工具造成的数据或磁盘损坏的责任！";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_agreed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "警告信息";
            // 
            // cb_agreed
            // 
            this.cb_agreed.AutoSize = true;
            this.cb_agreed.Location = new System.Drawing.Point(116, 118);
            this.cb_agreed.Name = "cb_agreed";
            this.cb_agreed.Size = new System.Drawing.Size(348, 16);
            this.cb_agreed.TabIndex = 4;
            this.cb_agreed.Text = "我已经阅读，并知晓，我将自行承担使用此工具的全部其后果";
            this.cb_agreed.UseVisualStyleBackColor = true;
            this.cb_agreed.CheckedChanged += new System.EventHandler(this.cb_agreed_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "1、此工具用于针对非标准的分区信息进行调整，如果有多个分区将会被自动合并！";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(467, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "5、请先关闭杀毒软件后，以管理员身份运行，或在杀毒软件警告时要允许此工具运行！";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "欢迎技术交流: ";
            // 
            // bt_repart
            // 
            this.bt_repart.Font = new System.Drawing.Font("宋体", 15F);
            this.bt_repart.Location = new System.Drawing.Point(186, 217);
            this.bt_repart.Name = "bt_repart";
            this.bt_repart.Size = new System.Drawing.Size(191, 37);
            this.bt_repart.TabIndex = 2;
            this.bt_repart.Text = "执行分区还原";
            this.bt_repart.UseVisualStyleBackColor = true;
            this.bt_repart.Click += new System.EventHandler(this.bt_repart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(87, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "执行分区调整完成后，请重新插拔移动设备，并自行格式化后才能使用！";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(272, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FML927@LIVE.COM";
            
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(554, 302);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_repart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_ref);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_disk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(570, 341);
            this.MinimumSize = new System.Drawing.Size(570, 341);
            this.Name = "FormMain";
            this.Text = "U盘分区调整工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_disk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_agreed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_repart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

