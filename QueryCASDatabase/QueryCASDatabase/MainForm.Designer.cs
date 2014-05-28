/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 05/11/2013
 * Time: 12:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QueryCASDatabase
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
			this.components = new System.ComponentModel.Container();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.QueryDBBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bindingSource1
			// 
			this.bindingSource1.CurrentChanged += new System.EventHandler(this.BindingSource1CurrentChanged);
			// 
			// QueryDBBtn
			// 
			this.QueryDBBtn.Location = new System.Drawing.Point(40, 58);
			this.QueryDBBtn.Name = "QueryDBBtn";
			this.QueryDBBtn.Size = new System.Drawing.Size(181, 23);
			this.QueryDBBtn.TabIndex = 0;
			this.QueryDBBtn.Text = "querydatabase";
			this.QueryDBBtn.UseVisualStyleBackColor = true;
			this.QueryDBBtn.Click += new System.EventHandler(this.QueryDBBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(881, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(822, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(856, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "label3";
			// 
			// oracleConnection2
			// 
			this.oracleConnection2.ConnectionString = "Data Source= CASU;User Id=dball;Password=Celtic123!;";
			this.oracleConnection2.InfoMessage += new Oracle.DataAccess.Client.OracleInfoMessageEventHandler(this.OracleConnection2InfoMessage);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 272);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.QueryDBBtn);
			this.Name = "MainForm";
			this.Text = "QueryCASDatabase";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
		}
		
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button QueryDBBtn;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}
