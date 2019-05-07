
var oBtn = document.getElementById("btn");

//点击提交运行方程
oBtn.onclick = function () {
    //捕获开始结束时间
    var startTime = Date.parse(document.getElementById("startTime").value);
    var endData = Date.parse(document.getElementById("endTime").value);
    //实例一个Course
    var luwei = new Course(startTime);
    //将结束时间存入实例中
    luwei.endTime = endData;
    luwei.money();
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
        alert(`学习日期${studyTime}天,学费${money}元`);
    }
}
