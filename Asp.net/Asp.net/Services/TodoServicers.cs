using Asp.net.Models;
namespace Asp.net.Services
    
{
    public class TodoServicers
    {
        public List<Todo> todos = new List<Todo>();
        public List<Todo> AllTodos()
        {
            var todo1 = new Todo
            {
                Id = 1,
                Description = "Task 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = "Pending"
            };
           todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Description = "Task 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = "Pending"
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Description = "Task 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = "Completed"
            };
            todos.Add(todo3);

            return todos;
        }

        public void AddTodos(Todo todo)
        {
            todos.Add(todo);
        }

        public void UpdateTodo(Todo todo)
        {
            var existingTodo = todos.FirstOrDefault(t => t.Id == todo.Id);
            if (existingTodo != null)
            {
                existingTodo.Description = todo.Description;
                existingTodo.Due = todo.Due;
                existingTodo.Status = todo.Status;
            }
        }


        public void DeleteTodos(int id)
        {
            var existingTodo = todos.FirstOrDefault(t => t.Id == id);
            if (existingTodo != null)
            {
                todos.Remove(existingTodo);
            }
        }
      
    }
}
