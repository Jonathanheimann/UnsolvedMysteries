using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserSet : System.Web.UI.Page
{
    public int UserId; // תכונה נגישה לכל הדף

    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["user_id"];
        if (int.TryParse(id, out UserId) == false)
            Response.Redirect("AdminOnly.aspx");
    }


	protected void Page_PreRender(object sender, EventArgs e)
	{
		string sql_user = "SELECT [user_id], [username],[salt], [role] FROM [Users];";
		using (MyDB db = new MyDB())
		{
			var cmd_user = db.Command(sql_user, UserId);
			var user = cmd_user.GetFirstRow();

			if (user == null)
				Response.Redirect("AdminOnly.aspx");

			Page.Title = user["username"].ToString();
		}
	}







}