 
using Ying.BookShop.DAL;
using Ying.BookShop.IDAL;
using Ying.BookShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ying.BookShop.DALFactory
{
	public partial class DBSession : IDBSession
    {
	
		private Itb_bookinfoDal _tb_bookinfoDal;
        public Itb_bookinfoDal tb_bookinfoDal
        {
            get
            {
                if(_tb_bookinfoDal == null)
                {
                    _tb_bookinfoDal = new tb_bookinfoDal();
                }
                return _tb_bookinfoDal;
            }
            set { _tb_bookinfoDal = value; }
        }
	
		private Itb_booktypeinfoDal _tb_booktypeinfoDal;
        public Itb_booktypeinfoDal tb_booktypeinfoDal
        {
            get
            {
                if(_tb_booktypeinfoDal == null)
                {
                    _tb_booktypeinfoDal = new tb_booktypeinfoDal();
                }
                return _tb_booktypeinfoDal;
            }
            set { _tb_booktypeinfoDal = value; }
        }
	
		private Itb_commentDal _tb_commentDal;
        public Itb_commentDal tb_commentDal
        {
            get
            {
                if(_tb_commentDal == null)
                {
                    _tb_commentDal = new tb_commentDal();
                }
                return _tb_commentDal;
            }
            set { _tb_commentDal = value; }
        }
	
		private Itb_customerinfoDal _tb_customerinfoDal;
        public Itb_customerinfoDal tb_customerinfoDal
        {
            get
            {
                if(_tb_customerinfoDal == null)
                {
                    _tb_customerinfoDal = new tb_customerinfoDal();
                }
                return _tb_customerinfoDal;
            }
            set { _tb_customerinfoDal = value; }
        }
	
		private Itb_managerDal _tb_managerDal;
        public Itb_managerDal tb_managerDal
        {
            get
            {
                if(_tb_managerDal == null)
                {
                    _tb_managerDal = new tb_managerDal();
                }
                return _tb_managerDal;
            }
            set { _tb_managerDal = value; }
        }
	
		private Itb_orderDal _tb_orderDal;
        public Itb_orderDal tb_orderDal
        {
            get
            {
                if(_tb_orderDal == null)
                {
                    _tb_orderDal = new tb_orderDal();
                }
                return _tb_orderDal;
            }
            set { _tb_orderDal = value; }
        }
	
		private Itb_orderdetailDal _tb_orderdetailDal;
        public Itb_orderdetailDal tb_orderdetailDal
        {
            get
            {
                if(_tb_orderdetailDal == null)
                {
                    _tb_orderdetailDal = new tb_orderdetailDal();
                }
                return _tb_orderdetailDal;
            }
            set { _tb_orderdetailDal = value; }
        }
	
		private Itb_parameterDal _tb_parameterDal;
        public Itb_parameterDal tb_parameterDal
        {
            get
            {
                if(_tb_parameterDal == null)
                {
                    _tb_parameterDal = new tb_parameterDal();
                }
                return _tb_parameterDal;
            }
            set { _tb_parameterDal = value; }
        }
	
		private Itb_replyDal _tb_replyDal;
        public Itb_replyDal tb_replyDal
        {
            get
            {
                if(_tb_replyDal == null)
                {
                    _tb_replyDal = new tb_replyDal();
                }
                return _tb_replyDal;
            }
            set { _tb_replyDal = value; }
        }
	
		private Itb_shopbookDal _tb_shopbookDal;
        public Itb_shopbookDal tb_shopbookDal
        {
            get
            {
                if(_tb_shopbookDal == null)
                {
                    _tb_shopbookDal = new tb_shopbookDal();
                }
                return _tb_shopbookDal;
            }
            set { _tb_shopbookDal = value; }
        }
	}	
}