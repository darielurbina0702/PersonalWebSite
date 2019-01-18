using Ninject;
using PersonalWebSite.Infrastructure.Repositories;
using PersonalWebSite.Infrastructure.Repositories.Interfaces;
using PersonalWebSite.Services;
using PersonalWebSite.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PersonalWebSite.Resolvers.DI
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }       

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IContactRequestRepository>().To<ContactRequestRepository>();
            _kernel.Bind<IDataProcessorService>().To<DataProcessorService>();
        }
    }
}