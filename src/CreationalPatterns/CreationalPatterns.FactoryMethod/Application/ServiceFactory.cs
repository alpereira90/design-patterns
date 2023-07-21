using CreationalPatterns.FactoryMethod.Enums;
using CreationalPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod;

public abstract class ServiceFactory
{
    public abstract IService? Create(ServiceType serviceType);
}