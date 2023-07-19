using Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataLyerClass : IDataLayer
    {
        private readonly EnployeeDetails _context;
        public DataLyerClass(EnployeeDetails context)
        {
            _context=context;
        }
        public List<DbModel> GetAll()
        {
            var data = _context.Employee.ToList();
            return data;
        }

        public object postAll(DbModel Employees)
        {
            try
            {
                var postData = _context.Employee.Add(Employees);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return Employees;
        }
    }
}
