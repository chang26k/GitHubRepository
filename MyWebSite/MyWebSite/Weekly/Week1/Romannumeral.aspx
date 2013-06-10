<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Romannumeral.aspx.cs" Inherits="MyWebSite.Weekly.Week1.Romannumeral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
            <asp:Label ID="lbl" runat="server" Text="Input Number :"></asp:Label>
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
        <div>
            <asp:Label ID="lblAnswer" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
