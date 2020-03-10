using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMappers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }


        public Student Get()
        {
            StudentDTO studentDto = new StudentDTO()
            {
                Name = "Onchari Wycliffe",
                Age = 25,
                CurrentCity = "New York"
            };

            return _mapper.Map<Student>(studentDto);
        }
    }
}