 

using Ying.BookShop.IDAL;
using Ying.BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ying.BookShop.DAL
{
		
	public partial class tb_bookinfoDal :BaseDal<tb_bookinfo>,Itb_bookinfoDal
    {

    }
		
	public partial class tb_booktypeinfoDal :BaseDal<tb_booktypeinfo>,Itb_booktypeinfoDal
    {

    }
		
	public partial class tb_commentDal :BaseDal<tb_comment>,Itb_commentDal
    {

    }
		
	public partial class tb_customerinfoDal :BaseDal<tb_customerinfo>,Itb_customerinfoDal
    {

    }
		
	public partial class tb_managerDal :BaseDal<tb_manager>,Itb_managerDal
    {

    }
		
	public partial class tb_orderDal :BaseDal<tb_order>,Itb_orderDal
    {

    }
		
	public partial class tb_orderdetailDal :BaseDal<tb_orderdetail>,Itb_orderdetailDal
    {

    }
		
	public partial class tb_parameterDal :BaseDal<tb_parameter>,Itb_parameterDal
    {

    }
		
	public partial class tb_replyDal :BaseDal<tb_reply>,Itb_replyDal
    {

    }
		
	public partial class tb_shopbookDal :BaseDal<tb_shopbook>,Itb_shopbookDal
    {

    }
	
}