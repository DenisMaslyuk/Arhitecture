using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Dap
{
    public class DappperRepository
    {
        public SqlConnection conn;
        public DappperRepository()
        {
            conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=localhost\\SQLEXPRESS;" +
              "Initial Catalog=Arch;" +
              "Integrated Security=SSPI;";
            conn.Open();
        }
        public List<Employee> GetUsers()
        {
            
            List<Employee> employees = new List<Employee>();
            using (IDbConnection db = conn)
            {
                employees = db.Query<Employee>("SELECT * FROM Employee").ToList();
            }

            return employees;
        }

        //public Employee Get(int id)
        //{
        //    Employee em = null;
        //    using (IDbConnection db = conn)
        //    {
        //        em = db.Query<Employee>("SELECT * FROM Employee WHERE Id = @id", new { id }).FirstOrDefault();
        //    }
        //    return em;
        //}

        public void Create(Employee em)
        {
            using (IDbConnection db = conn)
            {
                var sqlQuery = "INSERT INTO Employee (Name, Age,Salary,Position)" +
                    " VALUES(@Name, @Age,@Salary,@Position);";
                db.Execute(sqlQuery,em);
            }
        }

        public void Update(Employee em)
        {
            using (IDbConnection db = conn)
            {
                var sqlQuery = "UPDATE Employee " +
                    "SET Name = @Name, Age = @Age, Salary =@Salary," +
                    "Position = @Position " +
                    "WHERE Id = @Id";
                db.Execute(sqlQuery, em);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = conn)
            {
                var sqlQuery = "DELETE FROM Employee WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
