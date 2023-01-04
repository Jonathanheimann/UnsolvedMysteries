<%@ Page Title="התעלומות הגדולות" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BiggestUnsolved.aspx.cs" Inherits="BiggestUnsolved" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <div class ="section">
        <h2>ינואר - רוצח הזודיאק: </h2>
        <img src="images/zodiacPic.jpg" />
        <p>
            רוצח הזודיאק <i>(באנגלית: Zodiac Killer)</i> הוא כינויו של רוצח סדרתי
            (או של מספר רוצחים שפעלו במקביל) מצפון מדינת קליפורניה
            שבארצות הברית שפעל בשלהי שנות ה-60 ובתחילת שנות ה-70 של המאה ה-20.
            הרוצח רצח לפחות חמישה בני אדם, ופצע קשה שניים אחרים בין השנים 1968 
            ל-1969. הקורבנות היו נשים וגברים בני 16 עד 29.
            <br />
            זהותו של הרוצח לא התגלתה.
        </p>
        <asp:LinkButton ID ="zodiacLink" runat="server" Text="לקריאה נוספת" CssClass="monthsBtn" OnClick="zodiacLink_Click"/>
    </div><!--January-->
    <div class ="section">
        <h2>פברואר - משולש ברמודה: </h2>
        <img src="images/flight19.jpg" style="height:10em;"/>
        <p>
            משולש ברמודה <i>(באנגלית: "Bermuda Triangle")</i> הוא אזור באוקיינוס האטלנטי
            שצורתו משולשת, וקודקודיו הם איי ברמודה בצפון, החוף המזרחי של פלורידה
            במערב, ופוארטו ריקו בדרום. שטחו של המשולש כ-1,000,000 קילומטרים רבועים. 
            <br />
            המשולש הוא אזור עתיר-תחבורה, שנקשרו בו מספר תאונות לא מוסברות; המפורסמת בהן היא 
            של חמישה מפציצים אמריקניים בטיסת אימון שגרתית בדצמבר 1945, שנודעה בתור<i> "טיסה 19".</i>

        </p>
        <asp:LinkButton ID ="bermudaLink" runat="server" Text="לקריאה נוספת" CssClass="monthsBtn" OnClick="bermudaLink_Click"/>
    </div><!--Feburary-->
    <div class ="section">
        <h2>מרץ - אזור 51: </h2>
        <img src="images/area51Sign.jpg" style="height:6em; filter:grayscale(30%);"/>
        <p>
            אזור 51 <i>(באנגלית: Area 51) </i>  הוא שטח צבאי סגור הנמצא 
            בחלקה הדרומי של מדינת נבדה שבארצות הברית. הבסיס משמש 
            לפיתוח וניסוי כלי טיס צבאיים סודיים. שמו של אזור 51 נקשר גם
             לתאוריות קשר רבות העוסקות בחייזרים, ומכאן פרסומו הנרחב.
        </p>
        <asp:LinkButton ID ="area51Link" runat="server" Text="לקריאה נוספת" CssClass="monthsBtn" OnClick="area51Link_Click"/>
    </div><!--March-->
    <div class ="section">
        <h2>אפריל - המפלצת מלוך-נס:</h2>
        <img src="images/nessi1.jpg" style="height:9.3em; filter:grayscale(30%);"/>
        <p>
           המפלצת מלוך נס <i>(שם מדעי: Rhombopteryx nessiteras)</i>, הידועה גם בשם "נסי" (Nessie) היא מפלצת אגדתית שחיה, כביכול, באגם לוך נס שבסקוטלנד. אזכורים למפלצת השוכנת בלוך נס מופיעים בסיפורים מלפני כ-1,500 שנה. רבים מפקפקים באמינות הסיפור, ומציינים סיפור אחר בו קולומבה, קדוש נוצרי שהאמין כי ניצח את המפלצת מחסל דוב בר באמצעות קולו בלבד ולא מפלצת עצומה.
        </p>
        <asp:LinkButton ID ="LinkButton1" runat="server" Text="לקריאה נוספת" CssClass="monthsBtn" OnClick="Nessi_Click"/>
    </div><!--April-->
    <div class ="section">
        <h2>מאי - העיר האבודה אטלנטיס</h2>
        <img src ="images/atlan1.jpg" style ="filter: grayscale(60%);" />
        <p>
            אטלנטיס<i> (ביוונית: Ἀτλαντὶς νῆσος; ) </i>היא עיר אגדית המוזכרת בכתביו של הפילוסוף אפלטון. מיקום העיר לפי הכתבים היא "מעֵבר לעמודי הרקולס" (כלומר ממערב למצר גיברלטר, מנקודת המבט היוונית). מדובר בעיר שעל פי האגדה שקעה כולה על מתחת לאוקייאנוס וכיום מסתתרת לה במעמקי הים ושוכנת מספר לא מבוטל של אנשים הקוראים לעצמם "אטלאנטיים".
        </p>
                <asp:LinkButton ID ="Atlantis" runat="server" Text="לקריאה נוספת" CssClass="monthsBtn" OnClick="Atlantis_Click"/>

    </div><!--May-->
</asp:Content>

