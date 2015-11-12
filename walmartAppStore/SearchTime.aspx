<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchTime.aspx.cs" Inherits="SearchTime" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       
    <asp:TextBox ID="txtint" runat="server"></asp:TextBox>
    <asp:Label ID="lblstring" runat="server" Text="string"></asp:Label>
    <asp:Label ID="lbltime1" runat="server" Text="Time1"></asp:Label>

    <br />
    <asp:TextBox ID="txtstring" runat="server"></asp:TextBox><asp:Label ID="lblinteger" runat="server" Text="integer"></asp:Label>
     <asp:Label ID="lbltime2" runat="server" Text="Time2"></asp:Label>
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
<br />
<br />
    
   
</asp:Content>
