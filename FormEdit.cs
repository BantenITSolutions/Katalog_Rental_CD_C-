/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 05/11/2010
 * Time: 18:00
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
	/// Description of FormEdit.
	/// </summary>
	public partial class FormEdit : Form
	{
		public OleDbConnection database;
		public string nama, produsen, tipe, tahun, harga, id_tipe;
		public int id_cd;
		public FormEdit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			for(int i=1980;i<=2010;i++)
			{
				editTahun.Items.Add(i);
			}
			for(int j=2000;j<=7000;j+=500)
			{
				editHarga.Items.Add(j);
			}
			string sqlQueryString = ("Select * from tbl_tipe_katalog");
			TampilData f1 = new TampilData();
            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            OleDbDataAdapter dataAdapter = null;
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = f1.database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach(DataRow drRow in data.Rows)
            {
            	string id = drRow["id_tipe_katalog"].ToString();
            	string nama_kat = drRow["tipe_katalog"].ToString();
            	editTipe.Items.Add(id + " - " +nama_kat);
            }
		}
		void FormEditLoad(object sender, EventArgs e)
		{
			editJudul.Text = nama;
			editTahun.Text = tahun;
			editHarga.Text = harga;
			editPenerbit.Text = produsen;
			editTipe.Text = id_tipe+" - "+tipe;
			id_katalog.Text = id_cd.ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TampilData f1 = new TampilData();
			nama = editJudul.Text.ToString();
			produsen = editPenerbit.Text.ToString();
			tipe = editTipe.Text.Substring(0,1);
			tahun = editTahun.Text.ToString();
			harga = editHarga.Text.ToString();
			string SQLUpdateString = "update tbl_katalog set id_tipe_katalog='"+ tipe +"', nama_katalog='"+ nama +"', produsen='"+ produsen +"', harga_sewa='"+  harga +"', tahun_terbit='"+ tahun +"' where id_katalog="+ id_cd +"";
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
				MessageBox.Show(tipe);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
