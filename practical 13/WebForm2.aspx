<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="practical_13.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td colspan="2">Your Details:</td>
            </tr>
            
            <tr>
                <td> Name:</td>
                <td> <asp:TextBox ID="name" runat="server"></asp:TextBox> </td>
            </tr>

            <tr>
                <td> Mobile:</td>
                <td> <asp:TextBox ID="mobileNo" runat="server"></asp:TextBox> </td>
            </tr>
            
        </table>
    
    </div>
    </form>
</body>
</html>
