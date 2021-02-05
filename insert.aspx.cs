using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Windows.Input;
using System.Threading;
using BLL;

public partial class insert : System.Web.UI.Page
{
    PD s = new PD();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Session["xg"]!=null)
            {
                TextBox1.Text = Session["xgname"].ToString();//name赋值

                Session["imgname"] = Session["picxg"];

                int IndexofA = Session["picxg"].ToString().LastIndexOf("/");
                int IndexofB = Session["picxg"].ToString().LastIndexOf(".");
                Label3.Text = Session["picxg"].ToString().Substring(IndexofA + 1, IndexofB - IndexofA + 3);//pic路径赋值

                Label1.Visible = false;
                Label2.Visible = false;
                for (int i = 1; i <= 10; i++)
                {
                    if (Session["xg"].ToString() == "xg"+i)
                    {
                        string video= Session["videolj" + i].ToString();
                        Session["videoname"] = Session["videolj" + i];

                        int cs1 = video.LastIndexOf("/");
                        int cs2 = video.LastIndexOf(".");
                        Label4.Text = video.Substring(cs1 + 1, cs2 - cs1 + 3);//video路径赋值
                        break;
                    }
                }

                if (Session["dmlxpd"].ToString() == "gm") DropDownList1.SelectedIndex = 0;
                else if (Session["dmlxpd"].ToString() == "rm") DropDownList1.SelectedIndex = 1;
                else if (Session["dmlxpd"].ToString() == "zh") DropDownList1.SelectedIndex = 2;//下拉列表赋值
                Button1.Text = "修改";

                Page page = (Page)HttpContext.Current.Handler;
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('body').style=\"background-image:url('fm/xgbj.jpg');background-size:cover;color:white;\"</script>");
            }
            xl();
        }
    }
    public void xl()
    {
        DropDownList1.DataSource =s.chalx();
        DropDownList1.DataTextField = "lx";
        DropDownList1.DataValueField = "id";
        DataBind();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String fliname1 = FileUpload1.FileName.ToString();
        int flisize1 = FileUpload1.PostedFile.ContentLength / 1024;
        if(fliname1=="") Label3.Text = "请选择文件";
        else if (fliname1.EndsWith(".jpg") || fliname1.EndsWith(".png") || fliname1.EndsWith(".gif"))
        {
            if (flisize1 < 3000)
            {
                String path = Server.MapPath("~\\fm\\" + fliname1);
                FileUpload1.SaveAs(path);
                Label3.Text = "上传成功";
                int IndexofA = path.LastIndexOf("\\");
                int IndexofB = path.LastIndexOf(".");
                Session["imgname"] ="fm/"+path.Substring(IndexofA + 1, IndexofB - IndexofA + 3);
                Label1.Visible = false;
                if (Button1.Text == "修改")
                {
                    Page page = (Page)HttpContext.Current.Handler;
                    page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('body').style=\"background-image:url('fm/xgbj.jpg');background-size:cover;color:white;\"</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('文件过大')</script>");
            }
        }
        else
        {
            Label3.Text = "文件类型不正确";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        
        String fliname2 = FileUpload2.FileName.ToString();
        if (fliname2 == "") Label4.Text = "请选择文件";
        else if (fliname2.EndsWith(".mp4") || fliname2.EndsWith(".avi") || fliname2.EndsWith(".wmv"))
        {
            String path = Server.MapPath("~\\video\\" + fliname2);
            FileUpload2.SaveAs(path);
            Label4.Text = "上传成功";
            int IndexofA = path.LastIndexOf("\\");
            int IndexofB = path.LastIndexOf(".");
            Session["videoname"] = "video/" + path.Substring(IndexofA + 1, IndexofB - IndexofA + 3);
            Label2.Visible = false;
            if (Button1.Text == "修改")
            {
                Page page = (Page)HttpContext.Current.Handler;
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('body').style=\"background-image:url('fm/xgbj.jpg');background-size:cover;color:white;\"</script>");
            }
        }
        else
        {
            Label4.Text = "文件类型不正确";
        }
        String tp = FileUpload1.FileName.ToString();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string name;
        if (TextBox1.Text.Length != 0)
        {
            name = TextBox1.Text;
        }
        else name = "";
        int lx = int.Parse(DropDownList1.SelectedValue);
        string picname = Session["imgname"].ToString();
        string videoname = Session["videoname"].ToString();
        

        if (Button1.Text != "修改")
        {
            if (s.zeng(name, lx, picname, videoname,"正在审核"))
            {
                Response.Write("<script>alert('新增成功')</script>");
                Response.Redirect("Main.aspx");
            }
        }
        else if (Button1.Text == "修改")
        {
            string id = Session["idpd"].ToString();
            if (s.gai(id, name, lx, picname, videoname))
            {
                Response.Write("<script>alert('修改成功')</script>");
                Response.Redirect("Main.aspx");
            }
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}