using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickupUI : MonoBehaviour
{
    public pickerupper player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Pickup Count: " +player.count;
    }
}
