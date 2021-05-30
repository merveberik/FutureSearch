using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
//using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
//using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<SubCategoryManager>().As<ISubCategoryService>().SingleInstance();
            builder.RegisterType<EfSubCategoryDal>().As<ISubCategoryDal>().SingleInstance();

            builder.RegisterType<CardDescriptionManager>().As<ICardDescriptionService>().SingleInstance();
            builder.RegisterType<EfCardDescriptionDal>().As<ICardDescriptionDal>().SingleInstance();

            builder.RegisterType<TarotCardManager>().As<ITarotCardService>().SingleInstance();
            builder.RegisterType<EfTarotCardDal>().As<ITarotCardDal>().SingleInstance();

            builder.RegisterType<TarotImageManager>().As<ITarotImageService>().SingleInstance();
            builder.RegisterType<EfTarotImageDal>().As<ITarotImageDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }

    }
}
