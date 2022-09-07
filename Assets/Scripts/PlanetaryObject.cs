using UnityEngine;

public class PlanetaryObject : IPlanetaryObject
{
    public MassClassEnum MassClass { get; set; }
    public double Mass { get; set; }

    public PlanetaryObject(int planetNumber) => MassClass = (MassClassEnum)planetNumber;
    
    public void InitObject()
    {
        switch (MassClass)
        {
            case MassClassEnum.Asteroidan :
                Mass = Random.Range(0f, 0.000001f);
                Debug.Log($"Its {MassClassEnum.Asteroidan} his mass {Mass}");
                break;
            case MassClassEnum.Mercurian :
                Mass = Random.Range(0.000001f, 0.1f);
                Debug.Log($"Its {MassClassEnum.Mercurian} his mass {Mass}");
                break;
            case MassClassEnum.Subterran :
                Mass = Random.Range(0.1f, 0.5f);
                Debug.Log($"Its {MassClassEnum.Subterran} his mass {Mass}");
                break;
            case MassClassEnum.Terran :
                Mass = Random.Range(0.5f, 2f);
                Debug.Log($"Its {MassClassEnum.Terran} his mass {Mass}");
                break;
            case MassClassEnum.Superterran :
                Mass = Random.Range(2f, 10f);
                Debug.Log($"Its {MassClassEnum.Superterran} his mass {Mass}");
                break;
            case MassClassEnum.Neptunian :
                Mass = Random.Range(10f, 50f);
                Debug.Log($"Its {MassClassEnum.Neptunian} his mass {Mass}");
                break;
            case MassClassEnum.Jovian :
                Mass = Random.Range(50f, 5000f);
                Debug.Log($"Its {MassClassEnum.Jovian} his mass {Mass}");
                break;
        }
    }
}
