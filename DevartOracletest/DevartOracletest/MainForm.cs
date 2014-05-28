/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 19/11/2013
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.Oracle;
using FileHelpers;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace DevartOracletest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		const string delimeter=",";
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		BackgroundWorker worker;
	
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
		
		genderdob DOB(OracleConnection connection, string UCRN)
    {
        OracleCommand command = connection.CreateCommand();
        command.CommandText = "select   TO_CHAR(apps.hz_PERSON_PROFILES.DATE_OF_BIRTH,'dd/mm/yyyy') as DOB, DECODE(apps.hz_PERSON_PROFILES.GENDER,'MALE','M','F') as gender,apps.hz_parties.Person_First_Name as Forename,apps.hz_parties.Person_Last_Name as Surname,apps.hz_parties.PERSON_TITLE as Title from apps.hz_parties full outer join apps.hz_PERSON_PROFILES  on apps.hz_parties.Party_ID =apps.hz_PERSON_PROFILES.party_ID where    apps.hz_parties.ATTRIBUTE1 = '"+ UCRN +"'  ";
        string dobstring= null;
        genderdob myGenderDOB = new genderdob();
        // return value of ExecuteNonQuery (i) is the number of rows affected by the command
        using (OracleDataReader reader = command.ExecuteReader())
        {
        	//MessageBox.Show(reader.GetValue(1).ToString() + " "+ reader.FieldCount.ToString());
        	// printing the column names
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i).ToString() + "\t");
           // MessageBox.Show(reader.GetName(i).ToString());
            }
            Console.Write(Environment.NewLine);
            // Always call Read before accesing data
            while (reader.Read())
            {
                // printing the table content
                for (int i = 0; i < reader.FieldCount; i++)
                {
                	Console.Write(reader.GetValue(i).ToString() + "\t");
                	//MessageBox.Show(reader.GetValue(i).ToString());
                	dobstring=reader.GetValue(0).ToString();
                	myGenderDOB.DOB =reader.GetValue(0).ToString();
                	myGenderDOB.Gender=reader.GetValue(1).ToString();
                	myGenderDOB.Forename=reader.GetValue(2).ToString();
                	myGenderDOB.Surname=reader.GetValue(3).ToString();
                	myGenderDOB.Title = reader.GetValue(4).ToString();
                }
                Console.Write(Environment.NewLine);
            }
            return myGenderDOB;
       // int i = command.ExecuteNonQuery();
        //Console.WriteLine(Environment.NewLine + "Rows in DEPT updated: {0}", i + Environment.NewLine);
    
		}
		}
		
		string getMonth(int Month)
		{ string myMonth= string.Empty;
			switch (Month)
			{
			    case 1:
			        Console.WriteLine("Case 1");
			       myMonth= "Jan";
			        break;
			    case 2:
			        Console.WriteLine("Case 2");
			        myMonth="Feb";
			        break;
			    case 3:
			        Console.WriteLine("Case 2");
        			myMonth= "Mar";
        			break;
			     case 4:
			        Console.WriteLine("Case 2");
			       myMonth= "Apr";
			       break;
			    case 5:
			        Console.WriteLine("Case 2");
			        myMonth="May";
			        break;
			    case 6:
			        Console.WriteLine("Case 2");
			        myMonth= "Jun";
			        break;
			    case 7:
			        Console.WriteLine("Case 2");
			    	myMonth="Jul";
			        break;
			    case 8:
			        Console.WriteLine("Case 2");
			         myMonth="Aug";
			          break;
			    case 9:
			        Console.WriteLine("Case 2");
			        myMonth="Sep";
			        break;
			    case 10:
			        Console.WriteLine("Case 2");
			        myMonth= "Oct";
			        break;
			    case 11:
			        Console.WriteLine("Case 2");
			       	myMonth="Nov";
			        break;
			    case 12:
			        Console.WriteLine("Case 2");
			       	myMonth="Dec";
			            
			        break;
			    default:
			        Console.WriteLine("Default case");
			        
			        break;
			}
			return myMonth;

			
		}
		string GetUCRN(OracleConnection connection, string Forename, string Surname, string Gender, string DateOfBirth)
		{
			OracleCommand command = connection.CreateCommand();
			string[] DOBElements=DateOfBirth.Split('/');
			DateTime now = DateTime.Now;
			//string outfilenamewithpath=@"c:/test/querystrings"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+".txt";
			string Month = getMonth(Convert.ToInt16(DOBElements[1]));
			                        string Year =DOBElements[2].Remove(0,2);
			//command.CommandText = "select Apps.HZ_Parties.Attribute1  from apps.hz_parties full outer join apps.hz_PERSON_PROFILES  on apps.hz_parties.Party_ID =apps.hz_PERSON_PROFILES.party_ID where Apps.HZ_Parties.Person_First_Name ='"+Forename+"' and Apps.HZ_Parties.Person_Last_Name='"+Surname+"' and apps.hz_PERSON_PROFILES.DATE_OF_BIRTH='" +DOBElements[0]+"-"+Month+"-"+Year+ "' and apps.hz_PERSON_PROFILES.GENDER like'"+Gender+"%' and apps.hz_parties.Attribute1 not like 'UCR%'";
           command.CommandText = "select Apps.HZ_Parties.Attribute1  from apps.hz_parties full outer join apps.hz_PERSON_PROFILES  on apps.hz_parties.Party_ID =apps.hz_PERSON_PROFILES.party_ID where soundex(Apps.HZ_Parties.Person_First_Name) =soundex('"+Forename+"') and soundex(Apps.HZ_Parties.Person_Last_Name)=soundex('"+Surname+"') and apps.hz_PERSON_PROFILES.DATE_OF_BIRTH='" +DOBElements[0]+"-"+Month+"-"+Year+ "' and apps.hz_PERSON_PROFILES.GENDER like'"+Gender+"%' and apps.hz_parties.Attribute1 not like 'UCR%'";
           
			
//			using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
//			 {
//           	file.WriteLine(command.CommandText);
//           }
		using (OracleDataReader reader = command.ExecuteReader())
        {
        	//MessageBox.Show(reader.GetValue(1).ToString() + " "+ reader.FieldCount.ToString());
        	// printing the column names
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i).ToString() + "\t");
           // MessageBox.Show(reader.GetName(i).ToString());
            }
            Console.Write(Environment.NewLine);
            // Always call Read before accesing data
            while (reader.Read())
            {
                // printing the table content
                for (int i = 0; i < reader.FieldCount; i++)
                {
                	if (reader.FieldCount==1) return reader.GetValue(0).ToString();
                	if (reader.FieldCount>1) return "No  Unique  match found there where "+reader.FieldCount.ToString()+"Matches";
                }
                Console.Write(Environment.NewLine);
            }
            return String.Empty;
       //
		}
		}
		
		void Button1Click(object sender, EventArgs e)
		{   OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Password321!";
			
			
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Password321!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
		    OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
		    try
		    {
		    	myConnection.Open();
				MessageBox.Show(myConnection.ServerVersion);
		
				
				
					
			
			genderdob myDOB ;
			
			
			
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
				DateTime now = DateTime.Now;
				string outfilenamewithpath =@"c:\data\GHAoutputwithDOBGenderForenameSurnameAgainstLive"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+ now.Hour.ToString()+now.Minute.ToString()+".txt";
				
      			System.IO.StreamReader sr = new 
         		System.IO.StreamReader(openFileDialog1.FileName);
			    int  currentrow = 0;
			      while(sr.Peek() !=-1)
			      { string[] words;
			     
			     	words=sr.ReadLine().Split(',');
			     	//MessageBox.Show( words[NECLocation]);
			     	//MessageBox.Show(words[5]);
			     	//set location of UCRN
			     	myDOB =DOB(myConnection,words[1]);
      			
			    
						using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
							foreach (string userdetail   in words)
							{
								file.Write(userdetail+delimeter);
							}
			
					
						
					      	file.WriteLine(myDOB.DOB +delimeter + myDOB.Gender + delimeter + myDOB.Title + delimeter+myDOB.Forename+delimeter+myDOB.Surname);
			    
			      		}
			    }
			}
		   myConnection.Close(); 
		    }
		    catch(Exception  ex)
		{
			MessageBox.Show(ex.Message);
		}
			
			
		    MessageBox.Show("completed matching results are located at ");
		    
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Password321!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Password321!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
		    OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
		    try
		    {
		    	myConnection.Open();
				MessageBox.Show(myConnection.ServerVersion);
		
				
				
					
			
			genderdob myDOB ;
			int  currentrow = 0;
      			int  found=0;
      			int notfound=0;
			DateTime now = DateTime.Now;
			string outfilenamewithpath =@"c:/test/resolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+ now.Hour.ToString()+now.Minute.ToString()+".txt";
			string nonmatchoutfilenamewithpath=@"c:/test/nonresolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+  now.Hour.ToString()+now.Minute.ToString()+".txt";
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			System.IO.StreamReader sr = new 
         		System.IO.StreamReader(openFileDialog1.FileName);
      			
			      while(sr.Peek() !=-1)
			      { string[] words;
			        string UCRN =string.Empty;
			     	words=sr.ReadLine().Split(',');
			     	try
			     	{    currentrow++;
			     		 UCRN =GetUCRN(myConnection,words[1],words[2],words[4], words[3]);
			     	}
			     	catch(Exception ex)
			     	{
			     		UCRN= string.Empty;
			     	}
			     	//need code to get UCRN
			     	//MessageBox.Show(words.Length.ToString);
			     	//write to output file
			     	if (UCRN !=String.Empty)
			     	{
			     		found++;
			     	using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    {
							foreach (string userdetail   in words)
							{
								file.Write(userdetail+delimeter);
							}
			
					
						    // write file output
					      	file.WriteLine(UCRN);
			    
			      		}
			     	}
			     	else
			     	{ notfound++;
			     		using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
			      	    {
							foreach (string userdetail   in words)
							{
								file.Write(userdetail+delimeter);
							}
			
					
						    // write file output
					      	file.WriteLine(UCRN);
			    
			      		}
			     		
			     	}
			     	
			      }
			      
			  using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + notfound.ToString() +" no matches  found");
				}  
using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + found.ToString() +" matches  found");
				}    			  
			}
				
				
			
		    }
		    catch(Exception ex)
		    {
		    	MessageBox.Show(ex.Message);
		    }
			  
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Password321!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Password321!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
			DateTime now = DateTime.Now;
			string outfilenamewithpath =@"c:/test/resolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+ now.Hour.ToString()+now.Minute.ToString()+".txt";
			string nonmatchoutfilenamewithpath=@"c:/test/nonresolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+  now.Hour.ToString()+now.Minute.ToString()+".txt";
				int currentrow=0;
				int found=0;
				int notfound=0;
				 //   string UCRN= string.Empty;
				 OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
			  
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFile)); 
	           engine.Options.IgnoreFirstLines=1;
			  
				GUIDFile[] res = engine.ReadFile(openFileDialog1.FileName) as GUIDFile[]; 
			     List<GUIDFile> list_lines = new List<GUIDFile>(res);
			       Stopwatch stopwatch = new Stopwatch();
				
			    stopwatch.Start();
					myConnection.Open();
				 Parallel.ForEach(list_lines,
    			new ParallelOptions { MaxDegreeOfParallelism = 20 }, cust =>
							{ 
    							currentrow++;
    							 string    UCRN=string.Empty;
    							try{
    						
    							
    							
			    	    UCRN =GetUCRN(myConnection,cust.Forename,cust.Surname,cust.Gender, cust.DateOfBirth);
			    		    
    							}
    							catch(Exception Ex)
    							{
    								MessageBox.Show(Ex.Message);
    								
    								
    							}
   								 if (UCRN !=String.Empty)
			     				{
			     					found++;
			     				using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    			{
			     					file.WriteLine(UCRN+delimeter+cust.GUID+delimeter+cust.Forename+delimeter+cust.Surname+delimeter+cust.DateOfBirth+delimeter+cust.Gender +delimeter+ cust.AD1+delimeter+ cust.AD2+delimeter+cust.AD3+delimeter+cust.AD4+cust.PostCode+delimeter+cust.AD5+delimeter+ cust.AD6+delimeter+cust.UPRN);
							     	}
   								 }
						     	else
						     	{ notfound++;
						     		using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
						      	    {
										
						              string  tempguid = cust.GUID.Remove(0,3);
								
									    // write file output
								      	file.WriteLine(cust.GUID+delimeter+cust.Forename+delimeter+cust.Surname+delimeter+cust.DateOfBirth+delimeter+cust.Gender +delimeter+ cust.AD1+delimeter+ cust.AD2+delimeter+cust.AD3+delimeter+cust.AD4+cust.PostCode+delimeter+cust.AD5+delimeter+ cust.AD6+delimeter+cust.UPRN);
							     
						      		}
						     		
						     	}
    
    
    
    			});
    						
						     
						
	}
			//put counter in here
			 using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + notfound.ToString() +" no matches  found");
				}  
using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + found.ToString() +" matches  found");
				}    
myConnection.Close();
MessageBox.Show("processed " + 	openFileDialog1.FileName);
}

	#region BackgroundWorker
		void BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			RetrieveCitizenDetailsFromCAS();
		}
		
		void BackgroundWorkerProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
			this.Text = " Processed " + e.ProgressPercentage.ToString() +
				" out of " + progressBar1.Maximum.ToString();
		}
		
		void BackgroundWorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			
		}
		#endregion
		
		void Button4Click(object sender, EventArgs e)
		{
			//backgroundWorker.;
			
		}
		
		void RetrieveCitizenDetailsFromCAS()
		{
			
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Password321!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Password321!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
			DateTime now = DateTime.Now;
			string outfilenamewithpath =@"c:/test/resolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+ now.Hour.ToString()+now.Minute.ToString()+".txt";
			string nonmatchoutfilenamewithpath=@"c:/test/nonresolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+  now.Hour.ToString()+now.Minute.ToString()+".txt";
				int currentrow=0;
				int found=0;
				int notfound=0;
				 //   string UCRN= string.Empty;
				 OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
			Stopwatch stopwatch = new Stopwatch();
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFile)); 
	 
			
				GUIDFile[] res = engine.ReadFile(openFileDialog1.FileName) as GUIDFile[]; 
			     List<GUIDFile> list_lines = new List<GUIDFile>(res);
			       
				
			    stopwatch.Start();
					myConnection.Open();
				 Parallel.ForEach(list_lines,
    			new ParallelOptions { MaxDegreeOfParallelism = 20 }, cust =>
							{ 
    							currentrow++;
    							 string    UCRN=string.Empty;
    							try{
    						
    							
    							
			    	    UCRN =GetUCRN(myConnection,cust.Forename,cust.Surname,cust.Gender, cust.DateOfBirth);
			    		    
    							}
    							catch(Exception Ex)
    							{
    								//MessageBox.Show(Ex.Message);
    								
    								
    							}
   								 if (UCRN !=String.Empty)
			     				{
			     					found++;
			     				using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    			{
			     					file.WriteLine(found+",U,"+UCRN+",,,,,,"+ cust.GUID+ delimeter);
							     	}
   								 }
						     	else
						     	{ notfound++;
						     		using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
						      	    {
										
						              string  tempguid = cust.GUID.Remove(0,3);
								
									    // write file output
								      	file.WriteLine(tempguid+","+cust.Forename+","+cust.Surname+","+cust.DateOfBirth+","+cust.Gender+","+cust.PostCode);
						    
						      		}
						     		
						     	}
    
    
    
    			});
					stopwatch.Stop();
						     
						
	}
			//put counter in here
			 using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + notfound.ToString() +" no matches  found");
				}  
using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + found.ToString() +" matches  found");
				}    
myConnection.Close();

MessageBox.Show("processed " + 	openFileDialog1.FileName +" this took" +stopwatch.Elapsed.ToString() );
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Password321!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Password321!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
			DateTime now = DateTime.Now;
			string outfilenamewithpath =@"c:/test/resolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+ now.Hour.ToString()+now.Minute.ToString()+".txt";
			string nonmatchoutfilenamewithpath=@"c:/test/nonresolvedGUID"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+  now.Hour.ToString()+now.Minute.ToString()+".txt";
				int currentrow=0;
				int found=0;
				int notfound=0;
				 //   string UCRN= string.Empty;
				 OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
				 List<ResolvedFile> Resolved_File = new List<ResolvedFile>();
				 List<GUIDFile> list_lines=new List<GUIDFile>();
				  List<GUIDFile> No_Match_lines=new List<GUIDFile>();
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFile)); 
	          // engine.Options.IgnoreFirstLines=1;
			  
				GUIDFile[] res = engine.ReadFile(openFileDialog1.FileName) as GUIDFile[]; 
			  list_lines = new List<GUIDFile>(res);
			       Stopwatch stopwatch = new Stopwatch();
				
				
			    stopwatch.Start();
					myConnection.Open();
				 Parallel.ForEach(list_lines,
    			new ParallelOptions { MaxDegreeOfParallelism = 20 }, cust =>
							{ 
    							currentrow++;
    							 string    UCRN=string.Empty;
    							try{
    						
    							
    							
			    	    UCRN =GetUCRN(myConnection,cust.Forename,cust.Surname,cust.Gender, cust.DateOfBirth);
			    	    log.Info(cust.Forename + " "+cust.Surname +" = "+ UCRN);
    							}
    							catch(Exception Ex)
    							{
    								//MessageBox.Show(Ex.Message);
    								log.Error(Ex.Message,Ex);
    								
    							}
   								 if (UCRN !=String.Empty)
			     				{
			     					found++;
			     					ResolvedFile myResolvedFile = new ResolvedFile(cust,UCRN);
			     					
			     					Resolved_File.Add(myResolvedFile);
//			     				using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
//			      	    			{
//			     					file.WriteLine(UCRN+delimeter+cust.GUID+delimeter+cust.Forename+delimeter+cust.Surname+delimeter+cust.DateOfBirth+delimeter+cust.Gender +delimeter+ cust.AD1+delimeter+ cust.AD2+delimeter+cust.AD3+delimeter+cust.AD4+cust.PostCode+delimeter+cust.AD5+delimeter+ cust.AD6+delimeter+cust.UPRN);
//							     	}
   								 }
						     	else
						     	{ notfound++;
						     		 No_Match_lines.Add(cust);
//						     		using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
//						      	    {
//										
//						              string  tempguid = cust.GUID.Remove(0,3);
//						             
//									    // write file output
//								      	file.WriteLine(cust.GUID+delimeter+cust.Forename+delimeter+cust.Surname+delimeter+cust.DateOfBirth+delimeter+cust.Gender +delimeter+ cust.AD1+delimeter+ cust.AD2+delimeter+cust.AD3+delimeter+cust.AD4+cust.PostCode+delimeter+cust.AD5+delimeter+ cust.AD6+delimeter+cust.UPRN);
//							     
//						      		}
						     		
						     	}
    
    
    
    			});
					stopwatch.Stop();
					log.Info(stopwatch.Elapsed +" Seconds to processs");
					MessageBox.Show(stopwatch.Elapsed +" Seconds to processs");
						
	}
			//put counter in here
			FileHelperEngine engineNoMatch = new FileHelperEngine(typeof(GUIDFile)); 
	         FileHelperEngine engineMatch = new FileHelperEngine(typeof(ResolvedFile)); 
	         engineMatch.WriteFile(outfilenamewithpath,Resolved_File);
	         engineNoMatch.WriteFile(nonmatchoutfilenamewithpath,No_Match_lines);
	        
			 using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchoutfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + notfound.ToString() +" no matches  found");
				}  
using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + found.ToString() +" matches  found");
				}    
myConnection.Close();
MessageBox.Show("processed " + 	openFileDialog1.FileName);
		}
	}
}
