//作业：

//1.最封装作业的基础上，为Course添加两个子类：主修课（MajorCourse）和辅修课（ElectiveCourse）
//2.声明一个Stundent类，包含name和score两个属性，让Course的Students包含的是Student的对象
//3.主修课需要参加考试，所以有一个Exam(student)方法；辅修课只需要测评，所以有一个方法Assess(student)
//4.声明一个MajorCourse的实例，运行它的Exam(student)方法，结束课程（使用end()方法），并给该student的score赋值为50 - 100的随机整数
//5.声明一个ElectiveCourse的实例，运行它的Exam(student)方法，结束课程（使用end()方法），给该student的score赋值为ABCDE中的一个随机值
//6.给Course声明一个静态的GetStudentsByName(name) ，能根据不同的name返回不同的整数值（参加该course的学生数量）
//7.在子类调用GetStudentsByName(name)
//8.说明：为什么子类可以继承父类的实例和静态方法？


//1.最封装作业的基础上，为Course添加两个子类：主修课（MajorCourse）和辅修课（ElectiveCourse）
//class Course {
//    constructor(name, startDate, endDate/* studentName, studentScore*/) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        //this.studentName = studentName;
//        //this.studentScore = studentScore;
//        this.students = new Student("luwei", 88);
//    }
//    begin() {
//        console.log(this.name + "开始时间为：" + this.startDate);
//        console.log(`${this.students.name}同学，成绩为${this.students.score}`);
//    }
//    end() {
//        this.students.score = Math.floor(Math.random() * (100 - 50 + 1) + 50);
//        //console.log(this.name + "结束时间为：" + this.endDate);
//    }
//}

//3.主修课需要参加考试，所以有一个Exam(student)方法；辅修课只需要测评，所以有一个方法Assess(student)
//class MajorCourse extends Course {
//    constructor(students) {
//        super(students);
//    }
//    Exam() {
//        super.end();
//        console.log(`${this.students.name}同学，成绩为${this.students.score}`);
//    }
//}







//2.声明一个Student类，包含name和score两个属性，让Course的Students包含的是Student的对象
//class Student {
//    constructor(name, score) {
//        this.name = name;
//        this.score = score;
//    }
//}

//var JavaScript = new Course("JS", "2019-4-20", "2019-5-15");
//var SQL = new Course("SQL", "2019-3-20", "2019-4-15");

//4.声明一个MajorCourse的实例，运行它的Exam(student)方法，结束课程（使用end()方法），
//并给该student的score赋值为50 - 100的随机整数
//var advancedMath = new MajorCourse;
//advancedMath.Exam();


//5.声明一个ElectiveCourse的实例，运行它的Exam(student)方法，结束课程
//（使用end()方法），给该student的score赋值为ABCDE中的一个随机值
//class Course {
//    constructor(name, startDate, endDate/* studentName, studentScore*/) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        //this.studentName = studentName;
//        //this.studentScore = studentScore;
//        this.students = new Student("luwei", 88);
//    }
//    begin() {
//        console.log(this.name + "开始时间为：" + this.startDate);
//        console.log(`${this.students.name}同学，成绩为${this.students.score}`);
//    }
//    end() {
//        this.students.score = randomScore();
//        //console.log(this.name + "结束时间为：" + this.endDate);
//    }
//}

//class ElectiveCourse extends Course {
//    constructor(students) {
//        super(students)
//    }
//    Assess() {
//        super.end();
//        console.log(`${this.students.name}同学，成绩为${this.students.score}`);
//    }
//}


//function randomScore() {
//    var temp = ["A", "B", "C", "D", "E",];
//    var index = Math.floor(Math.random() * 5);
//    var score = temp[index];
//    return score;
//}

//var popMusic = new ElectiveCourse;
//popMusic.Assess();



//6.给Course声明一个静态的GetStudentsByName(name) ，
//能根据不同的name返回不同的整数值（参加该course的学生数量）
//class Course {
//    constructor(name, startDate, endDate/* studentName, studentScore*/) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        //this.studentName = studentName;
//        //this.studentScore = studentScore;
//        this.students = new Student("luwei", 88);
//    }
//    begin() {
//        console.log(this.name + "开始时间为：" + this.startDate);
//        console.log(`${this.students.name}同学，成绩为${this.students.score}`);
//    }
//    end() {
//        this.students.score = randomScore();
//        //console.log(this.name + "结束时间为：" + this.endDate);
//    }

//    static GetStudentsByName(name) {
//        var stuNumber = 0;
//        if (name === "popMusic") {
//            stuNumber = 100;
//        } else if (name === "advancedMath") {
//            stuNumber = 10;
//        } else {
//            stuNumber = 50;
//        }
//        console.log(`${name}课有${stuNumber}学生`);
//        return stuNumber;
//    }
//}

//Course.GetStudentsByName("popMusic");



//7.在子类调用GetStudentsByName(name)
//class ElectiveCourse extends Course {
//    constructor(name) {
//        super(name);
//    }

//    getNumber() {
//        Course.GetStudentsByName(this.name);
//    }

//    Assess() {
//        super.end();
//        console.log(`${this.students.name}同学，成绩为${this.students.score}`);
//    }
//}

//var popMusic = new ElectiveCourse("popMusic");
//popMusic.getNumber();


//8.说明：为什么子类可以继承父类的实例和静态方法？
//(1).静态方法都可以使用，并不需要继承
//(2).JS子类的

// 定义一个动物类
function Animal(name) {
    // 属性
    this.name = name || 'Animal';
    // 实例方法
    this.sleep = function () {
        console.log(this.name + '正在睡觉！');
    }
}
// 原型方法
Animal.prototype.eat = function (food) {
    console.log(this.name + '正在吃：' + food);
};

function Cat() {
}
Cat.prototype = new Animal();
Cat.prototype.name = 'cat';

//　Test Code
var cat = new Cat();
console.log(cat.name);
console.log(cat.eat('fish'));
console.log(cat.sleep());
console.log(cat instanceof Animal); //true 
console.log(cat instanceof Cat); //true