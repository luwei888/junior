//作业
//1.用class声明一个课程（Course），包含属性：name，startDate，endDate，students，
//以及方法：begin()和end()
//2.生成两个课程对象：JavaScript和SQL
//3.调用对象的begin()和end()方法，可以在控制台输出开课信息，如：JavaScript于2019年5月5日开课，
//共有5名同学（两开花、王枫、王平、采铃、老程）报名。
//4.不修改class，动态的改变begin()方法，使其能影响所有Course对象
//5.让end()方法为各自对象“自有”，其他对象无法修改



//1.用class声明一个课程（Course），包含属性：name，startDate，endDate，students，
//以及方法：begin()和end()
class Course {
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
    }
    begin() {
        console.log(this.name + "开始时间为：" + this.startDate);
        console.log(`共有${students.length}为同学：${students}`)
    }
    end() {
        console.log(this.name + "结束时间为：" + this.endDate);
        console.log(`共有${students.length}为同学：${students}`);
    }
}

//2.生成两个课程对象：JavaScript和SQL
var students = ["老程", "路炜", "老赵", "小龙", "子祥"];
var JavaScript = new Course("JS", "2019-4-20", "2019-5-15", students);
var SQL = new Course("SQL", "2019-3-20", "2019-4-15", students);


//3.调用对象的begin()和end()方法，可以在控制台输出开课信息，如：JavaScript于2019年5月5日开课，
//共有5名同学（两开花、王枫、王平、采铃、老程）报名。
//JavaScript.begin();
//JavaScript.end();
//SQL.begin();
//SQL.end();

//4.不修改class，动态的改变begin()方法，使其能影响所有Course对象
//JavaScript.__proto__.begin = function () {
//    alert(this.name + "开始时间为：" + this.startDate);
//}
////或
//Course.prototype.begin = function () {
//    alert(this.name + "开始时间为：" + this.startDate);
//}

//JavaScript.begin();
//SQL.begin();

//5.让end()方法为各自对象“私有”，其他对象无法修改
delete Course.prototype.begin;
Course.prototype.begin = function () {
    console.log("自有属性")
}

//JavaScript.__proto__.begin = function () {
//    alert(this.name + "开始时间为：" + this.startDate);
//}

//JavaScript.begin();
SQL.begin();


//6.在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天 
//见JS学费计算器及tuitionCount页面


//7.判断并证明以下说法：

//ES里的class其实就是一个function
//class student {
//    hello() {
//        console.log("大家好")
//    }
//}
//typeof student; true

//constructor总是返回class的实例
//var luwei = new student();
//luwei.constructor;

//当new了一个class之后，class里声明的方法就会被copy到新生成的实例对象上
//luwei.hasOwnProperty("hello") false

//JavaScript里面，类就是对象，对象也是类


//只有Function才有prototype


//Javascript是动态类型语言，所以对象的类型是可以随意更改的
//class student {
//    hello() {
//        console.log("666");
//    }
//}

//class gentlemen {
//    hello() {
//        console.log("888")
//    }
//}

//var luwei = new student();
//luwei.hello();
//luwei = new gentlemen;
//luwei.hello();    true