using Microsoft.AspNetCore.Mvc;
using System;
using TelephoneDirectory.DbModel;
using TelephoneDirectory.Migrations;
using TelephoneDirectory.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TelephoneDirectory.Controllers
{

    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IGenericRepository _genericRepository;

        public PersonsController(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Person> Get()
        {
            return _genericRepository.GetPerson();
        }

        [HttpGet("GetById/{id}")]
        public Person Details(int id)
        {
            return _genericRepository.GetPersonById(id);
        }

        [HttpPost("CreatePerson")]
        public IActionResult Create([FromBody] Person person)
        {
            _genericRepository.AddPerson(person);
            return Ok("Başarılı");
        }

        [HttpPut("EditPerson")]
        public IActionResult Edit([FromBody] Person person)
        {
            _genericRepository.UpdatePerson(person);
            return Ok("Değiştirildi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _genericRepository.GetPersonById(id);
            if (data == null)
            {
                return NotFound("Böyle bir kayıt yok");
            }
            _genericRepository.DeletePerson(id);
            return Ok("Silindi");
        }

    }

}


