using NewTestProject.Core.Entity;
using NewTestProject.Core.Service.ApplicationService;
using NewTestProject.Core.Service.ApplicationService.ImplService;
using NewTestProject.Infrastructure;

namespace TestProject3;

public class UnitTest1
{
    //All tests failed which is Good For now 

    [Theory]
        [InlineData(5, 0)]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        public void GetNumberOfReviewsFromReviewer_ValidArguments(int reviewer, int reviews)
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            
            movieRatingRepository.Add(new MovieRating(1, 3, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(1, 1, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 2, DateTime.Now));
            
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            int actual = movieRatingService.getNumberOfReviewsFromReviewer(reviewer);

            Assert.Equal(reviews, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 2.5)]
        public void GetAverageRateGivenByReviewer_ValidArguments(int reviewer, double average)
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            
            movieRatingRepository.Add(new MovieRating(1, 1, 1, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(3, 4, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(3, 5, 1, DateTime.Now));
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            double actual = movieRatingService.getAverageRateGivenByReviewer(reviewer);

            Assert.Equal(average, actual);
        }

        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 0)]
        public void GetAverageRateGivenByReviewer_ValidArguments_ReturnZero(int reviewer, double average)
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            
            movieRatingRepository.Add(new MovieRating(1, 1, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 1, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 4, 1, DateTime.Now));
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            double actual = movieRatingService.getAverageRateGivenByReviewer(reviewer);

            Assert.Equal(average, actual);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(2, 3, 3)]
        public void GetCountOfGradesGivenByReviewer_ValidArguments(int reviewer, int grade, int count)
        {
           
        }

    

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 2.5)]
        public void AverageRatingRecievedByMovie_ValidArguments(int movie, double average)
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            movieRatingRepository.Add(new MovieRating(1, 1, 1, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 1, DateTime.Now));
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            double actual = movieRatingService.averageRatingRecievedByMovie(movie);

            Assert.Equal(average, actual);
        }

        [Theory]
        [InlineData(6, 0)]
        [InlineData(7, 0)]
        public void AverageRatingRecievedByMovie_ValidArguments_ReturnZero(int movie, double average)
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            movieRatingRepository.Add(new MovieRating(1, 1, 2, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 1, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 1, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 2, 1, DateTime.Now));
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            double actual = movieRatingService.averageRatingRecievedByMovie(movie);

            Assert.Equal(average, actual);
        }

        [Theory]
        [InlineData(9, 1, 0)]
        [InlineData(2, 4, 1)]
        [InlineData(3, 3, 4)]
        public void GetCountOfGradesGottenByMovie_ValidArgumentse(int movie, int grade, int count)
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            movieRatingRepository.Add(new MovieRating(2, 2, 4, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 3, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 3, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 3, DateTime.Now));
            movieRatingRepository.Add(new MovieRating(2, 3, 3, DateTime.Now));
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            int actual = movieRatingService.getCountOfGradesGottenByMovie(movie, grade);

            Assert.Equal(count, actual);
        }
    


        [Fact]
        public void GetMoviesByReviewer_ValidArguments()
        {
            MovieReviewRepository movieRatingRepository = new MovieReviewRepository();
            MovieRating movieRating1 = new MovieRating(1, 1, 5, DateTime.Now.AddYears(4));
            MovieRating movieRating2 = new MovieRating(2, 1, 5, DateTime.Now.AddYears(3));
            MovieRating movieRating3 = new MovieRating(3, 1, 4, DateTime.Now.AddYears(3));
            MovieRating movieRating4 = new MovieRating(4, 1, 3, DateTime.Now.AddYears(2));
            MovieRating movieRating5 = new MovieRating(3, 2, 1, DateTime.Now);
            movieRatingRepository.Add(movieRating1);
            movieRatingRepository.Add(movieRating2);
            movieRatingRepository.Add(movieRating3);
            movieRatingRepository.Add(movieRating4);
            movieRatingRepository.Add(movieRating5);
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);

            List<MovieRating> expected = new List<MovieRating>() { movieRating1 };
            List<MovieRating> actual = movieRatingService.getAllMoviesByReviewer(1);

            Assert.Equal(expected, actual);
        }
}