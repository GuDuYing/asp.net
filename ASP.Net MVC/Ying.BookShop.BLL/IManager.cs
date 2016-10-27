 
using Ying.BookShop.IBLL;
using Ying.BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ying.BookShop.BLL
{
	
	public partial class tb_bookinfoService :BaseService<tb_bookinfo>,Itb_bookinfoService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_bookinfoDal;
        }
    }   
	
	public partial class tb_booktypeinfoService :BaseService<tb_booktypeinfo>,Itb_booktypeinfoService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_booktypeinfoDal;
        }
    }   
	
	public partial class tb_commentService :BaseService<tb_comment>,Itb_commentService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_commentDal;
        }
    }   
	
	public partial class tb_customerinfoService :BaseService<tb_customerinfo>,Itb_customerinfoService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_customerinfoDal;
        }
    }   
	
	public partial class tb_managerService :BaseService<tb_manager>,Itb_managerService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_managerDal;
        }
    }   
	
	public partial class tb_orderService :BaseService<tb_order>,Itb_orderService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_orderDal;
        }
    }   
	
	public partial class tb_orderdetailService :BaseService<tb_orderdetail>,Itb_orderdetailService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_orderdetailDal;
        }
    }   
	
	public partial class tb_parameterService :BaseService<tb_parameter>,Itb_parameterService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_parameterDal;
        }
    }   
	
	public partial class tb_replyService :BaseService<tb_reply>,Itb_replyService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_replyDal;
        }
    }   
	
	public partial class tb_shopbookService :BaseService<tb_shopbook>,Itb_shopbookService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.tb_shopbookDal;
        }
    }   
	
}