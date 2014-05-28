/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 12/06/2013
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MDMWDiffReporting
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
			this.button1 = new System.Windows.Forms.Button();
			this.Status = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Process File";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Status
			// 
			this.Status.Location = new System.Drawing.Point(13, 55);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(1142, 23);
			this.Status.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(13, 133);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(267, 23);
			this.progressBar1.TabIndex = 2;
			this.progressBar1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 266);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.Status);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "MDMWDiffReporting";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label Status;
		private System.Windows.Forms.Button button1;
	}
}
