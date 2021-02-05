<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style >
        div{

        }
        body{
            background-image:url('fm/loginbg.jpg');
            background-size:cover;
            margin:0 auto;
            text-align:center;
        }
        .zk{
             width:450px;
             height:300px;
             opacity:0.65;
             background-color: #15181C;
             position:absolute;
             top:170px;
             left:390px;
             
        }
        .xk
        {
            margin-top:20px;
            font-family:Arial;
             font-size:x-large;
             color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
    <div class="zk">
        <div class="xk">登录</div>
        <div class="xk">用户名：<asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="200px"></asp:TextBox><br />
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="请输入用户名" Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
        </div>
        <div class="xk">密&nbsp;&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="TextBox2" runat="server" Height="30px" TextMode="Password" Width="200px"></asp:TextBox>
            
            <br />
            <asp:Label ID="Label2" runat="server" Text="请输入密码" Font-Size="Smaller" ForeColor="Red" Visible="False"></asp:Label>
        </div>
        <div class="xk">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="记住密码" Font-Size="Smaller" />
        </div>
        <div class="xk">
            <asp:Button ID="Button3" runat="server" Text="游客登录" Font-Size="X-Large" ForeColor="Black" Width="110px" OnClick="Button3_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="登录" Font-Size="X-Large" ForeColor="Black" Width="100px" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="注册" Font-Size="X-Large" ForeColor="Black" Width="100px" OnClick="Button2_Click" /></div>
    </div>
    </form>
</body>
</html>
