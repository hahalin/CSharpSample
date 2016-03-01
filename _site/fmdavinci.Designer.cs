namespace acerclass
{
    partial class fmdavinci
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eda1 = new System.Windows.Forms.TextBox();
            this.eda2 = new System.Windows.Forms.TextBox();
            this.eda3 = new System.Windows.Forms.TextBox();
            this.eda4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listboxyear = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("標楷體", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 53;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "{0}事紛紛如閃電",
            "",
            "{1}迴滾滾四浪飛",
            "",
            "{2}日不知明日事",
            "",
            "{3}有功夫論是非"});
            this.listBox1.Location = new System.Drawing.Point(325, 17);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 534);
            this.listBox1.TabIndex = 0;
            // 
            // eda1
            // 
            this.eda1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eda1.Location = new System.Drawing.Point(54, 44);
            this.eda1.Margin = new System.Windows.Forms.Padding(4);
            this.eda1.Name = "eda1";
            this.eda1.Size = new System.Drawing.Size(88, 79);
            this.eda1.TabIndex = 1;
            // 
            // eda2
            // 
            this.eda2.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eda2.Location = new System.Drawing.Point(54, 153);
            this.eda2.Margin = new System.Windows.Forms.Padding(4);
            this.eda2.Name = "eda2";
            this.eda2.Size = new System.Drawing.Size(88, 79);
            this.eda2.TabIndex = 2;
            // 
            // eda3
            // 
            this.eda3.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eda3.Location = new System.Drawing.Point(54, 267);
            this.eda3.Margin = new System.Windows.Forms.Padding(4);
            this.eda3.Name = "eda3";
            this.eda3.Size = new System.Drawing.Size(88, 79);
            this.eda3.TabIndex = 3;
            // 
            // eda4
            // 
            this.eda4.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eda4.Location = new System.Drawing.Point(54, 372);
            this.eda4.Margin = new System.Windows.Forms.Padding(4);
            this.eda4.Name = "eda4";
            this.eda4.Size = new System.Drawing.Size(88, 79);
            this.eda4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "填入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listboxyear
            // 
            this.listboxyear.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listboxyear.FormattingEnabled = true;
            this.listboxyear.ItemHeight = 47;
            this.listboxyear.Location = new System.Drawing.Point(861, 17);
            this.listboxyear.Margin = new System.Windows.Forms.Padding(4);
            this.listboxyear.Name = "listboxyear";
            this.listboxyear.Size = new System.Drawing.Size(87, 521);
            this.listboxyear.TabIndex = 6;
            // 
            // fmdavinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 574);
            this.Controls.Add(this.listboxyear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eda4);
            this.Controls.Add(this.eda3);
            this.Controls.Add(this.eda2);
            this.Controls.Add(this.eda1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmdavinci";
            this.Text = "Danvic Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox eda1;
        private System.Windows.Forms.TextBox eda2;
        private System.Windows.Forms.TextBox eda3;
        private System.Windows.Forms.TextBox eda4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listboxyear;
    }
}