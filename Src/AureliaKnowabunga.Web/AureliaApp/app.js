export class App {
    constructor () {
        this.message = "";
    }

    activate () {
        this.message = "Hello";
    }

    changeMessage () {
        this.message = "Goodbye";
    }
}