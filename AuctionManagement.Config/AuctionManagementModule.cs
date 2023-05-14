using AuctionManagement.Application;
using AuctionManagement.Domain;
using AuctionManagement.Persistence.Mongo;
using Autofac;
using Framework.Application;
using Framework.Autofac;
using System;
using System.Linq;

namespace AuctionManagement.Config
{
    public class AuctionManagementModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(AuctionCommandHandlers).Assembly)
                .As(type => type.GetInterfaces()
                .Where(interfaceType => interfaceType.IsClosedTypeOf(typeof(ICommandHandler<>))))
                .InstancePerLifetimeScope();

            builder.RegisterType<MongoAuctionRepository>()
                .As<IAuctionRepository>();

            //TODO: remove this
            builder.RegisterType<AutofacCommandBus>()
                .As<ICommandBus>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
