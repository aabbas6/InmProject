using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area1Generation : MonoBehaviour
{

    public GameObject RWGScript;
    private bool areaGenerated;
    private List<int> biomeList;
    private int biome;
    // Use this for initialization
    void Start()
    {
        RWGScript = GameObject.Find("EventSystem");
        areaGenerated = RWGScript.GetComponent<RandomWorldGeneration>().isArea1Gen();
        biomeList = RWGScript.GetComponent<RandomWorldGeneration>().biomes;
        biome = biomeList[0];
        if (!areaGenerated)
        {
            RWGScript.GetComponent<RandomWorldGeneration>().setArea1(true);
            generateArea();
        }

    }

    private void generateArea()
    {
        GameObject biomeBlock;
        switch (biome)
        {
            //random generate the biomes: 1 - snow ; 2 - grassland; 3 - mountain
            //              4 - valley, 5 - Wasteland, 6 - Midnight Valley, 7 - Dark Forest, 8 - Riverland
            case 1:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/snow", typeof(GameObject))) as GameObject;
                break;
            case 2:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/grassland", typeof(GameObject))) as GameObject;
                break;
            case 3:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/mountain", typeof(GameObject))) as GameObject;
                break;
            case 4:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/valley", typeof(GameObject))) as GameObject;
                break;
            case 5:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/wasteland", typeof(GameObject))) as GameObject;
                break;
            case 6:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/midnightvalley", typeof(GameObject))) as GameObject; break;
            case 7:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/darkforest", typeof(GameObject))) as GameObject;
                break;
            case 8:
                biomeBlock = Instantiate(Resources.Load("Prefabs/Temp/riverland", typeof(GameObject))) as GameObject;
                break;
            default:
                break;
        }
    }

}
