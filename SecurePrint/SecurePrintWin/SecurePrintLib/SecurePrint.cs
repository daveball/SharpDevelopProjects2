/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 05/09/2012
 * Time: 14:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SecurePrintLib
{
	/// <summary>
	/// Description of SecurePrint.
	/// </summary>
	public class SecurePrint
	{   private int _Rows;
		private int _UsersCount;
		private	int	_PasswordCount;
        private int	_SecurityCount;	
		private string[] _Header;
		private string[][] _UserNames;
		private string[][] _Passwords;
		private string[][] _Security;
		private string[][] _PrintUserName;
		private string[][]_PrintPasswordSecurity;
		public string[] Header
		{
			get
			{
				return _Header;
			}
		}
		public int Rows
		{
			get
			{
				return _Rows;
			}
		}
		public int UsersCount
		{
			get
			{
				return _UsersCount;
			}
		}
		public int PasswordCount
		{
			get
			{
				return _PasswordCount;
			}
		}
		public int SecurityCount
		{
			get
			{
				return _SecurityCount;
			}
		}
		public string[][] UserNames
		{
			get
			{
				return _UserNames;
			}
		}
		public string[][]Passwords
		{
			get
			{
				return _Passwords;
			}
		}
		public string[][]Security
		{
			get
			{
				return _Security;
			}
		}
		public void processfile(string inputfile)
		{
			CountLinesInFile(inputfile);
		}
		private static void CountLinesInFile(string f)
    {
 	_Rows = 0;
 		_UserCount=0;
 	_PasswordCount=0;
 		_SecurityCount=0;
		
	
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
     	
     	this._Rows++;
     	if(words[2] =="U")
      	{  
      		
      		//countusernames++;
      		this._UserCount++;
      	}
      	if(words[2]=="P")
      	{
      		
      		this._PasswordCount++;
      	//countpasswords++;
      	}
      	  	if(words[2]=="M" || words[2]=="S")
      	{
      		this._SecurityCount++;
      	
      		//countsecurity++;
      	}
     	
      }
	    
	    
	}
//	int[] mycount= new int[4];
//	mycount[0]=count;
//	mycount[1]=countusernames;
//	mycount[2]=countpasswords;
//	mycount[3]=countsecurity;
//	return mycount;
    }
		
		public void printfile(string filename, string  filepath, string[][]dataarray, string[]header,int dataelements)
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
		      		if(userdetail!="001"&&userdetail!="002"&&userdetail!="003")
					{
						file.Write(userdetail+delimeter);
					}
					else
					{
						file.WriteLine(userdetail);
					}
					
				}
				
		      	}
				int rowcount= dataelements+2;
		file.WriteLine("T"+delimeter+rowcount+delimeter+dataelements);
          }
		}
	}
}
