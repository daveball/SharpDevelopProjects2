/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 20/01/2014
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TemporaryUCRNCleaningandConverting
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
			this.BtnLoadUCRNFile = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// BtnLoadUCRNFile
			// 
			this.BtnLoadUCRNFile.Location = new System.Drawing.Point(35, 25);
			this.BtnLoadUCRNFile.Name = "BtnLoadUCRNFile";
			this.BtnLoadUCRNFile.Size = new System.Drawing.Size(229, 23);
			this.BtnLoadUCRNFile.TabIndex = 0;
			this.BtnLoadUCRNFile.Text = "Load Resolved Temporary UCRN";
			this.BtnLoadUCRNFile.UseVisualStyleBackColor = true;
			this.BtnLoadUCRNFile.Click += new System.EventHandler(this.BtnLoadUCRNFileClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 272);
			this.Controls.Add(this.BtnLoadUCRNFile);
			this.Name = "MainForm";
			this.Text = "TemporaryUCRNCleaningandConverting";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BtnLoadUCRNFile;
	}
}
