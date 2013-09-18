<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebLogin.WebLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example Login Screen</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-align: center">&gt;login_</h1>
        <center><asp:Login ID="Login1" runat="server" style="text-align: center" Width="363px" TitleText="" DestinationPageUrl="~/members/Members.aspx" MembershipProvider="MySqlMembershipProvider" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Login1" />
        </center>
    </form>
    </body>
</html>
