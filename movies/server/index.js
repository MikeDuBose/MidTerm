const express = require('express');
const cors = require('cors');
const {json} = require('body-parser');
const axios = require('axios');


//Initialize server
const app = express();
const port = 3001;

//Middlewares
app.use(cors());
app.use(json());

//Endpoints
app.get('https://api.themoviedb.org/3/movie/popular?api_key=ef39202b98727e6ae5aa343ec621b037'), (req, res, next)=>{
    res.status(200).json(response.data);
}


app.listen(port, ()=> {
    console.log('server is alive on the port ' + port);
})