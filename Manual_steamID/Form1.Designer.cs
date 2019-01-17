namespace Manual_steamID
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000024D8 File Offset: 0x000006D8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000024F8 File Offset: 0x000006F8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Mini = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mini)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(225, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(25, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(22, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "sXe Injected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(22, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Counter Strike";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(156, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wait";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(156, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wait";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 10);
            this.label2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-3, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 10);
            this.label1.TabIndex = 48;
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(325, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(16, 16);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Exit.TabIndex = 49;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Mini
            // 
            this.Mini.Image = ((System.Drawing.Image)(resources.GetObject("Mini.Image")));
            this.Mini.Location = new System.Drawing.Point(303, 3);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(16, 16);
            this.Mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mini.TabIndex = 50;
            this.Mini.TabStop = false;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(4, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "greatR SteamID Spoofer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(352, 214);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Mini);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "SteamID Spoofer";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Mini;
        private System.Windows.Forms.Label label7;
    }
}
