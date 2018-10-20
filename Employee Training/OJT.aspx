<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="OJT.aspx.cs" Inherits="Employee_Training.OJT" %>
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
            <td colspan="8" style="font-weight: 700; font-size: x-large; text-decoration: underline; text-align: center">OJT TRAINING DETAILS</td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center">
                <asp:ValidationSummary ID="ValidationSummary1" DisplayMode="List "  runat="server"  HeaderText="You Must Enter The Following Fields" ValidationGroup="button" style="color: #FF3300; font-weight: 700;" />
            </td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center">
            <asp:Label ID="Lblmessage" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#009933"></asp:Label>
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
            <td>*Empcode<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="txtEmpcode" EnableClientScript="true" 
                                ErrorMessage="please Enter EmpCode In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtEmpcode" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEmpcode_TextChanged"></asp:TextBox>
            </td>
            <td>*Code</td>
            <td>
                <asp:DropDownList ID="drpCode" runat="server" Width="210px"  Height="35px" CssClass="textbox" AutoPostBack="True" OnSelectedIndexChanged="drpCode_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>*Station Name<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                ControlToValidate="txtStationName" EnableClientScript="true" 
                                ErrorMessage="please Enter Station Name In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtStationName" runat="server" CssClass="textbox" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Type<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="txtType" EnableClientScript="true" 
                                ErrorMessage="please Enter Type In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtType" runat="server" CssClass="textbox" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>*Name<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="txtName" EnableClientScript="true" 
                                ErrorMessage="please Enter Name In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" CssClass="textbox" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>*Project<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                ControlToValidate="txtproject" EnableClientScript="true" 
                                ErrorMessage="please Enter Project In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtproject" runat="server" CssClass="textbox" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2">*Job Type<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                ControlToValidate="txtOJTType" EnableClientScript="true" 
                                ErrorMessage="please Enter OJT Type In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtOJTType" runat="server" CssClass="textbox" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style2">*StartDate<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                ControlToValidate="txtStartDate" EnableClientScript="true" 
                                ErrorMessage="please Enter Start Date" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtStartDate" runat="server" CssClass="textbox" Width="200px" ></asp:TextBox>
                                        <asp:Image ID="Image1" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
                 <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate" PopupButtonID="Image1" runat="server">
        </asp:CalendarExtender>
            </td>
            <td class="auto-style2">*End Date<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                ControlToValidate="txtEndDate" EnableClientScript="true" 
                                ErrorMessage="please Enter End Date" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtEndDate" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
                                        <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
                  <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="txtEndDate" PopupButtonID="Image2" runat="server">
        </asp:CalendarExtender>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Status<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ValidationGroup="button" ControlToValidate="drpstatus" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please select  Status" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:DropDownList ID="drpstatus" runat="server" Width="210px"  Height="35px" CssClass="textbox" AutoPostBack="True" OnSelectedIndexChanged="drpstatus_SelectedIndexChanged">
                  <asp:ListItem>Unallocated</asp:ListItem>
                     <asp:ListItem>Pass</asp:ListItem>
                     <asp:ListItem>Fail</asp:ListItem>
                     <asp:ListItem>DeCertified</asp:ListItem>
                     <asp:ListItem>JobClosed</asp:ListItem>
                    
                </asp:DropDownList>
            </td>
            <td>Failed Due Date</td>
            <td>
                <asp:TextBox ID="txtfaildate" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
                                        <asp:Image ID="Image3" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
                <asp:CalendarExtender ID="CalendarExtender3" TargetControlID="txtfaildate" PopupButtonID="Image3" runat="server">
        </asp:CalendarExtender>
            </td>
            <td>Station Status</td>
            <td>
                <asp:TextBox ID="txtStationStatus" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEmpcode_TextChanged" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Score</td>
            <td>
                <asp:TextBox ID="txtScore" runat="server" CssClass="textbox" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3" colspan="3"><strong>* Field Should be Filled Mandatory</strong></td>
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
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" ValidationGroup="button" CssClass="button" />
                <asp:Button ID="btnUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnUpdate_Click" />
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
            <td>
                <asp:HiddenField ID="HiddenField1" runat="server" />
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
    </table>


</asp:Content>
