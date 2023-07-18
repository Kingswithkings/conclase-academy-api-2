using conclase_academy_api_2.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public ioperationtransient _operationtransientproperty { get; set; }
        public iconsumer _consumer { get; set; }

        public iDatabaseHelper _databaseHelper { get; set; }
        public StudentController (ioperationtransient operationprop)
        {
            _operationtransientproperty = operationprop;
            _databaseHelper = _databaseHelper;
            _consumer = _consumer;
            var guidincontroller = operationprop.operationId;

            Console.WriteLine($" guid in transient service is :{operationprop.operationId}");
        }
        List<Student> studentRecord = new List<Student>
        {
            new Student{Id = 1, Address = "Ikorodu", FirstName = "Ayoola", LastName = "opaleye", MatricNo = "100231013"},
            new Student{Id = 2, Address = "Ikeja", FirstName = "Saviour", LastName = "Patrick", MatricNo = "100231014"},
            new Student{Id = 3, Address = "Maryland", FirstName = "Kings", LastName = "Idogu", MatricNo = "100231015"},
            new Student{Id = 4, Address = "Ojota", FirstName = "Maryam", LastName = "Lola", MatricNo = "100231016"},
            new Student{Id = 5, Address = "Apapa", FirstName = "Mahmud", LastName = "Ishola", MatricNo = "100231017"}
        };
        //http verbs---get, post, delete, put, patch
        [HttpGet]
        [Route("getAllStudents")]
        public ActionResult<Student> GetStudents()
        {
            var students = studentRecord
                .ToList();
            if (students.Count == 0)
            {
                return NotFound();
            }
            return Ok(students);
        }
        [HttpGet]
        [Route("getStudentById/{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = studentRecord
                .Where(x => x.Id == id)
                .FirstOrDefault();
            if (student == null)
            {
                return NotFound("No record found");
            }
            return Ok(student);
        }
        [HttpPost]
        [Route("addStudent")]
        public ActionResult<Student> AddStudent(Student student)
        {
            studentRecord.Add(student);
            return Ok(student);
        }
        [HttpPut]
        [Route("updateStudent/{id}")]
        public ActionResult<Student> UpdateStudent(int id, Student student)
        {
            //check if the student exist
            var existingStudent = studentRecord.Where(x => x.Id == id).FirstOrDefault();
            if (existingStudent == null)
            {
                return BadRequest($"Student with id of {id} does not exist");
            }
            existingStudent.LastName = student.LastName;
            existingStudent.FirstName = student.FirstName;
            existingStudent.MatricNo = existingStudent.MatricNo;
            return Ok(student);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public ActionResult<Student> DeleteStudent(int id)
        {
            //check if the student exist
            var existingStudent = studentRecord.Where(x => x.Id == id).FirstOrDefault();
            if (existingStudent == null)
            {
                return BadRequest($"Student with id of {id} does not exist");
            }
            studentRecord.Remove(existingStudent);
            return Ok();
        }
    }
}
    
