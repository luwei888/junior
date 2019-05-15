import { moveUp } from './movUp.js'

function beginGame() {
    var startTime = new Date;
    setInterval(moveUp(startTime), 4000);

}
var i = 1;
var Time = new Date;
var startTime = Time.getTime();
var interval = setInterval(moveUp, 4000);

function moveUp() {
    var nowTime = new Date;
    console.log(i);
    if (nowTime.getTime() - startTime > (20 * 1000)) {
        clearInterval(interval)
    }
    i++
}