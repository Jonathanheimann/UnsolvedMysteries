using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void linkZodiac_Click(object sender, EventArgs e)
    {

        if (Session["username"] != null)
        {
            Response.Redirect("Zodiac.aspx");
        }
        else
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
    }

    protected void linkArea51_Click(object sender, EventArgs e)
    {

        if (Session["username"] != null)
        {
            Response.Redirect("Area51.aspx");
        }
        else
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
    }

    protected void linkLochness_Click(object sender, EventArgs e)
    {

        if (Session["username"] != null)
        {
            Response.Redirect("Nessi.aspx");
        }
        else
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
    }


    protected void linkAtlan_Click(object sender, EventArgs e)
    {

        if (Session["username"] != null)
        {
            Response.Redirect("Atlantis.aspx");
        }
        else
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
    }

    protected void HyperLink1_Click(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
        else
        {
            Response.Redirect("Mysteries.aspx");
        }
    }
}