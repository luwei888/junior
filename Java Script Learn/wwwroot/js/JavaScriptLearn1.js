
////作业
////1.利用javascript计算出：[(23 + 7)x12 - 8]÷6的值
////2.利用循环，计算出1 + 3 +5+ 7 +...+99=?
////3.将源栈同学姓名 / 昵称装入数组，再根据该数组输出共有多少同学
////4.在上述数组头部加上小雨老师，末尾加上大飞哥
////5.创建一个随机整数数组：长度不大于10，元素不大于100，然后找出其中的最大数
////6.建立一个数组，里面混杂有整数、小数、正数、负数、字符串、布尔值等，找出数组里面最大的数（忽略其他类型）
////7.如果一个数只能被1和它自己整除，这个数就被称之为“素数”。请找出100以内的所有素数。
////8.删除一个数组里面重复的元素
////9.编写一个计算源栈返还红包金额的函数 redbag() ，参考：
////10.使用JavaScript内置字符串函数，将 “‘源栈’：飞哥小班教学，线下免费收看” 变成：“大神"小"班教学，线上免费收看”。
////11.将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，所有字符串：
////（1）首字母大写开头，其他字母小写
////（2）截去超过6个字符的部分，如'community'将变成'Commun'

////1.利用javascript计算出：[(23 + 7)x12 - 8]÷6的值
//var count = 0;
//count = [(23 + 7) * 12 - 8] / 6;
//alert(count);

////2.利用循环，计算出1 + 3 +5+ 7 +...+99=?
//var sum = 0;
//for (var i = 1; i <= 99; i = i + 2) {
//    sum = sum + i;
//}
//alert(sum);

////3.将源栈同学姓名 / 昵称装入数组，再根据该数组输出共有多少同学
//var array = ['女生', '路炜', '小龙', '子祥', '老程', '老赵', '王锋', '明辉', '文轩'];
//alert(array.length);

////4.在上述数组头部加上小雨老师，末尾加上大飞哥
//var arrayconcathead = ['小余老师'];
//var arrayconcatfoot = ['大飞哥'];
//var concattemp = arrayconcathead.concat(array);
//var concatarray = array.concat(arrayconcatfoot);

//array.unshift('小余老师');
//array[array.length] = '大飞哥';

////5.创建一个随机整数数组：长度不大于10，元素不大于100，然后找出其中的最大数
//var radarray = new Array;
//for (var i = 0; i < 9; i++) {
//    radarray[i] = math.floor(math.random() * (100 - 0)) + 0;
//}

//var max = radarray[0];
//for (var i = 0; i < radarray.length; i++) {
//    if (max < radarray[i]) {
//        max = radarray[i];
//    }
//}

////6.建立一个数组，里面混杂有整数、小数、正数、负数、字符串、布尔值等，
////找出数组里面最大的数（忽略其他类型）
//var chaosarray = [3.4, 7.4, 10, -15, -36, 'adf', 'fje', 'fjo', true, true, false, true, false];
//var max = 0;
//for (var i = 0; i < chaosarray.length; i++) {
//    if (typeof (chaosarray[i]) === "number") {
//        if (max < chaosarray[i]) {
//            max = chaosarray[i];
//        }
//    }
//    else;
//}

////7.如果一个数只能被1和它自己整除，这个数就被称之为“素数”。请找出100以内的所有素数。
//(1)
function findPrime(max) {
    var primarynumber = [];
    var judge = false;
    for (var i = 2; i <= max; i++) {
        for (var j = 2; j < i; j++) {
            if (i % j === 0) {
                judge = true;
            }
            else;
        }
        if (judge === false) {
            primarynumber.push(i)
            index++;
        }
        judge = false;
    }
    return primarynumber;
}

////8.删除一个数组里面重复的元素
//var array = [8, 14, 8, '8', '14', 14, '8', true, false, true, true, false, '路炜', '路炜', '老程', '小龙', '小龙'];
//var compare;
//for (var i = 0; i < array.length; i++) {
//    compare = array[i];
//    for (var j = i + 1; j < array.length; j++) {
//        if (compare === array[j]) {
//            array.splice(j, 1);
//            i--;
//        }
//        else;
//    }
//}

////9.编写一个计算源栈返还红包金额的函数 redbag() ，参考：






////10.使用JavaScript内置字符串函数，将 “‘源栈’：飞哥小班教学，线下免费收看” 变成：
////“大神"小"班教学，线上免费收看”。

//var str = "‘源栈’：飞哥小班教学，线下免费收看 "
//str = str.replace(/小/, '"小"');
//str = str.replace(/飞哥/, "大神");


////11.将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，所有字符串：
////（1）首字母大写开头，其他字母小写
////（2）截去超过6个字符的部分，如'community'将变成'Commun'

//(1)
var arr = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
var str;
var firstStr;
//遍历数组每个元素
for (var i = 0; i < arr.length; i++) {
    str = arr[i];
    //将字符串每个字母变小写
    str = str.toLowerCase();
    firstStr = str[0];
    //将字符串变大写替换
    str = str.replace(str[0], firstStr.toUpperCase());
    arr[i] = str;
}

//(2)
//遍历数组每个元素
var str;
for (var i = 0; i < arr.length; i++) {
    str = arr[i];
    //将字符串字符大于6的截断
    if (str.length > 6) {
        str = str.substring(0, 6)
    } else;
    arr[i] = str;
}
