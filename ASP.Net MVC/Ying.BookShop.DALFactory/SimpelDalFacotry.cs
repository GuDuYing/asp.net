 

using Ying.BookShop.IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ying.BookShop.DALFactory
{
    public partial class AbstractFactory
    {
      
   
		
	    public static Itb_bookinfoDal Createtb_bookinfoDal()
        {

		 string fullClassName = NameSpace + ".tb_bookinfoDal";
          return CreateInstance(fullClassName) as Itb_bookinfoDal;

        }
		
	    public static Itb_booktypeinfoDal Createtb_booktypeinfoDal()
        {

		 string fullClassName = NameSpace + ".tb_booktypeinfoDal";
          return CreateInstance(fullClassName) as Itb_booktypeinfoDal;

        }
		
	    public static Itb_commentDal Createtb_commentDal()
        {

		 string fullClassName = NameSpace + ".tb_commentDal";
          return CreateInstance(fullClassName) as Itb_commentDal;

        }
		
	    public static Itb_customerinfoDal Createtb_customerinfoDal()
        {

		 string fullClassName = NameSpace + ".tb_customerinfoDal";
          return CreateInstance(fullClassName) as Itb_customerinfoDal;

        }
		
	    public static Itb_managerDal Createtb_managerDal()
        {

		 string fullClassName = NameSpace + ".tb_managerDal";
          return CreateInstance(fullClassName) as Itb_managerDal;

        }
		
	    public static Itb_orderDal Createtb_orderDal()
        {

		 string fullClassName = NameSpace + ".tb_orderDal";
          return CreateInstance(fullClassName) as Itb_orderDal;

        }
		
	    public static Itb_orderdetailDal Createtb_orderdetailDal()
        {

		 string fullClassName = NameSpace + ".tb_orderdetailDal";
          return CreateInstance(fullClassName) as Itb_orderdetailDal;

        }
		
	    public static Itb_parameterDal Createtb_parameterDal()
        {

		 string fullClassName = NameSpace + ".tb_parameterDal";
          return CreateInstance(fullClassName) as Itb_parameterDal;

        }
		
	    public static Itb_replyDal Createtb_replyDal()
        {

		 string fullClassName = NameSpace + ".tb_replyDal";
          return CreateInstance(fullClassName) as Itb_replyDal;

        }
		
	    public static Itb_shopbookDal Createtb_shopbookDal()
        {

		 string fullClassName = NameSpace + ".tb_shopbookDal";
          return CreateInstance(fullClassName) as Itb_shopbookDal;

        }
	}
	
}