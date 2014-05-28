/*
 * Created by SharpDevelop.
 * User: balld
 * Date: 13/01/2012
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CASAuthentication_v0_1;
using System.Xml;
using AuthenticationTest4.CASEndPoint;


namespace AuthenticationTest4
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
		private XmlElement CASAuthentication(string Guid)
		{ //CASAuthentication_v0_1.CASAuthenticationRequestType myAuthentication = new CASAuthentication_v0_1.CASAuthenticationRequestType.MemberElement_BoSGUID();
			CASAuthentication_v0_1.CASAuthentication_v0_12 doc = CASAuthentication_v0_1.CASAuthentication_v0_12.CreateDocument();
			CASAuthentication_v0_1.CASAuthenticationRequestType root =  doc.CASAuthenticationRequest.Append();
			CASAuthentication_v0_1.core0.BoSGUIDTypeType GUID= root.BoSGUID.Append();
			GUID.Value=Guid;
			 doc.SaveToFile("CASAuthentication_v0_11.xml", true);
			 XmlElement myelement = doc.CASAuthenticationRequest.First.Node as XmlElement;
       
       
return myelement;
			
			
			
		}
		void CASAuthenticationWSEBtnClick(object sender, EventArgs e)
		{
			AuthenticationTest4.CASEndPoint.CASEndpointBean myWseEndpoint = new CASEndpointBean();
			
			CitizenAccountRequestMessage  myRequest =  new CitizenAccountRequestMessage();
			myRequest.CASRequestData = new CitizenAccountRequestType();
			myRequest.CASRequestData.Header= new CitizenAccountRequestHeaderType();
		
			myRequest.CASRequestData.Header.CorrelationID= Guid.NewGuid().ToString();
			myRequest.CASRequestData.Header.UserID="Stirling";
			myRequest.CASRequestData.Header.Timestamp= DateTime.Now;
			myRequest.CASRequestData.Header.PartnerID="30";
			myRequest.CASRequestData.Any= CASAuthentication(GUIDtxt.Text);
			CitizenAccountResponseMessage MyResponse = new CitizenAccountResponseMessage();
			XmlDocument requestDoc = new XmlDocument(); 
			
			//MessageBox.Show(myRequest.CASRequestData.Any.OuterXml);
		    MessageBox.Show("send  request");
		   
		    MyResponse =myWseEndpoint.sendCitizenAccountMessage(myRequest);
		    MessageBox.Show(MyResponse.CASResponseData.Any.OuterXml);
		}
	}
}
