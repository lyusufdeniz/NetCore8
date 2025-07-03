using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //Task, her çağrıldığında bir nesne (instance) oluşturur. Eğer bu çağrı çok sık ve hızlı tamamlanıyorsa (örneğin cache kontrolü gibi), her seferinde Task üretmek gereksiz heap allocation yapar ve GC (Garbage Collector) yükünü artırır.💡 ValueTask, senkron olarak hemen dönebilen işlemler için kullanılabilir.Böylece gereksiz nesne üretimi önlenir.

        //IEnumerable, verileri bellekte işler ve sorgular veriler çekildikten sonra çalışır; küçük veri kümelerinde uygundur. IQueryable ise sorguyu veritabanına gönderir, filtreleme ve sıralama gibi işlemler SQL tarafında yapılır, bu yüzden büyük veri kümelerinde daha verimlidir. IQueryable performans için tercih edilirken, IEnumerable daha çok bellekteki verilerle çalışmak için kullanılır.
        IQueryable<T> GetAll();
        //delegate
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        ValueTask<T?> GetByIdAsync(int id);
        ValueTask AddAsync(T Entity);
        void Update(T entity);
        void Delete(T entity);

        /*
         * Delegate = "Metotları tutan ve çağırabilen bir tür (tip güvenli işaretçi)"
         C#’ta en sık kullanılan ve en önemli delegate türleri şunlardır:

✅ 1. Action

Genellikle bir işi yap, ama geriye bir şey döndürme senaryolarında kullanılır.
Action<string> yazdir = (msg) => Console.WriteLine(msg);
yazdir("Merhaba Action");

✅ 2. Func
Geri dönüş değeri vardır

Son parametre dönüş türüdür, önceki parametreler girdi parametreleridir.

      Func<int, int, int> topla = (a, b) => a + b;
int sonuc = topla(3, 4); // sonuc = 7


✅ 3. Predicate
Tek parametre alır, geriye bool döner

Genellikle filtreleme, kontrol gibi işlemlerde kullanılır.
  Predicate<int> ciftMi = sayi => sayi % 2 == 0;
bool sonuc = ciftMi(6); // true


        
         */




    }
}
