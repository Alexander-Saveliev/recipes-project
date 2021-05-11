using WebApi.Entities;

namespace WebApi.Dto
{
    public class ToDoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }

        public ToDoDto()
        { }

        public ToDoDto( ToDoEntity toDoEntity )
        {
            Id = toDoEntity.Id;
            Name = toDoEntity.Name;
            Done = toDoEntity.Done;
        }

        public void CopyTo( ToDoEntity toDoEntity )
        {
            toDoEntity.Name = Name;
            toDoEntity.Done = Done;
        }
    }
}
