using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Bus"))
        {
            EventManager.RaiseOnBus();
        }
        else if (Input.GetKeyDown("Taxi"))
        {
            EventManager.RaiseOnTaxi();
        }
        else if (Input.GetKeyDown("LuxuryBus"))
        {
            EventManager.RaiseOnLuxury();
        }
        
    }
}
