namespace acerclass
{
    partial class fmherostart
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
            this.TextButton = new System.Windows.Forms.Button();
            this.PictureBoxWithBear = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWithBear)).BeginInit();
            this.SuspendLayout();
            // 
            // TextButton
            // 
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextButton.FlatAppearance.BorderSize = 0;
            this.TextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextButton.ForeColor = System.Drawing.Color.Yellow;
            this.TextButton.Location = new System.Drawing.Point(347, 161);
            this.TextButton.Margin = new System.Windows.Forms.Padding(5);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(253, 49);
            this.TextButton.TabIndex = 5;
            this.TextButton.Text = "設定英雄";
            this.TextButton.UseVisualStyleBackColor = false;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // PictureBoxWithBear
            // 
            this.PictureBoxWithBear.BackgroundImage = global::acerclass.Properties.Resources._40c472740b3943e280144fa23773e226;
            this.PictureBoxWithBear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxWithBear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxWithBear.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxWithBear.Name = "PictureBoxWithBear";
            this.PictureBoxWithBear.Size = new System.Drawing.Size(905, 476);
            this.PictureBoxWithBear.TabIndex = 7;
            this.PictureBoxWithBear.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(347, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "選擇英雄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmherostart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.PictureBoxWithBear);
            this.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmherostart";
            this.Text = "東西英雄傳奇";
            this.Load += new System.EventHandler(this.fmherostart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWithBear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.PictureBox PictureBoxWithBear;
        private System.Windows.Forms.Button button1;
    }
}