using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//IRepository interface'i sayesinde her tablo için ayrı ayrı interface oluşturmaktan kurtulmuş olduk.
//DRY (Don't Repeat Yourself) Don't repeat yourself (DRY), yazılım kalıplarının tekrarlanmasını (code duplication) ve buna bağlı olarak ortaya çıkabilecek fazlalıkların / karmaşanın önlenmesini amaçlayan bir yazılım geliştirme ilkesidir 1.
namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T,bool>> filter);// Bu fonkisyon şöyle çalışıyor: Mesela tablo dan sadece ismi 'Ali' olanları getir
    }
}
