using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnTaxi();
    public static event OnTaxi onTaxi;

    public delegate void OnBus();//delegate
    public static event OnBus onBus;//event

    public delegate void OnLuxury();
    public static event OnLuxury onLuxury;
    // Start is called before the first frame update
    public static void RaiseOnTaxi()
    {
        if (onTaxi != null)
        {
            onTaxi();
        }
    }
    public static void RaiseOnBus()
    {
        if (onBus != null)
        {
            onBus();
        }
    }
    public static void RaiseOnLuxury()
    {
        if (onLuxury != null)
        {
            onLuxury();
        }
    }
    
}
