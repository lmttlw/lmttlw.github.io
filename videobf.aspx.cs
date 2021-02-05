using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class videobf : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Page page = (Page)HttpContext.Current.Handler;
            #region 总
            if (Session["pd"].ToString() == "pd1"&&Session["dmlxpd"].ToString()=="gm")//国漫1
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '"+Session["videolj1"].ToString()+"';</script>");
            }
            else if (Session["pd"].ToString() == "pd2" && Session["dmlxpd"].ToString() == "gm")//国漫2
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj2"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd3" && Session["dmlxpd"].ToString()=="gm")//国漫3
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj3"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd4" && Session["dmlxpd"].ToString() == "gm")//国漫4
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj4"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd5" && Session["dmlxpd"].ToString() == "gm")//国漫5
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj5"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd6" && Session["dmlxpd"].ToString() == "gm")//国漫6
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj6"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd1" && Session["dmlxpd"].ToString() == "rm")//日漫1
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj1"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd2" && Session["dmlxpd"].ToString() == "rm")//日漫2
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj2"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd3" && Session["dmlxpd"].ToString() == "rm")//日漫3
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj3"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd4" && Session["dmlxpd"].ToString() == "rm")//日漫4
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj4"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd5" && Session["dmlxpd"].ToString() == "rm")//日漫5
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj5"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd6" && Session["dmlxpd"].ToString() == "rm")//日漫6
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj6"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd7" && Session["dmlxpd"].ToString() == "rm")//日漫7
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj7"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd8" && Session["dmlxpd"].ToString() == "rm")//日漫8
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj8"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd1" && Session["dmlxpd"].ToString() == "zh")//综合1
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj1"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd2" && Session["dmlxpd"].ToString() == "zh")//综合2
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj2"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd3" && Session["dmlxpd"].ToString() == "zh")//综合3
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj3"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd4" && Session["dmlxpd"].ToString() == "zh")//综合4
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj4"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd5" && Session["dmlxpd"].ToString() == "zh")//综合5
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj5"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd6" && Session["dmlxpd"].ToString() == "zh")//综合6
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '"+ Session["videolj6"].ToString()+ "';</script>");
            }
            else if (Session["pd"].ToString() == "pd7" && Session["dmlxpd"].ToString() == "zh")//综合7
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj7"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd8" && Session["dmlxpd"].ToString() == "zh")//综合8
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj8"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd1" && Session["dmlxpd"].ToString() == "ss")//搜索1
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj1"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd2" && Session["dmlxpd"].ToString() == "ss")//搜索2
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj2"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd3" && Session["dmlxpd"].ToString() == "ss")//搜索3
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj3"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd4" && Session["dmlxpd"].ToString() == "ss")//搜索4
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj4"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd5" && Session["dmlxpd"].ToString() == "ss")//搜索5
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj5"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd6" && Session["dmlxpd"].ToString() == "ss")//搜索6
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj6"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd7" && Session["dmlxpd"].ToString() == "ss")//搜索7
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj7"].ToString() + "';</script>");
            }
            else if (Session["pd"].ToString() == "pd8" && Session["dmlxpd"].ToString() == "ss")//搜索8
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "js", "<script>document.getElementById('video1').src = '" + Session["videolj8"].ToString() + "';</script>");
            }
            #endregion
        }
    }
}