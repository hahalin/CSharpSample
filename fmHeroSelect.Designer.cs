﻿namespace acerclass
{
    partial class fmHeroSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbslogan = new System.Windows.Forms.Label();
            this.rdpower = new System.Windows.Forms.RadioButton();
            this.rdmagic = new System.Windows.Forms.RadioButton();
            this.rdiq = new System.Windows.Forms.RadioButton();
            this.rdfly = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdwest = new System.Windows.Forms.RadioButton();
            this.rdeast = new System.Windows.Forms.RadioButton();
            this.lbname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(867, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "載入英雄清單";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbslogan
            // 
            this.lbslogan.AutoSize = true;
            this.lbslogan.BackColor = System.Drawing.Color.DarkMagenta;
            this.lbslogan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbslogan.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbslogan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbslogan.Location = new System.Drawing.Point(581, 409);
            this.lbslogan.Name = "lbslogan";
            this.lbslogan.Size = new System.Drawing.Size(37, 40);
            this.lbslogan.TabIndex = 1;
            this.lbslogan.Text = "  ";
            this.lbslogan.Click += new System.EventHandler(this.lbslogan_Click);
            // 
            // rdpower
            // 
            this.rdpower.AutoSize = true;
            this.rdpower.BackColor = System.Drawing.Color.Transparent;
            this.rdpower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdpower.Location = new System.Drawing.Point(22, 107);
            this.rdpower.Name = "rdpower";
            this.rdpower.Size = new System.Drawing.Size(106, 37);
            this.rdpower.TabIndex = 2;
            this.rdpower.TabStop = true;
            this.rdpower.Text = "力量";
            this.rdpower.UseVisualStyleBackColor = false;
            // 
            // rdmagic
            // 
            this.rdmagic.AutoSize = true;
            this.rdmagic.BackColor = System.Drawing.Color.Transparent;
            this.rdmagic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdmagic.Location = new System.Drawing.Point(137, 107);
            this.rdmagic.Name = "rdmagic";
            this.rdmagic.Size = new System.Drawing.Size(106, 37);
            this.rdmagic.TabIndex = 3;
            this.rdmagic.TabStop = true;
            this.rdmagic.Text = "魔法";
            this.rdmagic.UseVisualStyleBackColor = false;
            // 
            // rdiq
            // 
            this.rdiq.AutoSize = true;
            this.rdiq.BackColor = System.Drawing.Color.Transparent;
            this.rdiq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdiq.Location = new System.Drawing.Point(263, 107);
            this.rdiq.Name = "rdiq";
            this.rdiq.Size = new System.Drawing.Size(106, 37);
            this.rdiq.TabIndex = 4;
            this.rdiq.TabStop = true;
            this.rdiq.Text = "智力";
            this.rdiq.UseVisualStyleBackColor = false;
            // 
            // rdfly
            // 
            this.rdfly.AutoSize = true;
            this.rdfly.BackColor = System.Drawing.Color.Transparent;
            this.rdfly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdfly.Location = new System.Drawing.Point(381, 107);
            this.rdfly.Name = "rdfly";
            this.rdfly.Size = new System.Drawing.Size(106, 37);
            this.rdfly.TabIndex = 5;
            this.rdfly.TabStop = true;
            this.rdfly.Text = "飛行";
            this.rdfly.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(355, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(12, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 484);
            this.listBox1.TabIndex = 8;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(504, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 102);
            this.button1.TabIndex = 9;
            this.button1.Text = "招喚";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.rdwest);
            this.groupBox1.Controls.Add(this.rdeast);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 77);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rdwest
            // 
            this.rdwest.AutoSize = true;
            this.rdwest.Location = new System.Drawing.Point(172, 30);
            this.rdwest.Name = "rdwest";
            this.rdwest.Size = new System.Drawing.Size(106, 37);
            this.rdwest.TabIndex = 16;
            this.rdwest.TabStop = true;
            this.rdwest.Text = "西方";
            this.rdwest.UseVisualStyleBackColor = true;
            // 
            // rdeast
            // 
            this.rdeast.AutoSize = true;
            this.rdeast.Location = new System.Drawing.Point(26, 30);
            this.rdeast.Name = "rdeast";
            this.rdeast.Size = new System.Drawing.Size(106, 37);
            this.rdeast.TabIndex = 15;
            this.rdeast.TabStop = true;
            this.rdeast.Text = "東方";
            this.rdeast.UseVisualStyleBackColor = true;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbname.Location = new System.Drawing.Point(375, 162);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(47, 33);
            this.lbname.TabIndex = 18;
            this.lbname.Text = "__";
            // 
            // fmHeroSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::acerclass.Properties.Resources.game_eve_online_exodus_02_1600x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 660);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rdfly);
            this.Controls.Add(this.rdiq);
            this.Controls.Add(this.rdmagic);
            this.Controls.Add(this.rdpower);
            this.Controls.Add(this.lbslogan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmHeroSelect";
            this.Text = "選取英雄";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbslogan;
        private System.Windows.Forms.RadioButton rdpower;
        private System.Windows.Forms.RadioButton rdmagic;
        private System.Windows.Forms.RadioButton rdiq;
        private System.Windows.Forms.RadioButton rdfly;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdwest;
        private System.Windows.Forms.RadioButton rdeast;
        private System.Windows.Forms.Label lbname;

    }
}