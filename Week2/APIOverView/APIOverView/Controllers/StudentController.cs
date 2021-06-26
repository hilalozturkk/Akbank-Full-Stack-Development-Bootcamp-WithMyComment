using APIOverView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIOverView.Controllers
{
    [Route("api/[controller]")] //  api/student
    [ApiController]
    public class StudentController : ControllerBase
    {

        List<Student> students = new List<Student>
        {
                new Student {Id=1,Name="Özgün",LastName="Demirel",Adress="Kartal/İstanbul"},
                new Student {Id=2,Name="Aydın",LastName="Necmi",Adress="Nilüfer/Bursa"},
                new Student {Id=3,Name="Olcay",LastName="Arpaç",Adress="Merkezefendi/Denizli"},
                new Student {Id=4,Name="Bahar",LastName="Arpaç",Adress="Merkez/Çanakkale"},
                new Student {Id=5,Name="Tibet Kağan",LastName="Arpaç",Adress="Kağıthane/İstanbul"}
         };

        // 1. Returns all students => get
        [HttpGet] //get request
        public IActionResult GetStudents() //
        {
            return Ok(students);//if students will come, returns 200 
        }
        [HttpGet("{ogrID:int}")]
        public IActionResult GetStudent(int ogrID)
        {
            //func -> get bool return student 
            var student = students.FirstOrDefault(stu => stu.Id == ogrID);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpGet("{city}")]
        public IActionResult GetStudentByCity(string city)
        {
            var findingStudent = students.Where(x => x.Adress.Contains(city));
            if (findingStudent == null)
            {
                return NotFound();
            }
            return Ok(findingStudent);
        }


    }
}
