using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyToDo.Data;
using Microsoft.EntityFrameworkCore;

namespace DailyToDo.Services
{
    public interface IToDoService
    {
        public Task<List<ToDo>> AsyncGetToDo();

        public Task<ToDo> AsyncInsertToDo(String Description, int Priority);

        public Task<ToDo> AsyncCheckAsDone(int Id);
    }
    public class ToDoService : IToDoService
    {
        private readonly ToDoDataContext _context;
        public ToDoService(ToDoDataContext context)
        {
            this._context = context;
        }
        public async Task<List<ToDo>> AsyncGetToDo()
        {
            return await _context.AllToDo.ToListAsync();
        }

        public async Task<ToDo> AsyncInsertToDo(string Description, int Priority)
        {
            ToDo todo = new ToDo(Description, Priority);
            _context.Entry(todo).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return todo;

        }
        public async Task<ToDo> AsyncCheckAsDone(int Id)
        {


            ToDo todo = _context.AllToDo.Find(Id);
            todo.Done = true;
            _context.Entry(todo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return todo;

        }
    }
}
