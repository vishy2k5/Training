<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="JobCardMasterRep.aspx.cs" Inherits="Employee_Training.JobCardMasterRep" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">


    <table class="auto-style1">
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Code</td>
            <td>
                <asp:TextBox ID="txtCode" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
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
            <td>
                <asp:Button ID="btnOverAll" runat="server" Text="Search" CssClass="button" OnClick="btnOverAll_Click" />
                <asp:Button ID="btnExcel"  CssClass="button2" runat="server" Text="Excel" OnClick="btnExcel_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
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
 
                                           <asp:BoundField DataField="Code" HeaderText="Code" />
                                           <asp:BoundField DataField="StationName" HeaderText="StationName" />
                                           <asp:BoundField DataField="ProjectName" HeaderText="ProjectName"/>
                                           <asp:BoundField DataField="Status" HeaderText="Status"/>
                                           <asp:BoundField DataField="Score" HeaderText="Score" />
                                           <asp:BoundField DataField="Location" HeaderText="Location" />
                                           <asp:BoundField DataField="WorkingStatus" HeaderText="WorkingStatus" />
                                           <asp:BoundField DataField="Createdby" HeaderText="Createdby" />
                                           
                                          </Columns>
                </asp:GridView>
            </td>
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
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
    </table>


</asp:Content>
