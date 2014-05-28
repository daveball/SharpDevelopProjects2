/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 05/11/2013
 * Time: 12:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
//using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
//using Oracle.DataAccess.Types; 
using Devart.Data.Oracle;

namespace QueryCASDatabase
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
		
		void BindingSource1CurrentChanged(object sender, EventArgs e)
		{
			
		}
		
		void QueryDBBtnClick(object sender, EventArgs e)
		{
			
			
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.Server = "localhost";
			oracleConnection1.UserId = "dball";
			oracleConnection1.Password = "Celtic123!";
			
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.q";
			oraCSB.Port = 1557;
			oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Celtic123!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
			OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
			try{
				myConnection.Open();
			}
			catch ( Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
//			string oradb = "Data Source=ORCL;User Id=hr;Password=hr;";
//  OracleConnection conn = new OracleConnection(oradb);  // C#
//conn.Open(); 
//OracleCommand cmd = new OracleCommand();
//cmd.Connection = conn;
//cmd.CommandText = "select department_name from departments where department_id = 10";
//cmd.CommandType = CommandType.Text; 
//OracleDataReader dr = cmd.ExecuteReader();
//dr.Read();
//label1.Text = dr.GetString(0);
//conn.Dispose();
//			
//			
//			
//			try
//			{
//		        string connStr="User Id=dball;Password=Celtic123!;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1557))(CONNECT_DATA=(SERVICE_NAME=CASU)));";
//		        OracleConnection oraConnect = new OracleConnection(connStr);
//		        oraConnect.Open();
//		        Console.WriteLine("Opened Connection");
//		        oraConnect.Close();
//		        Console.WriteLine("Complete");
//		        Console.ReadLine();
//			}
//		    catch (System.Exception ee) {
//		        Console.WriteLine(ee.Message);
//		        Console.ReadLine();
//		      } 
//			
//			
//			
//			try{
//		 oradb = "Data Source=CASU;User Id=dball;Password=Celtic123!;";
//oradb="Data Source=(DESCRIPTION=" +  "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1557))" +  "(CONNECT_DATA=(SERVICE_NAME =CASU)));" +"User Id=dball;Password=Celtic123!;";
//conn = new OracleConnection(oradb); // C#
//
//conn.Open();
//
//OracleCommand mycmd = new OracleCommand();
//
//mycmd.Connection = conn;
//
//mycmd.CommandText = "select count(*) from Apps.hz_Parties where apps.hz_parties.Attribute1 is not like 'UCR%'";;
//mycmd.CommandType = CommandType.Text;
//
//OracleDataReader mydr = mycmd.ExecuteReader();
//
//mydr.Read();
//
//label1.Text = mydr.GetString(0);
//
//conn.Dispose();
//			}
//			 catch (OracleException ex)
//    {
//      Console.WriteLine("Record is not inserted into the database table.");
//      Console.WriteLine("Exception Message: " + ex.Message);
//      //Console.WriteLine("Exception Source: " + ex.Source);
//    }
//			

			
//			//string oradb = "User Id=\"dball\";Password=\"Celtic123!\";"+ "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1557))(CONNECT_DATA=(SERVICE_NAME=CASU)));";
//			string oradb = "Data Source=(DESCRIPTION=" +  "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1557))" +  "(CONNECT_DATA=(SERVICE_NAME =CASU)));" +"User Id=dball;Password=Celtic123!;";;
//			oradb="Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1557))(CONNECT_DATA=(SERVICE_NAME=CASU)));User Id= dball;Password=Celtic123!;";
//			oradb ="Data Source=localhost:1557/CASU;User Id=dball;Password=Celtic123!;";
//			string connString = "user id=dball;password=Celtic123!;Data source=oracle;";
//    bool bRet = false;
//    
//    // Create an instance of OracleConnectionStringBuilder
//    OracleConnectionStringBuilder connStrBuilder = 
//      new OracleConnectionStringBuilder(oradb);
//    
//    // Add a new key/value to the connection string
//    connStrBuilder.Add("pooling", false);
//    
//    // Modify the existing value
//    connStrBuilder["Data Source"] = "(DESCRIPTION=" +  "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1557))" ;
//
//    string CONNECTION_STRING =   "User Id=dball;Password=Celtic123!;Data Source=(DESCRIPTION=" +  "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1557))" +  "(CONNECT_DATA=(SERVICE_NAME =CASU)));";
//			OracleConnection conn = new OracleConnection(oradb);
////            label1.Text= conn.DataSource 	;	// C#
////            label1.Update();
////            label2.Text=conn.DatabaseName;
////            label3.Text=conn.ConnectionString;
//             try
//             {
//			conn.Open(); 
//			OracleCommand cmd = new OracleCommand();
//			cmd.Connection = conn;
//			cmd.CommandText = "select count(*) from apps.hz_parties where apps.hz_parties.ATTRIBUTE1 LIKE 'UCR%'   and apps.hz_parties.STATUS ='A' ";
//			cmd.CommandType = CommandType.Text; 
//			OracleDataReader dr = cmd.ExecuteReader();
//			dr.Read();
//			label1.Text = dr.GetString(0);
//			conn.Dispose();
//             }
//             catch( Exception ex)
//             {
//             	MessageBox.Show(ex.Data +":"+ ex.Message +" : "+ ex.HelpLink );
//             }
			
		
		}
		
		void OracleConnection2InfoMessage(object sender, OracleInfoMessageEventArgs eventArgs)
		{
			
		}
	}
}
