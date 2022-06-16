using System;

namespace TelephoneDirectory.DbModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Creates_date { get; set; }
        public DateTime Updates_date { get; set; }
        public bool IsDeleted { get; set; }

    }
}
