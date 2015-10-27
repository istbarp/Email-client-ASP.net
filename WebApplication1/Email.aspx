<%@ Page Title="Email" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="WebApplication1.Email" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3> -- Email Page for test mail.</h3>
    
    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Send Test Email" />

</asp:Content>
