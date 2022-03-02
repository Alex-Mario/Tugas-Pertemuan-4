/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 3/2/2022
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Materi_Pertemuan_4
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masukkan Nama Anda";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(207, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(199, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(239, 196);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "CONFIRM";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Materi Pertemuan 4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
