namespace TelephoneDirectory.DbModel
{
    public class Detail:BaseEntity
    {
       
        public string Email { get; set; } 
        public string Number { get; set; }
        public int TypeId { get; set; }
        public int PersonId { get; set; }
        public virtual BaseEntity Base { get; set; }


         // ilişkileri virtual obje olarak eklemen gerekiyor

    }
   
}
