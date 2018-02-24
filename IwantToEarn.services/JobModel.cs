namespace IwantToEarn
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Where { get; set; }
        public int WholeOrHour { get; set; }
        public double Cash { get; set; }
        public string Description { get; set; }
    }
}