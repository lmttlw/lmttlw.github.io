using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class zc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    PD s = new PD();
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length == 0)
        {
            Label1.Visible = true;
            Label2.Visible = false;
            Label3.Visible = false;
        }
        else if (TextBox2.Text.Length == 0)
        {
            Label1.Visible = false;
            Label2.Visible = true;
            Label3.Visible = false;
        }
        else if(TextBox3.Text.Length==0)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = true;
            Label3.Text = "请确认密码";
        }
        else if(TextBox2.Text!=TextBox3.Text)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = true;
            Label3.Text = "请输入相同的密码";
        }
        else
        {
            Label1.Visible = Label2.Visible = false;

            if (s.zc(TextBox1.Text, TextBox2.Text))
            {
                Response.Write("<script>alert('注册成功！')</script>");
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}