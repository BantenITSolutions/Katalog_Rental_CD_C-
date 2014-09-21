/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 11/11/2010
 * Time: 2:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace katalogRentalCD
{
	partial class FormEditTipe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditTipe));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.editNamaTipe = new System.Windows.Forms.TextBox();
			this.editIDKat = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.editNamaTipe);
			this.groupBox1.Controls.Add(this.editIDKat);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(368, 108);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Edit Tipe Katalog";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(316, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(46, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Batal";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(222, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Update Data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// editNamaTipe
			// 
			this.editNamaTipe.Location = new System.Drawing.Point(117, 49);
			this.editNamaTipe.Name = "editNamaTipe";
			this.editNamaTipe.Size = new System.Drawing.Size(245, 20);
			this.editNamaTipe.TabIndex = 3;
			// 
			// editIDKat
			// 
			this.editIDKat.Location = new System.Drawing.Point(117, 25);
			this.editIDKat.Name = "editIDKat";
			this.editIDKat.ReadOnly = true;
			this.editIDKat.Size = new System.Drawing.Size(69, 20);
			this.editIDKat.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Tipe Katalog :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Tipe Katalog :";
			// 
			// FormEditTipe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 132);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormEditTipe";
			this.Text = "Edit Tipe Katalog";
			this.Load += new System.EventHandler(this.FormEditTipeLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox editIDKat;
		private System.Windows.Forms.TextBox editNamaTipe;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
