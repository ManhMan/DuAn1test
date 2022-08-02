using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLOderServices : IQLOderServices
    {
        private IOderRepositories _iqLOder;
        private List<Order> _lstOder;
        public QLOderServices()
        {
            _iqLOder = new OderRepositories();
            _lstOder = new List<Order>();
        }
        public bool AddOder(Order oder)
        {
            _iqLOder.AddOder(oder);
            return true;
        }

        public bool DeleteOder(Order oder)
        {
            _iqLOder.DeleteOder(oder);
            return true;
        }

        public List<Order> GetOderFromDB()
        {
            _lstOder = _iqLOder.GetOderFromDB();
            return _lstOder;
        }

        public bool UpdateOder(Order oder)
        {
            _iqLOder.UpdateOder(oder);
            return true;
        }
    }
}
