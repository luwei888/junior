//Q1
function findbigreward() {
    var num = 0;
    for (let i = 0; i < document.getElementsByClassName("message").length; i++) {
        var reward = +document.getElementsByClassName("message")[i].getElementsByClassName("status")[0].
            getElementsByTagName("span")[2].lastChild.data
        if (reward > 1) {
            num++;
        }
    }
    console.log(num);
}
findbigreward();

//Q2
function changeTagColor() {
    for (let i = 0; i < document.getElementsByClassName("message").length; i++) {
        var temp = document.getElementsByClassName("message")[i].getElementsByTagName("div")[0].
            firstElementChild.firstChild.data
        if (temp === "协助中") {
            changeColor("gray", i);
        }
    }

    function changeColor(color, i) {
        document.getElementsByClassName("message")[i].getElementsByTagName("h3")[0].
            firstElementChild.style.color = color;
    }
}
changeTagColor();