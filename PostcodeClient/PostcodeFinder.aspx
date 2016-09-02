<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostcodeFinder.aspx.cs" Inherits="PostcodeClient.PostcodeFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Task 3:Postcode Finder<br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <asp:Button ID="btnShowPostcode" runat="server" OnClick="btnShowPostcode_Click" Text="Show Postcode" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
        <asp:Label ID="lblDTNow" runat="server"></asp:Label>
    </form>
</body>
</html>
