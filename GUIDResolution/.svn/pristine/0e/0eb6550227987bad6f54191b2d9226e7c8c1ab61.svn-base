/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 26/11/2013
 * Time: 15:40
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
using System.IO;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace GUIDResolution
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		const string delimeter=",";
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		BackgroundWorker worker,backgroundWorker;
		private static readonly object locker = new object();                       


		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//set up  back ground worker
			 worker = new BackgroundWorker();
        	 worker.WorkerReportsProgress = true;
             worker.ProgressChanged += worker_ProgressChanged;
       		 worker.DoWork += worker_DoWork;
        	 worker.RunWorkerCompleted += worker_RunWorkerCompleted;

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private string SelectFilename()
		{
			string file = string.Empty;
			
			DialogResult result = openFileDialog.ShowDialog();
			
			if (result == DialogResult.OK)
			{
				try
				{
					file = openFileDialog.FileName;
					
					return file;
				}
				catch (IOException ex)
				{
					MessageBox.Show("An error occured while attempting to load your selected path. Error message: " +
					                System.Environment.NewLine + ex.Message);
					
					return file = string.Empty;
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occured while attempting to load your selected path. Error message: " +
					                System.Environment.NewLine + ex.Message);
					
					return file = string.Empty;
				}
			}
			else return file = string.Empty;
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
		
		string formatDate( string date)
		{
			string[] DOBElements=date.Split('/');
			string Month = getMonth(Convert.ToInt16(DOBElements[1]));
			string Year =DOBElements[2].Remove(0,2);
			string formattedDate =DOBElements[0]+"-"+Month+"-"+Year;
			return formattedDate;
		}
		string GetUCRN(OracleConnection connection, string Forename, string Surname, string Gender, string DateOfBirth)
		{
			OracleCommand command = connection.CreateCommand();
			string dateFormatted=formatDate(DateOfBirth);
			DateTime now = DateTime.Now;
			//command.CommandText = "select Apps.HZ_Parties.Attribute1  from apps.hz_parties full outer join apps.hz_PERSON_PROFILES  on apps.hz_parties.Party_ID =apps.hz_PERSON_PROFILES.party_ID where Apps.HZ_Parties.Person_First_Name ='"+Forename+"' and Apps.HZ_Parties.Person_Last_Name='"+Surname+"' and apps.hz_PERSON_PROFILES.DATE_OF_BIRTH='" +DOBElements[0]+"-"+Month+"-"+Year+ "' and apps.hz_PERSON_PROFILES.GENDER like'"+Gender+"%' and apps.hz_parties.Attribute1 not like 'UCR%'";
           command.CommandText = "select Apps.HZ_Parties.Attribute1  from apps.hz_parties full outer join apps.hz_PERSON_PROFILES  on apps.hz_parties.Party_ID =apps.hz_PERSON_PROFILES.party_ID where soundex(Apps.HZ_Parties.Person_First_Name) =soundex('"+Forename+"') and soundex(Apps.HZ_Parties.Person_Last_Name)=soundex('"+Surname+"') and apps.hz_PERSON_PROFILES.DATE_OF_BIRTH='" + dateFormatted+ "' and apps.hz_PERSON_PROFILES.GENDER like'"+Gender+"%' and apps.hz_parties.Attribute1 not like 'UCR%'";
           
           log.Info(command.CommandText);

		using (OracleDataReader reader = command.ExecuteReader())
        {
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
		
		
		
		void RetrieveCitizenDetailsFromCAS(string inputfilenamewithpath, string matchfileoutput, string nonmatchedfileoutput)
		{
			//set up database connection will need to refactor this at some point
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Celtic123!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Celtic123!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
			DateTime now = DateTime.Now;
			int currentrow=0;
			int found=0;
			int notfound=0;
				 //   string UCRN= string.Empty;
				 
		    OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
			  
			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFile));
			GUIDFile[] res = engine.ReadFile(inputfilenamewithpath) as GUIDFile[]; 
			List<GUIDFile> list_lines = new List<GUIDFile>(res);
			
			
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
    								log.Error( inputfilenamewithpath + currentrow, Ex);
    								
    								
    							}
   								 if (UCRN !=String.Empty)
			     				{
			     					found++;
			     					int attempts=0;
			     					lock(locker)
			     					{
			     				using(System.IO.StreamWriter file = new System.IO.StreamWriter(matchfileoutput, true))
			      	    			{tryagainfound:
			     					try{
			     					
			     						attempts++;
			     						file.WriteLine(found+",U,"+UCRN+",,,,,,,"+ cust.GUID+ delimeter);
			     						}
			     						catch(Exception e)
			     						{
			     						log.Error(e.Message,e);
			     						if (attempts<20)
				     						{ 
			     							goto tryagainfound;
				     						}
				     						
			     						}
			     					}
			     					}
   								 }
						     	else
						     	{ lock(locker)
						     		{
						     		notfound++;
						     		 int attempts=0;
						     		 using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchedfileoutput, true))
						      	    {tryagainnotfound:
						     			try{
						     		 		attempts++;
						     			
						              string  tempguid = cust.GUID.Remove(0,3);
								
									    // write file output
								      	file.WriteLine(tempguid+","+cust.Forename+","+cust.Surname+","+cust.DateOfBirth+","+cust.Gender+","+cust.PostCode);
						     			}
						     			catch(Exception e)
			     						{
			     						log.Error(e.Message,e);
			     						if (attempts<20)
				     						{ 
			     							goto tryagainnotfound;
				     						}
				     						
			     						}
						      		}
						     		}
						     	}
    
    
    
    			});
			myConnection.Close();
			//put counter in here
			 	using(System.IO.StreamWriter file = new System.IO.StreamWriter(nonmatchedfileoutput, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + notfound.ToString() +" no matches  found");
				}  
				using(System.IO.StreamWriter file = new System.IO.StreamWriter(matchfileoutput, true))
				{
			  	file.WriteLine(currentrow.ToString() +" records processed " + found.ToString() +" matches  found");
				}    
			       
		}
		
	    void RetrieveCitizenDetailsFromCAS()
		{
			
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Celtic123!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Celtic123!";
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
			if(openFileDialog.ShowDialog() == DialogResult.OK)
   			{
      			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFile)); 
	 
			
				GUIDFile[] res = engine.ReadFile(openFileDialog.FileName) as GUIDFile[]; 
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
    								MessageBox.Show(Ex.Message);
    								
    								
    							}
   								 if (UCRN !=String.Empty)
			     				{
			     					found++;
			     				using(System.IO.StreamWriter file = new System.IO.StreamWriter(outfilenamewithpath, true))
			      	    			{
			     					file.WriteLine(found+",U,"+UCRN+",,,,,,,"+ cust.GUID+ delimeter);
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

				MessageBox.Show("processed " + 	openFileDialog.FileName +" this took" +stopwatch.Elapsed.ToString() );
			
		}	
		#region BackgroundWorker
		void BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			string filenamelist = SelectFilename();
			string inputpath = System.IO.Path.GetDirectoryName(filenamelist); 
			string outputpath=@"c:\Test\GUIDResults\";
			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFileList)); 
	        GUIDFileList[] res = engine.ReadFile(filenamelist) as GUIDFileList[]; 
		    List<GUIDFileList> list_lines = new List<GUIDFileList>(res);
		    Parallel.ForEach(list_lines,
    			new ParallelOptions { MaxDegreeOfParallelism = 20 }, cust =>
				{
    				
    				log.Info("Processing "+inputpath+cust.GUIDFiletoProcess);
    				RetrieveCitizenDetailsFromCAS(inputpath+cust.GUIDFiletoProcess, outputpath+"Matched"+cust.GUIDFiletoProcess,outputpath+"NotMatched"+cust.GUIDFiletoProcess);
    			});
		}
		
		void BackgroundWorkerProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar.Value = e.ProgressPercentage;
			this.Text = " Processed " + e.ProgressPercentage.ToString() +
				" out of " + progressBar.Maximum.ToString();
		}
		
		void BackgroundWorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			
		}
		#endregion
		
		#region background worker for file list
		void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
       ProcessFileListBtn.Enabled = true;
    }

		void worker_DoWork(object sender, DoWorkEventArgs e)
    {
       		
    }

    void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        
        progressBar.Value = e.ProgressPercentage;
    }



		#endregion
		void ProcessFileListBtnClick(object sender, EventArgs e)
		{
			
			string filenamelist = SelectFilename();
			string inputpath = System.IO.Path.GetDirectoryName(filenamelist); 
			inputpath =inputpath +@"\";
			string outputpath=@"c:\Test\GUIDResultsNoQuote\";
			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFileList)); 
	        GUIDFileList[] res = engine.ReadFile(filenamelist) as GUIDFileList[]; 
	        progressBar.Maximum=res.Length;
		    List<GUIDFileList> list_lines = new List<GUIDFileList>(res);
		    Parallel.ForEach(list_lines,
		                     
    			new ParallelOptions { MaxDegreeOfParallelism = 2 }, cust =>
				{
    				
    				log.Info("Processing "+inputpath+cust.GUIDFiletoProcess);
    				RetrieveCitizenDetailsFromCAS(inputpath+cust.GUIDFiletoProcess, outputpath+"Matched"+cust.GUIDFiletoProcess,outputpath+"NotMatched"+cust.GUIDFiletoProcess);
    			});
			worker.RunWorkerAsync();
			ProcessFileListBtn.Enabled = false;

//			string filenamelist = SelectFilename();
//			string inputpath = System.IO.Path.GetDirectoryName(filenamelist); 
//			string outputpath=@"c:\Test\GUIDResults\";
//			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFileList)); 
//	        GUIDFileList[] res = engine.ReadFile(filenamelist) as GUIDFileList[]; 
//		    List<GUIDFileList> list_lines = new List<GUIDFileList>(res);
//		    Parallel.ForEach(list_lines,
//    			new ParallelOptions { MaxDegreeOfParallelism = 20 }, cust =>
//				{
//    				
//    				log.Info("Processing "+path+cust.GUIDFiletoProcess);
//    				RetrieveCitizenDetailsFromCAS(path+cust.GUIDFiletoProcess, outputpath+"Matched"+cust.GUIDFiletoProcess,outputpath+"NotMatched"+cust.GUIDFiletoProcess);
//    			});
    			
    	}
			  
		}
}
