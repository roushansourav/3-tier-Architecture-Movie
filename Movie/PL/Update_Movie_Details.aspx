<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Movie_Details.aspx.cs" Inherits="Movie.PL.Update_Movie_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Enter Movie Id To Update:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Movie Name:" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Enter Movie duration:" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Enter Movie Director:" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
        </p>
        <asp:Button ID="Button2" runat="server" Text="Update" Visible="False" Width="95px" />
    </form>
</body>
</html>
