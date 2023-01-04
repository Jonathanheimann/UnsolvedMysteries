<%@ Page Title="תוכן לרשומים בלבד" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegisteredOnly.aspx.cs" Inherits="RegisteredOnly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <div class ="section">
        <h2 style="margin:auto; font-size:2em;">היי גבר! (או גברת...)</h2>
        <p style="font-size:1.3em; text-align:center;">
            אתם מנסים להיכנס לדף לרשומים בלבד...
            <br />
            אתם לא משאירים לי יותר מדי אופציות:
        </p>
        <br />
        <div class="containRegister">
            <a href ="Login.aspx" class="NotRegister">לחץ להתחברות</a>
            <a href ="Main.aspx" class ="NotRegister">לחץ לדף הראשי</a>
            <a href ="Join.aspx" class ="NotRegister">לחץ להרשמה</a>
        </div>
        <br /><br />
    </div>
</asp:Content>

