<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="JobCardMaster.aspx.cs" Inherits="Employee_Training.JobCardMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">

    <table class="auto-style1">
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center; font-weight: 700; text-decoration: underline; font-size: x-large">JOB CARD MASTER DETAILS</td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center">
            <asp:Label ID="Lblmessage" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#009933"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center" class="auto-style2">
                <asp:ValidationSummary ID="ValidationSummary1" DisplayMode="List "  runat="server"  HeaderText="You Must Enter The Following Fields" ValidationGroup="button" style="color: #FF3300; font-weight: 700;" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Code<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="txtCode" EnableClientScript="true" 
                                ErrorMessage="please Enter Code" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtCode" runat="server" CssClass="textbox" Width="200px" AutoPostBack="True" OnTextChanged="txtCode_TextChanged"></asp:TextBox>
            </td>
            <td>*Station Name<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="txtStationName" EnableClientScript="true" 
                                ErrorMessage="please Enter Station" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtStationName" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
            </td>
            <td>*Project Name<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="txtProject" EnableClientScript="true" 
                                ErrorMessage="please Enter Project" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtProject" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2">*Station Status<asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ValidationGroup="button" ControlToValidate="drpStationStatus" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please select  Station Status" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                 <asp:DropDownList ID="drpStationStatus" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                    <asp:ListItem>---Select---</asp:ListItem>
                    <asp:ListItem>Critical</asp:ListItem>
                    <asp:ListItem>Non Critical</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style2">*Score <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                ControlToValidate="txtScore" EnableClientScript="true" 
                                ErrorMessage="please Enter Score" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtScore" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style2">*Location<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                ControlToValidate="txtLocation" EnableClientScript="true" 
                                ErrorMessage="please Enter Location" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtLocation" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Working Status<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ValidationGroup="button" ControlToValidate="drpstatus" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please select  Status" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:DropDownList ID="drpstatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                   <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Active</asp:ListItem>
                     <asp:ListItem>DeActive</asp:ListItem>
                     
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSave" CssClass="button" runat="server" Text="Submit" OnClick="btnSave_Click"  ValidationGroup="button"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
