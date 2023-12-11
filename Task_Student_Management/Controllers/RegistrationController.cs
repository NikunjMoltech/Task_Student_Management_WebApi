using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Task_Student_Management.DTO;
using Task_Student_Management.Tables;

namespace Task_Student_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly DbClass dbContext;

        public RegistrationController(DbClass repoContext)
        {
            dbContext = repoContext;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(DTORegister data)
        {
            try
            {
                var employees = dbContext.RegisterUser.FromSqlRaw("exec RegisterUser @name,@email,@password,@address,@gender,@country,@hobby",
                new SqlParameter("@name", data.name),
                new SqlParameter("@email", data.email),
                new SqlParameter("@password", data.password),
                new SqlParameter("@address", data.address),
                new SqlParameter("@gender", data.gender),
                new SqlParameter("@country", data.country),
                new SqlParameter("@hobby", data.hobbies)).ToList();

                if (employees != null)
                {
                    return Ok(employees);
                }

                return Ok("no data");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("availableHobby")]
        public async Task<IActionResult> get()
        {
            try
            {
                List<Hobbies> employees = dbContext.Hobbies.ToList();

                if (employees != null)
                {
                    return Ok(employees);
                }

                return Ok("no data");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginCheck(DTOLogin data)
        {
            try
            {
                List<DTOReturn> employees = dbContext.LoginCheck.FromSqlRaw("exec LoginCheck @email,@password",
                new SqlParameter("@email", data.email),
                new SqlParameter("@password", data.password)
                ).ToList();

                if (employees != null)
                {
                    var result = employees.Select((value)=>value.Value).FirstOrDefault();

                    return Ok(result);
                }
                return Ok("Try Again");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getStudents")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Students> students = dbContext.Students.ToList();

                if (students != null)
                {
                    return Ok(students);
                }
                return Ok("no data");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("updateStudent")]
        public async Task<IActionResult> UpdateStudent(Students data)
        {
            try
            {
                var employees = dbContext.UpdateStudent.FromSqlRaw("exec UpdateStudent @id, @name,@email,@address,@gender,@country",
                new SqlParameter("@id" , data.id),
                new SqlParameter("@name", data.name),
                new SqlParameter("@email", data.email),
                new SqlParameter("@address", data.address),
                new SqlParameter("@gender", data.gender),
                new SqlParameter("@country", data.country)
                ).ToList();

                if (employees != null)
                {
                    return Ok(employees);
                }

                return Ok("no data");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }


}
