<%@ Page Title="הרשמה" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Join.aspx.cs" Inherits="Join" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="scripts/MyScript.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <div class ="loginSec">
        
        <h2>הרשמה</h2>
        <br />
        
        <div class ="loginInSec">

            <asp:Label runat="server" Text="שם משתמש: " AssociatedControlID="TxtUserName" CssClass="loginLbl"/>
            <p style="brP"></p>

            <asp:TextBox ID="TxtUserName" runat="server" CssClass="loginBtn" onkeyup="ErrorUsername()"/>
            <br />
            <asp:Label ID="LblUsername" runat="server" Text="" CssClass="lblrrorjoin"></asp:Label>
            <p style="brP"></p>


            <table class="sigler">
                <tr>
                    <th><asp:Label runat="server" Text="סיסמה: " AssociatedControlID="TxtPassword" CssClass="loginLbl"/></th>
                    <th><asp:Label runat="server" Text="אימות סיסמה: " AssociatedControlID="TxtVerifyPassword" CssClass="loginLbl"/></th>
                </tr>
                <tr>
                    <td><div class="fff"><asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass ="loginBtn2"/></div>
                        
                    </td>

                    <td><asp:TextBox ID="TxtVerifyPassword" runat="server" TextMode="Password" CssClass ="loginBtn2" onkeyup="arePasswordsEqual()"/>
                        
                        
                    </td>
                </tr>
            </table>
            <asp:Label ID="LblPassword" runat="server" Text="" CssClass="lblrrorjoin"></asp:Label>
            <p style="brP"></p>
            <asp:Label ID="LblVr" runat="server" Text="" CssClass="lblrrorjoin"></asp:Label>
            <p style="brP"></p>
            <asp:Label runat="server" Text="כתובת מייל: " AssociatedControlID="TxtMail" CssClass="loginLbl"/>
            <p style="brP"></p>
            <asp:TextBox ID="TxtMail" runat="server" CssClass ="loginBtn"/>
            <br />
            <asp:Label ID="LblMail" runat="server" Text="" CssClass="lblrrorjoin"></asp:Label>

            <p style="brP"></p>
            <asp:Label runat="server" Text="ציון שג'ינג'י יקבל על האתר:" AssociatedControlID="TxtGrade" CssClass="loginLbl"/>
            <p style="brP"></p>
            <asp:TextBox ID="TxtGrade" runat="server" CssClass ="loginBtn" TextMode="singleline"/>
            <br />
            <asp:Label ID="LblGrade" runat="server" Text="" CssClass="lblrrorjoin"></asp:Label>


        </div>

        <br />
        <asp:Label ID="LblMessage" runat="server" />
        <br />
        <asp:Button ID="BtnJoin" runat="server" Text="הירשם" CssClass="loginBtn" OnClick="BtnJoin_Click" />
        <br /><br />



    </div>

</asp:Content>

