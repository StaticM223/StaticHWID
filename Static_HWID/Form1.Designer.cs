namespace Static_HWID
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002E98 File Offset: 0x00001098
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002EB8 File Offset: 0x000010B8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox9 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 196);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(427, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Apply?";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 186);
            this.listBox1.TabIndex = 1;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(315, 6);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(62, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "HWID\'s";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(315, 27);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(110, 15);
            this.metroCheckBox2.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox2.TabIndex = 3;
            this.metroCheckBox2.Text = "PC Profile Name";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(315, 48);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(99, 15);
            this.metroCheckBox3.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox3.TabIndex = 4;
            this.metroCheckBox3.Text = "Machine GUID";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.UseSelectable = true;
            this.metroCheckBox3.CheckedChanged += new System.EventHandler(this.metroCheckBox3_CheckedChanged);
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(315, 69);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(110, 15);
            this.metroCheckBox4.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox4.TabIndex = 5;
            this.metroCheckBox4.Text = "HDD Serial NUM";
            this.metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox4.UseSelectable = true;
            this.metroCheckBox4.CheckedChanged += new System.EventHandler(this.metroCheckBox4_CheckedChanged);
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(315, 90);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(79, 15);
            this.metroCheckBox5.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox5.TabIndex = 6;
            this.metroCheckBox5.Text = "Product ID";
            this.metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox5.UseSelectable = true;
            this.metroCheckBox5.CheckedChanged += new System.EventHandler(this.metroCheckBox5_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Static Cheats Hwid";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(315, 111);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(95, 15);
            this.metroCheckBox6.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox6.TabIndex = 8;
            this.metroCheckBox6.Text = "MAC Address";
            this.metroCheckBox6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox6.UseSelectable = true;
            this.metroCheckBox6.CheckedChanged += new System.EventHandler(this.metroCheckBox6_CheckedChanged);
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Location = new System.Drawing.Point(315, 132);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(81, 15);
            this.metroCheckBox7.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox7.TabIndex = 9;
            this.metroCheckBox7.Text = "Install time";
            this.metroCheckBox7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox7.UseSelectable = true;
            this.metroCheckBox7.CheckedChanged += new System.EventHandler(this.metroCheckBox7_CheckedChanged);
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Location = new System.Drawing.Point(315, 153);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(80, 15);
            this.metroCheckBox8.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox8.TabIndex = 10;
            this.metroCheckBox8.Text = "Install date";
            this.metroCheckBox8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox8.UseSelectable = true;
            this.metroCheckBox8.CheckedChanged += new System.EventHandler(this.metroCheckBox8_CheckedChanged);
            // 
            // metroCheckBox9
            // 
            this.metroCheckBox9.AutoSize = true;
            this.metroCheckBox9.Location = new System.Drawing.Point(314, 174);
            this.metroCheckBox9.Name = "metroCheckBox9";
            this.metroCheckBox9.Size = new System.Drawing.Size(102, 15);
            this.metroCheckBox9.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox9.TabIndex = 11;
            this.metroCheckBox9.Text = "HwProfileGUID";
            this.metroCheckBox9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox9.UseSelectable = true;
            this.metroCheckBox9.CheckedChanged += new System.EventHandler(this.metroCheckBox9_CheckedChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 33);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(441, 269);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabControl1.TabIndex = 12;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroCheckBox9);
            this.metroTabPage1.Controls.Add(this.metroCheckBox8);
            this.metroTabPage1.Controls.Add(this.listBox1);
            this.metroTabPage1.Controls.Add(this.metroCheckBox7);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroCheckBox6);
            this.metroTabPage1.Controls.Add(this.metroCheckBox5);
            this.metroTabPage1.Controls.Add(this.metroCheckBox1);
            this.metroTabPage1.Controls.Add(this.metroCheckBox2);
            this.metroTabPage1.Controls.Add(this.metroCheckBox4);
            this.metroTabPage1.Controls.Add(this.metroCheckBox3);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(433, 227);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "HWID Spoofer";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(433, 227);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "File Cleanup";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 307);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000009 RID: 9
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x0400000A RID: 10
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox1;

		// Token: 0x0400000B RID: 11
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox2;

		// Token: 0x0400000C RID: 12
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox3;

		// Token: 0x0400000D RID: 13
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox4;

		// Token: 0x0400000E RID: 14
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox5;

		// Token: 0x0400000F RID: 15
		private global::MetroFramework.Controls.MetroLabel metroLabel1;

		// Token: 0x04000010 RID: 16
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox6;

		// Token: 0x04000011 RID: 17
		public global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000012 RID: 18
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox7;

		// Token: 0x04000013 RID: 19
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox8;

		// Token: 0x04000014 RID: 20
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox9;

		// Token: 0x04000015 RID: 21
		private global::MetroFramework.Controls.MetroTabControl metroTabControl1;

		// Token: 0x04000016 RID: 22
		private global::MetroFramework.Controls.MetroTabPage metroTabPage1;

		// Token: 0x04000017 RID: 23
		private global::MetroFramework.Controls.MetroTabPage metroTabPage2;
	}
}
