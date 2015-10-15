using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerMarket.Shared.Patterns.Domain;
using SoccerMarket.Shared.Patterns.Repository;

namespace SoccerMarket.Domain.Test
{
    public class O : IDomainObject<Guid>
    {
        public Guid Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDirty
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepository<Guid, O> repo = null;


             
        }
    }
}
