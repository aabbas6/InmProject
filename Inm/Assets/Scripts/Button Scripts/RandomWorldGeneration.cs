using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomWorldGeneration : MonoBehaviour {

    /// <summary>
    /// The code for EventSystem for DontDestroy on Load
    /// This code contains values that picks the biome list, and generates them.
    /// 
    /// </summary>
    public bool area1Gen, area2Gen, area3Gen, area4Gen, area5Gen, area6Gen, area7Gen, area8Gen = false;
    public bool warriorBiome, thiefBiome, archerBiome, mageBiome;
    public bool clickedOnce = false;
    public List<int> biomes;
    public List<int> randomChoices;

    public void pickBiomes()
    {
        //random generate the biomes: 1 - snow ; 2 - grassland; 3 - mountain
        //              4 - valley, 5 - Wasteland, 6 - Midnight Valley, 7 - Dark Forest, 8 - Riverland
        //pickBiomes();
        if (!clickedOnce)
        {
            for (int i = 0; i < 6; i++)
            {
                if (archerBiome == false)
                {
                    randomChoices.Add(1);
                    randomChoices.Add(2);
                    archerBiome = true;
                }
                if (warriorBiome == false)
                {
                    randomChoices.Add(3);
                    randomChoices.Add(4);
                    warriorBiome = true;
                }
                if (thiefBiome == false)
                {
                    randomChoices.Add(5);
                    randomChoices.Add(6);
                    thiefBiome = true;
                }
                if (mageBiome == false)
                {
                    randomChoices.Add(7);
                    randomChoices.Add(8);
                }

                if (archerBiome == true && warriorBiome == true && thiefBiome == true && mageBiome == true)
                {
                    randomChoices.Add(1);
                    randomChoices.Add(2);
                    randomChoices.Add(3);
                    randomChoices.Add(4);
                    randomChoices.Add(5);
                    randomChoices.Add(6);
                    randomChoices.Add(7);
                    randomChoices.Add(8);
                }

                float RCLength = randomChoices.Count;
                int RandomIndex = (int)Random.Range(1.0f, RCLength);
                int biomeNum = randomChoices[RandomIndex];
                //check if this biome is already in the list
                while (biomes.Contains(biomeNum))
                {
                    RandomIndex = (int)Random.Range(1.0f, RCLength);
                    biomeNum = randomChoices[RandomIndex];
                }
                biomes.Add(biomeNum);
            }

            for (int i = 0; i < biomes.Count; i++)
            {
                Debug.Log(biomes[i]);
            }
            clickedOnce = true;
        }
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(2);
    }

    
	public bool isArea1Gen()
    {
        return area1Gen;
    }
    public void setArea1(bool set)
    {
        area1Gen = set;
    }

}
