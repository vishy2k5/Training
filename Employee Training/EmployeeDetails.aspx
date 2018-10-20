<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Employee_Training.EmployeeDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
 
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            height: 23px;
            width: 20px;
        }
        .auto-style4 {
        }
        .auto-style5 {
            height: 20px;
            color: #FF3300;
        }
        .auto-style7 {
            color: #990000;
        }
    </style>
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>


    <table class="auto-style1">
        <tr>
            <td colspan="7" style="text-align: center; font-weight: 700; font-size: x-large; text-decoration: underline">EMPOLYEE MASTER DETAILS</td>
        </tr>
        <tr>
            <td colspan="7" style="text-align: center">
                <asp:Label ID="Lblmessage" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="#009933"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" DisplayMode="List "  runat="server"  HeaderText="You Must Enter The Following Fields" ValidationGroup="button" style="color: #FF3300; font-weight: 700;" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="width:100px">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style2" rowspan="2">*Emp Name<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="txtEmpName" EnableClientScript="true" 
                                ErrorMessage="please Enter EmpName" Text="**" 
                    ValidationGroup="button" style="color: #FF0000"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style3" style="width:80px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="width:100px">&nbsp;</td>
            <td class="auto-style2">*Empcode<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="txtEmpcode" EnableClientScript="true" 
                                ErrorMessage="please Enter Empcode" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td class="auto-style2">
                <asp:TextBox ID="txtEmpcode" runat="server" Width ="200px"  CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEmpcode_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style2">Old No</td>
            <td class="auto-style3" style="width:20%">
                <asp:TextBox ID="txtOldNo" runat="server" Width="200px"  CssClass="textbox" AutoPostBack="True" OnTextChanged="txtOldNo_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style3" style="width:0px">
                <asp:TextBox ID="txtEmpName" runat="server" Width="200px"  CssClass="textbox"></asp:TextBox>
<asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" FilterType="UppercaseLetters, LowercaseLetters"
    TargetControlID="txtEmpName" />

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Father Name<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                ControlToValidate="TxtFatherName" EnableClientScript="true" 
                                ErrorMessage="please Enter Father Name" Text="**" 
                    ValidationGroup="button" style="color: #FF0000"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="TxtFatherName" runat="server" Width="200px"  CssClass="textbox"></asp:TextBox>
<asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="UppercaseLetters, LowercaseLetters"
    TargetControlID="TxtFatherName" />
            </td>
            <td>*Department<asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ValidationGroup="button" ControlToValidate="drpDep" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Department" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td class="auto-style4">
                <asp:DropDownList ID="drpDep" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>*Project<asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ValidationGroup="button" ControlToValidate="drpProj" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Project" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td>
                <asp:DropDownList ID="drpProj" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Location
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ValidationGroup="button" ControlToValidate="drpLoc" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Location" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:DropDownList ID="drpLoc" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>*Designation<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ValidationGroup="button" ControlToValidate="drpDes" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Designation" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td class="auto-style4">
                <asp:DropDownList ID="drpDes" runat="server" Width="210px"  Height="35px" CssClass="textbox" AutoPostBack="True" OnSelectedIndexChanged="drpDes_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>*Employee Type<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ValidationGroup="button" ControlToValidate="drpType" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Type" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td>
                <asp:DropDownList ID="drpType" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*DOJ<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                ControlToValidate="txtDOJ" EnableClientScript="true" 
                                ErrorMessage="please Enter DOJ" Text="**" 
                    ValidationGroup="button" style="color: #FF3300"></asp:RequiredFieldValidator>
                        </td>
            <td>
                <asp:TextBox ID="txtDOJ" runat="server" Width="200px"  CssClass="textbox" ></asp:TextBox>
                   <asp:Image ID="Image1" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDOJ" PopupButtonID="Image1" runat="server"> </asp:CalendarExtender>
            </td>
            <td>DOR</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtDOR" runat="server" Width="180px"  CssClass="textbox"></asp:TextBox>
                                <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />
             <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="txtDOR" PopupButtonID="Image2" runat="server"> </asp:CalendarExtender>
            </td>
            <td>Gender</td>
            <td>
                <asp:RadioButton ID="radMale" runat="server" Text="Male" GroupName="a" />
                <asp:RadioButton ID="radFemale" runat="server" Text="Female" GroupName="a" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>*Grade<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ValidationGroup="button" ControlToValidate="drpGrade" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Grade" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td>
                <asp:DropDownList ID="drpGrade" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>Education</td>
            <td class="auto-style4">
                <asp:DropDownList ID="drpEducation" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>Phone</td> 
            <td>
                <asp:TextBox ID="txtphone" runat="server" Width="200px"  CssClass="textbox" MaxLength="10"></asp:TextBox>
               

                <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Numbers,Custom" ValidChars="+" 
   TargetControlID="txtphone" />

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server" Width="200px"  CssClass="textbox"></asp:TextBox>
<asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="UppercaseLetters, LowercaseLetters"
    TargetControlID="txtUserName" />
            </td>
            <td>User Email</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtUserEmail" runat="server" Width="200px"  CssClass="textbox"></asp:TextBox>
            </td>
            <td>Reporting&nbsp; Manager Name</td>
            <td>
                <asp:TextBox ID="txtRepName" runat="server" Width="200px"  CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Reporting&nbsp; Manager Email</td>
            <td>
                <asp:TextBox ID="txtRepEamil" runat="server" Width="200px" CssClass="textbox"></asp:TextBox>
            </td>
            <td>*Status<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="button" ControlToValidate="drpStatus" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Enter Status" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td class="auto-style4">
                <asp:DropDownList ID="drpStatus" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>Contract Type<asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ValidationGroup="button" ControlToValidate="drpContract" InitialValue="---Select---" Display="Dynamic"    ErrorMessage="please Select  Contract Name" Text="**" style="color: #FF3300" ></asp:RequiredFieldValidator>
                                    </td>
            <td>
                <asp:DropDownList ID="drpContract" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2" class="auto-style7">
                <strong>* Field Should be Filled Mandatory</strong></td>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style4" colspan="2">
                <asp:Button ID="btnsave" CssClass="button" runat="server" Text="Submit" OnClick="btnsave_Click" ValidationGroup="button" />
                <asp:Button ID="btnUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnUpdate_Click"  ValidationGroup="button"/>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">&nbsp;</td>
        </tr>
    </table>
      
</asp:Content>
