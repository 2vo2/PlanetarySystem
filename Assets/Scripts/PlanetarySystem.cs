using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlanetarySystem : MonoBehaviour, IPlanetarySystem
{
    [SerializeField] private GameObject _planetModel;
    [SerializeField] private GameObject _pivot;
    
    private List<GameObject> _planetaryObjects = new List<GameObject>();
    private GameObject _spawnedPlanetModel;
    private PlanetaryObject _planet;
    private float _zOffset = 15f;
    
    public IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set; }

    private void Update() => VelocityUpdate(Time.deltaTime);
    
    public void InitSystem()
    {
        for (int i = 0; i < Random.Range(1, 8); i++)
        {
            _planet = new PlanetaryObject(Random.Range(0, 7));

            var spawnPoint = new Vector3(0f,0f,_zOffset);
            _spawnedPlanetModel = Instantiate(_planetModel, spawnPoint, Quaternion.identity, transform);
            _zOffset += Random.Range(10f, 30f);
            
            _planet.InitObject(_spawnedPlanetModel);
            
            var planetColor = _spawnedPlanetModel.GetComponent<MeshRenderer>().material.color;
            DrawOrbital(_pivot.transform.position, _spawnedPlanetModel.transform.position, planetColor);
            
            _planetaryObjects.Add(_spawnedPlanetModel);
        }
    }

    private void DrawOrbital(Vector3 center, Vector3 planetPosition, Color color)
    {
        var orbital = new GameObject();
        
        orbital.DrawOrbital
            (Vector3.Distance(center, planetPosition), 
                0.5f, color);
    }
    
    public void VelocityUpdate(float deltaTime)
    {
        foreach (var planet in _planetaryObjects)
        {
            planet.transform.RotateAround(_pivot.transform.position, new Vector3(0,1,0), Random.Range(10, 100) * deltaTime);
        }
    }
}
