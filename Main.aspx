<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <div class ="fadein">
            <div class ="section" style ="padding:0;  padding-right:.9em; margin-left:36em;">
            
            <p>
                אין דבר שמעניין יותר את המין האנושי מהלא נודע...<br>
                ממה שמסתירים מאיתנו, ממה שעוד לא גילינו.<br>
                בשביל זה אנחנו כאן לשתף אתכם בנוגע לכל מה<br>
                שמעניין אתכם לדעת, ולתת לכם את האופציה לשתף<br>
                אותנו בכל מה שאתם יודעים!<br>
            </p>
            

                


        </div>
         
        <div class="section" style="margin-right:25.5em; margin-left:20em; margin-top: -11em; padding-top:-0.5em; height:7.4em;">
                    <div class="ella"><h3 style="margin-top:-.1em;">כבר צפיתם בתעלומות המשתמשים החדשות?</h3></div>
                    <asp:Button ID ="btnMain111" runat="server" Text="לחץ למעבר לשאלות" OnClick="HyperLink1_Click" CssClass="asdf"/>
                </div>

        <div class="section" style="margin-right:41.5em; margin-left:1em; margin-top: -11em; padding-top:-0.5em; height:7.4em;">
            <div class="ella"><h3 style="margin-top:-.1em;">לחצו כאן על מנת להכיר את מי<br /> שהכין את האתר החתיך הזה</h3></div>
            <a href ="About.aspx"><img src="images/ging.jpg" style= "margin-top:-.8em; width:14em; object-fit:cover;height:4em; object-position:60% 23%; filter:grayscale(.1);" class="ani"/></a>
        </div>

        <div class = "section">
            <img src="images/atlan1.jpg" alt ="Atlantis" style= "margin:0em; width:38em; object-fit:cover;height:9.4em; object-position:10% 80%; filter:grayscale(.2)"/>
            <h2 style ="font-size:2em;">תעלומת החודש</h2>
            <h2>מאי - העיר האבודה אטלנטיס!!</h2>
            <h3 class="monthlyMystery">
                <asp:LinkButton runat="server" ID="linkAtlan" Text ="לצפייה לחץ כאן" OnClick="linkAtlan_Click" />
            </h3>
        </div>

    </div>
</asp:Content>

