//import { moveUp } from './movUp.js'
//var i = 1;
//var Time = new Date;
//var startTime = Time.getTime();
//var interval = setInterval(moveUp, 4000);

function beginGame() {
    var Time = new Date;
    this.startTime = Time.getTime();
    this.interval = setInterval(moveUp, 4000);
}
var i = 0
function moveUp() {
    this.nowTime = new Date;
    console.log(i);
    //20秒结束
    console.log(this.interval);
    console.log(this.startTime);
    if (nowTime.getTime() - this.startTime > (20 * 1000)) {
        clearInterval(this.interval);
    }



    i++
}

beginGame();