using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//**NOT: Normalde bu yapılan işlemler doğru değil. Ama yanlış yol da gösterilmiş oluyor.
namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();//SaveChanges() komutunun Ado.Net teki karşılığı ExecuteNonQuery() dir.
            //Not:SaveChanges()  => ExecuteNonQuery(); --> Update, delete, insert into islemleri
            //Not:ToList() => ExecuteReader(); --> Select Islemleri
            //Not:ExecuteScaler --> Sorgudan dönen deger tek satir ise kullanilir(tablodaki toplam satir sayisi)
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}

/*Entity Framework de kullandığımız bazı komutlar:
 * ToList
 * Add
 * Remove
 * Find
 */
