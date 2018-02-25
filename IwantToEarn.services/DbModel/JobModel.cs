namespace IwantToEarn.services.DbModel
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Where { get; set; }
        public bool WholeOrHour { get; set; }
        public decimal Cash { get; set; }
        public string Description { get; set; }
    }
}