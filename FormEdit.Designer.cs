/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 05/11/2010
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace katalogRentalCD
{
	partial class FormEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
			this.editJudul = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.editPenerbit = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.id_katalog = new System.Windows.Forms.TextBox();
			this.editTahun = new System.Windows.Forms.ComboBox();
			this.editTipe = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.editHarga = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// editJudul
			// 
			this.editJudul.Location = new System.Drawing.Point(161, 52);
			this.editJudul.Name = "editJudul";
			this.editJudul.Size = new System.Drawing.Size(209, 20);
			this.editJudul.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Judul Katalog :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Penerbit / Produsen :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tahun Terbit :";
			// 
			// editPenerbit
			// 
			this.editPenerbit.Location = new System.Drawing.Point(161, 78);
			this.editPenerbit.Name = "editPenerbit";
			this.editPenerbit.Size = new System.Drawing.Size(209, 20);
			this.editPenerbit.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Harga Sewa :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tipe Katalog :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.id_katalog);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.editTahun);
			this.groupBox1.Controls.Add(this.editTipe);
			this.groupBox1.Controls.Add(this.editPenerbit);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.editHarga);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.editJudul);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(379, 223);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ubah Data Katalog";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 35;
			this.label6.Text = "ID Katalog :";
			// 
			// id_katalog
			// 
			this.id_katalog.Location = new System.Drawing.Point(161, 26);
			this.id_katalog.Name = "id_katalog";
			this.id_katalog.ReadOnly = true;
			this.id_katalog.Size = new System.Drawing.Size(209, 20);
			this.id_katalog.TabIndex = 34;
			// 
			// editTahun
			// 
			this.editTahun.FormattingEnabled = true;
			this.editTahun.Location = new System.Drawing.Point(161, 104);
			this.editTahun.Name = "editTahun";
			this.editTahun.Size = new System.Drawing.Size(209, 21);
			this.editTahun.TabIndex = 33;
			// 
			// editTipe
			// 
			this.editTipe.FormattingEnabled = true;
			this.editTipe.Location = new System.Drawing.Point(161, 157);
			this.editTipe.Name = "editTipe";
			this.editTipe.Size = new System.Drawing.Size(209, 21);
			this.editTipe.TabIndex = 32;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(295, 184);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Batal";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// editHarga
			// 
			this.editHarga.FormattingEnabled = true;
			this.editHarga.Location = new System.Drawing.Point(161, 130);
			this.editHarga.Name = "editHarga";
			this.editHarga.Size = new System.Drawing.Size(209, 21);
			this.editHarga.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(199, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Simpan Data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 247);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormEdit";
			this.Text = "Ubah Data Katalog";
			this.Load += new System.EventHandler(this.FormEditLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox id_katalog;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox editTipe;
		private System.Windows.Forms.TextBox editPenerbit;
		private System.Windows.Forms.ComboBox editHarga;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox editTahun;
		private System.Windows.Forms.TextBox editJudul;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
