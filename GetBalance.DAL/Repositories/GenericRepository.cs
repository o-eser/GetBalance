using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DAL.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private AppDbContext context;

        public GenericRepository()
        {
            context = new AppDbContext();
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();

        }

        public TEntity GetById(int id)
        {
            try
            {
                //NortwindContext context = new NortwindContext();
                return context.Set<TEntity>().Find(id);

            }
            catch (Exception)
            {

                throw new Exception("Aranılan Kayıt Mevcut Değil!");
            }

        }
        public int Add(TEntity entity)
        {
            try
            {
                //NortwindContext context = new NortwindContext();

                context.Set<TEntity>().Add(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Ekleme işlemi başarısız");
            }

        }

        public int DeleteEntity(TEntity entity, int id)
        {
            try
            {
                TEntity deleted = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(deleted);

                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Silme Başarısız");

            }

        }
        public int DeleteEntity(int id)
        {
            try
            {
                TEntity deleted = GetById(id);
                context.Remove<TEntity>(deleted);
                return context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Silme Başarısız");
            }
        }
    }
}
