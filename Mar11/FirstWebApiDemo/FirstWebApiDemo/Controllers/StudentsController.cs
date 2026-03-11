using FirstWebApiDemo.Models.Repos;
using Microsoft.AspNetCore.Mvc;
using FirstWebApiDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        StudentRepos srepo = null;
        public StudentsController()
        {
            srepo = new StudentRepos();
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return srepo.GetAll();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return srepo.Get(id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post(Student item)
        {
            srepo.Add(item);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Student item)
        {
            srepo.Update(id, item);
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            srepo.Delete(id);
        }
    }
}
