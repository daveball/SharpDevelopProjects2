/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 19/11/2013
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DevartOracletest
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Process GHA File";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(13, 52);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(156, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Process GUID file";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(13, 95);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Process GUID Parallel";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
			this.progressBar1.Location = new System.Drawing.Point(13, 187);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(267, 25);
			this.progressBar1.TabIndex = 3;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Location = new System.Drawing.Point(13, 125);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(216, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Process GUID parallele with statusbar";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ControlText;
			this.button5.Location = new System.Drawing.Point(12, 155);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(217, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "GHA Parallel";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 272);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.Name = "MainForm";
			this.Text = "DevartOracletest";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
	}
}
