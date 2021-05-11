using System;

namespace WebApi.Entities
{
    public class ToDoEntity
    {
        public int Id { get; }
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
