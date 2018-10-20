<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="IDLRep.aspx.cs" Inherits="Employee_Training.IDLRep" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server">
        </asp:ScriptManager>

    <table class="auto-style1">
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8" style="font-weight: 700; font-size: x-large; text-decoration: underline; text-align: center">IDL EMPLOYEE INDUCTION REPORT</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">Empcode</td>
            <td class="auto-style1">
                <asp:TextBox ID="txEmpCode" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
           

            </td>
            <td class="auto-style1">
                </td>
            <td class="auto-style1">
                <asp:Button ID="btnEMPsearch" runat="server" CssClass="button" Text="Search" OnClick="btnEMPsearch_Click"/>
            </td>
            <td class="auto-style1">
                </td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>Form Distribution</td>
            <td>
                <asp:DropDownList ID="drpForm" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                    <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Template Given</asp:ListItem>
                     <asp:ListItem>Trainee Not Given</asp:ListItem>
                         <asp:ListItem>Employee Returned</asp:ListItem>
                     <asp:ListItem>Employee Not Returned</asp:ListItem>
                </asp:DropDownList></td>
            <td>
                Date</td>
            <td>
                <asp:TextBox ID="txtFormDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              <asp:CalendarExtender ID="CalendarExtender4" TargetControlID="txtFormDate" PopupButtonID="Image4" runat="server">
        </asp:CalendarExtender>

                                        <asp:Image ID="Image4" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />

            </td>
            <td>
                <asp:Button ID="btnFormSearch" CssClass="button" runat="server" Text="FormSearch" OnClick="btnFormSearch_Click"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>From </td>
            <td>
                <asp:TextBox ID="txtFromDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtFromDate" PopupButtonID="Image2" runat="server">
        </asp:CalendarExtender>

                                        <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />

            </td>
            <td>To</td>
            <td>
                <asp:TextBox ID="txtToDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              <asp:CalendarExtender ID="CalendarExtender" TargetControlID="txtToDate" PopupButtonID="Image3" runat="server">
        </asp:CalendarExtender>

                                        <asp:Image ID="Image3" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />

            </td>
            <td>
                <asp:Button ID="btnOverAll" CssClass="button" runat="server" Text="DateWiseReport" OnClick="btnOverAll_Click" />
            </td>
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
 
                                           <asp:BoundField DataField="Empcode" HeaderText="Empcode" />
                                           <asp:BoundField DataField="Name" HeaderText="Name" />
                                           <asp:BoundField DataField="DOJ" HeaderText="DOJ"  DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="Dep" HeaderText="Department"/>
                                           <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                           <asp:BoundField DataField="Designation" HeaderText="Designation" />
                                           <asp:BoundField DataField="RepName" HeaderText="RepName" />
                                           <asp:BoundField DataField="RepEmail" HeaderText="RepEmail" />
                                           <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                           <asp:BoundField DataField="UserId" HeaderText="UserId"  />
                                           <asp:BoundField DataField="StartDate" HeaderText="StartDate"   DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="EndDate" HeaderText="EndDate"  DataFormatString="{0:d}" />
                                           <asp:BoundField DataField="FormDistribution" HeaderText="FormDistribution" />
                                           <asp:BoundField DataField="Createdby" HeaderText="Createdby"/>
                                          
                                           
                                          </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="8" style="text-align: center">
                <asp:Button ID="btnexcel" CssClass="button2" runat="server" style="text-align: center" Text="Excel" OnClick="btnexcel_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
