<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieInsert.aspx.cs" Inherits="Movie.PL.MovieInsert" %>

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
            <table>
                <tr><td>Movie Id:</td>
                <td><asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Movie Name:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Duration:</td>
                    <td><asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Director:</td>
                    <td><asp:TextBox ID="TextBox4" runat="server" Width="250px"></asp:TextBox></td>
                </tr>
            </table>
            
        </div>
        
        
            <div class="auto-style1">
                <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" Width="96px" />
        </div>
        
    </form>
</body>
</html>
