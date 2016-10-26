 

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ying.BookShop.IDAL
{
	public partial interface IDBSession
    {

	
		Itb_bookinfoDal tb_bookinfoDal{get;set;}
	
		Itb_booktypeinfoDal tb_booktypeinfoDal{get;set;}
	
		Itb_commentDal tb_commentDal{get;set;}
	
		Itb_customerinfoDal tb_customerinfoDal{get;set;}
	
		Itb_managerDal tb_managerDal{get;set;}
	
		Itb_orderDal tb_orderDal{get;set;}
	
		Itb_orderdetailDal tb_orderdetailDal{get;set;}
	
		Itb_parameterDal tb_parameterDal{get;set;}
	
		Itb_replyDal tb_replyDal{get;set;}
	
		Itb_shopbookDal tb_shopbookDal{get;set;}
	}	
}