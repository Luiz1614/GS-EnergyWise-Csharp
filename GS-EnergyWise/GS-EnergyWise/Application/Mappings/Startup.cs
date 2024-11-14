namespace GS_EnergyWise.Application.Mappings;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
    }
}