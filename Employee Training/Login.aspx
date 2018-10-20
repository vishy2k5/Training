<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Employee_Training.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
.textbox { 
    border: 1px solid #c4c4c4; 
    height: 25px; 
    width: 275px; 
    font-size: 13px; 
    padding: 4px 4px 4px 4px; 
    border-radius: 4px; 
    -moz-border-radius: 4px; 
    -webkit-border-radius: 4px; 
    box-shadow: 0px 0px 8px #d9d9d9; 
    -moz-box-shadow: 0px 0px 8px #d9d9d9; 
    -webkit-box-shadow: 0px 0px 8px #d9d9d9; 
} 

 
        .auto-style3 {
            height: 23px;
            font-size: xx-large;
            color: #FFFFFF;
        }
        .auto-style5 {
            font-size: xx-large;
            color: #FFFFFF;
        }

 
        .auto-style6 {
            font-size: xx-large;
            color: #FFFFFF;
            text-align: right;
        }

 
    </style>
</head>

  <%--  <body id="image">--%>
<body style="background-image: url(Image/123.jpg); background-size:cover;background-origin:content-box;background-repeat:no-repeat">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="2" style="text-align: left; font-weight: 700; font-size: xx-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="width:200px"></td>
                <td class="auto-style6"><strong style="text-align: right">User Name</strong></td>
                <td class="auto-style2">
                <asp:TextBox ID="txtUserName" runat="server" Width ="300px" CssClass="textbox"></asp:TextBox>
                </td>
                <td class="auto-style2" style="width:200px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style6"><strong style="text-align: left">Password</strong></td>
                <td>
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width ="300px" CssClass="textbox" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style6"><strong>Role</strong></td>
                <td>
                <asp:DropDownList ID="drpRole" runat="server" Width="310px"  Height="35px" CssClass="textbox">
                </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                 <asp:ImageButton src="image/Login.jpg" width="200px" height="50px" ID="ImageButton1" runat="server" OnClick="Login_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblerrormsg" runat="server" style="color: #FF3300; font-weight: 700; font-size: x-large"></asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
