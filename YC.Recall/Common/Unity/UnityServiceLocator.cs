using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace YC.Recall.Common.Unity
{
    /// <summary>
    /// Unity实例
    /// </summary>
    class UnityServiceLocator : IUnityLocator
    {
        private UnityContainer container;

        public UnityServiceLocator()
        {
            container = new UnityContainer();
        }

        void IUnityLocator.Register<TInterface, Template>()
        {
            container.RegisterType<TInterface, Template>();
        }

        TInterface IUnityLocator.Get<TInterface>(string typeName)
        {
            return container.Resolve<TInterface>(typeName);
        }
        TInterface IUnityLocator.Get<TInterface>()
        {
            return container.Resolve<TInterface>();
        }
        /// <summary>
        ///默认自动注册
        /// </summary>
        public void Register()
        {
            //自动注册
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromAllInterfaces,
                WithName.TypeName, WithLifetime.PerResolve);
        }
    }
}
