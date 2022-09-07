using UnityEngine;

public class PlanetarySystemFactory : MonoBehaviour, IPlanetarySystemFactory
{
    private PlanetarySystem _planetarySystem;
    
    private void Start()
    {
        Create(10);
        _planetarySystem.InitSystem();
    }

    public IPlanetarySystem Create(double mass)
    {
        _planetarySystem = new PlanetarySystem();
        
        return _planetarySystem;
    }
}
