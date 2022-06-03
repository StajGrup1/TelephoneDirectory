namespace TelephoneDirectory.DbModel
{
    public class Person:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual BaseEntity Base { get; set; }

    }
}
