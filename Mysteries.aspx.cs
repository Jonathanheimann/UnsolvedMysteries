    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mysteries : System.Web.UI.Page
{
	public bool IsAdmin;

	/// <summary> פעולה המופעלת אוטומטית בטעינת הדף </summary>
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Session["username"] == null)
		{
			Response.Redirect("RegisteredOnly.aspx");
		}
		IsAdmin = "Admin".Equals(Session["user_role"]);


		PnlPostNewMystery.Visible = Session["user_id"] != null; // הגולש מחובר
		LnkLoginToPost.Visible = Session["user_id"] == null; // הגולש אינו מחובר
	}

	/// <summary> פעולה המופעלת אוטומטית לפני הפקת הדף </summary>
	protected void Page_PreRender(object sender, EventArgs e)
	{
		string sql = "SELECT [Id], [title], [username]" +
			" FROM [Mysteries] AS Q" +
			" JOIN [Users] AS U ON Q.[by_user]=U.[user_id]" +
			" ORDER BY [creation_time] DESC";
		string html = "";
		using (MyDB db = new MyDB())
		{
			var mysteries = db.Command(sql).GetTable();
			for (int i = 0; i < mysteries.Rows.Count; i++)
			{
				var row = mysteries.Rows[i];
				html += "<li><a href='Mystery.aspx?id=" + row["Id"].ToString() +
					"'>" + row["title"].ToString() + " - מאת " + row["username"].ToString() + "</a>" +
					"</li>";


				/*html += "<li><a href='Mystery.aspx?id=" + row["Id"] +
					"'>" + Server.HtmlEncode("" + row["title"]) +
					"</a> מאת " + Server.HtmlEncode("" + row["username"]) +
					"</li>";*/
			}
		}
		ulSubjects.InnerHtml = html;
	}

	/// <summary>
	/// פעולה הנקראת בהקלקה על הכפתור ״פרסם חידה״
	/// הפעולה מוסיפה את החידה לטבלת החידות, ומפנה לדף של החידה החדשה
	/// </summary>
	protected void AddNewMystery_Click(object sender, EventArgs e)
	{
		if (Session["user_id"] == null) // הגולש אינו מחובר
			Response.Redirect("RegsiteredOnly.aspx");
		else
		{
			string sql = "INSERT INTO [Mysteries] ([title], [content], [by_user])" +
				" VALUES ({0}, {1}, {2})";
			/*using (MyDB db = new MyDB())
			{
				var cmd = db.Command(sql, TxtTitle.Text, TxtContent.Text, Session["user_id"]);
				cmd.ExecuteNonQuery();
			}*/
			using (MyDB db = new MyDB())
			{
				var cmd = db.Command(sql, TxtTitle.Text, TxtContent.Text, Session["user_id"]);
				cmd.ExecuteNonQuery();
				var cmd_id = db.Command("SELECT @@IDENTITY");
				Response.Redirect("Mystery.aspx?id=" + cmd_id.ExecuteScalar());
			}
		}
	}
}