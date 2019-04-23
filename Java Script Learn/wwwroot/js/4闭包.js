////作业
////在函数student()中声明了函数域变量name、age和female，使用闭包机制，将其暴露到函数外部


////第一种方法
//function student() {
//    var name = "luwei";
//    var age = 24;
//    var female = false;
//    var arr = [];
//    arr[0] = name;
//    arr[1] = age;
//    arr[2] = female;
//    return function () {
//        return arr;
//    }
//}

//var luwei = student()();
//for (var i = 0; i < luwei.length; i++) {
//    console.log(luwei()[i]);
//}


////第二种方法
//function student() {
//    var name = "luwei";
//    var age = 24;
//    var female = false;
//    var arr = [];
//    arr[0] = name;
//    arr[1] = age;
//    arr[2] = female;
//    var Arr = [];
//    for (let i = 0; i < 3; i++) {
//        Arr[i] = function () {
//            return arr[i];
//        };
//    }
//    return Arr;
//}

//var luwei = student();
//for (var i = 0; i < luwei.length; i++) {
//    console.log(luwei[i]());
//}


////解释以下代码运行结果：
function foo(x) {
    var tmp = 3;
    return function (y) {
        //3.	此时x = x ? x + 1 : 1; 中两个x都为 - 1 为true 运算为 - 1 + 1 最后x = 0；
        x = x ? x + 1 : 1;
        //4.	最后得到0 + 3 + 10 =13；
        console.log(x + y + tmp);
    }
}

//1.	bar 为foo（1）的返回函数，此时function foo（） 内的 x为 - 1；
var bar = foo(-1);
//2.	bar（10）运行 foo（）内的 返回函数
bar(10);




//3.改动以下代码，让其输出如图所示，并说明理由。

function buildList(list) {
    var result = [];
    for (let i = 0; i < list.length; i++) {
        result.push(function () {
            console.log('item' + i + ': ' + list[i])
        });
    }
    return result;
}


(function () {
    var fnlist = buildList([1, 2, 3]);
    for (var i = 0; i < fnlist.length; i++) {
        fnlist[i]();
    }
})();

