﻿using MoviesBot.Data.MovieData.Model;
using System.Collections.Generic;


namespace MoviesBot
{
    interface IMovieService
    {
        List<Movie> SearchMovies(string query);
        Movie SingleMovieSearch(string query);
        string GetRandomFrom250();
        List<Actor> SearchActors(string query);
        List<Movie> GetNowPlaying();
    }
}
