/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 04/11/2010
 * Time: 23:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace katalogRentalCD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.usrName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.psWord = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tentanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// usrName
			// 
			this.usrName.Location = new System.Drawing.Point(184, 128);
			this.usrName.Name = "usrName";
			this.usrName.Size = new System.Drawing.Size(249, 20);
			this.usrName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username Admin :";
			// 
			// psWord
			// 
			this.psWord.Location = new System.Drawing.Point(184, 154);
			this.psWord.Name = "psWord";
			this.psWord.Size = new System.Drawing.Size(249, 20);
			this.psWord.TabIndex = 2;
			this.psWord.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password Admin :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(184, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Masuk";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(265, 180);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Hapus";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Location = new System.Drawing.Point(0, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(445, 34);
			this.label3.TabIndex = 6;
			this.label3.Text = "** Masukkan username dan password untuk masuk ke Panel Administrator";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aplikasiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(445, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aplikasiToolStripMenuItem
			// 
			this.aplikasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tentanToolStripMenuItem,
									this.keluarToolStripMenuItem});
			this.aplikasiToolStripMenuItem.Name = "aplikasiToolStripMenuItem";
			this.aplikasiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.aplikasiToolStripMenuItem.Text = "Aplikasi";
			// 
			// tentanToolStripMenuItem
			// 
			this.tentanToolStripMenuItem.Name = "tentanToolStripMenuItem";
			this.tentanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tentanToolStripMenuItem.Text = "Tentang Saya";
			this.tentanToolStripMenuItem.Click += new System.EventHandler(this.TentanToolStripMenuItemClick);
			// 
			// keluarToolStripMenuItem
			// 
			this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
			this.keluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.keluarToolStripMenuItem.Text = "Keluar";
			this.keluarToolStripMenuItem.Click += new System.EventHandler(this.KeluarToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(445, 89);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 246);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.psWord);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usrName);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Panel Log In - Katalog Rental CD";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox psWord;
		private System.Windows.Forms.TextBox usrName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tentanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplikasiToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
