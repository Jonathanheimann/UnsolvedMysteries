<%@ Page Title="משולש ברמודה" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Zodiac.aspx.cs" Inherits="mysteries_Zodiac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../styles/MysteriesStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <div class ="mystery">
        <br /><h2><%:Page.Title %></h2>
        <table align="left">
            <tr>
                <th colspan="2"><%:Page.Title %></th>
            </tr>
            <tr>
                <td colspan="2"><img src="../images/flight19.jpg" width="260"/></td>
            </tr>
            <tr>
                <td colspan="2" class="picBio">חמשת מטוסי "טיסה 19" דקות ספורות <br />לפני העלמותם.</td>
            </tr>
            <tr>
                <td>אזור</td>
                <td>האוקיינוס האטלנטי</td>
            </tr>
            <tr>
                <td>קצוות</td>
                <td>איי הברמודה (צפון)<br />החוף של פלורידה (מערב) <br />פוארטו ריקו (דרום)</td>
            </tr>
            <tr>
                <td>שטח</td>
                <td>1,000,000 קמ"ר</td>
            </tr>
        </table>

        <p>
            משולש ברמודה הוא אזור באוקיינוס האטלנטי שצורתו משולשת, וקודקודיו הם
 איי ברמודה בצפון, החוף המזרחי של פלורידה במערב, ופוארטו ריקו בדרום. 
שטחו של המשולש כ-1,000,000 קילומטרים רבועים. המשולש הוא אזור עתיר-תחבורה, 
שנקשרו בו מספר תאונות לא מוסברות; <br /><br/>המפורסמת בהן היא היעלמותם של חמישה
 מפציצים אמריקניים בטיסת אימון שגרתית בדצמבר 1945, שנודעה כ"טיסה 19".

        </p>
    
        <div class="sectionVideo"><iframe width="560" height="315" src="https://www.youtube.com/embed/bnCdIJAmUao" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen="true"></iframe></div>



        <div class ="section">
            <h3 style="margin-top:.5em;">לעוד מידע: </h3>
            <p style ="margin:auto; text-align:center;">
                <a href ="https://he.wikipedia.org/wiki/%D7%98%D7%99%D7%A1%D7%94_19" target="_blank">סיפורה המלא של טיסה 19</a>
                <a href ="https://www.youtube.com/watch?v=zHgScLIjN9o" target="_blank">סיפורו של משולש ברמודה</a>
                <a href ="https://news.walla.co.il/item/3083495" target="_blank">משולש ברמודה - הפתרון</a>
                <a href ="https://vod.walla.co.il/movie/1867706" target="_blank">משולש ברמודה - הסרט המלא</a>
            </p>
        </div>
        <br /><br /></div>
</asp:Content>