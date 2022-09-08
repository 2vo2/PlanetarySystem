using UnityEngine;

public class PlanetaryObject : IPlanetaryObject
{
    public MassClassEnum MassClass { get; set; }
    public double Mass { get; set; }
    public float Radius { get; set; }

    public PlanetaryObject(int planetNumber) => MassClass = (MassClassEnum)planetNumber;
    
    public void InitObject(GameObject planet)
    {
        switch (MassClass)
        {
            case MassClassEnum.Asteroidan :
                PlanetStatsSettings(MassClassEnum.Asteroidan);
                PlanetModelSettings(planet, MassClassEnum.Asteroidan, Color.blue);
                break;
            case MassClassEnum.Mercurian :
                Mass = Random.Range(0.000001f, 0.1f);
                Radius = Random.Range(0.03f, 0.7f);
                PlanetModelSettings(planet, MassClassEnum.Mercurian, Color.cyan);
                break;
            case MassClassEnum.Subterran :
                PlanetStatsSettings(MassClassEnum.Subterran);
                PlanetModelSettings(planet, MassClassEnum.Subterran, Color.gray);
                break;
            case MassClassEnum.Terran :
                PlanetStatsSettings(MassClassEnum.Terran);
                PlanetModelSettings(planet, MassClassEnum.Terran, Color.green);
                break;
            case MassClassEnum.Superterran :
                PlanetStatsSettings(MassClassEnum.Superterran);
                PlanetModelSettings(planet, MassClassEnum.Superterran, Color.magenta);
                break;
            case MassClassEnum.Neptunian :
                PlanetStatsSettings(MassClassEnum.Neptunian);
                PlanetModelSettings(planet, MassClassEnum.Neptunian, Color.red);
                break;
            case MassClassEnum.Jovian :
                PlanetStatsSettings(MassClassEnum.Jovian);
                PlanetModelSettings(planet, MassClassEnum.Jovian, Color.white);
                break;
        }
    }

    private void PlanetModelSettings(GameObject planet, MassClassEnum planetType, Color color)
    {
        planet.GetComponent<MeshRenderer>().material.color = color;
        planet.transform.localScale = new Vector3(Radius, Radius, Radius);
        Debug.Log($"Its {planetType} his mass {Mass}");
    }

    private void PlanetStatsSettings(MassClassEnum planetType)
    {
        switch (planetType)
        {
            case MassClassEnum.Asteroidan :
                Mass = Random.Range(0f, 0.000001f);
                Radius = Random.Range(0.01f, 0.03f);
                break;
            case MassClassEnum.Mercurian :
                Mass = Random.Range(0.000001f, 0.1f);
                Radius = Random.Range(0.03f, 0.7f);
                break;
            case MassClassEnum.Subterran :
                Mass = Random.Range(0.1f, 0.5f);
                Radius = Random.Range(0.5f, 1.2f);
                break;
            case MassClassEnum.Terran :
                Mass = Random.Range(0.5f, 2f);
                Radius = Random.Range(0.8f, 1.9f);
                break;
            case MassClassEnum.Superterran :
                Mass = Random.Range(2f, 10f);
                Radius = Random.Range(1.3f, 3.3f);
                break;
            case MassClassEnum.Neptunian :
                Mass = Random.Range(10f, 50f);
                Radius = Random.Range(2.1f, 5.7f);
                break;
            case MassClassEnum.Jovian :
                Mass = Random.Range(50f, 5000f);
                Radius = Random.Range(3.5f, 27f);
                break;
        }
    }
}
