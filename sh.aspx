<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sh.aspx.cs" Inherits="sh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="all.js" type="text/javascript"></script>
    <style type="text/css">
        .shdk
        {
            position:absolute;
            top:150px;
            left:200px;
        }
        td
        {
            width:200px;
        }
        .fh
        {
            position:absolute;
            top:100px;
            right:100px;
        }
        .auto-style1 {
            width: 100px;
        }
        .auto-style2 {
            width: 100px;
        }
    </style>
</head>
<body style="background-image:url('fm/shbj.jpg');background-size:cover;color:white;text-align:center;">
    <form id="form1" runat="server">
    <div class="shdk">
    <table>
        <tr>
            <td>
                <asp:ImageButton  OnClientClick="javascript:return videopd(id)" OnClick="ImageButton1_Click" ID="ImageButton1" runat="server" Width="100%" Height="150px" />
            </td>
            <td class="auto-style1">

                <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td class="auto-style2">

                <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td>

                <asp:Button ID="Button1" runat="server" Text="通过" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="不通过" OnClick="Button2_Click" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton  OnClientClick="javascript:return videopd(id)" ID="ImageButton2" runat="server" Width="100%" Height="150px" OnClick="ImageButton2_Click" />
            </td>
            <td class="auto-style1">

                <asp:Label ID="Label3" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td class="auto-style2">

                <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td>

                <asp:Button ID="Button3" runat="server" Text="通过" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="不通过" OnClick="Button4_Click" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton  OnClientClick="javascript:return videopd(id)" ID="ImageButton3" runat="server" Width="100%" Height="150px" OnClick="ImageButton3_Click" />
            </td>
            <td class="auto-style1">

                <asp:Label ID="Label5" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td class="auto-style2">

                <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td>

                <asp:Button ID="Button5" runat="server" Text="通过" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" Text="不通过" OnClick="Button6_Click" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton  OnClientClick="javascript:return videopd(id)" ID="ImageButton4" runat="server" Width="100%" Height="150px" OnClick="ImageButton4_Click" />
            </td>
            <td class="auto-style1">

                <asp:Label ID="Label7" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td class="auto-style2">

                <asp:Label ID="Label8" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>

            </td>
            <td>

                <asp:Button ID="Button7" runat="server" Text="通过" OnClick="Button7_Click" />
                <asp:Button ID="Button8" runat="server" Text="不通过" OnClick="Button8_Click" />

            </td>
        </tr>
    </table>
    </div>
        <div class="fh">
            <asp:Button ID="Button9" runat="server" Text="返回主页" Height="50px" Width="100px" OnClick="Button9_Click" />
        </div>
    </form>
</body>
</html>
