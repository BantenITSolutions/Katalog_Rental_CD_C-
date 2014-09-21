/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 11/11/2010
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;  //memanggil library database

namespace katalogRentalCD
{
	/// <summary>
	/// Description of FormEditPelanggan.
	/// </summary>
	public partial class FormEditPelanggan : Form
	{
		public OleDbConnection database;
		public string tipe_cd, nama, alamat, jaminan, total, tanggal, status;
		public int id_penyewa;
		public FormEditPelanggan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cmbJaminan.Items.Add("ktp");
			cmbJaminan.Items.Add("kartu pelajar");
		}
		
		void FormEditPelangganLoad(object sender, EventArgs e)
		{
			editId.Text = id_penyewa.ToString();
			editNama.Text = nama;
			editCmbTipe.Text = tipe_cd;
			editAlamat.Text = alamat;
			editHarga.Text = total;
			editTanggal.Text = tanggal;
			cmbJaminan.Text = jaminan;
			
			if(status=="sudah")
			{
				rdSudah.Checked=true;
			}
			else
			{
				rdBelum.Checked=true;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TampilData f1 = new TampilData();
			nama = editNama.Text.ToString();
			alamat = editAlamat.Text.ToString();
			jaminan = cmbJaminan.Text.ToString();
			total = editHarga.Text.ToString();
			if(rdSudah.Checked==true)
			{
				status="sudah";
			}
			else if(rdBelum.Checked==true)
			{
				status="belum";
			}
			string SQLUpdateString = "update tbl_pelanggan set nama='"+ nama +"', alamat='"+ alamat +"', jaminan='"+ jaminan +"', total_bayar='"+ total +"', status='"+ status +"' where id_pelanggan="+ id_penyewa +"";
			try{
			OleDbCommand SQLCommand = new OleDbCommand();
            SQLCommand.CommandText = SQLUpdateString;
            SQLCommand.Connection = f1.database;
			int response = SQLCommand.ExecuteNonQuery();
			MessageBox.Show("Update data berhasil...!!!","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
			}
			catch(Exception)
			{
				MessageBox.Show("Error");
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
