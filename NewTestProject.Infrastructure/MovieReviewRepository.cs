using NewTestProject.Core.Entity;
using NewTestProject.Core.Service.DomainService;

namespace NewTestProject.Infrastructure;

public class MovieReviewRepository : IMovieReviewRepository
{
    private List<MovieRating> _movieRatings = new List<MovieRating>();

    public void AddJson(List<MovieRating> newList)
    {
        _movieRatings = newList;
    }
    
    public int getNumberOfReviewsFromReviewer(int reviewerID)
    {
        return _movieRatings
            .Where(mr => mr.Reviewer == reviewerID)
            .Count();
    }

    public double getAverageRateGivenByReviewer(int reviewerID)
    {
        throw new NotImplementedException();
    }

    public int getCountOfGradesGivenByReviewer(int revieweID, int grade)
    {
        throw new NotImplementedException();
    }

    public int getCountOfMovieReviewers(int movieID)
    {
        throw new NotImplementedException();
    }

    public double averageRatingRecievedByMovie(int movieID)
    {
        return _movieRatings
            .Where(mr => mr.Movie == movieID)
            .Select(mr => mr.Grade)
            .DefaultIfEmpty(0)
            .Average();
    }

    public int getCountOfGradesGottenByMovie(int movieID, int grade)
    {
        return _movieRatings
            .Where(mr => mr.Movie == movieID && mr.Grade == grade)
            .Count();
    }

    public List<int> getIdOfTopGradedMovies()
    {
        throw new NotImplementedException();
    }

    public List<int> getTopReviewers()
    {
        throw new NotImplementedException();
    }

    public List<int> getTopMoviesByAverageGrade(int count)
    {
        throw new NotImplementedException();
    }

    public List<MovieRating> getAllMoviesByReviewer(int reviewerID)
    {
        return _movieRatings
            .Where(mr => mr.Reviewer == reviewerID)
            .OrderByDescending(mr => mr.Grade)
            .ThenByDescending(mr => mr.Date)
            .ToList();
    }

    public List<MovieRating> getAllReviewersFromMovie(int movieID)
    {
        throw new NotImplementedException();
    }

    public void Add(MovieRating movieRating)
    {
        _movieRatings.Add(movieRating);
    }
}