/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 08/11/2010
 * Time: 0:34
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
using System.Data.OleDb;  //memanggil library database;

namespace katalogRentalCD
{
	/// <summary>
	/// Description of FormSewa.
	/// </summary>
	public partial class FormSewa : Form
	{
		public OleDbConnection database;
		public string id_katalog, harga;
		public FormSewa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=rentalCD.mdb";
			try
            {

                database = new OleDbConnection(connectionString);
                database.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
		}
		
		void FormSewaLoad(object sender, EventArgs e)
		{
			sewaId.Text=id_katalog;
			sewaHarga.Text=harga;
		}
		
		
		void SewaBanyakTextChanged(object sender, EventArgs e)
		{
			try
			{
			int sHarga = Convert.ToInt32(sewaHarga.Text);
			int sBanyak = Convert.ToInt32(sewaBanyak.Text);
			sewaTotal.Text = Convert.ToString(sHarga*sBanyak);
			}
			catch(Exception)
			{
				sewaBanyak.Clear();
				MessageBox.Show("Input harus angka..!!");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string SQLString="";
			string nama = sewaNama.Text;
			string id_cd = sewaId.Text;
			string alamat = sewaAlamat.Text;
			string jaminan = "";
			if(rdKtp.Checked==true)
			{
				jaminan="ktp";
			}
			else if(rdPelajar.Checked==true)
			{
				jaminan="kartu pelajar";
			}
			string total = sewaTotal.Text;
			string sewaTanggal = DateTime.Now.ToString();
			string tgl = sewaTanggal.Substring(0,10).ToString();
			if(nama=="" || alamat=="" || jaminan=="" || jaminan=="")
			{
				MessageBox.Show("Semua Inputan Belum Lengkap...!!!");
			}
			else
			{
				SQLString = "INSERT INTO tbl_pelanggan(id_cd, nama, alamat, jaminan, total_bayar, tanggal, status) VALUES('" + id_cd + "','" + nama + "','" + alamat + "','" + jaminan + "','" + total + "','" + tgl + "','belum');";
				OleDbCommand SQLCommand = new OleDbCommand();
                SQLCommand.CommandText = SQLString;
                SQLCommand.Connection = database;
                int response = -1;
                try
                {
                    response = SQLCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (response >= 1) MessageBox.Show("Data sewa berhasil ditambahkan. \nKlik tab Data Pelanggan untuk melihat hasil input.","Berhasil..!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
