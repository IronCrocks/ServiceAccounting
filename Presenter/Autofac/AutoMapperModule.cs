using Autofac;
using AutoMapper;
using Presenter.AutoMapper;

namespace Presenter.Autofac
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<MappingProfile>();
                });

                //config.AssertConfigurationIsValid();

                return config;
            }).AsSelf().SingleInstance();

            builder.Register(ctx =>
            {
                var config = ctx.Resolve<MapperConfiguration>();
                return config.CreateMapper();
            }).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
