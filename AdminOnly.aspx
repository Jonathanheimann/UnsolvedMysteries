<%@ Page Title="דף מנהל" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminOnly.aspx.cs" Inherits="AdminOnly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <h2 style="font-size:3.5em; text-align:center;">מנהלה</h2>
    
    <div class="section" style="margin-left:18em; margin-top:-0em;"><p>שלום <%:Session["username"] %> ברוך הבא לדף ההנהלה! כאן תוכל לנהל את כל שקורה באתר ולעשות פאן פאן פאן! תרגיש חופשי לעשות מה שבראש שלך למה אתה המלך פה ואתה היחיד שמחליט! אם במקרה הגיע לכאן משתמש רגיל סחטיין, עקפת את האבטחה הפסיכית שלי זכית.</p></div>

    <div class="section">
        <asp:Panel runat="server" ID="UserTable" CssClass="coc"></asp:Panel>
            </div>-

</asp:Content>

