using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace EF
{
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        private readonly DataContext _context;
        public EntityRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }
        public void Add(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            Employee em = _context.Set<Employee>().Local.First(c => c.Id == id);
            if (em == null)
            {
                em = new Employee() { Id = id };
                _context.Employee.Attach(em);
            }
            _context.Employee.Remove(em);
            _context.SaveChanges();
        }

        //public void Update(Employee emnew)
        //{
        //    Employee em = _context.Set<Employee>().Local.First(c => c.Id == emnew.Id);
        //    if (em != null)
        //    {
        //        em.Name = emnew.Name;
        //        em.Age = emnew.Age;
        //        em.Salary = emnew.Salary;
        //        em.Position = emnew.Position;
        //        _context.SaveChanges();
        //    }
            
        //}

    }
}
