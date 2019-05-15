
//六个土堆随机取3个出事件


var startTime = new Date;
export function roundMound() {
    let mound = [1, 2, 3, 4, 5, 6];
    let ranIndex = 0;
    for (var i = 0; i < 3; i++) {
        ranIndex = Math.floor(Math.random() * (3 - i));
        mound[ranIndex];
        //将取得的土堆标号传出去

        //将数组中已取的数删除
        mound.splice(ranIndex, 1);
    }
}
