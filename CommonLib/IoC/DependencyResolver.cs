using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.IoC
{
    public class DependencyResolver
    {
        #region Singleton

        private static volatile DependencyResolver instance;
        private static object syncRoot = new object();

        public static DependencyResolver Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DependencyResolver();
                    }
                }

                return instance;
            }
        } 
        #endregion

        private IUnityContainer container;

        private DependencyResolver()
        {
            this.container = new UnityContainer();
            this.container.LoadConfiguration();
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }

        public void Register<TFrom, TTo>()
            where TTo : TFrom
        {
            this.container.RegisterType<TFrom, TTo>();
        }
    }
}
