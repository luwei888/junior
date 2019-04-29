
function findtime() {
    var javaTime = document.getElementsByName('java').length;
    var CrawlerTime = document.getElementsByName('Crawler').length;
    var Python = document.getElementsByName('Python').length;
    var programmingLanguage = document.getElementsByName('programmingLanguage').length;

    //var btn = document.getElementsByName();
    for (var i = 0; i < javaTime-1; i++) {
        document.getElementsByName('java')[i].onmouseover = function () {
            console.log(`使用${javaTime}次`);
        }
    }

}

findtime();

//var btns = document.getElementsByTagName('button');
//for (let i = 0; i < btns.length; i++) {
//    var btn = btns[i];
//    btn.onclick = function () { changeColor(this.style.color) };
//}