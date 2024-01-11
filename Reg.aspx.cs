using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BOL;
using DAL;



namespace _3_tier_practice
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void INSERT_Click1(object sender, EventArgs e)
        {
            bol_class b1 = new bol_class();
            bal_class b2 = new bal_class();
            b1.Username = TextBox1.Text; 
            b1.Mobile = TextBox2.Text;
            b1.Email = TextBox3.Text;
            b1.Gender = DropDownList2.Text;
            b1.Usertype = DropDownList1.Text;
            b1.password = TextBox4.Text;
            b1.photo = "Image/image7.jpg";
            b2.Insert(b1);

        }

     
    }
} 