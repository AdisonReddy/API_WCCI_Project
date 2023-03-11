namespace InnovaDiscs.Repositories.Interfaces
{
    public interface IRepository<T>
        where T : class
    {
        List<T>GetAll();   //Read
        T? GetById(int id);
        T Add(T entity);     //create
        T Update(T entity);   //update
        void Delete(int id);  //delete
    }
}
