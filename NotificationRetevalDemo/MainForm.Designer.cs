/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 05/12/2008
 * Time: 13:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NotificationRetevalDemo
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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.StartDemo = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(24, 25);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(801, 592);
			this.treeView1.TabIndex = 0;
			// 
			// StartDemo
			// 
			this.StartDemo.Location = new System.Drawing.Point(40, 627);
			this.StartDemo.Name = "StartDemo";
			this.StartDemo.Size = new System.Drawing.Size(173, 40);
			this.StartDemo.TabIndex = 1;
			this.StartDemo.Text = "Start Notification Demo\r\n using CAS Gateway";
			this.StartDemo.UseVisualStyleBackColor = true;
			this.StartDemo.Click += new System.EventHandler(this.StartDemoClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(544, 627);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(227, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "Start Notification Demo\r\n using WSE and CASEndpointBean";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 679);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.StartDemo);
			this.Controls.Add(this.treeView1);
			this.Name = "MainForm";
			this.Text = "NotificationRetevalDemo";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button StartDemo;
		private System.Windows.Forms.TreeView treeView1;
	}
}
