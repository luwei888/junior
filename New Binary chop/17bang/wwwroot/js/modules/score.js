//1.建立第一个module：score.js，里面有一个类score：

//含参构造函数，能给当前实例的属性赋值：时间（datetime = 当前时间），玩家Id（playerName）和成绩（score）
//静态方法：getBest(playName) ，返回一个score对象
//实例方法：save()
//score.js对外所有成员，但bestOfAll对外名称为record
//score.js中的getBest()利用user.js的getNameById() ，将玩家名称转换成Id 

import * as user from "./user.js";

export class score {
    constructor(playerName, score) {
        this.dateTime = new Date;
        this.playerName;
        this.score;
    }
    static getBest(playName) {
        this.playerName = user.getNameById(playName);
        return new score;
    }

    save() {

    }

}

var bestOfAll;
export { bestOfAll as record };
//score.getBest();
//var six = new score;