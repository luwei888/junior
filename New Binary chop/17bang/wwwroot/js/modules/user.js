//建立又一个module：user.js，里面有：

//三个属性：用户Id（Id）、昵称（name）、密码（password）
//一个静态方法：getNameById(id) ，返回一个字符串
//一个实例方法：login(name, password) ，返回一个整数值
//user.js默认对外暴露login() ，另外暴露getNameById() ，隐藏其他属性 

class user {
    constructor(Id, name, password) {
        this.Id = Id;
        this.name = name;
        this.password = password;
    }
    static getNameById(id) {
        return String;
    }
    login(name, password) {
        return Number;
    }
}

export default user.login;
export { getNameById };