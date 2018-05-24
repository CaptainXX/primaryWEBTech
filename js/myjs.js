// 标题皮一下
function mOver(obj){
    obj.innerHTML = "有本事你点一下！"
}
function mOut(obj){
obj.innerHTML = "Marking Some Food!"
}
function mDown(obj){
obj.innerHTML = "松开试试？"
}
function mUp(obj){
obj.innerHTML = "苟利国家生死以"
}

// 钟表
function Starttime(){
var weekday=new Array(7);
weekday[0]="星期日";
weekday[1]="星期一";
weekday[2]="星期二";
weekday[3]="星期三";
weekday[4]="星期四";
weekday[5]="星期五";
weekday[6]="星期六";
var today = new Date();
var y = today.getFullYear();
var mo = today.getMonth() + 1;
var d = today.getDate();
var h = today.getHours();
var m = today.getMinutes();
var s = today.getSeconds();
// add '0' in front of numbers < 10
m = checktime(m);
s = checktime(s);
document.getElementById("D").innerHTML=y + "年" + mo + "月" + d + "日 " + weekday[today.getDay()] + "<br />" + " " + h + ":" + m + ":" + s;
t = setTimeout('Starttime()', 500);

}
function checktime(i){
if (i<10){
    i = '0' + i;
    
}
return i;

}

// Jquery Ajax异步转载页面
function turnPage(url, div){
    $.ajax({
        type:"get",
        url:url,
        success:function(html){
            $(div).html(html);
        },
        error:function(XMLHttpRequest, textStatus, errorThrown){
            // 状态码
            console.log(XMLHttpRequest.status);
            // 状态
            console.log(XMLHttpRequest.readyState);
            // 错误信息   
            console.log(textStatus);

            console.log(errorThrown);
        }
    })
}

$(document).ready(function(){
    $(".flip1").click(function(){
        $(".panel1").slideToggle("slow");
      });
    });
$(document).ready(function(){
$(".flip2").click(function(){
    $(".panel2").slideToggle("slow");
  });
});
$(document).ready(function(){
    $(".flip3").click(function(){
        $(".panel3").slideToggle("slow");
      });
    });