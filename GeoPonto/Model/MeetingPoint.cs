namespace GeoPonto.Model
{
    public class MeetingPoint
    {
        public int MeetingPointId { get; set; }
        public string Date { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public virtual User User { get; set; }

    }
}