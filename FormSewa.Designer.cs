/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 08/11/2010
 * Time: 0:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace katalogRentalCD
{
	partial class FormSewa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSewa));
			this.sewaAlamat = new System.Windows.Forms.TextBox();
			this.sewaId = new System.Windows.Forms.TextBox();
			this.sewaNama = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.sewaTotal = new System.Windows.Forms.TextBox();
			this.sewaBanyak = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.sewaHarga = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rdPelajar = new System.Windows.Forms.RadioButton();
			this.rdKtp = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// sewaAlamat
			// 
			this.sewaAlamat.Location = new System.Drawing.Point(162, 86);
			this.sewaAlamat.Name = "sewaAlamat";
			this.sewaAlamat.Size = new System.Drawing.Size(222, 20);
			this.sewaAlamat.TabIndex = 1;
			// 
			// sewaId
			// 
			this.sewaId.Location = new System.Drawing.Point(162, 34);
			this.sewaId.Name = "sewaId";
			this.sewaId.ReadOnly = true;
			this.sewaId.Size = new System.Drawing.Size(49, 20);
			this.sewaId.TabIndex = 2;
			// 
			// sewaNama
			// 
			this.sewaNama.Location = new System.Drawing.Point(162, 60);
			this.sewaNama.Name = "sewaNama";
			this.sewaNama.Size = new System.Drawing.Size(222, 20);
			this.sewaNama.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.sewaTotal);
			this.groupBox1.Controls.Add(this.sewaBanyak);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.sewaHarga);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.rdPelajar);
			this.groupBox1.Controls.Add(this.rdKtp);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 255);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sewa CD - Software & Movie";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(231, 210);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(51, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Batal";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(150, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Total Bayar :";
			// 
			// sewaTotal
			// 
			this.sewaTotal.Location = new System.Drawing.Point(150, 184);
			this.sewaTotal.Name = "sewaTotal";
			this.sewaTotal.ReadOnly = true;
			this.sewaTotal.Size = new System.Drawing.Size(132, 20);
			this.sewaTotal.TabIndex = 9;
			// 
			// sewaBanyak
			// 
			this.sewaBanyak.Location = new System.Drawing.Point(150, 157);
			this.sewaBanyak.Name = "sewaBanyak";
			this.sewaBanyak.Size = new System.Drawing.Size(49, 20);
			this.sewaBanyak.TabIndex = 8;
			this.sewaBanyak.TextChanged += new System.EventHandler(this.SewaBanyakTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Banyak Sewa :";
			// 
			// sewaHarga
			// 
			this.sewaHarga.Location = new System.Drawing.Point(150, 130);
			this.sewaHarga.Name = "sewaHarga";
			this.sewaHarga.ReadOnly = true;
			this.sewaHarga.Size = new System.Drawing.Size(132, 20);
			this.sewaHarga.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Harga Sewa :";
			// 
			// rdPelajar
			// 
			this.rdPelajar.Location = new System.Drawing.Point(205, 100);
			this.rdPelajar.Name = "rdPelajar";
			this.rdPelajar.Size = new System.Drawing.Size(89, 24);
			this.rdPelajar.TabIndex = 5;
			this.rdPelajar.TabStop = true;
			this.rdPelajar.Text = "Kartu Pelajar";
			this.rdPelajar.UseVisualStyleBackColor = true;
			// 
			// rdKtp
			// 
			this.rdKtp.Location = new System.Drawing.Point(150, 100);
			this.rdKtp.Name = "rdKtp";
			this.rdKtp.Size = new System.Drawing.Size(49, 24);
			this.rdKtp.TabIndex = 4;
			this.rdKtp.TabStop = true;
			this.rdKtp.Text = "KTP";
			this.rdKtp.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Jaminan Sewa :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "AlamatPenyewa :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Penyewa :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Katalog :";
			// 
			// FormSewa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 279);
			this.Controls.Add(this.sewaId);
			this.Controls.Add(this.sewaAlamat);
			this.Controls.Add(this.sewaNama);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormSewa";
			this.Text = "Sewa CD";
			this.Load += new System.EventHandler(this.FormSewaLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox sewaTotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox sewaHarga;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox sewaBanyak;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rdKtp;
		private System.Windows.Forms.RadioButton rdPelajar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox sewaAlamat;
		private System.Windows.Forms.TextBox sewaNama;
		private System.Windows.Forms.TextBox sewaId;
	}
}
