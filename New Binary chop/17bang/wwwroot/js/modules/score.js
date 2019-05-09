export class score {
    constructor() {
        var dateTime = new Date;
        var playerName = "";
        var score = "";
    }
    static getBest(playName) {
        this.playName = playName;
        return new score;
    }

    save() {

    }

}

var bestOfAll;
export { bestOfAll as record };
//score.getBest();
//var six = new score;