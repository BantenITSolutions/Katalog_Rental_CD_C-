/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 11/11/2010
 * Time: 2:00
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
	/// Description of FormEditTipe.
	/// </summary>
	public partial class FormEditTipe : Form
	{
		public OleDbConnection database;
		public string nama;
		public int id_kat;
		public FormEditTipe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		
		void FormEditTipeLoad(object sender, EventArgs e)
		{
			editIDKat.Text = id_kat.ToString();
			editNamaTipe.Text = nama;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TampilData f1 = new TampilData();
			nama = editNamaTipe.Text.ToString();
			string SQLUpdateString = "update tbl_tipe_katalog set tipe_katalog='"+ nama +"' where id_tipe_katalog="+ id_kat +"";
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
