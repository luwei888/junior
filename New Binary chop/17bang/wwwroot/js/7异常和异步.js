//使用setTimeout创建以下三个异步函数，分别使用普通callback方式和Promise方式，完成如下逻辑：

//1.getPassword(name) ：通过用户名获得他 / 她的密码
//2.login() ：如果密码正确，返回用户Id；否则，报一个异常
//3.getRecord() ：根据用户Id，返回该用户“打地鼠”游戏的最高记录
//4.捕获抛出的异常，输出（console.log）异常信息

//模拟Promise写一个MimicPromise类，能实现和Promise一样的功能（异步执行除外）


//(1) 普通callback方法
let name = "luwei";
setTimeout(function () {
    getPassword(name);
}, 3000)

//1.getPassword(name) ：通过用户名获得他 / 她的密码
function getPassword(name) {
    var password = "";
    //不知道什么密码，随便乱写
    password = name + "888";

}

//2.login() ：如果密码正确，返回用户Id；否则，报一个异常
function login() {

    throw
}

//3.getRecord() ：根据用户Id，返回该用户“打地鼠”游戏的最高记录
function getRecord() {

}