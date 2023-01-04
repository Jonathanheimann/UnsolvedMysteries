using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
        //פעולה המופעלת אוטומטית בטעינת הדף
    {
        if ((string)Session["user_role"] == "Admin")
        {
            linkLogin.Visible = false;
            linkLogout.Visible = true;
            lblHello.Text = "שלום " + Session["username"] + "!";
            linkJoin.Visible = false;
            AdminLink.Visible = true;
        }

        if (Session["username"] != null)
        {
            linkLogin.Visible = false;
            linkLogout.Visible = true;
            lblHello.Text = "שלום " + Session["username"] + "!";
            linkJoin.Visible = false;
        }

        else
        {
            lblHello.Text = "שלום אורח!";
            linkMysteries.Visible = false;
            string returnURL = Request.Url.PathAndQuery;
            if (returnURL.ToLower().StartsWith("/login.aspx"))
                returnURL = Request.QueryString["returnURL"] ?? "Main.aspx";
            linkLogin.NavigateUrl = "~/Login.aspx?returnURL=" + Server.UrlEncode(returnURL);
        }
    }



    protected void linkLogout_Click(object sender, EventArgs e)
        //פעולה הנקראת בהקלקה על הקישור "התנתק"
        //הפעולה מנתקת את המשתמש ומפנה את הדפדפן לדף הראשי
    {
        Session.Clear();
        Response.Redirect("Main.aspx");
    }
}
