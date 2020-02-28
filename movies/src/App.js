import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';
import Axios from 'axios';
import { render } from '@testing-library/react';

class App extends Component{

  constructor(){
    super();

    this.state = {
      moviesList: []
    }
  }




  componentDidMount(){
    Axios.get('https://api.themoviedb.org/3/movie/popular?api_key=ef39202b98727e6ae5aa343ec621b037').then(response=>{
      //takes the movie list from the the movie db and assigns each movie object to the moviesList (I think)
      this.setState({moviesList: response.data.results})
    });
  }
  

  render(){
    console.log(this.state.moviesList);
    const imgURL = 'http://image.tmdb.org/t/p/original'
    const movies = this.state.moviesList.map((movie, index)=>{
      return(
        <div className = 'movie-card'>
          <img src = {imgURL+movie.poster_path}></img>
          <p>{movie.title}</p>
        </div>



               
      )
    });
       
  return (
    <div className = "body">
    <div className="Text">
        <h1>Today's Most Popular Movies</h1>
        <h3>From The Movie Database</h3>
      <div className="App">

        
        {movies}
        </div>
        </div>
    </div>
  );
  }
}


export default App;
