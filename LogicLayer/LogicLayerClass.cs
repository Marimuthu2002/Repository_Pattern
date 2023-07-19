using DataLayer;
using Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicLayerClass:ILogicLayer
    {
        private readonly IDataLayer _dataLayer;
        public LogicLayerClass(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }


        public object AddUpdateEmployee(DbModel Employees)
        {
            var data = _dataLayer.postAll(Employees);
            return Employees;
            
        }

        public List<DbModel> GetLogic()
        {
            var data = _dataLayer.GetAll();
            return data;
        }
    }
}
