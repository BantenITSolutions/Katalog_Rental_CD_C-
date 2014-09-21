/*
 * Created by SharpDevelop.
 * User: FVCK-32
 * Date: 04/11/2010
 * Time: 23:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace katalogRentalCD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(usrName.Text=="admin" && psWord.Text=="admin")
			{
				Form frmData = new TampilData();
				frmData.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Username dan Password tidak Valid...!!!","Username & Password Salah...!!!");
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			usrName.Text = "";
			psWord.Text = "";
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		void TentanToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Aplikasi Katalog Rental CD Sederhana dengan C#\noleh Gede Suma Wijaya\n\nTemukan tutorial-tutorial IT lainnya di www.gedelumbung.co.cc","Tentang Saya - Gede Suma Wijaya");
		}
		
		void KeluarToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
