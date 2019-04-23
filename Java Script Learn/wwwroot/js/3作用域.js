
//作业
//在函数yz.fei.get986()中嵌入不带参数的函数has9() / has8() / has6() ，并调用上述函数，
//找出10000以内有多少个数字包含：9或者8或者6。

var yz = {};
yz.fei = {};
yz.fei.get986 = {};
yz.fei.get986.has9 = function () {
    var num9 = 0;
    for (let i = 1; i < number; i++) {
        if (ishas9(i)) {
            num9++;
        }
    }
    console.log(num9);

    function ishas9(n) {
        var str = String(n);
        for (let i = 0; i < str.length; i++) {
            if (str[i] == 9) {
                return true;
            }
        }
        return false;
    }
}


yz.fei.get986.has8 = function () {
    var num8 = 0;
    for (let i = 1; i < number; i++) {
        if (ishas8(i)) {
            num8++;
        }
    }
    console.log(num8);

    function ishas8(n) {
        var str = String(n);
        for (let i = 0; i < str.length; i++) {
            if (str[i] == 8) {
                return true;
            }
        }
        return false;
    }
}


yz.fei.get986.has6 = function () {
    var num6 = 0;
    for (let i = 1; i < number; i++) {
        if (ishas6(i)) {
            num6++;
        }
    }
    console.log(num6);

    function ishas6(n) {
        var str = String(n);
        for (let i = 0; i < str.length; i++) {
            if (str[i] == 6) {
                return true;
            }
        }
        return false;
    }
}


var number = 100;
yz.fei.get986.has9();
yz.fei.get986.has8();
yz.fei.get986.has6();