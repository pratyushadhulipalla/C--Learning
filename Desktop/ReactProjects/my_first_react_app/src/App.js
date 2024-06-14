import React from 'react';
import { useState, useEffect } from 'react';

import  MovieCard  from './MovieCard';

import './App.css';
import SeacrhIcon from './search.svg';

//7d07c1af


const API_URL = 'http://www.omdbapi.com?apikey=7d07c1af';

const movie1 = {
    "Title": "Amazing Spiderman Syndrome",
    "Year": "2012",
    "imdbID": "tt2586634",
    "Type": "movie",
    "Poster": "N/A"
}


const App = () => {
    const [movies, setMovies] = useState([]);


    const searchMovies = async (title) => {
        const response = await fetch(`${API_URL}&s=${title}`);
        const data =  response.json();


        setMovies(data.Search);
    }

    useEffect(() => {
        searchMovies('Spiderman');
    }, []);

    return (
        <div className="app">
            <h1>MovieLand</h1>

            <div className="search">
                <input 
                  placeholder='Search for movies'
                  value = 'Superman'
                  onChange={() => {}}
                />
                <img
                  src={SeacrhIcon}
                  alt="search"
                  onClick={() => {}}
                />
            </div>
            {
                movies?.length > 0
                  ? (
                    <div className ="container">
                        {movies.map((movie) => (
                            <MovieCard movie = {movie} />
                        ))}
                        
                    </div>
                  ) : (
                    <div className = "empty">
                        <h2>No movies found</h2>

                    </div>
                  )
            }
            
        </div>
    )
}


export default App;
