using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MaliyoCardData", menuName = "MaliyoCard")]
public class MyScriptableObject : ScriptableObject
{
    public string titleText;
    public string descriptionText;
    public string fuelText;
    public string speedText;
    public Sprite characterImage;
}
