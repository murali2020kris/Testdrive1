<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile ="~/MasterPage.master"%>

    
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
    <div>
   <center>  
       <br />
       <asp:Label ID="lblparentcategory" runat="server" Text="Department"></asp:Label>
       <asp:DropDownList ID="ddlParentCategory" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlParentCategory_SelectedIndexChanged">
       </asp:DropDownList>
       &nbsp;&nbsp;&nbsp;<asp:Label ID="lblcategory" runat="server" Text="Category"></asp:Label>
       <asp:DropDownList ID="ddlsubcat" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlsubcat_SelectedIndexChanged">
       </asp:DropDownList>
       <br />
       load contilou<br />
       <asp:GridView ID="grdcustomer" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="60%" OnPageIndexChanging="grdcustomer_PageIndexChanging">
           <AlternatingRowStyle BackColor="White" ForeColor="#284775" Height="20px" />
          
           <EditRowStyle BackColor="#999999" />
           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Height ="20px"/>
           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Height="20px" />
           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#E9E7E2" />
           <SortedAscendingHeaderStyle BackColor="#506C8C" />
           <SortedDescendingCellStyle BackColor="#FFFDF8" />
           <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
       </asp:GridView>
        </center>
    </div>
   
     </asp:Content>
