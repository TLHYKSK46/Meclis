using MeclisDal.IDal;
using MeclisEntities.IEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MeclisDal.BaseDb.Interfaces;
using System.Data.Entity.Validation;

namespace MeclisDal.BaseDb
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
      

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                entity.EklenmeTarihi = DateTime.Now;
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
              //  context.Configuration.LazyLoadingEnabled = false;

                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                //var deleteEntity = context.Entry(entity);
                //deleteEntity.State = EntityState.Deleted;
                //context.SaveChanges();
                entity.Silindi = 1;
                entity.SilinmeTarihi = DateTime.Now;
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter=null)
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {

                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
               entity.GuncellemeTarihi = DateTime.Now;
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;

                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException dbValEx)
                {
                    var outputLines = new StringBuilder();
                    foreach (var eve in dbValEx.EntityValidationErrors)
                    {
                        outputLines.AppendFormat("{0}: Entity of type {1} in state {2} has the following validation errors:"
                          , DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry);

                        foreach (var ve in eve.ValidationErrors)
                        {
                            outputLines.AppendFormat("- Property: {0},Error: {1}", ve.PropertyName, ve.ErrorMessage);
                        }
                    }

                    //Tools.Notify(this, outputLines.ToString(),"error");
                    throw new DbEntityValidationException(string.Format("Validation errorsrn{0}"
                     , outputLines.ToString()), dbValEx);
                }
              
            }
        }
    }
}
