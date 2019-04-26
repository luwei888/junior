
//作业
//1.不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。

//2.统计出这段文字中有多少个单词：
//There are two ways to create a RegExp object: a literal notation and a constructor.
//To indicate strings, the parameters to the literal notation do not use quotation marks while 
//the parameters to the constructor function do use quotation - marks.So the following
//expressions create the same regular expression


//1.不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
turnString('hello,yuanzhan')
function turnString(string) {
    var turnStr = "";
    for (var j = 0; j < string.length; j++) {
        turnStr = turnStr + string[string.length - j - 1];
    }
    return turnStr;
}



//2.统计出这段文字中有多少个单词：
//There are two ways to create a RegExp object: a literal notation and a constructor.
//To indicate strings, the parameters to the literal notation do not use quotation marks while 
//the parameters to the constructor function do use quotation - marks.So the following
//expressions create the same regular expression
var demo = "There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings, the parameters to the literal notation do not use quotation marks while the parameters to the constructor function do use quotation - marks.So the following expressions create the same regular expression "

findWordNumber("There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings, the parameters to the literal notation do not use quotation marks while the parameters to the constructor function do use quotation - marks.So the following expressions create the same regular expression ")

function findWordNumber(string) {
    var number = 0;
    for (var i = 1; i < string.length; i++) {
        var temp1 = string[i].charCodeAt();
        var temp2 = string[i - 1].charCodeAt();
        //当不是英文单词的符号前面为英文单词，英文单词数量加1；
        if (!isWord(temp1)) {
            if (isWord(temp2)) {
                number++;
            }
        }
    }
    return number;
}

function isWord(word) {
    if ((word >= 65 & word <= 90) | (word >= 97 & word <= 122)) {
        return true;
    }
    return false;
}
