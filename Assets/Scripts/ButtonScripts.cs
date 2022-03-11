using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    public MyScriptableObject card;
    public Text titleText;
    public Text descriptionText;
    public Text fuelText;
    public Text speedText;
    public Image characterImage;

    private void OnEnable()
    {
        EventManager.onTaxi += Taxi;
        EventManager.onBus += Bus;
        EventManager.onLuxury += Luxury;
    }
    void Start()
    {
        
    }
    private void OnDisable()
    {
        EventManager.onTaxi -= Taxi;
        EventManager.onBus -= Bus;
        EventManager.onLuxury -= Luxury;
    }
    public void Taxi()
    {
        titleText.text = card.titleText;
        descriptionText.text = card.descriptionText;
        fuelText.text = card.fuelText;
        speedText.text = card.speedText;
        characterImage.sprite = card.characterImage;
    }
    public void Bus()
    {
        titleText.text = card.titleText;
        descriptionText.text = card.descriptionText;
        fuelText.text = card.fuelText;
        speedText.text = card.speedText;
        characterImage.sprite = card.characterImage;
    }
    public void Luxury()
    {
        titleText.text = card.titleText;
        descriptionText.text = card.descriptionText;
        fuelText.text = card.fuelText;
        speedText.text = card.speedText;
        characterImage.sprite = card.characterImage;
    }
}
