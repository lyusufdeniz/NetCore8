
namespace App.Repositories
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        public void SaveChanges() => context.SaveChanges();

        public  Task<int> SaveChangesAsync() => context.SaveChangesAsync();

    }
}
