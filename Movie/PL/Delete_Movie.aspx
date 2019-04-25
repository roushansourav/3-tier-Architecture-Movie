<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_Movie.aspx.cs" Inherits="Movie.PL.Delete_Movie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 360px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Movie Id:
            <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        </div>
        <div class="auto-style1">
        </div>
    </form>
</body>
</html>
