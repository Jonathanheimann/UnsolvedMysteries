using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mystery : System.Web.UI.Page
{
	public int MysteryId; // תכונה נגישה לכל הדף

	protected void Page_Load(object sender, EventArgs e)
	{
		string id = Request.QueryString["id"];
		if (int.TryParse(id, out MysteryId) == false)
			Response.Redirect("Mysteries.aspx");
	}

	protected void Page_PreRender(object sender, EventArgs e)
	{
		string sql_mystery = @"SELECT *
			FROM [Mysteries] AS Q
			JOIN [Users] AS U ON Q.[by_user]=U.[user_id]
			WHERE [Id]={0} AND [is_visible]=1";
		using (MyDB db = new MyDB())
		{
			var cmd_mystery = db.Command(sql_mystery, MysteryId);
			var mystery = cmd_mystery.GetFirstRow();

			if (mystery == null)
				Response.Redirect("Mysteries.aspx");

			Page.Title = mystery["title"].ToString();
			LblContent.Text = mystery["content"].ToString();
			LblPostedBy.Text = mystery["username"].ToString();
			LblCreationTime.Text = mystery["creation_time"].ToString();
		}
	}

	/// <summary>
	/// פעולה המופעלת בעקבות אירוע הקלקה על כפתור ליד תגובה לחידה
	/// </summary>
	protected void LVReplies_ItemCommand(object sender, ListViewCommandEventArgs e)
	{
		if ("DeleteReply" == e.CommandName) // כפתור מחיקה
		{
			int msg_id = int.Parse(e.CommandName);
			string sql = @"UPDATE [Replies] SET [is_visible]=0
				WHERE [reply_id]={0}";
			using (MyDB db = new MyDB())
				db.Command(sql, msg_id).ExecuteNonQuery();
		}
	}
}