using System.Net.Http.Headers;
using NewTestProject.Core.Entity;
using NewTestProject.Core.Service.DomainService;

namespace NewTestProject.Core.Service.ApplicationService.ImplService;

public class MovieRatingService : IMovieRatingService
{
    private readonly IMovieReviewRepository _movieReviewRepository;

    public MovieRatingService(IMovieReviewRepository movieReviewRepository)
    {
        _movieReviewRepository = movieReviewRepository;
    }

    public int getNumberOfReviewsFromReviewer(int reviewerID)
    {
        return _movieReviewRepository.getNumberOfReviewsFromReviewer(reviewerID);
    }

    public double getAverageRateGivenByReviewer(int reviewerID)
    {
        return _movieReviewRepository.getAverageRateGivenByReviewer(reviewerID);
    }

    public int getCountOfGradesGivenByReviewer(int revieweID, int grade)
    {
        return _movieReviewRepository.getCountOfGradesGivenByReviewer(revieweID, grade);
    }

    public int getCountOfMovieReviewers(int movieID)
    {
        return _movieReviewRepository.getCountOfMovieReviewers(movieID);
    }

    public double averageRatingRecievedByMovie(int movieID)
    {
        return _movieReviewRepository.averageRatingRecievedByMovie(movieID);
    }

    public int getCountOfGradesGottenByMovie(int movieID, int grade)
    {
        return _movieReviewRepository.getCountOfGradesGottenByMovie(movieID, grade);
    }

    public List<int> getIdOfTopGradedMovies()
    {
        return _movieReviewRepository.getIdOfTopGradedMovies();
    }

    public List<int> getTopReviewers()
    {
        return _movieReviewRepository.getTopReviewers();
    }

    public List<int> getTopMoviesByAverageGrade(int count)
    {
        return _movieReviewRepository.getTopMoviesByAverageGrade(count);
    }

    public List<MovieRating> getAllMoviesByReviewer(int reviewerID)
    {
        return _movieReviewRepository.getAllMoviesByReviewer(reviewerID);
    }

    public List<MovieRating> getAllReviewersFromMovie(int movieID)
    {
        return _movieReviewRepository.getAllReviewersFromMovie(movieID);
    }
    
    /*
     *  private void checkForGradeException(int checkableGrade)
        {
            if (checkableGrade < 1 || checkableGrade > 5)
            {
                throw new ArgumentException("Invalid Grade");
            }
        }
        private void checkForMovieAndReviewException(int checkableItem)
        {
            if(checkableItem < 1)
            {
                throw new ArgumentException("The item cannot be a negative number");
            }
        }
     */
}