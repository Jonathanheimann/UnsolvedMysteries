<%@ Page Title="חידת משתמש" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Mystery.aspx.cs" Inherits="Mystery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <article class="tavor1">
		<br />
		<h2 class="barak"><%:Page.Title %></h2>
		<footer class ="ilaydekel">
			פורסם על־ידי <asp:Label runat="server" ID="LblPostedBy" />
			ב־<asp:Label runat="server" ID="LblCreationTime" />
		</footer>
		<p class="section"><asp:Label runat="server" ID="LblContent" Textmode="multiline"/></p>
		
	</article>

	<h3>תגובות</h3>
	
	<asp:ListView ID="LVReplies" runat="server" OnItemCommand="LVReplies_ItemCommand">
		<ItemTemplate>
			<article>
				<p class="tavor1"><%#: Eval("content") %></p>
				<footer>
					פורסם על־ידי <%#: Eval("username") %>
					ב־<%# Eval("creation_time") %>
					<asp:LinkButton Text="מחק תגובה" runat="server"
						CommandName="DeleteReply" CommandArgument='<%# Eval("reply_id") %>' />
				</footer>
			</article>
		</ItemTemplate>
		<EmptyDataTemplate>
			<p>עדיין אין תגובות.</p>
		</EmptyDataTemplate>
	</asp:ListView>
</asp:Content>

