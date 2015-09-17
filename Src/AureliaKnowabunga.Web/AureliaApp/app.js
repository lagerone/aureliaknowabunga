import {inject} from "aurelia-framework";
import {MovieData} from "./MovieData";

@inject(MovieData)
export class App {
    constructor (movieData) {
        this.movieData = movieData;
    }

    activate () {
        return this.movieData.getAll()
            .then(movies => this.movies = movies);
    }
}