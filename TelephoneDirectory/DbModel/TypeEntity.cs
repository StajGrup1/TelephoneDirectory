namespace TelephoneDirectory.DbModel
{
    public class TypeEntity:BaseEntity
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public virtual BaseEntity Base { get; set; }
    }
}
