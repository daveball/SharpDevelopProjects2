/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 03/09/2012
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SecurePrintWin
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.OpenFileBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(93, 163);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(685, 24);
			this.progressBar1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 244);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(873, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1HelpRequest);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// OpenFileBtn
			// 
			this.OpenFileBtn.Location = new System.Drawing.Point(93, 29);
			this.OpenFileBtn.Name = "OpenFileBtn";
			this.OpenFileBtn.Size = new System.Drawing.Size(191, 23);
			this.OpenFileBtn.TabIndex = 2;
			this.OpenFileBtn.Text = "Select Secure print Fiel to be processed";
			this.OpenFileBtn.UseVisualStyleBackColor = true;
			this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 266);
			this.Controls.Add(this.OpenFileBtn);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.progressBar1);
			this.Name = "MainForm";
			this.Text = "SecurePrintWin";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button OpenFileBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}
