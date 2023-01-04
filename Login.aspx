<%@ Page Title="התחברות לאתר" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">

    <div class ="loginSec">
        
        <h2>התחברות</h2>
        <br />
        <div class ="loginInSec"><asp:Label runat="server" Text="שם משתמש: " AssociatedControlID="TxtUserName" CssClass="loginLbl"/>
            <br />
        <asp:TextBox ID="TxtUserName" runat="server" CssClass="loginBtn"/>

        <br /><br />
        <asp:Label runat="server" Text="סיסמה: " AssociatedControlID="TxtPassword" CssClass="loginLbl"/>
            <br />
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass ="loginBtn"/></div>
    
        <br />
        <asp:Label ID="LblMessage" runat="server" />
        <br />
        <asp:Button ID="BtnLogin" runat="server" Text="התחבר" OnClick="BtnLogin_Click" CssClass="loginBtn"/>
        <br /><br />
    </div>

</asp:Content>

