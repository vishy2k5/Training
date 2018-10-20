<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="TrainingDetails.aspx.cs" Inherits="Employee_Training.Training_Details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
        .auto-style3 {
            color: #800000;
        }
    </style>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <table class="auto-style1">
        <tr>
            <td colspan="6" style="text-align: center; font-weight: 700; text-decoration: underline; font-size: x-large">DL &amp; IDL TRAINING DETAILS</td>
        </tr>
        <tr>
            <td colspan="6" style="text-align: center">
                <asp:Label ID="Lblmessage" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#009933"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6" style="text-align: center">
                <asp:ValidationSummary ID="ValidationSummary1" DisplayMode="List "  runat="server"  HeaderText="You Must Enter The Following Fields" ValidationGroup="button" style="color: #FF3300; font-weight: 700;" />
            </td>
        </tr>
        <tr>
            <td colspan="6" style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td>Emp Code</td>
            <td>
                <asp:TextBox ID="txtEmpcode" runat="server" Width ="200px" CssClass="textbox" OnTextChanged="txtEmpcode_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>Emp Name</td>
            <td>
                <asp:TextBox ID="txtEmpName" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
            <td>Emp Type</td>
            <td>
                <asp:TextBox ID="txtType" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>*Training Topics<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="txtTopic" EnableClientScript="true" 
                                ErrorMessage="please Enter Topics" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtTopic" runat="server" Width ="200px" CssClass="textbox" ></asp:TextBox>
            </td>
            <td>*Start Date<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="txtStartDate" EnableClientScript="true" 
                                ErrorMessage="please Select StartDate" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtStartDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
                   <asp:Image ID="Image1" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate" PopupButtonID="Image1" runat="server">
        </asp:CalendarExtender>
            </td>
            <td>*End Date<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="txtEnddate" EnableClientScript="true" 
                                ErrorMessage="please select EndDate" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtEnddate" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEnddate_TextChanged"></asp:TextBox>
                       <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="txtEndDate" PopupButtonID="Image2" runat="server">
        </asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Total Days</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtTotaldays" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style2">*Trainer<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                ControlToValidate="txtTrainer" EnableClientScript="true" 
                                ErrorMessage="please Enter Trainer" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtTrainer" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
            </td>
            <td class="auto-style2">*Venue<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                ControlToValidate="txtVenu" EnableClientScript="true" 
                                ErrorMessage="please Enter Venue" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtVenu" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>*Score <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                ControlToValidate="txtScore" EnableClientScript="true" 
                                ErrorMessage="please Enter Score" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtScore" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtScore_TextChanged"></asp:TextBox>
            </td>
            <td>Training Status<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="button" ControlToValidate="drpStatus" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please select Training Status" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
            <td>
                <%--<asp:DropDownList ID="drpStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                    <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Pass</asp:ListItem>
                     <asp:ListItem>Fail</asp:ListItem>
                         <asp:ListItem>Unallocated</asp:ListItem>
                     </asp:DropDownList>--%>
                <asp:TextBox ID="drpStatus" runat="server" Width="200px" CssClass="textbox"></asp:TextBox>
                               

            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="3"><strong>* Field Should be Filled Mandatory</strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" ValidationGroup="button" CssClass="button" />
                <asp:Button ID="btnUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
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
        </tr>
    </table>

</asp:Content>
