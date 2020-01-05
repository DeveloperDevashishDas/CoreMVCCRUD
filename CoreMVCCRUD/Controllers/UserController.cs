using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreMVCCRUD.Repository;
using CoreMVCCRUD.Models;

namespace CoreMVCCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {   
        private readonly IRepository<Employee> _employee ;

        public UserController(IRepository<Employee> employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employee.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_employee.GetById(id));
        }
    }
}