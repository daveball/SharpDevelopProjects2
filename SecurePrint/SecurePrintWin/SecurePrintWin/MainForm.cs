/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 03/09/2012
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SecurePrintWin
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
		
		void FolderBrowserDialog1HelpRequest(object sender, EventArgs e)
		{
			
		}
		void printfile(string filename, string  filepath, string[][]dataarray, string[]header,int dataelements)
		{ 
			string delimeter ="|";
		 string filenamewithpath=filepath+filename;
			using(System.IO.StreamWriter file = new System.IO.StreamWriter(filenamewithpath, true))
      	{
			//foreach(string[] username in usernames)
			file.WriteLine("H|"+filename+"|"+header[2]+"|"+header[3]);
			int i;
				for(i=0;i<dataelements;i++)
      	        {
				foreach (string userdetail   in dataarray[i])
				{
		      		file.Write(userdetail+delimeter);
				}
				file.WriteLine("001");
		      	}
				int rowcount= dataelements+2;
		file.WriteLine("T"+delimeter+rowcount+delimeter+dataelements);
          }
		}
		static int[] CountLinesInFile(string f,int countusernames, int countpasswords,int countsecurity)
    {
	int count = 0;
	using ( System.IO.StreamReader r = new  System.IO.StreamReader(f))
	{
	    string line;
//	    while ((line = r.ReadLine()) != null)
//	    {
//		count++;
//	    }
	    
	   int  currentrow = 0;
      while(r.Peek() !=-1)
      {   string[] words;
     
     		words=r.ReadLine().Split('~');
     	
     	count++;
     	if(words[2] =="U")
      	{  
      		
      		countusernames++;
      	}
      	if(words[2]=="P")
      	{
      		
      		
      	countpasswords++;
      	}
      	  	if(words[2]=="M" || words[2]=="S")
      	{
      		
      	
      		countsecurity++;
      	}
     	
      }
	    
	    
	}
	int[] mycount= new int[4];
	mycount[0]=count;
	mycount[1]=countusernames;
	mycount[2]=countpasswords;
	mycount[3]=countsecurity;
	return mycount;
    }
		void OpenFileBtnClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   {
      System.IO.StreamReader sr = new 
         System.IO.StreamReader(openFileDialog1.FileName);
      int countpass=0,countuser=0, countsec=0;
      int[] rows = CountLinesInFile(openFileDialog1.FileName,countuser,countpass,countsec);
      MessageBox.Show("rows="+ rows[0]+",username records="+rows[1]+", password records="+rows[2]+", Security phrase records="+rows[3]);
      
      //MessageBox.Show(records.ToString());
      string[][] row = new string[rows[0]][];
      string[][] usernames = new string[rows[1]][];
      string[][] passwords= new string[rows[2]][];
      string[][] SecurityPhrase= new string[rows[3]][];
      string[] header = new string[4] ;
      string[] trailer;
     int currentsecurityphrase=0;
     int currentusername=0;
     int currentpassword =0;
     int  currentrow = 0;
      while(sr.Peek() !=-1)
      {   string[] words;
     
     		words=sr.ReadLine().Split('~');
     	row[currentrow]= words;
     // rows[row]=sr.ReadLine().Split('~');
     if(words[0]=="D")
     {
      	if(words[2] =="U")
      	{  
      		
      		usernames[currentusername]=words;
      		MessageBox.Show(usernames[currentusername][4]+" username is "+ usernames[currentusername][3]+" and  address "+usernames[currentusername][5]+","+usernames[currentusername][10]);
      		currentusername++;
      	}
      	if(words[2]=="P")
      	{
      		
      		passwords[currentpassword]=words;
      		currentpassword++;
      	}
      	  	if(words[2]=="M" || words[2]=="S")
      	{
      		
      	SecurityPhrase[currentsecurityphrase]=words;
      		currentsecurityphrase++;
      	}
     } else if(words[0]=="T")
     {// code to process trailer
     	trailer=words;
     	
     }
     else if(words[0]=="H")
     {
     	header = words;
     	//code to process header
     }
      	currentrow++;
      	
      	
      }
        
      int processed =0;
      int secureprintsecuirtyrecords =0;
     secureprintsecuirtyrecords=rows[3] + rows[2];
     
      string[][] securePrintPasswordSecurityPhrase= new string[secureprintsecuirtyrecords][];
      
      for(int i=0;i< rows[3];i++)
      { bool match= false;
      	currentpassword=0;
      
	      		while((match==false)&& ( rows[2]!=currentpassword ))
	      		 {
	      			if((SecurityPhrase[i][4] == passwords[currentpassword][4])&&(SecurityPhrase[i][10] == passwords[currentpassword][10]))
	      			{
	      			MessageBox.Show("Found a match");
	      			securePrintPasswordSecurityPhrase[processed]= new String[13];
	      			securePrintPasswordSecurityPhrase[processed][0]="D";
	      			securePrintPasswordSecurityPhrase[processed][1]= passwords[currentpassword][1]+"-"+SecurityPhrase[i][1];
	      			securePrintPasswordSecurityPhrase[processed][2]=passwords[currentpassword][3];
	      			securePrintPasswordSecurityPhrase[processed][3]=SecurityPhrase[i][3];
	      			securePrintPasswordSecurityPhrase[processed][4]=SecurityPhrase[i][4];
	      			securePrintPasswordSecurityPhrase[processed][5]=SecurityPhrase[i][5];
	      		    securePrintPasswordSecurityPhrase[processed][6]=SecurityPhrase[i][6];
	      			securePrintPasswordSecurityPhrase[processed][7]=SecurityPhrase[i][7];
	      			securePrintPasswordSecurityPhrase[processed][8]=SecurityPhrase[i][8];
	      			securePrintPasswordSecurityPhrase[processed][9]=SecurityPhrase[i][9];
	      			securePrintPasswordSecurityPhrase[processed][10]=SecurityPhrase[i][10];
	      			securePrintPasswordSecurityPhrase[processed][11]=SecurityPhrase[i][11];
	      			securePrintPasswordSecurityPhrase[processed][12]="001";
	      			match=true;
	      			processed++;
	      		} 
	      		currentpassword++;
	      		 }
	      		if (match==false)
	      		{
	      			MessageBox.Show("No Found a match");
	      			securePrintPasswordSecurityPhrase[processed]= new String[13];
	      			securePrintPasswordSecurityPhrase[processed][0]="D";
	      			securePrintPasswordSecurityPhrase[processed][1]= "-"+SecurityPhrase[i][1];
	      			securePrintPasswordSecurityPhrase[processed][2]=string.Empty;
	      			securePrintPasswordSecurityPhrase[processed][3]=SecurityPhrase[i][3];
	      			securePrintPasswordSecurityPhrase[processed][4]=SecurityPhrase[i][4];
	      			securePrintPasswordSecurityPhrase[processed][5]=SecurityPhrase[i][5];
	      		    securePrintPasswordSecurityPhrase[processed][6]=SecurityPhrase[i][6];
	      			securePrintPasswordSecurityPhrase[processed][7]=SecurityPhrase[i][7];
	      			securePrintPasswordSecurityPhrase[processed][8]=SecurityPhrase[i][8];
	      			securePrintPasswordSecurityPhrase[processed][9]=SecurityPhrase[i][9];
	      			securePrintPasswordSecurityPhrase[processed][10]=SecurityPhrase[i][10];
	      			securePrintPasswordSecurityPhrase[processed][11]=SecurityPhrase[i][11];
	      			securePrintPasswordSecurityPhrase[processed][12]="002";
	      			processed++;
	      								
	      		}
      }
      	 		
   for(int i=0;i< rows[2];i++)
      { bool match= false;
      	currentpassword=0;
      	   	while((match==false)&& ( rows[3]!=currentpassword ))
	      		 {
	      		if(passwords[i][4] == SecurityPhrase[currentpassword][4])
	      			{
	      			
	      			match=true;
	      		
	      		} 
	      		currentpassword++;
	      		 }
	      		if (match==false)
	      		{
	      			MessageBox.Show("No Found a match");
	      			securePrintPasswordSecurityPhrase[processed]= new String[13];
	      			securePrintPasswordSecurityPhrase[processed][0]="D";
	      			securePrintPasswordSecurityPhrase[processed][1]= passwords[i][1]+"-";
	      			securePrintPasswordSecurityPhrase[processed][2]=passwords[i][3];
	      			securePrintPasswordSecurityPhrase[processed][3]=string.Empty;
	      			securePrintPasswordSecurityPhrase[processed][4]=passwords[i][4];
	      			securePrintPasswordSecurityPhrase[processed][5]=passwords[i][5];
	      		    securePrintPasswordSecurityPhrase[processed][6]=passwords[i][6];
	      			securePrintPasswordSecurityPhrase[processed][7]=passwords[i][7];
	      			securePrintPasswordSecurityPhrase[processed][8]=passwords[i][8];
	      			securePrintPasswordSecurityPhrase[processed][9]=passwords[i][9];
	      			securePrintPasswordSecurityPhrase[processed][10]=passwords[i][10];
	      			securePrintPasswordSecurityPhrase[processed][11]=passwords[i][11];
	      			securePrintPasswordSecurityPhrase[processed][12]="003";
	      			processed++;
	      								
	      		}
      	   }
    DateTime now = DateTime.Now;
    string usernamefilename="sp-"+"u-"+"001-"+now.ToString("yyyyMMdd-HHmm")+".csv";
    MessageBox.Show(usernamefilename);
 string usernamefilenamewithpath =@"c:\";
      	   string delimeter ="|";
      	   printfile(usernamefilename,usernamefilenamewithpath,usernames,header,rows[1]);
      	   
//		using(System.IO.StreamWriter file = new System.IO.StreamWriter(usernamefilenamewithpath, true))
//      	{
//			//foreach(string[] username in usernames)
//			file.WriteLine("H|"+usernamefilename+"|"+header[2]+"|"+header[3]);
//			int i;
//				for(i=0;i<rows[1];i++)
//      	        {
//				foreach (string userdetail   in usernames[i])
//				{
//		      		file.Write(userdetail+delimeter);
//				}
//				file.WriteLine("001");
//		      	}
//				int rowcount= rows[1]+2;
//		file.WriteLine("T"+delimeter+rowcount+delimeter+rows[1]);
//          }
       string securefilename ="sp-"+"u-"+"002-"+now.ToString("yyyyMMdd-HHmm")+".csv";
       string securefilenamewithpath =@"c:\"+securefilename;
       using(System.IO.StreamWriter secure = new System.IO.StreamWriter(securefilenamewithpath,true))
       {
             secure.WriteLine("H|"+securefilename+"|"+header[2]+"|"+header[3]);
             int i;
             	
             	for(i=0;i<processed;i++)
      	        {
				foreach (string userdetail   in securePrintPasswordSecurityPhrase[i])
				{
					if(userdetail!="001"&&userdetail!="002"&&userdetail!="003")
					{
						secure.Write(userdetail+delimeter);
					}
					else
					{
						secure.WriteLine(userdetail);
					}
				}
				//file.WriteLine("001");
		      	}
             	int rowcount = processed+2;
             	secure.WriteLine("T"+delimeter+rowcount+delimeter+processed);
         }
		
		
		
			}
			
			
			
		}
//   
	}
}
