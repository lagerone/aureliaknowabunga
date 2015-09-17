import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

@inject(HttpClient)
export class MovieData {
    constructor (httpClient) {
        this.httpClient = httpClient;
    }

    getAll () {
        return this.httpClient.get("/api/movies")
            .then(response => {
                return response.content;
            });
    }
}