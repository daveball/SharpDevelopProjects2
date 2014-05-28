/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 12/04/2011
 * Time: 10:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

using System.IO;

using FileHelpers.MasterDetail;
using FileHelpers;
using System.Diagnostics;

using Microsoft.Office.Core;
using Excel ;

namespace ConsoleSanParser
{
	class Program
	{
		public static void Main(string[] args)
		{
			string  time= String.Empty;
	Iteration data = new Iteration();
	data.date="Date";
	data.StorageSubsystems="StorageSubsystems";
	data.Total="Total";
	data.Read="Read";
	data.CacheHit="CacheHit";
data.Current="Current";
data.Maximum="Maximum";
data.IOs="IOs";
data.Percentage="Percentage";
data.KBsecond="KBsecond";
		
	
	List<Iteration> SAN = new List<Iteration>();
		List<Iteration> STORAGE= new List<Iteration>();
			List<Iteration> CONTROLLER = new List<Iteration>();
	SAN.Add(data);
	STORAGE.Add(data);
	CONTROLLER.Add(data);
	
	string  filepath= @"C:\Working Directory\Documents\OSG\NMON\sanmonitoring\";
	 
	DirectoryInfo di = new DirectoryInfo(filepath);
 FileInfo[] rgFiles = di.GetFiles("*.*");
 MultiRecordEngine engine; 
		engine = new MultiRecordEngine(typeof(IterationDate), typeof(Subrecords),typeof(CaptIteration),typeof(SanController),typeof(Summary),typeof(junk));
	engine.RecordSelector = new RecordTypeSelector(ConsoleSanParser.CustomSelector); 
	foreach(FileInfo fi in rgFiles)
 {
  Trace.Write("<br><a href=" + fi.Name + ">" + fi.Name + "</a>");       


			
		
		
	 
	object[] res = engine.ReadFile(filepath+fi.Name);
	
	foreach(object o in res)
	{ if (o is IterationDate)
		{IterationDate date = (IterationDate)o;
			time= date.Date;
			Trace.WriteLine(time);}
		if (o is Subrecords)
		{
			Subrecords record = (Subrecords)o;
			Trace.WriteLine(time +","+ record.StorageSubsystems);
			Iteration data1			= new Iteration();
			data1.date=time;
			data1.StorageSubsystems=record.StorageSubsystems;
			data1.Total=record.Total;
			data1.Read=record.Read;
			data1.CacheHit=record.CacheHit;
			data1.Maximum=record.Maximum;
			data1.Percentage=record.Percentage;
			data1.KBsecond=record.KBsecond;
			data1.IOs=record.IOs;
			
			SAN.Add(data1);
			  
		}
		if(o is SanController)
		{
			SanController record = (SanController)o;
			Trace.WriteLine(time +","+ record.StorageSubsystems);
			Iteration data1			= new Iteration();
			data1.date=time;
			data1.StorageSubsystems=record.StorageSubsystems;
			data1.Total=record.Total;
			data1.Read=record.Read;
			data1.CacheHit=record.CacheHit;
			data1.Maximum=record.Maximum;
			data1.Percentage=record.Percentage;
			data1.KBsecond=record.KBsecond;
			data1.IOs=record.IOs;
			CONTROLLER.Add(data1);
		}
     if(o is Summary)
		{
			Summary record = (Summary)o;
			Trace.WriteLine(time +","+ record.StorageSubsystems);
			Iteration data1	= new Iteration();
			data1.date=time;
			data1.StorageSubsystems=record.StorageSubsystems;
			data1.Total=record.Total;
			data1.Read=record.Read;
			data1.CacheHit=record.CacheHit;
			data1.Maximum=record.Maximum;
			data1.Percentage=record.Percentage;
			data1.KBsecond=record.KBsecond;
			data1.IOs=record.IOs;
			
			STORAGE.Add(data1);
		}
	
		
	}
 }
	FileHelperAsyncEngine outputengine = new FileHelperAsyncEngine(typeof(Iteration)); 
	 
	outputengine.BeginWriteFile("TestOut.txt"); 
	foreach (Iteration iter in SAN)
	{
		
		outputengine.WriteNext(iter);
		Trace.WriteLine(iter.StorageSubsystems+","+iter.date);
		
		
	}
			outputengine.BeginWriteFile("Summary.txt"); 
	foreach (Iteration iter in STORAGE)
	{
		
		outputengine.WriteNext(iter);
		Trace.WriteLine(iter.StorageSubsystems+","+iter.date);
		
		
	}
	outputengine.BeginWriteFile("controller.txt"); 
	foreach (Iteration iter in CONTROLLER)
	{
		
		outputengine.WriteNext(iter);
		Trace.WriteLine(iter.StorageSubsystems+","+iter.date);
		
		
	}


Excel.Application excelApp = new Excel.Application();
string myPath = @"C:\Excel.xls";
excelApp.Workbooks.Open(myPath);
int rowIndex = 10; 



foreach (Iteration iter in CONTROLLER)
	{
		
		excelApp.Cells[rowIndex, 1] = iter.date;
		
		excelApp.Cells[rowIndex, 2] = iter.StorageSubsystems;
		
		excelApp.Cells[rowIndex, 3] = iter.Total;
		
		excelApp.Cells[rowIndex, 4] = iter.Read;
		
		excelApp.Cells[rowIndex, 5] = iter.CacheHit;
		
		excelApp.Cells[rowIndex, 6] = iter.Maximum;
		
		excelApp.Cells[rowIndex, 7] = iter.Percentage;
		
		excelApp.Cells[rowIndex, 8] = iter.IOs;
	
		excelApp.Cells[rowIndex, 9] = iter.KBsecond;
	

		
		
	}
	excelApp.Visible = true;
		}
		
	}
		
		public Type CustomSelector(MultiRecordEngine engine, string record)
        {    char d ='D';
			 char c ='C';
			 char l ='L';
			 char s= 'S';
			 Trace.WriteLine(record);
			 if(record.Length==0)
			 	return typeof (junk);
			 else if(record.Length<22)
			 		return typeof (junk);
			else if (Char.Equals(record[0],d))
                return typeof(IterationDate);
			else if (Char.Equals(record[0],c))
				return typeof(SanController);
                else if (Char.Equals(record[0],s))
				return typeof(Summary);
                else if(Char.Equals(record[0],l))
                return typeof(Subrecords);
                else
                	return typeof(junk);
        }
		[ConditionalRecord(RecordCondition.IncludeIfBegins, "testdata")]
		[IgnoreEmptyLines]
		[DelimitedRecord(":")]
				public class junk
		{
			public string trash;
		}
					
		[DelimitedRecord(",")]
		public class Iteration
		{
			public string  date;
		public string StorageSubsystems,Total,Read,CacheHit,Current,Maximum,IOs,Percentage,KBsecond;
		}
		[IgnoreEmptyLines]
		[ConditionalRecord(RecordCondition.IncludeIfBegins, "Date")]
[DelimitedRecord(":")]
public sealed class IterationDate
{

public String name;
	 public string Date;




}
[IgnoreEmptyLines]		
[ConditionalRecord(RecordCondition.IncludeIfBegins, "Capture")]
[DelimitedRecord(":")]
public sealed class CaptIteration
{

public String name;
	 public string iteration;




}

	[IgnoreEmptyLines]		
[ConditionalRecord(RecordCondition.IncludeIfBegins, "STORAGE ")]
		[DelimitedRecord(",")]
	public class Summary
	{
		public string StorageSubsystems,Total,Read,CacheHit,Current,Maximum,IOs,Percentage,KBsecond;
		
	}
		


	
[IgnoreEmptyLines]		
[ConditionalRecord(RecordCondition.IncludeIfBegins, "CONTROLLER ")]
		[DelimitedRecord(",")]
	public class SanController
	{
		public string StorageSubsystems,Total,Read,CacheHit,Current,Maximum,IOs,Percentage,KBsecond;
		
		
		


	}
	
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
}
	[IgnoreEmptyLines]	
	[ConditionalRecord(RecordCondition.IncludeIfBegins, "Logical")]
		[DelimitedRecord(",")]
	public class Subrecords
	{
		public string StorageSubsystems,Total,Read,CacheHit,Current,Maximum,IOs,Percentage,KBsecond;
		
		
		


	}
	
	  
	