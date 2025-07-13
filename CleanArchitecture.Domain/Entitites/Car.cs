using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entitites;

public sealed class Car:Entity
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int EnginPower { get; set; }

}
