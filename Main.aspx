<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="all.js"></script>
    <style type="text/css">
        .bj1{
            background-image:url('fm/mainbj.jpg');
            background-size:cover;
            height:300px;
        }
        .lbk{
            width:400px;
            height:250px;
            position:absolute;
            top:100px;
            left:400px;
            border:1px red solid;
            margin:0 auto;
            background-color:gray;
        }
        .lb{
            width:100%;
            text-align:center;
            height:90px;
            line-height:80px;
            background-color:lightslategray;
            opacity:0.9;
        }
        .ss{
            position:absolute;
            width:100%;
            text-align:center;
            top:350px;
        }
        .loge{
             height:90px;
             position:absolute;
             left:40px;
        }
        .dlzc{
            position:absolute;
            right:100px;
            top:30px;
        }
        .spdk{
            margin-top:20px;
        }
        .spxk{
            margin-top:20px;
            width:19%;
            float:left;
            margin-left:10px;
            text-align:center;
            
        }
        a:hover { text-decoration: underline; }
    </style>
</head>
<body onload="startlb()" style="margin:0 auto;">
    <form id="form1" runat="server">
        <img class="loge" src="fm/星空.png"/><%--loge--%>
        <div class="lb">
            
            <asp:LinkButton ID="LinkButton1" runat="server" Text="国漫" ForeColor="White" Font-Size="XX-Large" style="TEXT-DECORATION: none" onmouseover="onmouseovered(this.id)" onmouseout="onmouseouted(this.id)" OnClick="LinkButton1_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" Text="日漫" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovered(this.id)" onmouseout="onmouseouted(this.id)" Font-Size="XX-Large" OnClick="LinkButton2_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton3" runat="server" Text="综合" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovered(this.id)" onmouseout="onmouseouted(this.id)" Font-Size="XX-Large" OnClick="LinkButton3_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton4" runat="server" Text="排行榜" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovered(this.id)" onmouseout="onmouseouted(this.id)" Font-Size="XX-Large"></asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton5" runat="server" Text="退出登录" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovered(this.id)" onmouseout="onmouseouted(this.id)" Font-Size="XX-Large" OnClick="LinkButton5_Click"></asp:LinkButton>
        </div>
        <div class="dlzc"><%--新增登录注册--%>
            <asp:LinkButton ID="LinkButton19" runat="server" Text="上传视频" Font-Size="Large" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovereddlzc(this.id)" onmouseout="onmouseouteddlzc(this.id)" OnClick="LinkButton19_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton7" runat="server" Text="登录" Font-Size="Large" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovereddlzc(this.id)" onmouseout="onmouseouteddlzc(this.id)" OnClick="LinkButton7_Click" ></asp:LinkButton>&nbsp;  &nbsp;<asp:LinkButton ID="LinkButton8" runat="server" Text="注册" Font-Size="Large" ForeColor="White" style="TEXT-DECORATION: none" onmouseover="onmouseovereddlzc(this.id)" onmouseout="onmouseouteddlzc(this.id)" OnClick="LinkButton8_Click" ></asp:LinkButton>
        </div>
        <div class="ss"><%--搜索--%>
            <asp:TextBox ID="TextBox1" runat="server" Width="300px" Height="30px" placeholder="请输入动漫名称或关键字"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton6" runat="server" Text="搜索" style="TEXT-DECORATION: none" ForeColor="Black" Font-Size="X-Large" onmouseover="onmouseoveredss(this.id)" onmouseout="onmouseoutedss(this.id)" OnClick="LinkButton6_Click"></asp:LinkButton>
        </div>
    <div class="bj1"></div>                         <%--背景1--%>
        <div class="lbk">                           <%--轮播框--%>
            <asp:Button OnClientClick="javascript:return tpcs1()" onmouseover="onmouseoveredz(this.id)" onmouseout="onmouseoutedz(this.id)" ID="Button1" runat="server" Text="<" Width="40px" BorderStyle="None" Height="100%" />
            <asp:Button OnClientClick="javascript:return tpcs2()" onmouseover="onmouseoveredy  (this.id)" onmouseout="onmouseoutedy(this.id)" ID="Button2" runat="server" Text="&gt;" BorderStyle="None" Height="100%" Width="40px" style="float:right;" ForeColor="Black"/>
            <asp:Image onmouseover="stoplunbo()" onmouseout="startlunbo()" ID="lunbopic" runat="server" style="width:340px;height:100%;position:absolute;left:30px; top: 0px;" />
        </div>
        <div class="spdk">                          <%--视频大div--%>
            <div class="spxk">
               <asp:ImageButton  OnClientClick="javascript:return videopd(id)" OnClick="ImageButton1_Click" ID="ImageButton1" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button13" runat="server" Text="修改" OnClick="Button13_Click" /><asp:LinkButton ID="LinkButton9" runat="server" style="TEXT-DECORATION: none;" OnClick="LinkButton9_Click">LinkButton</asp:LinkButton>
                
                <asp:Button ID="Button3" runat="server" Text="删除" OnClick="Button3_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton2_Click"  ID="ImageButton2" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button14" runat="server" Text="修改" OnClick="Button14_Click" /><asp:LinkButton ID="LinkButton10" runat="server" style="TEXT-DECORATION: none" OnClick="LinkButton10_Click"></asp:LinkButton>
                <asp:Button ID="Button4" runat="server" Text="删除" OnClick="Button4_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton3_Click"  ID="ImageButton3" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button15" runat="server" Text="修改" OnClick="Button15_Click" /><asp:LinkButton ID="LinkButton11" runat="server" style="TEXT-DECORATION: none" OnClick="LinkButton11_Click1"></asp:LinkButton>
                <asp:Button ID="Button5" runat="server" Text="删除" OnClick="Button5_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton4_Click"  ID="ImageButton4" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button16" runat="server" Text="修改" OnClick="Button16_Click" /><asp:LinkButton ID="LinkButton12" runat="server" style="TEXT-DECORATION: none" OnClick="LinkButton12_Click"></asp:LinkButton>
                <asp:Button ID="Button6" runat="server" Text="删除" OnClick="Button6_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton5_Click"  ID="ImageButton5" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button17" runat="server" Text="修改" OnClick="Button17_Click" /><asp:LinkButton ID="LinkButton13" runat="server" style="TEXT-DECORATION: none">LinkButton</asp:LinkButton>
                <asp:Button ID="Button7" runat="server" Text="删除" OnClick="Button7_Click" />
            </div>
        </div>
        <div class="spdk"><%--视频大div--%>
            <div class="spxk">
               <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton6_Click"   ID="ImageButton6" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button18" runat="server" Text="修改" OnClick="Button18_Click" /><asp:LinkButton ID="LinkButton14" runat="server" style="TEXT-DECORATION: none">LinkButton</asp:LinkButton>
                <asp:Button ID="Button8" runat="server" Text="删除" OnClick="Button8_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton7_Click"  ID="ImageButton7" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button19" runat="server" Text="修改" OnClick="Button19_Click" /><asp:LinkButton ID="LinkButton15" runat="server" style="TEXT-DECORATION: none">LinkButton</asp:LinkButton>
                <asp:Button ID="Button9" runat="server" Text="删除" OnClick="Button9_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton8_Click"  ID="ImageButton8" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button20" runat="server" Text="修改" OnClick="Button20_Click" /><asp:LinkButton ID="LinkButton16" runat="server" style="TEXT-DECORATION: none">LinkButton</asp:LinkButton>
                <asp:Button ID="Button10" runat="server" Text="删除" OnClick="Button10_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton9_Click"  ID="ImageButton9" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button21" runat="server" Text="修改" OnClick="Button21_Click" /><asp:LinkButton ID="LinkButton17" runat="server" style="TEXT-DECORATION: none">LinkButton</asp:LinkButton>
                <asp:Button ID="Button11" runat="server" Text="删除" OnClick="Button11_Click" />
            </div>
            <div class="spxk">
                <asp:ImageButton OnClientClick="javascript:return videopd(id)" OnClick="ImageButton10_Click"  ID="ImageButton10" runat="server" Width="100%" Height="150px" /><asp:Button ID="Button22" runat="server" Text="修改" OnClick="Button22_Click" /><asp:LinkButton ID="LinkButton18" runat="server" style="TEXT-DECORATION: none">LinkButton</asp:LinkButton>
                <asp:Button ID="Button12" runat="server" Text="删除" OnClick="Button12_Click" />
            </div>
        </div>
    </form>
</body>
</html>
