//作业：

//1.使用setTimeout()实现每隔1秒钟依次显示：第n周，源栈同学random人
//2.完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^

//Q1
function showNum() {
    var n = 0;
    function show() {
        n++;
        var ran = Math.floor(Math.random() * 50);
        alert(`第${n}周` + `源栈同学${ran}人`)
    }
    setInterval(show, 1000);
}

showNum();


//Q2

function beginGame() {
    if (confi()) {
        guess();
    }
}

function confi() {
    return confirm("请按确定开始猜数字游戏");
}

function guess() {
    var ran = Math.floor(Math.random() * 1000);
    var guessTime = 0;
    while (true) {
        guessTime++;
        if (guessTime > 10) {
            alert("^ (*￣(oo) ￣) ^");
            break;
        }
        var surmise = +prompt(`第${guessTime}次猜测，请输入正整数!`);
        if (ran !== surmise) {
            difference(ran, surmise);
        }
        else {
            output(guessTime);
        }
    }
}

function difference(ran, surmise) {
    if (surmise < ran) {
        alert("小了，再猜")
    }
    if (surmise > ran) {
        alert("大了，再猜")
    }
}

function output(guessTime) {
    if (guessTime < 6) {
        alert("碉堡了！");
    }
    else {
        if (guessTime < 8) {
            alert("666");
        }
        else {
            alert("猜到了。");
        }
    }
}


beginGame();