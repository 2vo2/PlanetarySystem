using System.Collections.Generic;
using UnityEngine;

public class PlanetarySystem : IPlanetarySystem
{
    private List<PlanetaryObject> _planetaryObjects = new List<PlanetaryObject>();

    public IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set; }

    public void InitSystem()
    {
        for (int i = 0; i < Random.Range(1, 7); i++)
        {
            var planet = new PlanetaryObject(Random.Range(0, 6));
            _planetaryObjects.Add(planet);
            planet.InitObject();
        }

        Debug.Log(_planetaryObjects.Count);
        PlanetaryObjects = _planetaryObjects;
    }

    public void VelocityUpdate(float deltaTime)
    {
        Debug.Log(deltaTime);
    }
}
