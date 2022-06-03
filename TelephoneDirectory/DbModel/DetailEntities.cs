namespace TelephoneDirectory.DbModel
{
    public class DetailEntities:BaseEntity
    {
       
        public string email { get; set; } //isimlendirme kuralları 
        public string number { get; set; }
        public int TypeId { get; set; }
        public int PersonId { get; set; }

         // ilişkileri virtual obje olarak eklemen gerekiyor

    }
   
}
