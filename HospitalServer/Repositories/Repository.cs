using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HospitalEntities.Models;

namespace HospitalServer.Repositories
{
    /*
     * Implementation of the IRepository<ModelType>
     */
    public class Repository<ModelType, TId> : IRepository<ModelType, TId> where ModelType : class, IIdentifiable<TId>
    {
        private readonly ApplicationDatabaseContext _applicationDatabaseContext;
        private readonly DbSet<ModelType> _databaseSet;

        public Repository(ApplicationDatabaseContext applicationDatabaseContext)
        {
            _applicationDatabaseContext = applicationDatabaseContext;
            _databaseSet = _applicationDatabaseContext.Set<ModelType>();
        }

        public Repository() : this(new ApplicationDatabaseContext())
        {
        }

        public IEnumerable<ModelType> GetAll(params Expression<Func<ModelType, object>>[] includes)
        {
            // No includes
            if (includes.Length == 0)
            {
                return _databaseSet.ToList();
            }

            var query = _databaseSet.AsQueryable();
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList();
        }

        public IEnumerable<ModelType> GetAll(Expression<Func<ModelType, bool>> predicate, params Expression<Func<ModelType, object>>[] includes)
        {
            return includes.Aggregate(_databaseSet.AsQueryable(),
                (current, includeProperty) => current.Include(includeProperty)).Where(predicate);
        }

        public ModelType GetById(TId id, params Expression<Func<ModelType, object>>[] includes)
        {
            return includes.Aggregate(_databaseSet.AsQueryable(), (current, expression) => current.Include(expression))
                .FirstOrDefault(model => model.Id.Equals(id));
        }

        public ModelType GetById(Func<ModelType, bool> idPredicate, params Expression<Func<ModelType, object>>[] includes)
        {
            var query = _databaseSet.AsQueryable();
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsEnumerable()
                           .Where(idPredicate)
                           .FirstOrDefault();
        }

        public bool Exists()
        {
            return _databaseSet.Any();
        }

        public bool Exists(Expression<Func<ModelType, bool>> predicate)
        {
            return _databaseSet.Any(predicate);
        }

        public void Insert(ModelType model)
        {
            _databaseSet.Add(model);
        }

        public virtual void SetStateModified(ModelType model)
        {
            _applicationDatabaseContext.Entry(model).State = EntityState.Modified;
        }

        public void Update(ModelType model)
        {
            _databaseSet.Attach(model);
            SetStateModified(model);
        }

        public void Delete(object Id)
        {
            ModelType toDelete = _databaseSet.Find(Id);
            _databaseSet.Remove(toDelete);
        }

        public void Save()
        {
            _applicationDatabaseContext.SaveChanges();
        }


    }

    public class Repository<ModelType> : Repository<ModelType, int>, IRepository<ModelType> where ModelType : class, IIdentifiable
    {
        public Repository(ApplicationDatabaseContext applicationDatabaseContext) : base(applicationDatabaseContext)
        {
        }

        public Repository() : base()
        {
        }
    }
}