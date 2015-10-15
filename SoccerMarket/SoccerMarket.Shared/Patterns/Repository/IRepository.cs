using SoccerMarket.Shared.Patterns.Domain;
using System;

namespace SoccerMarket.Shared.Patterns.Repository
{
    public interface IRepository<TId, TDomainObject>
        where TId : IEquatable<TId>
        where TDomainObject : IDomainObject<TId>
    {
        void Add(TDomainObject domainObject);
        void Remove(TDomainObject domainObject);
        TDomainObject GetById(TId id);
    }
}
