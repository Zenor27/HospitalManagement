using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HospitalEntities.Models;

namespace HospitalServer.Repositories
{
    /*
     * Abstract Repository of ModelType
     */
    public interface IRepository<ModelType, TId> where ModelType : class, IIdentifiable<TId>
    {
        /*
         * Get all object of ModelType
         */
        IEnumerable<ModelType> GetAll(params Expression<Func<ModelType, object>>[] includes);

        /*
         * Get all object of ModelType based on predicate
         */
        IEnumerable<ModelType> GetAll(Expression<Func<ModelType, bool>> predicate, params Expression<Func<ModelType, object>>[] includes);

        /*
         * Get one particular object of ModelType with Id
         */
        ModelType GetById(TId id, params Expression<Func<ModelType, object>>[] includes);

        /*
         * Get one particular object of ModelType with Id
         */
        ModelType GetById(Func<ModelType, bool> idPredicate, params Expression<Func<ModelType, object>>[] includes);

        /*
         * Check that at least one instance exists.
         */
        bool Exists();

        /*
         * Check that at least one instance exists.
         */
        bool Exists(Expression<Func<ModelType, bool>> predicate);

        /*
         * Insert a new ModelType
         */
        void Insert(ModelType model);

        /*
         * Set to state of an entity to modify
         */
        void SetStateModified(ModelType model);

        /*
         * Update an item
         */

        void Update(ModelType model);
        /*
         * Delete an item by its Id
         */

        void Delete(object Id);

        /*
         * Save into repository
         */
        void Save();
    }

    public interface IRepository<ModelType> : IRepository<ModelType, int> where ModelType : class, IIdentifiable
    { }
}
