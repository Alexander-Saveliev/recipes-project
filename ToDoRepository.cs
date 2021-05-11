using System.Collections.Generic;
using System.Linq;
using WebApi.DbInfrastructure;
using WebApi.Entities;

namespace WebApi
{
    public interface IToDoRepository
    {
        List<ToDoEntity> GetAll();
        void Add( ToDoEntity newEntity );
        ToDoEntity GetById( int id );
    }

    public class ToDoRepository : IToDoRepository
    {
        readonly ToDoDbContext _context;

        public ToDoRepository( ToDoDbContext context )
        {
            _context = context;
        }

        public List<ToDoEntity> GetAll() => _context.Set<ToDoEntity>().ToList();

        public void Add( ToDoEntity newEntity )
        {
            _context.Set<ToDoEntity>().Add( newEntity );
        }

        public ToDoEntity GetById( int id )
        {
            ToDoEntity foundEntity = _context.Set<ToDoEntity>().SingleOrDefault( item => item.Id == id );
            return foundEntity;
        }
    }
}
