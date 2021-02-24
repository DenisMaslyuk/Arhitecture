using System;
using System.Linq;
using System.Collections.Generic;
using Model;
using EF;
using Dap;

namespace BL
{
    public class Logic
    {
        private DataContext _context = new DataContext();
        private EntityRepository<Employee> _employee;
        private DappperRepository _dapper;
        public IEnumerable<Employee> getData()
        {
            _employee = new EntityRepository<Employee>(_context);
            return _employee.GetAll();

        }
        public void SetData(string name, int age, int salary, string position)
        {
            Employee em = new Employee() {Name=name,Age=age,Salary=salary,Position=position};
            _employee = new EntityRepository<Employee>(_context);
            _employee.Add(em);
        }
        public void DeleteData(int id)
        {
            _employee = new EntityRepository<Employee>(_context);
            _employee.Delete(id);
        }
        public void UpdateData(int id, string name, int age, int salary, string position)
        {
            Employee em = new Employee() { Id=id,Name = name, Age = age, Salary = salary, Position = position };
            _employee = new EntityRepository<Employee>(_context);
            _employee.Update(em);
        }

        public List<Employee> GetDataDap()
        {
            _dapper = new DappperRepository();
            return _dapper.GetUsers();
        }
        public void SetDataDap(string name, int age, int salary, string position)
        {
            Employee em = new Employee() { Name = name, Age = age, Salary = salary, Position = position };
            _dapper = new DappperRepository();
            _dapper.Create(em);
        }
        public void DeleteDataDap(int id)
        {
            _dapper = new DappperRepository();
            _dapper.Delete(id);
        }
        public void UpdateDataDap(int id, string name, int age, int salary, string position)
        {
            Employee em = new Employee() { Id = id, Name = name, Age = age, Salary = salary, Position = position };
            _dapper = new DappperRepository();
            _dapper.Update(em);
        }
    }
}
