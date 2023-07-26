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

        public object deleteRow(int id)
        {
            var delData = _context.Employee.Where(x => x.emp_Id == id).FirstOrDefault();
            if (delData !=null)
            {
                _context.Employee.Remove(delData);
                _context.SaveChanges();
                return "data sucessfully Deleted";
            }
            return false;
        }

        public object editAll(DbModel Employe)
        {
            var editingData = _context.Employee.FirstOrDefault(x => x.emp_Id == Employe.emp_Id);
            if (editingData != null)
            {
                editingData.emp_Age = Employe.emp_Age;
                editingData.emp_Dept = Employe.emp_Dept;
                editingData.emp_Name = Employe.emp_Name;
                editingData.salary = Employe.salary;
                _context.SaveChanges();
                return true;
            }
            return false;
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
