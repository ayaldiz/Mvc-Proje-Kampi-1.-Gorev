using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {


        //CRUD
        //Type Name();
        //List<Category> List(); // ': IRepository<Category>' ifadesi sayesinde yazmaya gerek kalmadı

        //void Insert(Category p);//ekleme işlemi için ???// ': IRepository<Category>' ifadesi sayesinde yazmaya gerek kalmadı
        //void Update(Category p);// ': IRepository<Category>' ifadesi sayesinde yazmaya gerek kalmadı
        //void Delete(Category p);// ': IRepository<Category>' ifadesi sayesinde yazmaya gerek kalmadı
    }
}
