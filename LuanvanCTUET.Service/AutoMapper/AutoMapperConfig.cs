using AutoMapper;

namespace LuanvanCTUET.Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModel());
                cfg.AddProfile(new ViewModelToDomain());
            });
        }
    }
}