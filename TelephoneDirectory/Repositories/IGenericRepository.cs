using TelephoneDirectory.DbModel;
using System.Collections.Generic;


namespace TelephoneDirectory.Repositories
{
    public interface IGenericRepository
    {
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
        List<Person> GetPerson();
        Person GetPersonById(int id);
        //bool HaveNumber(string number);
    }
}
