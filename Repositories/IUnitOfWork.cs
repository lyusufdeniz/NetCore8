namespace App.Repositories
{
    public interface IUnitOfWork
    {
        public Task<int> SaveChangesAsync();
        public void SaveChanges();

    }
}
