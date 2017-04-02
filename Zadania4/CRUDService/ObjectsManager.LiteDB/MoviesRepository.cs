using LiteDB;
using ObjectsManager.Interfaces;
using ObjectsManager.LiteDB.Model;
using ObjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsManager.LiteDB
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly string _moviesConnection = DatabaseConnections.MovieConnection;
        public int Add(Movie movie)
        {
            using(var db = new LiteDatabase(this._moviesConnection))
            {
                var dbObject = InverseMap(movie);

                var repository = db.GetCollection<MovieDB>("movies");
                if (repository.FindById(movie.Id) != null)
                    repository.Update(dbObject);
                else
                    repository.Insert(dbObject);

                return dbObject.Id;
            }
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Movie Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            using(var db = new LiteDatabase(this._moviesConnection))
            {
                var respotory = db.GetCollection<MovieDB>("movies");
                var results = respotory.FindAll();

                return results.Select(x => Map(x)).ToList();
            }
        }

        public Movie Update(Movie movie)
        {
            throw new NotImplementedException();
        }

        internal Movie Map(MovieDB dbMovie)
        {
            if (dbMovie == null)
                return null;
            return new Movie() { Id = dbMovie.Id, ReleaseYear = dbMovie.ReleaseYear, Title = dbMovie.Title };
        }

        internal MovieDB InverseMap(Movie movie)
        {
            if (movie == null)
                return null;
            return new MovieDB() { Id = movie.Id, ReleaseYear = movie.ReleaseYear, Title = movie.Title };
        }
    }
}
