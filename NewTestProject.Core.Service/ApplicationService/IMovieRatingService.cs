using NewTestProject.Core.Entity;

namespace NewTestProject.Core.Service.ApplicationService;

public interface IMovieRatingService
{

    int getNumberOfReviewsFromReviewer(int reviewerID);

    double getAverageRateGivenByReviewer(int reviewerID);

    int getCountOfGradesGivenByReviewer(int revieweID, int grade);

    int getCountOfMovieReviewers(int movieID);

    double averageRatingRecievedByMovie(int movieID);

    int getCountOfGradesGottenByMovie(int movieID, int grade);

    List<int> getIdOfTopGradedMovies();
    
    List<int> getTopReviewers();

    List<int> getTopMoviesByAverageGrade(int count);
    
    List<MovieRating> getAllMoviesByReviewer(int reviewerID);
   
    List<MovieRating> getAllReviewersFromMovie(int movieID);
}