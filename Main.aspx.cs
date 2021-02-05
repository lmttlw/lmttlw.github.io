using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using BLL;

public partial class Main : System.Web.UI.Page
{
    PD s = new PD();
    string sql="";
    string sjk = "Data Source=.;Initial Catalog=xmdb;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["dmlxpd"].ToString() == "gm") sql = "select * from data where lx=1 and sh='通过'";
            else if (Session["dmlxpd"].ToString() == "rm") sql = "select * from data where lx=2 and sh='通过'";
            else sql = "select * from data where lx=3 and sh='通过'";
            show(sql);

            Button1.BackColor = Color.Transparent;
            Button2.BackColor = Color.Transparent;
            if(Session["username"]==null) Response.Redirect("Login.aspx");

            if (Session["username"] .ToString()=="admin")
            {
                LinkButton7.Text = Session["username"].ToString();
                LinkButton8.Text = "审核";
            }
            else if(Session["username"].ToString() == "游客")//判断是否为游客
            {
                LinkButton8.Text = Session["username"].ToString();
                LinkButton19.Visible = false;
                LinkButton19.Enabled = false;
                LinkButton7.Text = "上传视频";
                for (int i = 3; i <= 22; i++)// 按钮隐藏
                {
                    object o = FindControl("Button" + i);
                    if (o != null && o is Button)
                    {
                        Button t = (Button)o;
                        t.Visible = false;
                        t.Enabled = false;
                    }
                }
            }
            else if (Session["username"].ToString() != "游客")//判断是否为普通用户
            {
                LinkButton7.Text = Session["username"].ToString();
                LinkButton8.Visible = false;
                LinkButton8.Enabled = false;

                for (int i = 3; i <= 22; i++)// 按钮隐藏
                {
                    object o = FindControl("Button" + i);
                    if (o != null && o is Button)
                    {
                        Button t = (Button)o;
                        t.Visible = false;
                        t.Enabled = false;
                    }
                }
            }
            Session["dmlxpd"] = "gm";
            Session["xg"] = null;
        }
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if(Session["username"].ToString()=="游客")Response.Redirect("Login.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)//国漫
    {
        Session["dmlxpd"] = "gm";
        sql = "select * from data where lx=1 and sh='通过'";
        show(sql);
    }

    #region ImageButton跳转
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton9.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton10.Text != "敬请期待")
        {
            Session["pd"] = "pd2";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton11.Text != "敬请期待")
        {
            Session["pd"] = "pd3";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton12.Text != "敬请期待")
        {
            Session["pd"] = "pd4";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton13.Text != "敬请期待")
        {
            Session["pd"] = "pd5";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton14.Text != "敬请期待")
        {
            Session["pd"] = "pd6";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton15.Text != "敬请期待")
        {
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton16.Text != "敬请期待")
        {
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton17.Text != "敬请期待")
        {
            Response.Redirect("videobf.aspx");
        }
    }

    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        if (LinkButton18.Text != "敬请期待")
        {
            Response.Redirect("videobf.aspx");
        }
    }
    #endregion
    
    protected void LinkButton2_Click(object sender, EventArgs e)//日漫
    {
        Session["dmlxpd"] = "rm";
        sql = "select * from data where lx=2 and sh='通过'";
        show(sql);
    }

    protected void LinkButton3_Click(object sender, EventArgs e)//综合
    {
        Session["dmlxpd"] = "zh";
        sql = "select * from data where lx=3 and sh='通过'";
        show(sql);
    }

    protected void LinkButton19_Click(object sender, EventArgs e)//新增按钮
    {
        Response.Redirect("insert.aspx");
    }

    
    protected void LinkButton6_Click(object sender, EventArgs e)//搜索
    {
        Session["dmlxpd"] = "ss";
        sql = "select * from data where name like '%" + TextBox1.Text + "%'";
        show(sql);
        
    }

    #region show显示方法
    public void show(string sql)
    {
        DataTable biao =s.show (sql);
        for (int i = 1; i <= biao.Rows.Count; i++)
        {
            string name = biao.Rows[i - 1]["name"].ToString();//取到表中名为name列的值
            string picname = biao.Rows[i - 1]["img"].ToString();//取到表中名为img列的值
            string videoname = biao.Rows[i - 1]["video"].ToString();//取到表中名为video列的值
            Session["id" + i] = biao.Rows[i - 1]["id"].ToString();//获取表中名为id列的值
            Session["piclj"] = picname;//获取到图片的名称
            Session["videolj" + i] = videoname;//获取到视频的名称

            object o = FindControl("ImageButton" + i);
            object cs1 = FindControl("LinkButton" + (i + 8));
            if (o != null && o is ImageButton)
            {
                ImageButton t = (ImageButton)o;
                LinkButton cs2 = (LinkButton)cs1;
                t.ImageUrl = Session["piclj"].ToString();
                cs2.Text = name;
            }
        }
        for (int j = biao.Rows.Count + 1; j <= 10; j++)//其他为 敬请期待
        {
            object o = FindControl("ImageButton" + j);
            object cs1 = FindControl("LinkButton" + (j + 8));
            if (o != null && o is ImageButton)
            {
                ImageButton t = (ImageButton)o;
                LinkButton cs2 = (LinkButton)cs1;
                t.ImageUrl = "fm/敬请期待.jpg";
                cs2.Text = "敬请期待";
            }
        }
    }
    #endregion

    #region 删除
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (LinkButton9.Text != "敬请期待")
        {
            if (s.del(LinkButton9.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }
    
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (LinkButton10.Text != "敬请期待")
        {
            if (s.del(LinkButton10.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (LinkButton11.Text != "敬请期待")
        {
            if (s.del(LinkButton11.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        if (LinkButton12.Text != "敬请期待")
        {
            if (s.del(LinkButton12.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        if (LinkButton13.Text != "敬请期待")
        {
            if (s.del(LinkButton13.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        if (LinkButton14.Text != "敬请期待")
        {
            if (s.del(LinkButton14.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        if (LinkButton15.Text != "敬请期待")
        {
            if (s.del(LinkButton15.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        if (LinkButton16.Text != "敬请期待")
        {
            if (s.del(LinkButton16.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        if (LinkButton17.Text != "敬请期待")
        {
            if (s.del(LinkButton17.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        if (LinkButton18.Text != "敬请期待")
        {
            if (s.del(LinkButton18.Text))
            {
                Response.Write("<script>alert('删除成功！')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }
    #endregion

    #region 判断启用注册
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        if (Session["username"].ToString() != "游客"&&LinkButton8.Text!="审核")
        {
            Response.Redirect("zc.aspx");
        }
        else
        {
            Response.Redirect("sh.aspx");
        }
    }
    #endregion

    #region LinkButton跳转
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        if (LinkButton9.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        if (LinkButton10.Text != "敬请期待")
        {
            Session["pd"] = "pd2";
            Response.Redirect("videobf.aspx");
        }
    }
    protected void LinkButton11_Click1(object sender, EventArgs e)
    {
        if (LinkButton11.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        if (LinkButton12.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        if (LinkButton13.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        if (LinkButton14.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        if (LinkButton15.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        if (LinkButton16.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        if (LinkButton17.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }

    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        if (LinkButton18.Text != "敬请期待")
        {
            Session["pd"] = "pd1";
            Response.Redirect("videobf.aspx");
        }
    }
    #endregion

    #region 修改
    protected void Button13_Click(object sender, EventArgs e)
    {
        if (LinkButton9.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton9.Text;
            Session["picxg"] = ImageButton1.ImageUrl;
            Session["xg"] = "xg1";
            Session["idpd"] = Session["id1"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        if (LinkButton10.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton10.Text;
            Session["picxg"] = ImageButton2.ImageUrl;
            Session["xg"] = "xg2";
            Session["idpd"] = Session["id2"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        if (LinkButton11.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton11.Text;
            Session["picxg"] = ImageButton3.ImageUrl;
            Session["xg"] = "xg3";
            Session["idpd"] = Session["id3"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        if (LinkButton12.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton12.Text;
            Session["picxg"] = ImageButton4.ImageUrl;
            Session["xg"] = "xg4";
            Session["idpd"] = Session["id4"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        if (LinkButton13.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton13.Text;
            Session["picxg"] = ImageButton5.ImageUrl;
            Session["xg"] = "xg5";
            Session["idpd"] = Session["id5"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        if (LinkButton14.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton14.Text;
            Session["picxg"] = ImageButton6.ImageUrl;
            Session["xg"] = "xg6";
            Session["idpd"] = Session["id6"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        if (LinkButton15.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton15.Text;
            Session["picxg"] = ImageButton7.ImageUrl;
            Session["xg"] = "xg7";
            Session["idpd"] = Session["id7"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        if (LinkButton16.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton16.Text;
            Session["picxg"] = ImageButton8.ImageUrl;
            Session["xg"] = "xg8";
            Session["idpd"] = Session["id8"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        if (LinkButton17.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton17.Text;
            Session["picxg"] = ImageButton9.ImageUrl;
            Session["xg"] = "xg9";
            Session["idpd"] = Session["id9"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        if (LinkButton18.Text != "敬请期待")
        {
            Session["xgname"] = LinkButton18.Text;
            Session["picxg"] = ImageButton10.ImageUrl;
            Session["xg"] = "xg10";
            Session["idpd"] = Session["id10"];
            Response.Redirect("insert.aspx");
        }
        else
        {
            Response.Write("<script>alert('没有该视频')</script>");
        }
    }
    #endregion

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}