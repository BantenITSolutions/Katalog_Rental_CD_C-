/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 04/11/2010
 * Time: 23:49
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
	/// Description of TampilData.
	/// </summary>
	public partial class TampilData : Form
	{
		public OleDbConnection database;
		DataGridViewButtonColumn sewaData;
		DataGridViewButtonColumn editData;
		DataGridViewButtonColumn hapusData;
		DataGridViewButtonColumn hapusTipe;
		DataGridViewButtonColumn editTipe;
		DataGridViewButtonColumn editPelanggan;
		DataGridViewButtonColumn hapusPelanggan;
        public int id_katalog;
		public TampilData()
		{
			InitializeComponent();
			jamTanggal.Text = DateTime.Now.ToString();
			jamTanggalonSewa.Text = DateTime.Now.ToString();
			for(int i=1980;i<=2010;i++)
			{
				cmbTahun.Items.Add(i);
			}
			for(int j=2000;j<=7000;j+=500)
			{
				harga_sewa.Items.Add(j);
			}
			for(int x=1;x<=31;x++)
			{
				cmbTanggal.Items.Add(x);
			}
			for(int y=1;y<=12;y++)
			{
				cmbBulan.Items.Add(y);
			}
			for(int z=2000;z<=2015;z++)
			{
				cmbThn.Items.Add(z);
			}
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
            string sqlQueryString = ("Select * from tbl_tipe_katalog");
            loadTipe(sqlQueryString);
            
		}
		public void loadTipe(string sqlQueryString)
		{
			OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
            OleDbDataAdapter dataAdapter = null;
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            foreach(DataRow drRow in data.Rows)
            {
            	string id = drRow["id_tipe_katalog"].ToString();
            	string nama_kat = drRow["tipe_katalog"].ToString();
            	id_tipe_katalog.Items.Add(id + " - " +nama_kat);
            	cmbCariKatalog.Items.Add(id + " - " +nama_kat);
            }
		}
        public void loadData1(string sqlQueryString) {

            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
			tampil.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            tampil.Columns.Clear(); // <-- clear columns
            //---------------------------------
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            tampil.DataSource = data;
            tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Judul Katalog CD";
            tampil.Columns[1].Width = 150; //nama cd
            tampil.Columns[2].HeaderText = "Tipe CD";
            tampil.Columns[2].Width = 120; //tipe cd
            tampil.Columns[3].HeaderText = "Penerbit CD";
            tampil.Columns[3].Width = 110; //produsen
            tampil.Columns[4].HeaderText = "Tahun Terbit";
            tampil.Columns[4].Width = 110; //tahun
            tampil.Columns[5].HeaderText = "Harga Sewa CD";
            tampil.Columns[5].Width = 110; //harga

            sewaData = new DataGridViewButtonColumn();
            sewaData.HeaderText = "Sewa CD";
            sewaData.Text = "Sewa CD";
            sewaData.UseColumnTextForButtonValue = true;
            sewaData.Width = 80;
            tampil.Columns.Add(sewaData);
		}
        public void loadData2(string sqlQueryString) {

            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
			tampil.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            tampil.Columns.Clear(); // <-- clear columns
            //---------------------------------
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            tampil.DataSource = data;
            tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Judul Katalog CD";
            tampil.Columns[1].Width = 150; //nama cd
            tampil.Columns[2].HeaderText = "Tipe CD";
            tampil.Columns[2].Width = 100; //tipe cd
            tampil.Columns[3].HeaderText = "Penerbit CD";
            tampil.Columns[3].Width = 110; //produsen
            tampil.Columns[4].HeaderText = "Tahun Terbit";
            tampil.Columns[4].Width = 110; //tahun
            tampil.Columns[5].HeaderText = "Harga Sewa CD";
            tampil.Columns[5].Width = 110; //harga
            tampil.Columns[6].Visible = false;

            editData = new DataGridViewButtonColumn();
            editData.HeaderText = "Edit";
            editData.Text = "Edit";
            editData.UseColumnTextForButtonValue = true;
            editData.Width = 50;
            tampil.Columns.Add(editData);
            
            hapusData = new DataGridViewButtonColumn();
            hapusData.HeaderText = "Hapus";
            hapusData.Text = "Hapus";
            hapusData.UseColumnTextForButtonValue = true;
            hapusData.Width = 50;
            tampil.Columns.Add(hapusData);
		}
        public void loadData3(string sqlQueryString) {

            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
			tampil.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            tampil.Columns.Clear(); // <-- clear columns
            //---------------------------------
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            tampil.DataSource = data;
            tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].HeaderText = "ID Tipe Katalog";
            tampil.Columns[0].Width = 130; //id tipe
            tampil.Columns[1].HeaderText = "Tipe Katalog";
            tampil.Columns[1].Width = 450; //nama katalog

            editTipe = new DataGridViewButtonColumn();
            editTipe.HeaderText = "Edit";
            editTipe.Text = "Edit";
            editTipe.UseColumnTextForButtonValue = true;
            editTipe.Width = 50;
            tampil.Columns.Add(editTipe);
            
            hapusTipe = new DataGridViewButtonColumn();
            hapusTipe.HeaderText = "Hapus";
            hapusTipe.Text = "Hapus";
            hapusTipe.UseColumnTextForButtonValue = true;
            hapusTipe.Width = 50;
            tampil.Columns.Add(hapusTipe);
		}
        public void loadData4(string sqlQueryString) {

            OleDbCommand SQLQuery = new OleDbCommand();
            DataTable data = null;
			tampil.DataSource = null;
            SQLQuery.Connection = null;
            OleDbDataAdapter dataAdapter = null;
            tampil.Columns.Clear(); // <-- clear columns
            //---------------------------------
            SQLQuery.CommandText = sqlQueryString;
            SQLQuery.Connection = database;
            data = new DataTable();
            dataAdapter = new OleDbDataAdapter(SQLQuery);
            dataAdapter.Fill(data);
            tampil.DataSource = data;
            tampil.AllowUserToAddRows = false; // remove the null line
            tampil.ReadOnly = true;
            tampil.Columns[0].Visible = false; //id cd
            tampil.Columns[1].HeaderText = "Judul Katalog CD";
            tampil.Columns[1].Width = 150; //nama cd
            tampil.Columns[2].HeaderText = "Nama Penyewa";
            tampil.Columns[2].Width = 140; //tipe cd
            tampil.Columns[3].HeaderText = "Alamat";
            tampil.Columns[3].Width = 160; //produsen
            tampil.Columns[4].HeaderText = "Status";
            tampil.Columns[4].Width = 50; //tahun
            tampil.Columns[5].HeaderText = "Tanggal";
            tampil.Columns[5].Width = 80; //harga
            tampil.Columns[6].Visible = false;
            tampil.Columns[7].Visible = false;

            editPelanggan = new DataGridViewButtonColumn();
            editPelanggan.HeaderText = "Edit";
            editPelanggan.Text = "Edit";
            editPelanggan.UseColumnTextForButtonValue = true;
            editPelanggan.Width = 50;
            tampil.Columns.Add(editPelanggan);
            
            hapusPelanggan = new DataGridViewButtonColumn();
            hapusPelanggan.HeaderText = "Hapus";
            hapusPelanggan.Text = "Hapus";
            hapusPelanggan.UseColumnTextForButtonValue = true;
            hapusPelanggan.Width = 50;
            tampil.Columns.Add(hapusPelanggan);
		}
		void TampilCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int currentRow = int.Parse(e.RowIndex.ToString());
            try
            {
                string id_string = tampil[0, currentRow].Value.ToString();
               id_katalog = int.Parse(id_string);
            }
            catch (Exception) { }
            // edit button
            if (tampil.Columns[e.ColumnIndex] == editData && currentRow >= 0)
            {
                string nama = tampil[1, currentRow].Value.ToString();
                string tipe = tampil[2, currentRow].Value.ToString();
                string produsen = tampil[3, currentRow].Value.ToString();
                string harga = tampil[5, currentRow].Value.ToString();
                string tahun = tampil[4, currentRow].Value.ToString();
                string id_tipe = tampil[6, currentRow].Value.ToString();
                //runs form 2 for editing    
                FormEdit f2 = new FormEdit();
                f2.nama = nama;
                f2.harga = harga;
                f2.tahun = tahun;
                f2.tipe = tipe;
                f2.produsen = produsen;
                f2.id_cd = id_katalog;
                f2.id_tipe = id_tipe;
                f2.Show();
                tampil.Update();
            }
            else if (tampil.Columns[e.ColumnIndex] ==sewaData && currentRow >= 0)
			{
			string harga = tampil[5, currentRow].Value.ToString();
			FormSewa frmSewa = new FormSewa();
			frmSewa.id_katalog = id_katalog.ToString();
			frmSewa.harga = harga;
			frmSewa.Show();
			tampil.Update();
			}
            else if(tampil.Columns[e.ColumnIndex] == hapusData && currentRow >= 0)
			{
			string queryString = "SELECT id_katalog,nama_katalog,tipe_katalog,produsen,tahun_terbit,harga_sewa,tbl_katalog.id_tipe_katalog FROM tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog order by tbl_katalog.tahun_terbit DESC";
			string queryDeleteString = "DELETE FROM tbl_katalog where id_katalog = "+id_katalog+""; //hapus data dengan id sesuai baris
            OleDbCommand sqlDelete = new OleDbCommand();
            sqlDelete.CommandText = queryDeleteString;
            sqlDelete.Connection = database;
            sqlDelete.ExecuteNonQuery();
            loadData2(queryString);
			}
            else if(tampil.Columns[e.ColumnIndex] == hapusTipe && currentRow >= 0)
			{
			string queryString = "select * from tbl_tipe_katalog";
			string queryDeleteString = "DELETE FROM tbl_tipe_katalog where id_tipe_katalog = "+id_katalog+""; //hapus data dengan id sesuai baris
            OleDbCommand sqlDelete = new OleDbCommand();
            sqlDelete.CommandText = queryDeleteString;
            sqlDelete.Connection = database;
            sqlDelete.ExecuteNonQuery();
            loadData3(queryString);
			}
            else if (tampil.Columns[e.ColumnIndex] == editTipe && currentRow >= 0)
            {
                string nama = tampil[1, currentRow].Value.ToString();
                //runs form 2 for editing    
               	FormEditTipe f3 = new FormEditTipe();
                f3.nama = nama;
                f3.id_kat = id_katalog;
                f3.Show();
                tampil.Update();
            }
            else if (tampil.Columns[e.ColumnIndex] == editPelanggan && currentRow >= 0)
            {
                string nama = tampil[2, currentRow].Value.ToString();
                string tipe = tampil[1, currentRow].Value.ToString();
                string alamat = tampil[3, currentRow].Value.ToString();
                string jaminan = tampil[6, currentRow].Value.ToString();
                string status = tampil[4, currentRow].Value.ToString();
                string total = tampil[7, currentRow].Value.ToString();
                string tanggal = tampil[5, currentRow].Value.ToString();
                //runs form 2 for editing    
                FormEditPelanggan f4 = new FormEditPelanggan();
                f4.nama = nama;
                f4.tipe_cd = tipe;
                f4.alamat = alamat;
                f4.jaminan = jaminan;
                f4.total = total;
                f4.status = status;
                f4.tanggal = tanggal;
                f4.id_penyewa = id_katalog;
                /*f4.nama = nama;
                f4.harga = harga;
                f4.tahun = tahun;
                f4.tipe = tipe;
                f4.produsen = produsen;
                f4.id_cd = id_katalog;*/
                f4.Show();
                tampil.Update();
            }
            else if(tampil.Columns[e.ColumnIndex] == hapusPelanggan && currentRow >= 0)
			{
			string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd order by tbl_pelanggan.status DESC ";
            string queryDeleteString = "DELETE FROM tbl_pelanggan where id_pelanggan = "+id_katalog+""; //hapus data dengan id sesuai baris
            OleDbCommand sqlDelete = new OleDbCommand();
            sqlDelete.CommandText = queryDeleteString;
            sqlDelete.Connection = database;
            sqlDelete.ExecuteNonQuery();
            loadData4(queryString);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string queryString = "SELECT id_katalog, nama_katalog, tipe_katalog, produsen, tahun_terbit, harga_sewa from tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog";
            loadData1(queryString);
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			string queryString = "SELECT id_katalog, nama_katalog, tipe_katalog, produsen, tahun_terbit, harga_sewa, tbl_katalog.id_tipe_katalog from tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog";
            loadData2(queryString);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(cariJudul.Text.ToString()!="")
			{
				string queryString = "SELECT id_katalog, nama_katalog, tipe_katalog, produsen, tahun_terbit, harga_sewa from tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog and tbl_katalog.nama_katalog like '%"+ cariJudul.Text.ToString()  +"%'";
            	loadData1(queryString);
			}
			else
			{
				MessageBox.Show("Input masih kosong...!!!","Inputan Kosong");
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if(cmbCariKatalog.Text.ToString()!="")
			{
				string queryString = "SELECT id_katalog, nama_katalog, tipe_katalog, produsen, tahun_terbit, harga_sewa from tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog and tbl_katalog.id_tipe_katalog like '%"+ cmbCariKatalog.Text.Substring(0,1)  +"%'";
            	loadData1(queryString);
			}
			else
			{
				MessageBox.Show("Input masih kosong...!!!","Inputan Kosong");
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if(tahunCari.Text.ToString()!="")
			{
				string queryString = "SELECT id_katalog, nama_katalog, tipe_katalog, produsen, tahun_terbit, harga_sewa from tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog and tbl_katalog.tahun_terbit like '%"+ tahunCari.Text.ToString()  +"%'";
            	loadData1(queryString);
			}
			else
			{
				MessageBox.Show("Input masih kosong...!!!","Inputan Kosong");
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if(penerbitCari.Text.ToString()!="")
			{
				string queryString = "SELECT id_katalog, nama_katalog, tipe_katalog, produsen, tahun_terbit, harga_sewa from tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog and tbl_katalog.produsen like '%"+ penerbitCari.Text.ToString()  +"%'";
            	loadData1(queryString);
			}
			else
			{
				MessageBox.Show("Input masih kosong...!!!","Inputan Kosong");
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string SQLString="";
			string nama = nama_katalog.Text;
			string id_tipe_kat = id_tipe_katalog.Text;
			string tahun_terbit = cmbTahun.Text;
			string penerbit = produsen.Text;
			string harga = harga_sewa.Text;
			if(nama=="" || id_tipe_kat=="" || tahun_terbit=="" || penerbit=="" || harga=="")
			{
				MessageBox.Show("Semua Inputan Belum Lengkap...!!!","Inputan Kosong");
			}
			else
			{
				string id_tipe = id_tipe_katalog.Text.Substring(0,1);
				SQLString = "INSERT INTO tbl_katalog(id_tipe_katalog, nama_katalog, produsen, tahun_terbit, harga_sewa) VALUES('" + id_tipe + "','" + nama + "','" + penerbit + "','" + tahun_terbit + "'," + harga + ");";
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
                if (response >= 1) MessageBox.Show("Data katalog berhasil ditambahkan. \nKlik tombol Muat Ulang Data untuk melihat hasil input.","Berhasil..!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                nama_katalog.Clear();
                id_tipe_katalog.ResetText();
                cmbTahun.ResetText();
                produsen.Clear();
                harga_sewa.ResetText();
                string queryString = "SELECT id_katalog,nama_katalog,tipe_katalog,produsen,tahun_terbit,harga_sewa,tbl_katalog.id_tipe_katalog FROM tbl_katalog,tbl_tipe_katalog where tbl_tipe_katalog.id_tipe_katalog=tbl_katalog.id_tipe_katalog order by tbl_katalog.tahun_terbit DESC";
                loadData2(queryString);
			}			
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			string SQLString="";
			string nama = namaKatBaru.Text;
			if(nama=="")
			{
				MessageBox.Show("Inputan Belum Lengkap...!!!","Inputan Kosong");
			}
			else
			{
				SQLString = "INSERT INTO tbl_tipe_katalog(tipe_katalog) VALUES('" + nama + "');";
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
                if (response >= 1) MessageBox.Show("Data katalog berhasil ditambahkan. \nKlik tombol Muat Ulang Data untuk melihat hasil input.","Berhasil..!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                namaKatBaru.Clear();
                string queryTipe = "SELECT * from tbl_tipe_katalog";
                loadData3(queryTipe);
			}
		}
		
		void Button11Click(object sender, EventArgs e)
		{
                string queryTipe = "SELECT * from tbl_tipe_katalog";
                loadData3(queryTipe);
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			id_tipe_katalog.Items.Clear();
			cmbCariKatalog.Items.Clear();
            string sqlQueryString = ("Select * from tbl_tipe_katalog");
            loadTipe(sqlQueryString);
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd order by tbl_pelanggan.status DESC ";
            loadData4(queryString);
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			if(namaPenyewa.Text=="")
			{
				MessageBox.Show("Input Masih Kosong","Inputan Kosong");
			}
			else{
				string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd and tbl_pelanggan.nama like '%"+ namaPenyewa.Text.ToString()  +"%' order by tbl_pelanggan.status DESC ";
            	loadData4(queryString);
			}
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			int pTanggal = cmbTanggal.Text.Length;
			int pBulan = cmbBulan.Text.Length;
			string tgl = cmbTanggal.Text;
			string bln = cmbBulan.Text;
			string thn = cmbThn.Text;
			string gabung = "";
			if(pTanggal<=1)
			{
				tgl = "0"+tgl;
			}
			else
			{
				tgl = tgl;
			}
			if(pBulan<=1)
			{
				bln = "0"+bln;
			}
			else
			{
				bln = bln;
			}
			gabung = tgl +"/"+ bln +"/"+ thn;
			if(tgl=="" || bln=="" || thn=="")
			{
				MessageBox.Show("Input belum lengkap...!!!","Inputan Kosong");
			}
			else
			{
				string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd and tbl_pelanggan.tanggal='"+ gabung +"' order by tbl_pelanggan.status DESC ";
            	loadData4(queryString);
			}
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			string status="";
			if(rdBelum.Checked==true)
			{
				status = "belum";
				string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd and status='"+ status +"' order by tbl_pelanggan.status DESC ";
            	loadData4(queryString);
			}
			else if(rdSudah.Checked==true)
			{
				status = "sudah";
				string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd and status='"+ status +"' order by tbl_pelanggan.status DESC ";
            	loadData4(queryString);
			}
			else
			{
				MessageBox.Show("Pilihan masih kosong...!!","Inputan Kosong");
			}
		}
		
		
		void Button17Click(object sender, EventArgs e)
		{
			string status="";
			if(rdKtp.Checked==true)
			{
				status = "ktp";
				string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd and jaminan='"+ status +"' order by tbl_pelanggan.status DESC ";
            	loadData4(queryString);
			}
			else if(rdKrtPljr.Checked==true)
			{
				status = "kartu pelajar";
				string queryString = "SELECT id_pelanggan, nama_katalog, nama, alamat, status, tanggal, jaminan, total_bayar from tbl_pelanggan,tbl_katalog where tbl_katalog.id_katalog=tbl_pelanggan.id_cd and jaminan='"+ status +"' order by tbl_pelanggan.status DESC ";
            	loadData4(queryString);
			}
			else
			{
				MessageBox.Show("Pilihan masih kosong...!!","Inputan Kosong");
			}
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			if(cariTipe.Text.ToString()!="")
			{
				string queryString = "SELECT * from tbl_tipe_katalog where tbl_tipe_katalog.tipe_katalog like '%"+ cariTipe.Text.ToString()  +"%'";
            	loadData3(queryString);
			}
			else
			{
				MessageBox.Show("Input masih kosong...!!!","Inputan Kosong");
			}
		}
		
		void KeluarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void LogOutKeluarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm f1 = new MainForm();
			f1.Show();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			nama_katalog.Clear();
			id_tipe_katalog.ResetText();
			produsen.Clear();
			cmbTahun.ResetText();
			harga_sewa.ResetText();
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			namaKatBaru.Clear();
		}
		
		void TampilDataFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void TentangSayaToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Aplikasi Katalog Rental CD Sederhana dengan C#\noleh Gede Suma Wijaya\n\nTemukan tutorial-tutorial IT lainnya di www.gedelumbung.co.cc","Tentang Saya - Gede Suma Wijaya");
		}
	}
}
