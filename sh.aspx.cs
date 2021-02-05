using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

public partial class sh : System.Web.UI.Page
{
    PD s = new PD();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable biao = new DataTable();
        biao = s.pdsh();

        for (int i = 1; i <= biao.Rows.Count; i++)
        {
            string name = biao.Rows[i - 1]["name"].ToString();//取到表中名为name列的值
            string lx = biao.Rows[i - 1][7].ToString();//取到表中名为lx列的值
            string picname = biao.Rows[i - 1]["img"].ToString();//取到表中名为img列的值
            string videoname = biao.Rows[i - 1]["video"].ToString();//取到表中名为video列的值
            Session["id" + i] = biao.Rows[i - 1]["id"].ToString();//获取表中名为id列的值
            Session["piclj"] = picname;//获取到图片的名称
            Session["videolj" + i] = videoname;//获取到视频的名称

            object o = FindControl("ImageButton" + i);
            object cs1 = FindControl("Label" + (2*i-1));
            object lbl1 = FindControl("Label" + i*2);
            if (o != null && cs1 != null&& lbl1 != null)
            {
                ImageButton t = (ImageButton)o;
                Label cs2 = (Label)cs1;
                Label lbl2 = (Label)lbl1;
                t.ImageUrl = Session["piclj"].ToString();
                cs2.Text = name;
                lbl2.Text = lx;
            }
        }
        for (int j = biao.Rows.Count + 1; j <= 4; j++)//其他隐藏
        {
            object o = FindControl("ImageButton" + j);
            object cs1 = FindControl("Label" + (2 * j - 1));
            object lbl1 = FindControl("Label" + j * 2);
            object a1 = FindControl("Button" + (2 * j - 1));
            object an1 = FindControl("Button" + j * 2);
            if (o != null && cs1 != null && lbl1 != null && a1 != null && an1 != null)
            {
                ImageButton t = (ImageButton)o;
                Label cs2 = (Label)cs1;
                Label lbl2 = (Label)lbl1;
                Button a2 = (Button)a1;
                Button an2 = (Button)an1;
                t.Visible = false;
                t.Enabled = false;
                cs2.Visible = false;
                cs2.Enabled = false;
                lbl2.Visible = false;
                lbl2.Enabled = false;
                a2.Visible = false;
                a2.Enabled = false;
                an2.Visible = false;
                an2.Enabled = false;
            }
            
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["pd"] = "pd1";
        Response.Redirect("videobf.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["pd"] = "pd2";
        Response.Redirect("videobf.aspx");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session["pd"] = "pd3";
        Response.Redirect("videobf.aspx");
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Session["pd"] = "pd4";
        Response.Redirect("videobf.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(s.sh(Session["id1"].ToString(),"通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id1"].ToString(), "不通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id2"].ToString(), "通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id2"].ToString(), "不通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id3"].ToString(), "通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id3"].ToString(), "不通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id4"].ToString(), "通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        if (s.sh(Session["id4"].ToString(), "不通过"))
        {
            Response.Redirect("sh.aspx");
        }
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}