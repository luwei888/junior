//1.使用正则表达式判断某个字符串
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）

//2.JSON生成和解析
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示
//利用新学到的Array函数，重新完成之前的数组相关作业

//function isEmail(email) {
//    var re = /^[\w.]+@\w+\.[a-z]+$/i;

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


function isDecimal(number) {
    var re = /^-?[\d0]+\.[\d]+[1-9]+$/;
    if (re.test(number)) {
        console.log(`${number}是小数`);
    } else {
        console.log(`${number}不是小数`);
    }
}

isDecimal("1.65311");
isDecimal("0.548");
isDecimal("-20.5622");
isDecimal("20.3.55");
isDecimal("0.236jd");
isDecimal(".235");
isDecimal("ajs12.52300");
isDecimal("020.3");





