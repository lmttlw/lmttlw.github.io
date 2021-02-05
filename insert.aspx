<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert.aspx.cs" Inherits="insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="all.js"></script>
    <style type="text/css">
        .insert{
            margin:0 auto;
            position:absolute;
            left:400px;
            top:150px;
            width:500px;
            text-align:center;
            height:350px;
            background-color:gray;
            opacity:0.3;
        }
        .selectimg,.selectvideo{
            float:left;
            width:250px;
        }
        .mytable{
            line-height:40px;
            
        }
        .xk{
            position:absolute;
            left:430px;
            top:170px;
        }
        /*.ts1{
            position:absolute;
            left:520px;
            top:290px;
        }
        .ts2{
            position:absolute;
            left:520px;
            top:335px;
        }*/
        /*td{
            border:1px black solid;
        }*/
        /*.an1{
            position:absolute;
            left:430px;
            top:380px;
        }
        .an2{
            position:absolute;
            left:570px;
            top:380px;
        }*/
    </style>
</head>
<body id="body" style="margin:0 auto;background-image:url('fm/insertbj.jpg');background-size:cover;color:white;">
    <form id="form1" runat="server">
    <div class="insert">
          
    </div>
        
        <div class="xk">
        <table class="mytable">
            <tr>
                <td>视频名称：</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="上传" OnClick="Button2_Click" /></td>
                

                <td><asp:FileUpload onchange="yclabel1()" ID="FileUpload1" runat="server" AllowMultiple="True" Width="60px" Text="" />&nbsp;&nbsp;</td>
                <td class="gd">
                    <asp:Label ID="Label3" runat="server" Width="100%" Font-Size="Smaller"></asp:Label></td>
                
            </tr>
            <tr>
                <td></td>
                <td style="line-height:20px;"><asp:Label ID="Label1" runat="server" Text="请选择封面" ForeColor="Red" Font-Size="Smaller" Height="20px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="上传" OnClick="Button3_Click" /></td>
                

                <td><asp:FileUpload onchange="yclabel2()" ID="FileUpload2" runat="server" Width="60px" />&nbsp;&nbsp;</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Width="100%" Font-Size="Smaller"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td style="line-height:20px;"><asp:Label ID="Label2" runat="server" Text="请选择视频" ForeColor="Red" Font-Size="Smaller"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
            </tr>
        </table>
            <asp:Button ID="Button1" runat="server" Text="新增" Height="30px" Width="100px" style="margin-top:20px;" OnClick="Button1_Click1" />
            <asp:Button ID="Button4" runat="server" Text="取消" Height="30px" Width="100px" style="margin-left:50px;" OnClick="Button4_Click" />
        </div>
        
        
    </form>
</body>
</html>
