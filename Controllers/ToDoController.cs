using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbInfrastructure;
using WebApi.Dto;
using WebApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository _toDoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ToDoController( IToDoRepository toDoRepository, IUnitOfWork unitOfWork )
        {
            _toDoRepository = toDoRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<ToDoDto> Get()
        {
            return _toDoRepository.GetAll().Select( item => new ToDoDto( item ) ).ToList();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public int Post( [FromBody] ToDoDto todo )
        {
            ToDoEntity newEntity = new ToDoEntity();
            todo.CopyTo( newEntity );

            _toDoRepository.Add( newEntity );

            _unitOfWork.Commit();
            return newEntity.Id;
        }

        // PUT api/<ValuesController>/5
        [HttpPut( "{id}" )]
        public void Put( int id, [FromBody] ToDoDto todo )
        {
            ToDoEntity foundEntity = _toDoRepository.GetById( id );
            todo.CopyTo( foundEntity );
            _unitOfWork.Commit();
        }
    }
}
