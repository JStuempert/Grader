namespace Grader.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string TestSubject { get; set; }
        public int TestGrade { get; set; }
        public DateTime Date { get; set; }
        public bool SecondAttempt { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }


    }
}
