using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolutionRep
{
   public interface ISingletonService
    {
        Guid GetOperationID();
    }

    public interface IContainerRuntime
    {
        TService GetService<TService>();
        object GetService(Type serviceType);
    }

    public interface IContainerRegistration
    {
        // Transient service registration methods

        // Service
        void AddTransient<TService>();

        // Service factory method
        void AddTransient<TService>(Func<IContainerRuntime, TService> factoryMethod);

        // Service -> Concrete
        void AddTransient<TService, TConcrete>() where TConcrete : TService;

        // Service -> Concrete factory method
        void AddTransient<TService, TConcrete>(Func<IContainerRuntime, TConcrete> factoryMethod) where TConcrete : TService;

        // Singleton service registration methods

        // Service
        void AddSingleton<TService>();

        // Service instance
        void AddSingleton<TService>(TService instance);

        // Service factory method
        void AddSingleton<TService>(Func<IContainerRuntime, TService> factoryMethod);

        // Service -> Concrete
        void AddSingleton<TService, TConcrete>() where TConcrete : TService;

        // Service -> Concrete instance
        void AddSingleton<TService, TConcrete>(TConcrete instance) where TConcrete : TService;

        // Service -> Concrete factory method
        void AddSingleton<TService, TConcrete>(Func<IContainerRuntime, TConcrete> factoryMethod) where TConcrete : TService;

        // Create a runtime container
        IContainerRuntime CreateRuntime();
    }

}
