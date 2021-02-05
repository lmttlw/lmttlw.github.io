<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zc.aspx.cs" Inherits="zc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style >
        div{

        }
        body{
            background-image:url('fm/zcbj.png');
            background-size:cover;
            margin:0 auto;
            text-align:center;
        }
        .zk{
             width:450px;
             height:310px;
             opacity:0.65;
             background-color: #15181C;
             position:absolute;
             top:170px;
             left:390px;
             
        }
        .xk
        {
            font-family:Arial;
             font-size:x-large;
             color:white;
        }
        .xkqr
        {
            font-family:Arial;
             font-size:x-large;
             color:white;
             padding-right:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        
    <div class="zk"><br />
        <div class="xk">注册</div>
        <div class="xk">用户名：<asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="200px"></asp:TextBox><br />
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="请输入用户名" Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
        </div>
        <div class="xk">密&nbsp;&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="TextBox2" runat="server" Height="30px" TextMode="Password" Width="200px"></asp:TextBox><br />
            &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="请输入密码" Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
        </div>
        <div class="xkqr">确认密码：<asp:TextBox ID="TextBox3" runat="server" Height="30px" TextMode="Password" Width="200px"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="请确认密码" Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
        </div>
        <br />
        <div class="xk">
            <asp:Button ID="Button1" runat="server" Text="变成光" Font-Size="X-Large" ForeColor="Black" Width="100px" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="返回" Font-Size="X-Large" ForeColor="Black" Width="100px" OnClick="Button2_Click" /></div>
    </div>
    </form>
</body>
</html>
