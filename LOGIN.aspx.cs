using BAL;
using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_tier_practice
{
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bol_class b1 = new bol_class();
            bal_class b2 = new bal_class();
            b1.Username = TextBox1.Text;
            b1.password = TextBox2.Text;
            DataSet ds = b2.Savelogindetails(b1);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["Username"] = ds.Tables[0].Rows[0]["Username"].ToString();
                Session["Email"] = ds.Tables[0].Rows[0]["Email"].ToString();
                Session["Password"] = ds.Tables[0].Rows[0]["Password"].ToString();
                Session["UserId"] = ds.Tables[0].Rows[0]["UserId"].ToString();
                if (ds.Tables[0].Rows.Count>0)
                {
                    Response.Redirect("Userpage.aspx");
                }
                else
                {
                    Response.Redirect("Admin.aspx");
                }
            }
            else
            {
                Response.Write("data failed");
            }
        }
    }
}