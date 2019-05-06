

var oBtn = document.getElementById("btn");
oBtn.onclick = function () {
    var startTime = Date.parse(document.getElementById("startTime").value);
    var endTime = Date.parse(document.getElementById("endTime").value);
    var studyWeek = (endTime - startTime) / 1000 / 3600 / 24 / 7;
    var money = studyWeek * 986;
    alert(`学习${studyWeek}周，学费为${money}`);
};
