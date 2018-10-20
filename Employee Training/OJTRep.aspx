<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="OJTRep.aspx.cs" Inherits="Employee_Training.OJTRep" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

    <table class="auto-style1">
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8" style="font-weight: 700; text-decoration: underline; text-align: center; font-size: x-large">OJT TRAINING REPORT</td>
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
            <td style="width:20%">&nbsp;</td>
            <td>Empcode</td>
            <td>
                <asp:TextBox ID="txtEmpcode" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              

                                        </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnEmpcode" CssClass="button" runat="server" Text="EmpcodeSearch" OnClick="btnEmpcode_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Station</td>
            <td>
                <asp:DropDownList ID="drpStation" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnStation" CssClass="button" runat="server" Text="StationSearch" OnClick="btnStation_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Station Status</td>
            <td>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                <asp:DropDownList ID="drpStationStatus" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                    <asp:ListItem>---Select---</asp:ListItem>
                    <asp:ListItem>Critical</asp:ListItem>
                    <asp:ListItem>Non Critical</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnStationStatus" CssClass="button" runat="server" Text="Station status Search" OnClick="btnStationStatus_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Created By </td>
            <td>
                <asp:DropDownList ID="drpcreatedby" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                   
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btncreatedby" CssClass="button" runat="server" Text="Createdby Search" OnClick="btncreatedby_Click"  />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Expiry From </td>
            <td>
                <asp:TextBox ID="txtFromDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtFromDate" PopupButtonID="Image2" runat="server">
        </asp:CalendarExtender>

                                        <asp:Image ID="Image2" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />

            </td>
            <td>ExpiryTo</td>
            <td>
                <asp:TextBox ID="txtToDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              <asp:CalendarExtender ID="CalendarExtender" TargetControlID="txtToDate" PopupButtonID="Image3" runat="server">
        </asp:CalendarExtender>

                                        <asp:Image ID="Image3" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />

            </td>
            <td>
                <asp:Button ID="btnDate" CssClass="button" runat="server" Text="DateSearch" OnClick="btnDate_Click" />
            </td>
            <td style="width:20%">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Contract Name</td>
            <td>
                <asp:DropDownList ID="drpContact" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                   
                </asp:DropDownList>

            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnContract" CssClass="button" runat="server" Text="Contract Search" OnClick="btnContract_Click"  />

            </td>
            <td>
                &nbsp;</td>
            <td style="width:20%">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>Project </td>
            <td>
                
              

                <asp:DropDownList ID="drpProject" runat="server" Width="210px"  Height="35px"  CssClass="textbox">
                   
                </asp:DropDownList>

              

            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnProject" CssClass="button" runat="server" Text="Project Search" OnClick="btnProject_Click"  />

            </td>
            <td>
                &nbsp;</td>
            <td style="width:20%">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnExcelDown" CssClass="button2" runat="server" Text="Excel" OnClick="btnExcelDown_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">
                <asp:GridView ID="GridView1" runat="server" DataKeyNames="id" AutoGenerateColumns="false"  BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black"  OnRowDeleting="GridView1_RowDeleting">
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

                                           <asp:CommandField ShowDeleteButton="true" />

                                           <asp:BoundField DataField="Id" HeaderText="Id"  /> 
                                           <asp:BoundField DataField="Type" HeaderText="Type" />
                                           <asp:BoundField DataField="Empcode" HeaderText="Empcode" />
                                           <asp:BoundField DataField="Name" HeaderText="Name"/>
                         <asp:BoundField DataField="ContractName" HeaderText="Contract Name" />
                         <asp:BoundField DataField="JobCode" HeaderText="JobCode" />
                         <asp:BoundField DataField="StationName" HeaderText="StationName" />
                         <asp:BoundField DataField="StationStatus" HeaderText="StationStatus" />
                         
                                           <asp:BoundField DataField="Project" HeaderText="Project" />
                                           <asp:BoundField DataField="OJTType" HeaderText="OJTType" />
                                           <asp:BoundField DataField="StartDate" HeaderText="StartDate"  DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="EndDate" HeaderText="EndDate"  DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="FailedDueDate" HeaderText="FailedDueDate"  />
                           <asp:BoundField DataField="Score" HeaderText="Score" />
                                           <asp:BoundField DataField="Status" HeaderText="Status"  />
                                         
                                          </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
    </table>


</asp:Content>
