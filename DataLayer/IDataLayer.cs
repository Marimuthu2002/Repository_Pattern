using Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDataLayer
    {
        public List<DbModel> GetAll();
        public object postAll(DbModel Employees);
    }
}
