
//作业
//在函数yz.fei.get986()中嵌入不带参数的函数has9() / has8() / has6() ，并调用上述函数，
//找出10000以内有多少个数字包含：9或者8或者6。

var yz = {};
yz.fei = {};
yz.fei.get986 = {};
yz.fei.get986 = function (number) {
    var num = 0;
    for (var i = 1; i < number; i++) {
        var str = i.toString();
        var is9 = (function has9() {
            if (str.indexOf("9") != -1) {
                return true;
            }
            else { return false };
        })();
        var is8 = (function has8() {
            if (str.indexOf("8") != -1) {
                return true;
            }
            else return false;
        })();
        var is6 = (function has6() {
            if (str.indexOf("6") != -1) {
                return true;
            }
            else return false;
        })();

        if (is9 | is8 | is6) {
            num++;
        }
    }
    return num;
}

var number = 10000;
yz.fei.get986(number);
