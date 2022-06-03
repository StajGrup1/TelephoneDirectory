using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.DbModel;
using TelephoneDirectory.Migrations;


namespace TelephoneDirectory.Controllers
{

    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly DataBaseContext _db;

        public PersonsController(DataBaseContext db)
        {
            _db = db;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var Person = _db.Persons.ToList();
            return Ok(Person);
        }

        [HttpGet("GetById")] // ıdye göre customer değeri döner. ıd yoksa hata döner
        public IActionResult GetById(int id)
        {
            var Person = _db.Persons.FirstOrDefault(x => x.Id == id);
            return Ok(Person);
        }

        [HttpGet("GetByNation")]
        public IActionResult GetGirl(int id)
        {
            var person = _db.Persons.Where(x => x.Id == id);
            return Ok(person);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] Person person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
            return Ok(person);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] Person person)
        {
            _db.Persons.Update(person);
            _db.SaveChanges();
            return Ok(person);
        }

        [HttpDelete("Delete")]
        public virtual IActionResult Delete(int id)
        {
            var personToDelete = _db.Persons.Find(id);
            if (personToDelete == null) // getbyıd de olabilir
            {
                return NotFound("Bulunamadı");
            }
            //customerToDelete.Is_active = false;
            _db.Persons.Update(personToDelete);
            _db.SaveChanges();
            return NoContent();
        }
    }

}

