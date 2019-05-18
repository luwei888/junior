//import { gameGather } from './gameGather.js'



function beginGame() {
    var Time = new Date;
    this.startTime = Time.getTime();
    this.interval = setInterval(moveUp, 4000);
}

function moveUp() {
    this.nowTime = new Date;
    //20秒结束
    if (nowTime.getTime() - this.startTime > (20 * 1000)) {
        clearInterval(this.interval);
    }

    gameGather();

}


//游戏整合
function gameGather() {
    //先寻找三个土堆出来
    var temp = randMound();

    //再随机出来鼹鼠，坏鼹鼠，地雷，插入
    insertMole(temp[0]);
    insertMole(temp[1]);
    insertMole(temp[2]);
    insertMole(temp[3]);


}


//随机土堆
function randMound() {
    let mound = [1, 2, 3, 4, 5, 6];
    let gain = [];
    let ranIndex = 0;
    for (var i = 0; i < 4; i++) {
        ranIndex = Math.floor(Math.random() * (6 - i));
        //将取得的土堆标号储存到数组
        gain.push(mound[ranIndex]);
        //将数组中已取的数删除
        mound.splice(ranIndex, 1);
    }
    return gain;
}


//随机鼹鼠，地雷
class randMole {
    constructor(id) {
        this.result = "";
        this.id = "mole" + id;
        this.value = "";
        let ran = Math.floor(Math.random() * 3);
        //萌鼹鼠
        if (ran === 0) {
            this.result = "./打地鼠/萌地鼠.png";
            this.value = "goodMole"
        } else if (ran === 1) {
            this.result = "./打地鼠/坏地鼠.png";
            this.value = "badMole"
        } else if (ran === 2) {
            this.result = "./打地鼠/地雷.png";
            this.value = "mine"
        } else { };
    }
}


//插入鼹鼠
function insertMole(value) {
    console.log(value);
    //随机鼹鼠
    var mound1 = new randMole(value);
    console.log(mound1.id);
    console.log(mound1.value);
    console.log(mound1.result);

    //将得到的三个属性传入 value ：图片的出现位置，图片的引用地址，图片的类型
    moleUp(value, mound1.result, mound1.value);
}


//鼹鼠上升
function moleUp(id, result, moleType) {

    let moleId = id;

    var areaObj = document.getElementById(`area${moleId}`);
    console.log(`area${moleId}`);
    var moleObj = null;

    function init() {
        moleObj = document.getElementById(`mole${moleId}`);
        moveUp();
    }

    function moveUp() {
        //改变鼹鼠的高度位置，形成上升效果。
        moleObj.style["margin-top"] = parseInt(moleObj.style["margin-top"]) - 10 + "px";
        //鼹鼠上升到一定位置后停止
        if (+moleObj.style["margin-top"].slice(0, 4) < -125) {
            return;
        }
        setTimeout(moveUp, 10);
    }


    var Mole = document.createElement("img");
    Mole.id = `mole${moleId}`;
    Mole.style = "margin-left:300px;margin-top:45px; ";




    console.log(Mole.style);
    Mole.src = result;

    //插入鼹鼠
    areaObj.insertBefore(Mole, areaObj.nextSiblings);

    console.log("Mole.id =" + Mole.id);
    var insertElement = document.getElementById(`${Mole.id}`);
    //绑定点击事件
    console.log("insertElement =" + insertElement);
    insertElement.onmousedown = six;

    function six() {
        console.log(moleType);
        if (moleType === "mine") {
            Mole.style = "width:400px;margin-left:200px;margin-top:-250px;";
            Mole.src = "./打地鼠/爆炸.png";
        } else if (moleType === "badMole") {
            Mole.src = "./打地鼠/晕老鼠.png"
        } else {
            Mole.src = "";
        }
    }


    //清除图片
    console.log("mole ID:" + moleId);
    //奇巧淫技 让setTimeout 传参
    function _clearMole(moleId) {
        return function () {
            clearMole(moleId);
        }
    }
    setTimeout(_clearMole(moleId), 3000);

    function clearMole(moleId) {
        console.log("mole Id:" + moleId);
        $(`#mole${moleId}`).remove();
    }

    //开始运行
    init();
}





beginGame();


