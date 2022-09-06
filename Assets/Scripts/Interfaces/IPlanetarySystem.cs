using System.Collections.Generic;

public interface IPlanetarySystem
{
    public List<IPlanetaryObject> PlanetaryObjects { get; set; }
    public void Update(float deltaTime);
}
