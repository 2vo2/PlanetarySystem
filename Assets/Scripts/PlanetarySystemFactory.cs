using System;
using UnityEngine;

public class PlanetarySystemFactory : MonoBehaviour, IPlanetarySystemFactory
{
    [SerializeField] private PlanetarySystem _planetarySystem;
    
    private void Start()
    {
        Create(10);
        _planetarySystem.InitSystem();
    }

    public IPlanetarySystem Create(double mass)
    {
        _planetarySystem = Instantiate(_planetarySystem);
        
        return _planetarySystem;
    }
}
