<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThreeWay.aspx.cs" Inherits="MyWebSite.Weekly.Week1.ThreeWay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btn1" runat="server" Text="Switch 1" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="Switch 2" OnClick="btn2_Click" />
    
    </div>
        <div>
            <asp:Label ID="lblLight" runat="server" Text="Off"></asp:Label>
        </div>
    </form>
</body>
</html>
