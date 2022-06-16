using System.Collections.Generic;
using TelephoneDirectory.DbModel;
using System.Linq;

namespace TelephoneDirectory.Repositories
{

    public class GenericRepository : IGenericRepository
    {
        private readonly DataBaseContext _context;

        public GenericRepository(DataBaseContext context)
        {
            _context = context;
        }
        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }
        public void UpdatePerson(Person person)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();
        }
        public void DeletePerson(int id)
        {
            var person = _context.Persons.FirstOrDefault(x => x.Id == id);
            person.IsDeleted = false;
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }
        public List<Person> GetPerson()
        {
            return _context.Persons.ToList();
        }
        public Person GetPersonById(int id)
        {
            return _context.Persons.FirstOrDefault(x => x.Id == id);
        }

        // Aynı numaradan- girilince hata verecek.
        //public bool HaveNumber(string number)
        //{
        //    var number2 = _context.Persons.Where(x => x. == number);
        //    if (number2.Any())
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
