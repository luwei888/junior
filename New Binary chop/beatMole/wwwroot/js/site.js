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
    insertMole(temp[0]);
    insertMole(temp[1]);
    insertMole(temp[2]);
    //再随机出来鼹鼠，坏鼹鼠，地雷

}


//随机土堆
function randMound() {
    let mound = [1, 2, 3, 4, 5, 6];
    let gain = [];
    let ranIndex = 0;
    for (var i = 0; i < 3; i++) {
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
    var mound1 = new randMole(value);
    console.log(mound1.id);
    console.log(mound1.value);
    console.log(mound1.result);

    //将得到的三个属性传入
    moleUp(value, mound1.result);


}


//鼹鼠上升
function moleUp(id,result) {

    var areaObj = document.getElementById(`area${id}`);
    console.log(`area${id}`);
    var moleObj = null;

    function init() {
        moleObj = document.getElementById(`mole${id}`);
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
    Mole.id = `mole${id}`;
    
    Mole.style = "margin-left:300px;margin-top:45px;"
    Mole.src = result;

    //插入鼹鼠
    areaObj.insertBefore(Mole,areaObj.nextSiblings);

    init();

    //清除图片

}

//清除图片
function clearMole(id) {
    var box = document.getElementById(`mole${id}`);
    box.removeNode(true);
}



beginGame();
