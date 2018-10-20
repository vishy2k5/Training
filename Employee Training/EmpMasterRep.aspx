<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="EmpMasterRep.aspx.cs" Inherits="Employee_Training.EmpMasterRep"  EnableEventValidation="false" %>
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
            <td colspan="8" style="font-weight: 700; text-decoration: underline; text-align: center; font-size: x-large">EMPOLYEE MASTER REPORT</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width:20%">&nbsp;</td>
            <td>EmpCode</td>
            <td>
                <asp:TextBox ID="txtempcode" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" Text="Empcode Search" CssClass="button" OnClick="btnsubmit_Click" />
            </td>
            <td style="width:38%">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>EmpType</td>
            <td>
                <asp:DropDownList ID="drpType" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnType" runat="server" Text="Type Search" CssClass="button"  OnClick="btnType_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2">Department</td>
            <td class="auto-style2">
                <asp:DropDownList ID="drpDep" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td class="auto-style2">
                <asp:Button ID="btnDep" runat="server" CssClass="button"  Text="Department Search" OnClick="btnDep_Click" />
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">Status</td>
            <td class="auto-style2">
                <asp:DropDownList ID="drpStatus" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList></td>
            <td class="auto-style2">
                <asp:Button ID="btnStatus" runat="server" CssClass="button"  Text="Status Search" OnClick="btnStatus_Click"/>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">ContractName</td>
            <td class="auto-style2">
                <asp:DropDownList ID="drpContract" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList></td>
            <td class="auto-style2">
                <asp:Button ID="btnContract" runat="server" CssClass="button"  Text="Contract Search" OnClick="btnContract_Click" />
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center">
                <asp:Button ID="btnExcel"  CssClass="button2" runat="server" Text="Excel" OnClick="btnExcel_Click" />
            </td>
        </tr>
        </table>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" >
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                     <Columns>
                                           <asp:BoundField DataField="Id" HeaderText="Id"  />
 
                                           <asp:BoundField DataField="Empcode" HeaderText="Empcode" />
                                           <asp:BoundField DataField="OldNo" HeaderText="OldNo" />
                                           <asp:BoundField DataField="Name" HeaderText="Name"/>
                                          <asp:BoundField DataField="EmpType" HeaderText="Type"/>
                                           <asp:BoundField DataField="ContractName" HeaderText="ContractName" />
                                           <asp:BoundField DataField="FatherName" HeaderText="FatherName"/>
                                           <asp:BoundField DataField="Dep" HeaderText="Department" />
                                           <asp:BoundField DataField="Project" HeaderText="Project" />
                                           <asp:BoundField DataField="Location" HeaderText="Location" />
                                           <asp:BoundField DataField="Designation" HeaderText="Designation" />
                                           <asp:BoundField DataField="DOJ" HeaderText="DOJ"   DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="DOR" HeaderText="DOR"   DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                           <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                           <asp:BoundField DataField="Education" HeaderText="Education"/>
                                           <asp:BoundField DataField="phone" HeaderText="phone"/>
                                           <asp:BoundField DataField="UserName" HeaderText="UserName" />    
                                           <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" />
                                           <asp:BoundField DataField="RepName" HeaderText="RepName" />
                                           <asp:BoundField DataField="RepEmail" HeaderText="RepEmail" />
                                           <asp:BoundField DataField="Createdby" HeaderText="Createdby" />
                                          </Columns>
                </asp:GridView>

</asp:Content>
