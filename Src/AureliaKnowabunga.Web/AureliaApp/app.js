import {HttpClient} from "aurelia-http-client";

export class App {
    constructor () {
        this.message = "";
        this.http = new HttpClient();
    }

    activate () {
        return this.http.get("/api/movies")
            .then(hrm => {
                this.movies = JSON.parse(hrm.response);
            });
    }

    changeMessage () {
        this.message = "Goodbye";
    }
}