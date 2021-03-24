using System;
using System.Linq;
using System.Collections.Generic;
using Model;
using EF;
using Dap;
using Ninject;

namespace BL
{
    public class Logic
    {
        private DataContext _context;
        private EntityRepository<Employee> _employee;
        private DappperRepository<Employee> _dapper;

        public Logic()
        {
            _context = new DataContext();
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IRepository<Employee>>().To<EntityRepository<Employee>>();
            ninjectKernel.Bind<IRepository<Employee>>().To<DappperRepository<Employee>>();
            _employee = ninjectKernel.Get<EntityRepository<Employee>>();
            _dapper= ninjectKernel.Get<DappperRepository<Employee>>();
        }
        public IEnumerable<Employee> getData()
        {
            return _employee.GetAll();

        }
        public void SetData(string name, int age, int salary, string position)
        {
            Employee em = new Employee() {Name=name,Age=age,Salary=salary,Position=position};
            _employee.Add(em);
        }
        public void DeleteData(int id)
        {
            _employee.Delete(id);
        }
        public void UpdateData(int id, string name, int age, int salary, string position)
        {
            Employee em = new Employee() { Id=id,Name = name, Age = age, Salary = salary, Position = position };
            _employee.Update(em);
        }

        public List<Employee> GetDataDap()
        {
            return _dapper.GetUsers();
        }
        public void SetDataDap(string name, int age, int salary, string position)
        {
            Employee em = new Employee() { Name = name, Age = age, Salary = salary, Position = position };
            _dapper.Create(em);
        }
        public void DeleteDataDap(int id)
        {
            _dapper.Delete(id);
        }
        public void UpdateDataDap(int id, string name, int age, int salary, string position)
        {
            Employee em = new Employee() { Id = id, Name = name, Age = age, Salary = salary, Position = position };
            _dapper.Update(em);
        }
    }
}
