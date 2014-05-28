/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 02/06/2013
 * Time: 14:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CMSFileMatching
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.BtnOpenFile = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.LblStatus = new System.Windows.Forms.Label();
			this.ESP = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// BtnOpenFile
			// 
			this.BtnOpenFile.Location = new System.Drawing.Point(45, 51);
			this.BtnOpenFile.Name = "BtnOpenFile";
			this.BtnOpenFile.Size = new System.Drawing.Size(805, 23);
			this.BtnOpenFile.TabIndex = 0;
			this.BtnOpenFile.Text = "Open CMS CSV File produced from new CMS screens for Matching";
			this.BtnOpenFile.UseVisualStyleBackColor = true;
			this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFileClick);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(45, 186);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(805, 23);
			this.progressBar1.TabIndex = 2;
			this.progressBar1.Visible = false;
			this.progressBar1.Click += new System.EventHandler(this.ProgressBar1Click);
			// 
			// LblStatus
			// 
			this.LblStatus.Location = new System.Drawing.Point(45, 160);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(805, 23);
			this.LblStatus.TabIndex = 3;
			// 
			// ESP
			// 
			this.ESP.Location = new System.Drawing.Point(45, 108);
			this.ESP.Name = "ESP";
			this.ESP.Size = new System.Drawing.Size(805, 23);
			this.ESP.TabIndex = 4;
			this.ESP.Text = "ESP file  for Matching";
			this.ESP.UseVisualStyleBackColor = true;
			this.ESP.Click += new System.EventHandler(this.ESPClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 266);
			this.Controls.Add(this.ESP);
			this.Controls.Add(this.LblStatus);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.BtnOpenFile);
			this.Name = "MainForm";
			this.Text = "CMSFileMatching";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button ESP;
		private System.Windows.Forms.Label LblStatus;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button BtnOpenFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
