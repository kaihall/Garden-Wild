using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPot : MonoBehaviour
{
    public GameManager gameManager;

    private bool followMouse = false;
    private Plant plant;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followMouse)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Click");
        if (gameManager.currentTool == "Hand")
        {
            followMouse = !followMouse;
        }
        else if (gameManager.currentTool == "Seed" && plant == null)
        {
            GameObject newPlant = (GameObject)Instantiate(Resources.Load("Prefabs/Plants/" + gameManager.currentSeed));
            newPlant.transform.position = transform.position + Vector3.up * 2.8f;
            newPlant.transform.SetParent(transform);
            plant = newPlant.GetComponent<Plant>();
            plant.gm = gameManager;
        }
    }
}
