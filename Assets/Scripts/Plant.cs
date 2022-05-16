using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{    
    public Sprite spriteSprout;
    public Sprite spriteSeedling;
    public Sprite spriteVegetative;
    public Sprite spriteBudding;
    public Sprite spriteFlowering;
    public Sprite spriteFruiting;

    public float lifespanSeed;
    public float lifespanSprout;
    public float lifespanSeedling;
    public float lifespanVegetative;
    public float lifespanBudding;
    public float lifespanFlowering;
    public float lifespanFruiting;

    internal GameManager gm;
    private float dayPlanted;
    private float lastGrowthDay;
    private string stage = "planted";
    
    // Start is called before the first frame update
    void Start()
    {
        dayPlanted = gm.currentDay;
        lastGrowthDay = gm.currentDay;
        GetComponent<SpriteRenderer>().sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (stage == "planted" && gm.currentDay-dayPlanted > lifespanSeed)
        {
            stage = "sprout";
            GetComponent<SpriteRenderer>().sprite = spriteSprout;
            lastGrowthDay = gm.currentDay;
        }
        if (stage == "sprout" && gm.currentDay - lastGrowthDay > lifespanSprout)
        {
            stage = "seedling";
            GetComponent<SpriteRenderer>().sprite = spriteSeedling;
            lastGrowthDay = gm.currentDay;
        }
        if (stage == "seedling" && gm.currentDay - lastGrowthDay > lifespanSeedling)
        {
            stage = "vegetative";
            GetComponent<SpriteRenderer>().sprite = spriteVegetative;
            lastGrowthDay = gm.currentDay;
        }
        if (stage == "vegetative" && gm.currentDay - lastGrowthDay > lifespanVegetative)
        {
            stage = "budding";
            GetComponent<SpriteRenderer>().sprite = spriteBudding;
            lastGrowthDay = gm.currentDay;
        }
        if (stage == "budding" && gm.currentDay - lastGrowthDay > lifespanBudding)
        {
            stage = "flowering";
            GetComponent<SpriteRenderer>().sprite = spriteFlowering;
            lastGrowthDay = gm.currentDay;
        }
        if (stage == "flowering" && gm.currentDay - lastGrowthDay > lifespanFlowering)
        {
            stage = "fruiting";
            GetComponent<SpriteRenderer>().sprite = spriteFruiting;
            lastGrowthDay = gm.currentDay;
        }
        if (stage == "fruiting" && gm.currentDay - lastGrowthDay > lifespanFruiting)
        {
            stage = "vegetative";
            GetComponent<SpriteRenderer>().sprite = spriteVegetative;
            lastGrowthDay = gm.currentDay;
        }
    }
}
