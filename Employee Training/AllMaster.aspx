<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="AllMaster.aspx.cs" Inherits="Employee_Training.AllMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        font-size: x-large;
        font-weight: 700;
        text-decoration: underline;
        text-align: left;
    }
        .auto-style4 {
            text-align: center;
            height: 31px;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="8" class="auto-style2"></td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center">
                <asp:Label ID="Lblmessage" runat="server" style="text-align: center; font-weight: 700; font-size: x-large; color: #009900" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2" style="font-weight: 700; text-decoration: underline; font-size: x-large; text-align: left">ADD DEPARTMENT</td>
            <td colspan="2" style="font-size: x-large; font-weight: 700; text-decoration: underline; " class="auto-style7">ADD LOCATION</td>
            <td colspan="2" style="font-weight: 700; text-decoration: underline; text-align: left; font-size: x-large">ADD EDUCATION</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Department</td>
            <td>
                <asp:TextBox ID="txtDep" runat="server" Width ="200px" CssClass="textbox" OnTextChanged="txtDep_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>Location</td>
            <td>
                <asp:TextBox ID="txtLoc" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtLoc_TextChanged"></asp:TextBox>
            </td>
            <td>Education</td>
            <td>
                <asp:TextBox ID="txtEdu" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtEdu_TextChanged"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="drpDepStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                     <asp:ListItem  Value="1">Active</asp:ListItem>
                     <asp:ListItem  Value="2">Deactive</asp:ListItem>
                 
                </asp:DropDownList>
            </td>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="drpLocStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                     <asp:ListItem  Value="1">Active</asp:ListItem>
                     <asp:ListItem  Value="2">Deactive</asp:ListItem>
                 
                </asp:DropDownList>
            </td>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="drpEduStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                     <asp:ListItem  Value="1">Active</asp:ListItem>
                     <asp:ListItem  Value="2">Deactive</asp:ListItem>
                 
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnDepSave" CssClass="button" runat="server" Text="Save" OnClick="btnDepSave_Click" />
                <asp:Button ID="btnDepUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnDepUpdate_Click"  ValidationGroup="button"/>
                </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnLocSave" CssClass="button" runat="server" Text="Save" OnClick="btnLocSave_Click" />
                <asp:Button ID="btnLocUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnLocUpdate_Click"  ValidationGroup="button"/>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnEduSave" CssClass="button" runat="server" Text="Save" OnClick="btnEduSave_Click" />
                <asp:Button ID="btnEduUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnEduUpdate_Click"  ValidationGroup="button"/>
            </td>
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
        <tr>
            <td>&nbsp;</td>
            <td colspan="2" style="font-size: x-large; font-weight: 700; text-decoration: underline; text-align: left">ADD PROJECT</td>
            <td colspan="2" style="font-weight: 700; text-decoration: underline; font-size: x-large" class="auto-style7">ADD CONTRACT</td>
            <td colspan="2" style="font-weight: 700; text-align: left; text-decoration: underline; font-size: x-large"></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style8" colspan="2" style="font-size: x-large; font-weight: 700; text-decoration: underline; text-align: center"></td>
            <td colspan="2" style="font-weight: 700; text-decoration: underline; font-size: x-large" class="auto-style4"></td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Project</td>
            <td>
                <asp:TextBox ID="txtProject" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtProject_TextChanged"></asp:TextBox>
            </td>
            <td>Contract</td>
            <td>
                <asp:TextBox ID="txtContract" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtContract_TextChanged" ></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="drpProStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                     <asp:ListItem  Value="1">Active</asp:ListItem>
                     <asp:ListItem  Value="2">Deactive</asp:ListItem>
                 
                </asp:DropDownList>
            </td>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="drpContract" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                     <asp:ListItem  Value="1">Active</asp:ListItem>
                     <asp:ListItem  Value="2">Deactive</asp:ListItem>
                 
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnProjectSave" CssClass="button" runat="server" Text="Save" OnClick="btnProjectSave_Click" />
                <asp:Button ID="btnProUpdate" CssClass="button1" runat="server" Text="Update" OnClick="btnProUpdate_Click"  ValidationGroup="button"/>
             </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnContractSave" CssClass="button" runat="server" Text="Save" OnClick="btnContractSave_Click"  />
                <asp:Button ID="btncontractUpdate" CssClass="button1" runat="server" Text="Update"  ValidationGroup="button" OnClick="btncontractUpdate_Click"/>
                </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
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
                &nbsp;</td>
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
                &nbsp;</td>
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
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Designation</td>
            <td>
                <asp:TextBox ID="txtDes" runat="server" Width ="200px" CssClass="textbox" AutoPostBack="True" OnTextChanged="txtDes_TextChanged"></asp:TextBox>
            </td>
            <td>Grade</td>
            <td>
                <asp:TextBox ID="txtGrade" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
            </td>
            <td>Type</td>
            <td>
                <asp:DropDownList ID="drpType" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                   
                 
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="drpCommonStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                  
                     <asp:ListItem  Value="1">Active</asp:ListItem>
                     <asp:ListItem  Value="2">Deactive</asp:ListItem>
                 
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
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
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnCommonSave" CssClass="button" runat="server" Text="Save" OnClick="btnCommonSave_Click" />
                <asp:Button ID="btnCommonUpdate" CssClass="button1" runat="server" Text="Update"   ValidationGroup="button" OnClick="btnCommonUpdate_Click"/>
             </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
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
                &nbsp;</td>
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
                &nbsp;</td>
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
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        </table>
</asp:Content>
