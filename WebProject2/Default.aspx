<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebProject2._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lblhello" runat="server"></asp:Label>
            <asp:TextBox ID="txthello" runat="server"></asp:TextBox>
            <asp:Button ID="btnLabel" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
