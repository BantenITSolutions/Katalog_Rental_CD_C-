/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 11/11/2010
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace katalogRentalCD
{
	partial class FormEditPelanggan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPelanggan));
			this.label1 = new System.Windows.Forms.Label();
			this.editId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbJaminan = new System.Windows.Forms.ComboBox();
			this.editCmbTipe = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.rdBelum = new System.Windows.Forms.RadioButton();
			this.rdSudah = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.editTanggal = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.editHarga = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.editAlamat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.editNama = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Penyewa :";
			// 
			// editId
			// 
			this.editId.Location = new System.Drawing.Point(116, 19);
			this.editId.Name = "editId";
			this.editId.ReadOnly = true;
			this.editId.Size = new System.Drawing.Size(79, 20);
			this.editId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Judul CD :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbJaminan);
			this.groupBox1.Controls.Add(this.editCmbTipe);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.rdBelum);
			this.groupBox1.Controls.Add(this.rdSudah);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.editTanggal);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.editHarga);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.editAlamat);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.editNama);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.editId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 309);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Edit Data Penyewa";
			// 
			// cmbJaminan
			// 
			this.cmbJaminan.FormattingEnabled = true;
			this.cmbJaminan.Location = new System.Drawing.Point(116, 174);
			this.cmbJaminan.Name = "cmbJaminan";
			this.cmbJaminan.Size = new System.Drawing.Size(168, 21);
			this.cmbJaminan.TabIndex = 22;
			// 
			// editCmbTipe
			// 
			this.editCmbTipe.Location = new System.Drawing.Point(116, 46);
			this.editCmbTipe.Name = "editCmbTipe";
			this.editCmbTipe.ReadOnly = true;
			this.editCmbTipe.Size = new System.Drawing.Size(278, 20);
			this.editCmbTipe.TabIndex = 21;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(216, 277);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 23);
			this.button2.TabIndex = 20;
			this.button2.Text = "Batal";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(116, 277);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Update Data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// rdBelum
			// 
			this.rdBelum.Location = new System.Drawing.Point(249, 246);
			this.rdBelum.Name = "rdBelum";
			this.rdBelum.Size = new System.Drawing.Size(129, 24);
			this.rdBelum.TabIndex = 18;
			this.rdBelum.TabStop = true;
			this.rdBelum.Text = "Belum Dikembalikan";
			this.rdBelum.UseVisualStyleBackColor = true;
			// 
			// rdSudah
			// 
			this.rdSudah.Location = new System.Drawing.Point(116, 247);
			this.rdSudah.Name = "rdSudah";
			this.rdSudah.Size = new System.Drawing.Size(127, 24);
			this.rdSudah.TabIndex = 17;
			this.rdSudah.TabStop = true;
			this.rdSudah.Text = "Sudah Dikembalikan";
			this.rdSudah.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(10, 252);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Status Sewa :";
			// 
			// editTanggal
			// 
			this.editTanggal.Location = new System.Drawing.Point(116, 225);
			this.editTanggal.Name = "editTanggal";
			this.editTanggal.ReadOnly = true;
			this.editTanggal.Size = new System.Drawing.Size(168, 20);
			this.editTanggal.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(10, 226);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Tanggal Sewa :";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(116, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Rp.";
			// 
			// editHarga
			// 
			this.editHarga.Location = new System.Drawing.Point(146, 199);
			this.editHarga.Name = "editHarga";
			this.editHarga.Size = new System.Drawing.Size(138, 20);
			this.editHarga.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(10, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Total Bayar :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Jaminan Sewa :";
			// 
			// editAlamat
			// 
			this.editAlamat.Location = new System.Drawing.Point(116, 98);
			this.editAlamat.Multiline = true;
			this.editAlamat.Name = "editAlamat";
			this.editAlamat.Size = new System.Drawing.Size(278, 72);
			this.editAlamat.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Alamat Penyewa :";
			// 
			// editNama
			// 
			this.editNama.Location = new System.Drawing.Point(116, 72);
			this.editNama.Name = "editNama";
			this.editNama.Size = new System.Drawing.Size(278, 20);
			this.editNama.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nama Penyewa :";
			// 
			// FormEditPelanggan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 333);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormEditPelanggan";
			this.Text = "Edit Data Penyewa";
			this.Load += new System.EventHandler(this.FormEditPelangganLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbJaminan;
		private System.Windows.Forms.TextBox editAlamat;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox editTanggal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdSudah;
		private System.Windows.Forms.RadioButton rdBelum;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox editHarga;
		private System.Windows.Forms.TextBox editCmbTipe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox editNama;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox editId;
		private System.Windows.Forms.Label label1;
	}
}
