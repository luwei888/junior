


var areaObj = document.getElementById("area2");
var moleObj = null;


//function init() {
//    moleObj = document.getElementById("mole2");
//    moveUp();
//}

//function moveUp() {
//    //改变鼹鼠的高度位置，形成上升效果。
//    moleObj.style["margin-top"] = parseInt(moleObj.style["margin-top"]) - 5 + "px";
//    //鼹鼠上升到一定位置后停止
//    if (+moleObj.style["margin-top"].slice(0,4) < -115) {
//        return;
//    }
//    setTimeout(moveUp, 10);
//}




var goodMole = document.createElement("img");
goodMole.id = "mole2";
goodMole.style = "margin-left:300px;margin-top:35px;"
goodMole.src = "./打地鼠/萌地鼠.png";

//插入鼹鼠
areaObj.insertBefore(goodMole, areaObj.nextSiblings);

$(document).ready(function () {
    $("mole2").animate({ top: '+=150px' });
});
