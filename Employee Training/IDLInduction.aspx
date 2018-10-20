<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="IDLInduction.aspx.cs" Inherits="Employee_Training.IDLInduction" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 24px;
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
        <td colspan="6" style="text-align: center; font-weight: 700; text-decoration: underline; font-size: x-large">IDL EMPLOYEE INDUCTION DETAILS</td>
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
        <td class="auto-style2">Emp Code</td>
        <td class="auto-style2">
                <asp:TextBox ID="txtEmpcode" runat="server" Width ="200px" CssClass="textbox" OnTextChanged="txtEmpcode_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
        <td class="auto-style2">Emp Name</td>
        <td class="auto-style2">
                <asp:TextBox ID="txtEmpName" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
        <td class="auto-style2">*DOJ<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="txtDOJ" EnableClientScript="true" 
                                ErrorMessage="please Enter DOJ In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtDOJ" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>Departmet</td>
        <td>
                <asp:TextBox ID="txtDep" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Grade<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                ControlToValidate="txtGrade" EnableClientScript="true" 
                                ErrorMessage="please Enter Grade In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtGrade" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Designation<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                ControlToValidate="txtDes" EnableClientScript="true" 
                                ErrorMessage="please Enter Designation In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtDes" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>Reporting Manager Name</td>
        <td>
                <asp:TextBox ID="txtRepName" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
        <td>Reporting Manager Email</td>
        <td>
                <asp:TextBox ID="txtRepEmail" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
            </td>
        <td>Phone No</td>
        <td>
                <asp:TextBox ID="txtPhone" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>User Id</td>
        <td>
                <asp:TextBox ID="txtUserName" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Start Date<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                ControlToValidate="txtStartDate" EnableClientScript="true" 
                                ErrorMessage="please EnterStartDate" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtStartDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
                    <asp:Image ID="Image1" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate" PopupButtonID="Image1" runat="server">
        </asp:CalendarExtender>
            </td>
        <td>*End Date<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                ControlToValidate="txtEndDate" EnableClientScript="true" 
                                ErrorMessage="please select EndDate" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtEndDate" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEndDate_TextChanged"></asp:TextBox>
                                      <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="txtEndDate" PopupButtonID="Image2" runat="server">
        </asp:CalendarExtender>
            </td>
    </tr>
    <tr>
        <td>Total Days</td>
        <td>
                <asp:TextBox ID="txttotal" runat="server"  Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Form Distribution<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ValidationGroup="button" ControlToValidate="drpForm" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please select Form Distribution" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:DropDownList ID="drpForm" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                    <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Template Given</asp:ListItem>
                     <asp:ListItem>Trainee Not Given</asp:ListItem>
                         <asp:ListItem>Employee Returned</asp:ListItem>
                     <asp:ListItem>Employee Not Returned</asp:ListItem>
                </asp:DropDownList>
            </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3" colspan="3"><strong>* Field Should be Filled Mandatory</strong></td>
        <td>
                &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
                &nbsp;</td>
        <td>&nbsp;</td>
        <td>
                &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnSave" CssClass="button" runat="server" Text="Submit" OnClick="btnSave_Click"   ValidationGroup="button"/>
            <asp:Button ID="btnUpdate" runat="server" CssClass="button1" OnClick="btnUpdate_Click" Text="Update"  ValidationGroup="button"/>
        </td>
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
    <tr>
        <td colspan="6">&nbsp;</td>
    </tr>
</table>

</asp:Content>
