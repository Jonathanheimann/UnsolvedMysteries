using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


public partial class Join : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnJoin_Click(object sender, EventArgs e)
    {
        string name = TxtUserName.Text, pass = TxtPassword.Text, mail = TxtMail.Text;
        string grade = TxtGrade.Text;
        string sql_taken = @"SELECT COUNT(1) FROM Users WHERE [username] = {0}";
        string sql_add = @"INSERT INTO [Users] ([username], [salt], [hash], [mail]) Values({0},{1},{2},{3})";
        bool rowNotNull = false;
        bool isName = false;
        bool isPass = false;
        bool isDigitPresent = pass.Any(c => char.IsDigit(c));
        bool isLetterPresent = pass.Any(c => char.IsLetter(c));
        bool isMail = false;

        using (MyDB db = new MyDB())
        {
            //האם שם המשתמש תפוס?
            var cmd_taken = db.Command(sql_taken, name);

            bool is1 = false;
            bool is2 = false;
            bool is3 = false;
            bool is4 = false;
            bool ab0 = false;
            bool is5 = true;

            bool isGrade = false;
            Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regexMail.Match(mail);
            if ((int)cmd_taken.ExecuteScalar() > 0)
            {
                LblUsername.Text = "שם המשתמש " + name + " תפוס.";
            }
            else
            {
                // המלחה וגיבוב
                string salt = Password.Salt();
                string hash = Password.Hash(pass, salt);

                if (name.Length >= 1)
                {
                    ab0 = true;
                    isName = true;
                    LblUsername.Text = "";
                    if (ab0)
                    {
                        if (name.Length >= 6 || name.Length <= 10)
                        {
                            is1 = true;
                            isName = true;

                        }
                        else
                        {
                            LblUsername.Text = "על שם המשתמש להכין בין 6-10 אותיות";
                        }
                    }
                    
                }
                else
                {
                    LblUsername.Text = "לא הזנת שם משתמש...";
                    LblMessage.Text = "";
                }


                if (pass.Length > 0)
                {
                    isPass = true;
                    LblPassword.Text = "";

                    if (pass.Length >= 6)
                    {
                        
                        isPass = true;
                        LblPassword.Text = "";

                        if (!isDigitPresent || !isLetterPresent)
                        {
                            LblPassword.Text = "על הסיסמה להכיל ספרה ואות";
                        }
                        else
                        {
                            is2 = true;
                            LblPassword.Text = "";
                        }
                    }
                    else
                    {
                        LblPassword.Text = "על הסיסמה להכיל לפחות 6 תווים";
                    }
                }
                else
                {
                    LblPassword.Text = "לא הזנת סיסמה...";
                }


                if (match.Success)
                {
                    is3 = true;
                    LblMail.Text = "";

                    
                }
                else
                {
                    LblMail.Text = "יש להזין כתובת מייל תקינה";
                }

                if ((grade.Length >= 0 && grade.Length<=2)||grade =="100")
                {
                    isGrade = true;
                    LblGrade.Text = "";
                    bool isLetterPresent2 = grade.Any(c => char.IsLetter(c));
                    if (isLetterPresent2)
                    {
                        LblGrade.Text = "על הציון להכיל ספרות בלבד";
                    }
                    else
                    {
                        LblGrade.Text = "";
                        is4 = true;
                        
                    }
                    if (grade != "100")
                    {
                        is5 = false;
                        LblGrade.Text = "סתכל כמה השקעתי נו תפנק בציון";
                    }
                }
                else if(grade.Length==0)
                {
                    LblGrade.Text = "לא הוזן ציון";
                }
                else
                {
                    is5 = false;
                    LblGrade.Text = "על הציון להיות בין 0 ל-100";
                }

                


                if (is1 && is2 && is3 && is4 && is5)
                {
                    //הוספת משתמש
                    var cmd_add = db.Command(sql_add, name, salt, hash, mail);
                    cmd_add.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }

            }


            


            

            
            

        }

    }

    /*
     * using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql; //1
using System.Data.SqlClient; //2

// שתי השורות האחרונות הן בשביל לאפשר שימוש ב SqlConnection וב SqlCommand

public partial class register : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string newName = TxtUserName.Text;
        bool rowNotNull = false;
        using (MyDB db = new MyDB())
        {
            string sql = "SELECT[user_id], [password], [role] FROM[Users] WHERE[username] = {0};";
            var command = db.Command(sql, newName);
            var row = command.GetFirstRow();
            if (row != null)
                rowNotNull = true;
        }

        string newPass = TxtPassword.Text;

        bool pass = false;
        bool name = false;
        bool passcon = false;
        if (rowNotNull == true)
        {
            UsernameWarning.Text = "שם משתמש זה קיים במערכת.";
        }
        else
        {
            if(newName.Length > 0)
            {
                UsernameWarning.Text = "✅";
                name = true;
            }
            else
            {
                UsernameWarning.Text = "לא הזנת שם משתמש...";
            }
            
        }

        if (newPass.Length >= 6)
        {
            bool isDigitPresent = newPass.Any(c => char.IsDigit(c));
            bool isLetterPresent = newPass.Any(c => char.IsLetter(c));
            if (isDigitPresent && isLetterPresent)
            {
                PasswordWarning.Text = "✅";
                pass = true;
                if (TxtPasswordConfirm.Text == TxtPassword.Text)
                {
                    PasswordConfirmWarning.Text = "✅";
                    passcon = true;
                }
                else
                {
                    PasswordConfirmWarning.Text = "על אימות הסיסמא להיות זהה לסיסמא.";
                }
            }
            else
            {
                PasswordWarning.Text = "על הסיסמא להכיל לפחות מספר אחד ואות אחת";
                TxtPassword.Text = newPass;
            }
        }
        else
        {
            PasswordWarning.Text = "אורך הסיסמא חייב להיות מעל 6 תווים";
            TxtPassword.Text = newPass;
        }
        if (pass == true && passcon == true && name == true)
        {
            
            //    var command = db.Command(sql, TxtUserName.Text);
                //var row = command.GetFirstRow();


                using (MyDB db = new MyDB())
            {
                string queryString = "INSERT INTO [Users] ([username], [password]) VALUES( N'" + newName + "', N'" + newPass + "'); ";
                var cmd_add = db.Command(queryString);
                cmd_add.ExecuteNonQuery();

                Response.Redirect("~/login.aspx?id=1");
            }
        }

    }
}
    */

}