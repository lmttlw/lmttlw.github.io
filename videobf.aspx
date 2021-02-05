<%@ Page Language="C#" AutoEventWireup="true" CodeFile="videobf.aspx.cs" Inherits="videobf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="all.js"></script>
</head>
<body onload="videoload()">
    <form id="form1" runat="server">
    <div>
        <video id="video1" autoplay="autoplay" loop="loop" controls="controls" style="width:800px;"></video>
    </div>
    </form>
</body>
</html>
