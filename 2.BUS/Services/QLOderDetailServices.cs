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
    public class QLOderDetailServices : IQLOderDetailServices
    {
        private IOderDetailRepositories _qLOderDetail;
        private List<OrderDetail> _lstOderDetails;
        public QLOderDetailServices()
        {
            _qLOderDetail = new OderDetailRepositories();
            _lstOderDetails = new List<OrderDetail>();
        }

        public bool AddOderDetail(OrderDetail oderDetail)
        {
            _qLOderDetail.AddOderDetail(oderDetail);
            return true;
        }

        public bool DeleteOderDetail(OrderDetail oderDetail)
        {
            _qLOderDetail.DeleteOderDetail(oderDetail);
            return true;
        }

        public List<OrderDetail> GetOderDetailFromDB()
        {
            _lstOderDetails = _qLOderDetail.GetOderDetailFromDB();
            return _lstOderDetails;
        }

        public bool UpdateOderDetail(OrderDetail oderDetail)
        {
            _qLOderDetail.UpdateOderDetail(oderDetail);
            return true;
        }
    }
}
