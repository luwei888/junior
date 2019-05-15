


export class ranMole {
    constructor() {
        this.result = "";
        this.id = "";
        let ran = Math.floor(Math.random() * 3);
        //萌鼹鼠
        if (ran === 0) {
            this.result = "./打地鼠/萌地鼠.png";
            this.id = "goodMole"
        } else if (ran === 1) {
            this.result = "./打地鼠/坏地鼠.png";
            this.id = "badMole"
        } else if (ran === 2) {
            this.result = "./打地鼠/地雷.png"
            this.id = "mine"
        } else { };
    }
}