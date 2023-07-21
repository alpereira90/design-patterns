using CreationalPatterns.FactoryMethod.Enums;
using CreationalPatterns.FactoryMethod.Interfaces;
using CreationalPatterns.FactoryMethod.Services;

namespace DesignPatterns.Creational.FactoryMethod;

public class ServiceFactoryImpl : ServiceFactory
{
    private readonly Dictionary<ServiceType, Type> _map = new()
    {
        { ServiceType.Traditional, typeof(TraditionalService) },
        { ServiceType.Premium, typeof(PremiumService) },
        { ServiceType.Master, typeof(MasterService) },
        { ServiceType.Top, typeof(TopService) }
    };

    public override IService? Create(ServiceType serviceType)
    {
        if (_map.TryGetValue(serviceType, out var type)) return Activator.CreateInstance(type) as IService;

        return null;
    }
}