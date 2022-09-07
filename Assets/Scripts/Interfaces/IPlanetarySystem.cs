using System.Collections.Generic;

public interface IPlanetarySystem
{
    public IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set; }
    public void VelocityUpdate(float deltaTime);
}
