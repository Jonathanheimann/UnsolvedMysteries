using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminOnly : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
        if ((string)Session["user_role"]!="Admin")
        {
			Response.Redirect("RegisteredOnly.aspx");

        }

        string id = Request.QueryString["id"];
        string state = Request.QueryString["state"];
        string modd = Request.QueryString["modd"];

        if (id != null)
        {
            if (state != null)
            {
                string queryString;
                if (state == "0")
                {
                    queryString = "UPDATE [Users] SET [role]='Sus' WHERE [user_id]=" + id + ";";
                }
                else
                {
                    queryString = "UPDATE [Users] SET [role]='dbo' WHERE [user_id]=" + id + ";";
                }
                using (MyDB db = new MyDB())
                {
                    var cmd_add = db.Command(queryString);
                    cmd_add.ExecuteNonQuery();

                }
            }
            if (modd != null)
            {
                string queryString;
                if (modd == "0")
                {
                    queryString = "UPDATE [Users] SET [role]='0' WHERE [user_id]=" + id + ";";
                }
                else
                {
                    queryString = "UPDATE [Users] SET [role]='Admin' WHERE [user_id]=" + id + ";";
                }
                using (MyDB db = new MyDB())
                {
                    var cmd_add = db.Command(queryString);
                    cmd_add.ExecuteNonQuery();

                }
                // קליטה של המידע שנקלט מהקישור ושליחה של עדכון מתאים לדטה בייס
            }

        }



    }

	/// <summary> פעולה המופעלת אוטומטית לפני הפקת הדף </summary>
	protected void Page_PreRender(object sender, EventArgs e)
	{
		Table table1 = new Table();
		string sql = "SELECT [user_id], [username],[salt], [role], [isVisible] FROM [Users];";
		string html = "<table>";
		using (MyDB db = new MyDB())
		{
			var users = db.Command(sql).GetTable();
			for (int i = 0; i < users.Rows.Count; i++)
			{
				var row = users.Rows[i];
				if ((string)row["role"] != "Admin")
                {
                    if ((string)row["salt"]!="0")
                    {
						html += "<tr><td><li><a  class='roy' href='UserSet.aspx?id=" + row["user_id"].ToString() +
					"'>" + row["username"].ToString() + "</a>" +
					"</li></td></tr>";
					}
				}
					

			}
			html += "</table>";
		}


        table1.CssClass = ("VipTables");
        string sql1 = "SELECT [username],[salt], [role], [user_id]" +
" FROM [Users]" +
" ORDER BY [user_id] ASC";
        string html1 = "";
        using (MyDB db = new MyDB())
        {
            TableRow row;
            TableCell cell;
            row = new TableRow();
            var Users = db.Command(sql1).GetTable();


            cell = new TableCell();
            cell.Text = "username";
            row.Cells.Add(cell);
            cell = new TableCell();
            cell.Text = "user_id";
            row.Cells.Add(cell);
            cell = new TableCell();
            cell.Text = "role";
            row.Cells.Add(cell);
            cell = new TableCell();
            cell.Text = "admin";
            row.Cells.Add(cell);
            row.CssClass = ("FirstRow");
            table1.Rows.Add(row);
            row = new TableRow();
            
            // יצירת טבלה של היוזרים והוספת לינקים שמתארים את מצב הרול של היוזר


            for (int i = Users.Rows.Count - 1; i >= 0; i--)
            {
                
                var SQLrow = Users.Rows[i];
                //if ((string)SQLrow["salt"] == "0")
                //{
               //     i++;
               // }
                cell = new TableCell();



                cell.Text = "" + (string)SQLrow["username"];
                row.Cells.Add(cell);
                cell = new TableCell();

                string userID = @"<p>" + (int)SQLrow["user_id"] + @"</p>";
                cell.Text = "" + userID;
                row.Cells.Add(cell);
                cell = new TableCell();

                string role = (string)SQLrow["role"];
                int RoleInt = 0;
                string RoleString = "user";
                if (role == "Sus")
                {
                    RoleInt = 1;
                    RoleString = "banned";
                }

                html = @"/AdminOnly.aspx?id=" + (int)SQLrow["user_id"] + "&state=" + RoleInt;

                string TheID = "" + (int)SQLrow["user_id"];

                cell.Text = "<a id='" + TheID + "' href='" + html + "'>" + RoleString + "</a>";
                cell.ID = "cell" + TheID;
                row.Cells.Add(cell);

                cell = new TableCell();

                string admin = "no";
                int IntMod = 1;
                if (role == "Admin")
                {
                    admin = "yes";
                    IntMod = 0;
                }
                string ModHtml = "/AdminOnly.aspx?id=" + (int)SQLrow["user_id"] + "&modd=" + IntMod;
                cell.Text = "<a id='" + TheID + "' href='" + ModHtml + "'>" + admin + "</a>";
                row.Cells.Add(cell);




                table1.Rows.Add(row);
                row = new TableRow();

            }
            UserTable.Controls.Add(table1);
            

        }
    }
}