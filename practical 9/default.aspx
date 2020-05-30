<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            height: 23px;
            width: 493px;
        }
        .auto-style3
        {
            width: 493px;
        }
    </style>
</head>
<body>
    <div><h1>CLICK THE BELOW GIVEN BUTTON TO INCREASE/DECREASE FONT SIZE</h1></div>
    <form id="form1" runat="server" >
   
           
    
    <table>
            <tbody>
                
                <tr>
                    <td class="auto-style1">

                        <asp:Label ID="Label1" runat="server" Text="WELCOME TO OUR WEBSITE" font-size="10" ></asp:Label>

                    </td>
                </tr>


                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button2" runat="server" Text="++" Width="193px" onclick="Button2_Click"/>
                        <asp:Button ID="Button3" runat="server" Text="--" Width="188px" style="margin-left: 28px" Onclick="Button3_Click" />
                    </td>
                    
                </tr>

                
                
            
        </tbody></table>
    
    
        
    
    
    </form>
</body>
</html>
