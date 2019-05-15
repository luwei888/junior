var moundObj = document.getElementById("mound1");
var areaObj = document.getElementById("area1");
var moleObj = null;
var animate;


function init() {
    moleObj = document.getElementById("mole1");
    moveUp();
}

function moveUp() {
    //改变鼹鼠的高度位置，形成上升效果。
    moleObj.style["margin-top"] = parseInt(moleObj.style["margin-top"]) - 10 + "px";
    //鼹鼠上升到一定位置后停止
    if (moleObj.y < 1380) {
        return;
    }
    animate = setTimeout(moveUp, 10);
}


var goodMole = document.createElement("img");
goodMole.id = "mole1";
goodMole.style = "margin-left:220px;margin-top:45px;"
goodMole.src = "./打地鼠/萌地鼠.png";

//插入鼹鼠
areaObj.insertBefore(goodMole, areaObj.nextSiblings);

init();


function random() {

}