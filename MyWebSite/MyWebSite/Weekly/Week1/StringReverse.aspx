<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StringReverse.aspx.cs" Inherits="MyWebSite.Weekly.Week1.StringReverse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblInput" runat="server" Text="Input :"></asp:Label>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    
    </div>
        <div>

            <asp:Label ID="lblForAnswer" runat="server" Text="Your answer is :" ></asp:Label>

            <asp:Label ID="lblAnswer" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
