//1.使用正则表达式判断某个字符串
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）

//2.JSON生成和解析
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示
//3.利用新学到的Array函数，重新完成之前的数组相关作业

//2073414181@qq.com   true
//Luwei.jin@outlook.com   true
//15736262776@163.com   true

//Luwei--@outlook.com false
//@2073414181@qq.com false
//1573626[][]@163.com false



//function isEmail(email) {
//var re = /^[\w.]+@\w+\.[a-z]+$/i;
//    if (re.test(email)) {
//        console.log(`${email}是合法的邮箱`);
//    } else {
//        console.log(`${email}不是合法的邮箱`);
//    }
//}

//isEmail("2073414181@qq.com");  
//isEmail("luwei.jin@outlook.com");  
//isEmail("15736262776@163.com");   
//isEmail("Luwei--@outlook.com");  
//isEmail("@2073414181@qq.com");
//isEmail("1573626[][]@163.com");
//isEmail("121e3ee.@!qq.2e2");
//isEmail("121e3ee.@!qq.2e2#");
//isEmail("121e3eeqq.2e2");
//isEmail("%121e3ee.@!qq.2e2");
//isEmail("121e3ee.@qq2e2");
//isEmail("     121e3ee.@qq2e2");
//isEmail("w21e3ee.@qq2.e2");



//是否是小数（正负小数都可以）
//1.65311 true
//0.548 true
//    - 20.5622 true

//20.3.55 false
//0.236jd false
//.235 false
//ajs12.52300 false
//020.3 false

//function isDecimal(number) {
//    var re = /^[+-]?[\d0]+\.[\d]+[1-9]+$/;
//    if (re.test(number)) {
//        console.log(`${number}是小数`);
//    } else {
//        console.log(`${number}不是小数`);
//    }
//}

//isDecimal("1.65311");
//isDecimal("0.548");
//isDecimal("-20.5622");
//isDecimal("20.3.55");
//isDecimal("0.236jd");
//isDecimal(".235");
//isDecimal("ajs12.52300");
//isDecimal("020.3");



//将所有以zyf- 开头的属性去掉zyf-

function deleteStr(str) {
    var regOfTag = /<[^/|.]+\/.>/ig;
    var tags = str.match(regOfTag);
    console.log(tags);
    var regOfProperty = /\s(zyf\-)[\S]*?=/g;
    var result = [];
    for (var i = 0; i < tags.length; i++) {
        result.push(tags[i].replace(regOfProperty, function (match, content) {
            console.log(match);
            console.log(content);
            return match.replace(content, "");
        }))
    }
    console.log(result);
}

deleteStr('<a zyf-href="zyf-s">zyf-lu</a> <p></p>');
deleteStr('<p zyf-class="zyf-skj"> </p>')




//var LaoCheng = {
//    name: '老程',
//    age: 21,
//    isFemale: true,
//    hobby: ['tabletennis', 'basketball', 'swim'],
//    course: {
//        'C#': 86,
//        'HTML/CSS/JavaScript': 95,
//        SQL: 92,
//        'ASP.NET': null
//    }
//}
//console.log(JSON.stringify(LaoCheng));
//console.log(JSON.stringify(LaoCheng, ['age']));
//console.log(JSON.stringify(LaoCheng, null, '   '));
//console.log(JSON.stringify(LaoCheng, function (key, value) {
//    if (typeof value === 'string') {
//        return value.toUpperCase();
//    }
//    return value;
//}));


//2.JSON生成和解析
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示

//var luwei = {
//    sketch: {
//        name: "金路炜",
//        nickna: "路炜",
//        age: 24,
//        gender: "gentleman",
//    },
//    hobby: ["learning", "I love learning", "Learning makes me happy"],
//    introduction: "一粒金丹吞入腹，始知我命不由天"
//}

//console.log(JSON.stringify(luwei));

//var LaoCheng = JSON.parse('{ "name": "小龙", "nickname": "江流儿", "age": 3, "isFamel": true, "hobby": ["eat", "drink", "goWhoring", "gamble"], "indroduce": "神一样男人" }')
//var LaoCheng = JSON.parse('{"name":"小程","QQname":"老程","age":41,"gender":"女","hobby":"blackmail,cheat,thief","introduction":"Never Mind the Scandal and Liber"}')



//1.删除一个数组里面重复的元素
//2.建立一个数组，里面混杂有整数、小数、正数、负数、字符串、布尔值等，
//找出数组里面最大的数（忽略其他类型）
//var s = new Set([8, 14, 8, '8', '14', 14, '8', true, false, true, true, false, '路炜', '路炜', '老程', '小龙', '小龙']);


//var arr = [8, '14', 8, '8', '14', 14, '8', true, false, true, true, false, '路炜', '路炜', '老程', '小龙', '小龙'];

//var arr1 = arr.sort(function (a, b) {
//    if (typeof a !== "string" || typeof b !== "string") {
//        if (a < b) {
//            return 1;
//        } else if (a > b) {
//            return -1;
//        } else {
//            return 0;
//        }
//    }
//});
//console.log(arr1);
//console.log(arr1[0]);