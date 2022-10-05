using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //WEB API içindeki startup a bağlı kalmak yerine değişmesi ihtimaline karşı business katmanında oluşturuyoruz.
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();//Biri senden IProductService isterse ona productManager ver .
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
