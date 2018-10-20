<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="DLInduction.aspx.cs" Inherits="Employee_Training.DLInduction" %>
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
        <td colspan="6" style="text-align: center; font-weight: 700; text-decoration: underline; font-size: x-large">DL EMPLOYEE INDUCTION DETAILS</td>
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
                <asp:TextBox ID="txtEmpcode" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEmpcode_TextChanged"></asp:TextBox>
            </td>
        <td>*Name<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="txtEmpName" EnableClientScript="true" 
                                ErrorMessage="please Enter EmpName In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtEmpName" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Gender<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="txtGender" EnableClientScript="true" 
                                ErrorMessage="please Enter Gender In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtGender" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>*Department<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="txtDep" EnableClientScript="true" 
                                ErrorMessage="please Enter Department In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtDep" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Project<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                ControlToValidate="txtProj" EnableClientScript="true" 
                                ErrorMessage="please Enter Prject In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtProj" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Shift<asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                                ControlToValidate="txtShift" EnableClientScript="true" 
                                ErrorMessage="please Enter Shift" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtShift" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>*Type<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                ControlToValidate="txtType" EnableClientScript="true" 
                                ErrorMessage="please Enter Type In Master Screen" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
                <asp:TextBox ID="txtType" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>Topics
                        </td>
        <td>
                <asp:TextBox ID="txtTopics" runat="server" Width ="200px" Text="Induction" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>*Trainer<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                ControlToValidate="txtTrainer" EnableClientScript="true" 
                                ErrorMessage="please Enter Trainer" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td>
        
                <asp:TextBox ID="txtTrainer" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td class="auto-style2">*From Date<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                ControlToValidate="txtStartDate" EnableClientScript="true" 
                                ErrorMessage="please Enter StartDate" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtStartDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
                                        <asp:Image ID="Image1" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
              <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate" PopupButtonID="Image1" runat="server">
        </asp:CalendarExtender>

            </td>
        <td class="auto-style2">*End Date<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                                ControlToValidate="txtEndDate" EnableClientScript="true" 
                                ErrorMessage="please Enter EndDate" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtEndDate" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEndDate_TextChanged"></asp:TextBox>
                                        <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="txtEndDate" PopupButtonID="Image2" runat="server">
        </asp:CalendarExtender>
            </td>
        <td class="auto-style2">Total Days</td>
        <td class="auto-style2">
                <asp:TextBox ID="txtTotalDays" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>Score</td>
        <td>
                <asp:TextBox ID="txtScore" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtScore_TextChanged" Text="0"></asp:TextBox>
            </td>
        <td>*Training Status<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ValidationGroup="button" ControlToValidate="drpTraStatus" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please select Training Status" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
        <td>
               <%-- <asp:DropDownList ID="drpTraStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                    <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Pass</asp:ListItem>
                     <asp:ListItem>Fail</asp:ListItem>
                       <asp:ListItem>Unallocated</asp:ListItem>
                </asp:DropDownList>--%>

                            <asp:TextBox ID="drpTraStatus" runat="server" Width ="200px" CssClass="textbox" ReadOnly="True"></asp:TextBox>

            </td>
        <td>Hand Over Date</td>
        <td>
                <asp:TextBox ID="txtHandOverDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
                                        <asp:Image ID="Image3" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender3" TargetControlID="txtHandOverDate" PopupButtonID="Image3" runat="server">
        </asp:CalendarExtender>
            </td>
    </tr>
    <tr>
        <td>Hand Over Status</td>
        <td>
                <asp:DropDownList ID="drpHandoverStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox" AutoPostBack="True" OnSelectedIndexChanged="drpHandoverStatus_SelectedIndexChanged">
                       <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Present</asp:ListItem>
                     <asp:ListItem>Absent</asp:ListItem>
                </asp:DropDownList>
            </td>
        <td>Reporting Manager Name</td>
        <td>
                <asp:TextBox ID="txtRepName" runat="server" Width ="200px"  CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
        <td>Reporting Manager Email</td>
        <td>
                <asp:TextBox ID="txtRepEmail" runat="server" Width ="200px"  CssClass="textbox" ReadOnly="True"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td class="auto-style3" colspan="3"><strong>* Field Should be Filled Mandatory</strong></td>
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
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td colspan="2">
            <asp:Button ID="BtnSave" CssClass="button" runat="server" Text="Submit" OnClick="BtnSave_Click"  ValidationGroup="button" />
            <asp:Button ID="BtnUpdate" CssClass="button1" runat="server" Text="Update" OnClick="BtnUpdate_Click"  />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="6"></td>
    </tr>
    <tr>
        <td colspan="6">&nbsp;</td>
    </tr>
</table>

</asp:Content>
