namespace OOP.Domain.Entities
{
    public class Review
    {
        private int rating;
        private string comment;

        public int GetRating()
        {
            return rating;
        }

        public void SetRating(int value)
        {
            rating = value;
        }

        public string GetComment()
        {
            return comment;
        }

        public void SetComment(string value)
        {
            comment = value;
        }
    }
}
