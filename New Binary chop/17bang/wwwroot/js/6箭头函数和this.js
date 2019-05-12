//1.判断并证明事件处理函数中的this，等于target还是currentTarget
//2.已有如下代码：
//var sname = "飞哥";
//var a = {
//    sname: '老程',
//    fn: function () {
//        console.log(this.sname);
//    }
//}

//3.请用不同的方式调用fn()函数，能分别打印出‘飞哥’和‘老程’
//4.不改变上述代码，分别使用call()和apply() ，打印出‘文轩’和‘两开花’
//5.将fn()永久拷贝到showName() ，始终打印‘源栈最棒！^ _ ^’


var sname = "飞哥";
var a = {
    sname: '老程',
    fn: function () {
        console.log(this.sname);
    }
}

//3.请用不同的方式调用fn()函数，能分别打印出‘飞哥’和‘老程’
a.fn();  //老程

var o = {};
o.sname = sname;
o.fn = a.fn;
o.fn(); //飞哥


//4.不改变上述代码，分别使用call()和apply() ，打印出‘文轩’和‘两开花’

a.fn.call({ sname: "文轩" });
a.fn.apply({ sname: "两开花" });


//5.将fn()永久拷贝到showName() ，始终打印‘源栈最棒！^ _ ^’

let showName = a.fn.bind({ sname: "源栈最棒！^ _ ^" });