using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entityes;

namespace LogicLayer
{
    public interface ILogicLayer
    {
        public List<DbModel> GetLogic();
        object AddUpdateEmployee(DbModel Employees);
    }
}
