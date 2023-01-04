using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
        //פעולה הנקראת אוטומטית כשהדף נטען
        
    {
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
        //פעולה הקולטת את שם המשתמש ואת הסיסמה מהטופס
        //אם הם נכונים, הפעולה תפנה את הדפדפן לדף הראשי
    {
        using (MyDB db = new MyDB())
        {
            string sql1 = "SELECT [user_id], [hash], [salt], [role] FROM [Users] Where [username] = {0}";
            var command = db.Command(sql1, TxtUserName.Text);
            var row = command.GetFirstRow();
            string state = Request.QueryString["state"];
            if (row != null)
            {
                // נשחזר את הגיבוב עם הסיסמה שהוזנה כעת
                string hash = Password.Hash(TxtPassword.Text, (string)row["salt"]);
                // נבדוק אם קיבלנו גיבוב זהה לזה מהמסד
                if (hash == (string)row["hash"])
                {
                    
                        Session["user_id"] = row["user_id"];
                        Session["username"] = TxtUserName.Text;
                        Session["user_role"] = row["role"];

                        if ((string)Session["user_role"] == "Admin")
                        {
                            Response.Redirect("AdminOnly.aspx");
                        }
                        else
                        {


                            Response.Redirect(Request.QueryString["returnURL"] ?? "Main.aspx");
                        }
                    
                    
                    
                }


            }
            else
            {
                LblMessage.Text = "שם המשתמש או הסיסמה שגויים\n\n";
            }
        }
    }
}