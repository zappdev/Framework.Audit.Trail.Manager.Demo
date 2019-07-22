﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using CLMS.Framework.Auditing.Model;
using CLMS.Framework.Data.DAL;

namespace CLMS.Framework.Auditing.DAL
{
    public class Repository : ICreateRepository, IAuditingRepository
    {
        private readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }

        public void DeleteAuditPropertyConfiguration(AuditPropertyConfiguration propertyConfiguration, bool doNotCallDeleteForThis = false, bool isCascaded = false, object calledBy = null)
        {
            throw new NotImplementedException();
        }

        public List<T> Get<T>(Expression<Func<T, bool>> predicate, bool cacheQuery = true)
        {
            throw new NotImplementedException();
        }

        public List<T> Get<T>(Expression<Func<T, bool>> predicate, int startRowIndex, int pageSize, Dictionary<Expression<Func<T, object>>, bool> orderBy, out int totalRecords, bool cacheQuery = true)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>(bool cacheQuery = true)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>(int startRowIndex, int pageSize, out int totalRecords, bool cacheQuery = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAsQueryable<T>(Expression<Func<T, bool>> predicate = null, bool cacheQuery = true)
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(object id, bool throwIfNotFound = true) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMainQuery<T>()
        {
            throw new NotImplementedException();
        }

        public void Insert<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Save<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void SaveWithoutTransaction<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
