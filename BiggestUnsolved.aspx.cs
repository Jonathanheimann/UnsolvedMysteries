using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BiggestUnsolved : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void zodiacLink_Click(object sender, EventArgs e)
    {
        if (Session["username"]!=null)
        {
            Response.Redirect("Zodiac.aspx");
        }
        else
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
    }

    protected void bermudaLink_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            Response.Redirect("Bermuda.aspx");
        }
        else
        {
            Response.Redirect("RegisteredOnly.aspx");
        }
    }
    protected void area51Link_Click(object sender, EventArgs e)
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

    protected void Nessi_Click(object sender, EventArgs e)
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

    protected void Atlantis_Click(object sender, EventArgs e)
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
}