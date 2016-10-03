# DAL-SDK
Data access layer using generic common methods .
Take alook to the sample .

After adding the DAL.SDK to your projcet :

at your project create  a collection to your model and extend BusinessCollection

    public class ApplicationUsers : BusinessCollection<ApplicationUser,ApplicationDbContext>
 
at the UserRepository :
 
     public class UserRepository : GenericRepository<ApplicationUsers, ApplicationUser>
     
at GenericRepository :

  
    public class GenericRepository<TCollection, TItem>
        where TCollection : BusinessCollection<TItem, ApplicationDbContext>, new()
        where TItem : class,new()
    {

        public IEnumerable<TItem> QueryByAll()
        {
            var c = new TCollection();
            return c.Get().ToList();
        }
        public TItem GetById(string id)
        {
            var c = new TCollection();

            return c.GetByID(id);
        }
        public TItem Save(TItem item)
        {
            var c = new TCollection();
            return c.Insert(item);
        }

        public TCollection GetCollection()
        {
            var c = new TCollection();
            return c;

        }
    }
