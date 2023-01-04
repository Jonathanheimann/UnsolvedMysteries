<%@ Page Title="תעלומות גולשים" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Mysteries.aspx.cs" Inherits="Mysteries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
	<div class ="loginSec" style="margin-right: 0; margin-left: 27em;">
    <h2>חידה חדשה</h2>
	<asp:Panel runat="server" ID="PnlPostNewMystery">
		<asp:Label runat="server" Text="כותרת:" /><br />
		<asp:TextBox ID="TxtTitle" runat="server" cssClass="loginBtn"/><br />
		<br />
		<asp:Label runat="server" Text="תוכן:" /><br />
		<asp:TextBox ID="TxtContent" TextMode="MultiLine" runat="server" cssClass="loginBtn"/><br />
		<br />
		<asp:Button runat="server" Text="פרסם חידה" OnClick="AddNewMystery_Click" cssClass="mysteryBtn" onkeyyp="disBtn()" ID="gingBtn"/>
		<br />
	</asp:Panel>

	<asp:HyperLink ID="LnkLoginToPost" runat="server"
		Text="עליך להתחבר כדי לפרסם חידה" NavigateUrl="~/Login.aspx?returnURL=Riddles.aspx" cssClass="bibi"/>
		</div>
	<div class="ari">
		<br />
	<h2>חידות משתמשים:</h2>
		<div class="loginInSec">
    	<ul id="ulSubjects" runat="server">
			
    	</ul>

			</div>
	</div>
</asp:Content>

