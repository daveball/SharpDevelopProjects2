/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 20/01/2014
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FileHelpers;

namespace TemporaryUCRNCleaningandConverting
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
		
		void BtnLoadUCRNFileClick(object sender, EventArgs e)
		{
         if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{    
         		string MDMWFileName = @"c:\DATA\UCRN.csv";
      			FileHelperEngine engine = new FileHelperEngine(typeof(GUIDFile)); 
      			FileHelperEngine MDMWengine = new FileHelperEngine(typeof(MDMWFile));
      			FileHelperEngine CASCoreEngine= new FileHelperEngine(typeof(CASCoreUpdate));
      			FileHelperEngine MDMWMatchedEngine = new FileHelperEngine(typeof(MDMWMatched));
      			List<MDMWMatched> myMDMWMatched = new List<MDMWMatched>();
      			MDMWFile[] mdmdRes= MDMWengine.ReadFile(MDMWFileName) as MDMWFile[];
				GUIDFile[] res = engine.ReadFile(openFileDialog1.FileName) as GUIDFile[]; 
				List<CASCoreUpdate> myCasCoreUpdate =  new List<CASCoreUpdate>();
				List<MDMWFile> MDMWusers = new List<MDMWFile>(mdmdRes);
				List<GUIDFile> list_lines = new List<GUIDFile>(res);
			    List<GUIDFile> MDMWList = new List<GUIDFile>();
			     MessageBox.Show(list_lines.Count.ToString());
			     int intiallines = list_lines.Count;	
			     MessageBox.Show(list_lines[34191].GUID +" & UCRN:" +list_lines[34191].UCRN);
			     string  UCRN = "8022901985693042667";
			     GUIDFile myguid = new GUIDFile();
			     myguid.UCRN=UCRN;
			     myguid.GUID="0015235";
			     MessageBox.Show(myguid.UCRN +" "+myguid.GUID);
			     int record=0;
			     List<int> MDMWrecords = new List<int>();
			     foreach( GUIDFile currentGuid in list_lines)
			     { currentGuid.GUID= "UCR"+currentGuid.GUID;
			     	foreach( MDMWFile myMDMWrecord in MDMWusers)
			     	{
			     	if (currentGuid.UCRN == myMDMWrecord.UCRN)
			     	{
			     		//MessageBox.Show("Match Found" +currentGuid.UCRN + " "+ myMDMWrecord.UCRN);
			     		MDMWList.Add(currentGuid);
			     		MDMWMatched TempMDMWMatched = new MDMWMatched();
			     		TempMDMWMatched.UCRN=currentGuid.UCRN;
			     		TempMDMWMatched.tempUCRN=currentGuid.GUID;
			     		TempMDMWMatched.Forename= myMDMWrecord.Forename;
			     		TempMDMWMatched.Surname= myMDMWrecord.Surname;
			     		//TempMDMWMatched.username=myMDMWrecord.username;
			     		TempMDMWMatched.DOB= myMDMWrecord.DOB;
			     		//TempMDMWMatched.email= myMDMWrecord.email;
			     		//TempMDMWMatched.Gender=myMDMWrecord.Gender;
			     		myMDMWMatched.Add(TempMDMWMatched);
			     		//list_lines.Remove(currentGuid);
			     		MDMWrecords.Add(record);		     		;
			     		
			     	}
			     	}
			     		 	record++;
			     		 	CASCoreUpdate tempCasCoreUpdate = new CASCoreUpdate();
			     		tempCasCoreUpdate.recordID= record.ToString();
			     		tempCasCoreUpdate.TransType="U";
			     		tempCasCoreUpdate.UCRN = currentGuid.UCRN;
			     		tempCasCoreUpdate.T_UCRN = currentGuid.GUID;
			     		
			     		myCasCoreUpdate.Add(tempCasCoreUpdate);
			    
			     	
			     }
			     MessageBox.Show(intiallines.ToString() +" current lines  " +list_lines.Count.ToString() +"  "+ MDMWList.Count.ToString());
			      
			     //TextWriter tw = new StreamWriter("MDMWGuidMatches.txt");
			     foreach ( int i in MDMWrecords)
			     {
			     	myCasCoreUpdate.RemoveAt(i);
			     	
			     }
//			     foreach(GUIDFile myMDMWRecord  in MDMWList)
//			     {
//			     	tw.WriteLine(myMDMWRecord.GUID+","+myMDMWRecord.UCRN);
//			     }
//			     tw.Close();
//			     
			     MessageBox.Show(intiallines.ToString() +" current lines  " +list_lines.Count.ToString() +"  "+ MDMWList.Count.ToString());
                
                // TextWriter tw2 = new StreamWriter("CASCoreUpdate.csv");
                MDMWMatchedEngine.WriteFile(@"c:\data\MDMWGuidMatcheswithNames.txt",myMDMWMatched);
                //engine.WriteFile(@"C:\CASCoreUpdate.csv",list_lines);
                CASCoreEngine.WriteFile(@"C:\DATA\CASCoreUpdate.csv",myCasCoreUpdate);


								
//			     record=0;
//			     UCRN="8020881975899899725";
//			     foreach( GUIDFile currentGuid in list_lines)
//			     {
//			     	if (currentGuid.UCRN == UCRN)
//			     	{
//			     		MessageBox.Show("Match Found" +currentGuid.UCRN + " "+ currentGuid.UCRN);
//			     		MDMWList.Add(currentGuid);
//			     		//list_lines.Remove(currentGuid);
//			     		MDMWrecords.Add(record);		     		;
//			     		
//			     	}
//			     	record++;
//			     }
			     
			  MessageBox.Show(intiallines.ToString() +" current lines  " +list_lines.Count.ToString() +"  "+ MDMWList.Count.ToString());
			    
			     if (list_lines.Contains(myguid))
			     		
			     		
	{
	    Console.WriteLine("UCRN was found");
	}
         	}
		}
	}
}
