namespace NewTestProject.Core.Entity;

public class MovieRating
{
    public MovieRating(int reviewer, int movie, int grade, DateTime date)
    {
        Reviewer = reviewer;
        Movie = movie;
        Grade = grade;
        Date = date;
    }

    public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; private set; }
  }

