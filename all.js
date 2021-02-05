function yclabel1() {
    document.getElementById("Label1").style.display = "none";//隐藏label
    var fmname = document.getElementById("FileUpload1").value;
    if (fmname.lastIndexOf("\\" > 0)) var filename = fmname.substring(fmname.lastIndexOf("\\") + 1, fmname.length);      //如果\后面还有值，就把路径从\开始赋值给filename

    document.getElementById("Label3").innerHTML = filename;//将label3显示为filename
}
function yclabel2() {
    document.getElementById("Label2").style.display = "none";
    var fmname = document.getElementById("FileUpload2").value;
    if (fmname.lastIndexOf("\\" > 0)) var filename = fmname.substring(fmname.lastIndexOf("\\") + 1, fmname.length);      //如果\后面还有值，就把路径从\开始赋值给filename

    document.getElementById("Label4").innerHTML = filename;//将label4显示为filename
}
function onmouseovered(id) {
    document.getElementById(id).setAttribute("style", "color:darkorange;text-decoration:none;font-size:32px;");//设置linkbutton的鼠标经过样式
}
function onmouseouted(id) {
    document.getElementById(id).setAttribute("style", "color:white;text-decoration:none;font-size:32px;");//设置linkbutton的鼠标脱离样式
}
function onmouseovereddlzc(id) {
    document.getElementById(id).setAttribute("style", "color:darkcyan;text-decoration:none;font-size:18px;");//设置linkbutton的鼠标经过样式
}
function onmouseouteddlzc(id) {
    document.getElementById(id).setAttribute("style", "color:white;text-decoration:none;font-size:18px;");//设置linkbutton的鼠标脱离样式
}
function onmouseoveredss(id) {
    document.getElementById(id).setAttribute("style", "color:gray;text-decoration:none;font-size:26px;");//设置linkbutton的鼠标经过样式
}
function onmouseoutedss(id) {
    document.getElementById(id).setAttribute("style", "color:white;text-decoration:none;font-size:26px;");//设置linkbutton的鼠标脱离样式
}
function onmouseoveredz(id) {
    document.getElementById(id).setAttribute("style", "color:gray;height:100%;font-size:12px;");//设置左button的鼠标经过样式

    clearTimeout(time);
}
function onmouseoutedz(id) {
    document.getElementById(id).setAttribute("style", " background:transparent;color:black;height:100%;border:none;font-size:12px;");//设置左button的鼠标脱离样式

    time = setTimeout("startlb()", 1000);
}
function onmouseoveredy(id) {
    document.getElementById(id).setAttribute("style", "color:gray;height:100%;font-size:12px;float:right;");//设置右button的鼠标经过样式

    clearTimeout(time);
}
function onmouseoutedy(id) {
    document.getElementById(id).setAttribute("style", " background:transparent;color:black;height:100%;border:none;font-size:12px;float:right;");//设置右button的鼠标脱离样式

    time = setTimeout("startlb()", 1000);
}
var index = 1;
function startlb() { //开始轮播
    if (index >= 5) {
        index = 1;
        document.getElementById("lunbopic").src = "fm/1.jpg";
    }
    else {
        index++;
        document.getElementById("lunbopic").src = "fm/" + index + ".jpg";
    }
    time = setTimeout("startlb()", 1000);
}
function tpcs1()//点击左边按钮
{
    var filename = document.getElementById("lunbopic").src;
    var fileindex = filename.lastIndexOf('/') + 1;
    var newindex = filename.substring(fileindex);
    var num = newindex.split('.')[0];
    if (num == 1) {
        num = 5;
        document.getElementById("lunbopic").src = "fm/" + num + ".jpg"
    } else {
        num--;
        document.getElementById("lunbopic").src = "fm/" + num + ".jpg"
    }
    return false;//防止按钮刷新页面
}
function tpcs2()//点击右边按钮
{
    var filename = document.getElementById("lunbopic").src;
    var fileindex = filename.lastIndexOf('/') + 1;
    var newindex = filename.substring(fileindex);
    var num = newindex.split('.')[0];
    if (num == 5) {
        num = 1;
        document.getElementById("lunbopic").src = "fm/" + num + ".jpg"
    } else {
        num++;
        document.getElementById("lunbopic").src = "fm/" + num + ".jpg"
    }
    return false;//防止按钮刷新页面
}
function stoplunbo() {
    clearTimeout(time);
}
function startlunbo() {
    time = setTimeout("startlb()", 1000);
}


function videopd(id)//(万能的session)没用
{
    sessionStorage.setItem('key', id);
    return true;
}