/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 3/2/2022
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_Pertemuan_4
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
			MessageBox.Show("Nama : " + this.textBox1.Text);
			MessageBox.Show("NIM : " + this.textBox2.Text);
			MessageBox.Show("Kelas : " + this.textBox3.Text);
			MessageBox.Show("Mata Kuliah : " + this.textBox4.Text);
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
