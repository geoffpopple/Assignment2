<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZodiacFinder.aspx.cs" Inherits="Client.ZodiacFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>

        Task 1 &amp; 2 Zodiac Finder<br/>
        <br/>
        Find Date By Name<br/>

        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GetDate"/>&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;<br/>
        <br/>
        Find Name By Date<br/>
        <asp:Label ID="Label2" runat="server" Text="Mon"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label3" runat="server" Text="Day"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GetName"/>
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br/>

    </div>
</form>
</body>
</html>