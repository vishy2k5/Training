<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="DLIndRep.aspx.cs" Inherits="Employee_Training.DLIndRep" EnableEventValidation="false" %>
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
            <td colspan="8" style="font-weight: 700; text-align: center; text-decoration: underline; font-size: x-large">DL EMPLOYEE INDUCTION REPORT</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>HandOverDate</td>
            <td>
                <asp:TextBox ID="txtHandOverDate" runat="server" Width ="200px" CssClass="textbox"></asp:TextBox>
              <asp:CalendarExtender ID="txtStartDate1_CalendarExtender" TargetControlID="txtHandOverDate" PopupButtonID="Image1" runat="server">
        </asp:CalendarExtender>

                                        <asp:Image ID="Image1" runat="server" 
                                            ImageUrl="image/Calendar_scheduleHS.png" />

            </td>
            <td>HanoverStatuus</td>
            <td>
                <asp:DropDownList ID="drpHandoverStatus" runat="server" Width="210px"  Height="35px" CssClass="textbox">
                       <asp:ListItem>---Select---</asp:ListItem>
                     <asp:ListItem>Present</asp:ListItem>
                     <asp:ListItem>Absent</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnhandover" CssClass="button" runat="server" Text="HandoverReport" OnClick="btnhandover_Click" />
            </td>
            <td style="width:40%">&nbsp;</td>
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
                <asp:Button ID="btnOverAll" runat="server" Text="OverAllReport" CssClass="button" OnClick="btnOverAll_Click" />
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
                                           <asp:BoundField DataField="Name" HeaderText="NAme" />
                                           <asp:BoundField DataField="EmpType" HeaderText="EmpType"/>
                                           <asp:BoundField DataField="Gender" HeaderText="Gender"/>
                                           <asp:BoundField DataField="Dep" HeaderText="Department" />
                                           <asp:BoundField DataField="Project" HeaderText="Project" />
                                           <asp:BoundField DataField="Shift" HeaderText="Shift" />
                                           <asp:BoundField DataField="Topics" HeaderText="Topics" />
                                           <asp:BoundField DataField="Trainer" HeaderText="Trainer" />
                                           <asp:BoundField DataField="StartDate" HeaderText="StartDate"   DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="EndDate" HeaderText="EndDate"   DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="TotalDays" HeaderText="TotalDays" />
                                           <asp:BoundField DataField="Score" HeaderText="Score" />
                                           <asp:BoundField DataField="TrainingStatus" HeaderText="TrainingStatus"/>
                                           <asp:BoundField DataField="HandOverDate" HeaderText="HandOverDate" DataFormatString="{0:d}"/>
                                           <asp:BoundField DataField="HandOverStatus" HeaderText="HandOverStatus" />    
                                           <asp:BoundField DataField="RepName" HeaderText="RepName" />
                                           <asp:BoundField DataField="RepEmail" HeaderText="RepEmail" />
                                          
                                           
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
