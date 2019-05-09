
var oBtn = document.getElementById("btn");

//点击提交运行方程
oBtn.onclick = function () {
    //捕获开始结束时间
    var endTime;
    var startDate = new Date(document.getElementById("startTime").value);

    var startTime = Date.parse(document.getElementById("startTime").value);

    var studyTime = +document.getElementById("learnTime").value;
    var unit = document.getElementById("unit").value;
    if (unit === "月") {
        var month = studyTime + startDate.getMonth();
        var year = 0;
        if (studyTime + startDate.getMonth() > 11) {
            month = Math.abs(studyTime - startDate.getMonth());
            year = 1;
        }
        endTime = startDate.setMonth(month);
    } else if (unit === "周") {
        endTime = startTime + studyTime * 7 * 24 * 3600 * 1000;
    } else if (unit === "日") {
        endTime = startTime + studyTime * 24 * 3600 * 1000;
    }
    //实例一个Course
    var study = new Course(startTime);
    //将结束时间存入实例中
    study.endTime = endTime;
    study.money();
};

class Course {
    constructor(startTime) {
        this._startTime = startTime;
    }

    get endTime() {
        return this.endTime;
    }
    set endTime(endTime) {
        if (endTime - this._startTime < 0) {
            console.log("错误啦，开始比结束时间还小");
            throw 'error';
        } else if (endTime - this._startTime > 31536000000) {
            console.log("学太久啦");
            throw 'error';
        } else {
            this._endTime = endTime;
        }
    }

    money() {
        var studyTime = (this._endTime - this._startTime) / 1000 / 3600 / 24;
        var money = studyTime / 7 * 986;
        alert(`学习日期${studyTime}天,结束日期为${getLocalTime(this._endTime)},学费${money}元`);
    }
}

function getLocalTime(nS) {
    return new Date(parseInt(nS)).toLocaleString().replace(/:\d{1,2}$/, ' ');
}

//1.若一位同学从2019年5月5号入栈，学习4个月整，同时享受押金1000元顶2000元的优惠。
//经计算后，为学习到2019年9月5号，总共123天，换算为17.5周，计算出学费为17325元，


//2.另一位同学从2019年5月6日入栈，学习20周整得出结果为，出栈时间2019年9月24日，
//总学费19720元。
