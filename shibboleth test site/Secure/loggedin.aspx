<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loggedin.aspx.cs" Inherits="Secure_loggedin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTTP Server Variables</title>
</head>
<body BGCOLOR=#FFFFFF>
    <form id="form1" runat="server">
    <div>
    <BR> <H2 align="center">Shibboleth Test Page</H2> 
        <BR>
        <BR>
         <I>Authenticated User Information </I>
        (information received from your IdP, if any, will be populated below):<BR><BR>
         <TABLE> 
             <TR>
                 <TD><B>First name:</B></TD>
                 <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_GIVENNAME")%>"></TD>

             </TR>
              <TR>
                  <TD><B>Last name:</B></TD>
                  <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_SN")%>"></TD>

              </TR> <TR><TD><B>Email address:</B></TD>
                  <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_MAIL")%>"></TD>

                    </TR>
              <TR>
                  <TD><B>eduPersonPrincipalName:</B></TD>
                  <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_EPPN")%>"></TD>

              </TR> 
             <TR>
                 <TD><B>REMOTE_USER:</B></TD>
                 <TD><INPUT type="text" value="<%=Request.ServerVariables("HTTP_REMOTEUSER")%>"></TD>

             </TR>

         </TABLE>
         <BR>
        <BR>
        <BR>
         <HR> <H2>Raw HTTP Server Variables</H2> 
        <TABLE BORDER=1> 
            <TR>
                <TD VALIGN=TOP><B>Variable</B></TD>
                <TD VALIGN=TOP><B>Value</B></TD>

            </TR> <% For Each key in Request.ServerVariables %> <%If Trim(key) <> "HTTP_SHIBSPOOFCHECK" Then%> 
            <TR> <TD><% = key %></TD>
                <TD> <% if Request.ServerVariables(key) = "" Then Response.Write "&nbsp" ' To force border around table cell else Response.Write Request.ServerVariables(key) end if Response.Write "</TD>" %> </TR>
             <%End IF Next %>

        </TABLE>


    </div>
    </form>
</body>
</html>
