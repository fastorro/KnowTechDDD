﻿
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Shared.Patterns.IoC
{
    public static class Container
    {
        private static IWindsorContainer _container;

        public static void Configure(Action<IWindsorContainer> configurator)
        {
            _container = new WindsorContainer();
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));

            configurator(_container);
        }
        
        public static IWindsorContainer Current
        {
            get { return _container; }
        }
    }
}