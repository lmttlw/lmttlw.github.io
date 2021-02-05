using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Dsql
    {
        DBHelper s = new DBHelper();
        public DataTable Login(string name,string pwd)//登录
        {
            string sql = "select * from UserMsg where name='" + name + "' and pwd='" + pwd + "'";
            return s.cha(sql);
        }
        public int zeng(string name,int lx,string img,string video,string sh)//新增
        {
            string sql = "insert data(name,lx,img,video,sh) values('" + name + "','" + lx + "','" + img + "','" + video + "','" + sh + "')";
            return s.zsg(sql);
        }
        public DataTable chalx()//下拉框赋值（类型）
        {
            return s.cha("select * from lxbiao");
        }
        public int del(string name)//删除
        {
            string sql = "delete data where name = '" + name + "'";
            return s.zsg(sql);
        }
        public int zc(string name,string pwd)//注册
        {
            string sql = "insert UserMsg(name,pwd) values('" + name + "','" + pwd + "')";
            return s.zsg(sql);
        }
        public int gai(string id,string name, int lx, string img, string video)//修改
        {
            string sql = "update data set name='"+name+"',lx="+lx+",img='"+img+"',video='"+video+"' where id='" + id + "'";
            return s.zsg(sql);
        }
        public DataTable pdsh()//查询正在审核的
        {
            string sql = "select * from data inner join lxbiao on data.lx=lxbiao.id where sh='正在审核'";
            return s.cha(sql);
        }
        public int sh(string id,string sf)//审核
        {
            string sql= "update data set sh='"+sf+"' where id='" + id + "'";
            return s.zsg(sql);
        }
        public DataTable show(string sql)//主页面显示
        {
            return s.cha(sql);
        }
    }
}
