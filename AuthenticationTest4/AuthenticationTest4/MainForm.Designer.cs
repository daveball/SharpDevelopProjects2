/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 13/01/2012
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AuthenticationTest4
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
			this.GUIDtxt = new System.Windows.Forms.TextBox();
			this.CASAuthenticationWSEBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GUIDtxt
			// 
			this.GUIDtxt.Location = new System.Drawing.Point(37, 60);
			this.GUIDtxt.Name = "GUIDtxt";
			this.GUIDtxt.Size = new System.Drawing.Size(229, 20);
			this.GUIDtxt.TabIndex = 0;
			// 
			// CASAuthenticationWSEBtn
			// 
			this.CASAuthenticationWSEBtn.Location = new System.Drawing.Point(37, 142);
			this.CASAuthenticationWSEBtn.Name = "CASAuthenticationWSEBtn";
			this.CASAuthenticationWSEBtn.Size = new System.Drawing.Size(229, 23);
			this.CASAuthenticationWSEBtn.TabIndex = 1;
			this.CASAuthenticationWSEBtn.Text = "CAS Authentication Service WSE";
			this.CASAuthenticationWSEBtn.UseVisualStyleBackColor = true;
			this.CASAuthenticationWSEBtn.Click += new System.EventHandler(this.CASAuthenticationWSEBtnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.CASAuthenticationWSEBtn);
			this.Controls.Add(this.GUIDtxt);
			this.Name = "MainForm";
			this.Text = "AuthenticationTest4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button CASAuthenticationWSEBtn;
		private System.Windows.Forms.TextBox GUIDtxt;
	}
}
