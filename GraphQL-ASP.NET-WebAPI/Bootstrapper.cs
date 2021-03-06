﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GraphQL;
using GraphQL.Types;
using StarWars;
using StarWars.Types;

namespace GraphQL_ASP.NET_WebAPI
{
    public class Bootstrapper
    {
        public System.Web.Http.Dependencies.IDependencyResolver Resolver()
        {
            var container = BuildContainer();
            var resolver = new SimpleContainerDependencyResolver(container);
            return resolver;
        }

        private ISimpleContainer BuildContainer()
        {
            var container = new SimpleContainer();
            container.Singleton<IDocumentExecuter>(new DocumentExecuter());
            container.Singleton<IDocumentWriter>(new GraphQL.NewtonsoftJson.DocumentWriter(true));

            container.Singleton(new StarWarsData());
            container.Register<StarWarsQuery>();
            container.Register<StarWarsMutation>();
            container.Register<HumanType>();
            container.Register<HumanInputType>();
            container.Register<DroidType>();
            container.Register<CharacterInterface>();
            container.Singleton<ISchema>(new StarWarsSchema(new FuncServiceProvider(type => container.Get(type))));

            return container;
        }

    }
}