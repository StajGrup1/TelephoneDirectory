namespace TelephoneDirectory.DbModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime creates_date { get; set; }
        public DateTime updates_date { get; set; }

    }
}
