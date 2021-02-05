using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Main : System.Web.UI.Page
{
    PD s = new PD();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["username"] = null;
        if(Session["name"]!=null&&Session["pwd"]!=null)
        {
            TextBox1.Text = Session["name"].ToString();
            TextBox2.Text = Session["pwd"].ToString();
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Length==0)
        {
            Label1.Visible = true;
            Label2.Visible = false;
        }
        else if(TextBox2.Text.Length==0)
        {
            Label1.Visible = false;
            Label2.Visible = true;
        }
        else
        {
            Label1.Visible = Label2.Visible = false;

            if(s.Login(TextBox1.Text,TextBox2.Text))
            {
                Session["username"] = TextBox1.Text;
                Session["dmlxpd"] = "gm";
                Response.Redirect("Main.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("zc.aspx");
    }



    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Session["name"] = TextBox1.Text;
        Session["pwd"] = TextBox2.Text;
    }

    protected void Button3_Click(object sender, EventArgs e)//游客登录
    {
        Session["piclj"] = "";
        Session["videolj"] = "";
        Session["username"] = "游客";
        Session["dmlxpd"] = "gm";
        Response.Redirect("Main.aspx");
    }
}