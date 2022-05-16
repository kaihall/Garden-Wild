using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : MonoBehaviour
{
    private GameManager gm;
    public GameObject potPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gm.currentTool == "Pot")
            {
                GameObject newPot = Instantiate(potPrefab);
                newPot.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
                newPot.GetComponent<FlowerPot>().gameManager = gm;
            }
        }
    }
}
