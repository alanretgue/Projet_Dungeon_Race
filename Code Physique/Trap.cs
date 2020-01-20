using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private float randomTime;
    bool isOn = false;

    public GameObject Killzone;
    

    // Active selon la valeur de isOn et de randomTime la DeadZone
    void Update()
    {
        if (isOn)
        {
            randomTime -= Time.deltaTime;
            if (randomTime <= 0)
            {
                //active la DeadZone du piege
                Killzone.SetActive(true);
                isOn = false;
            }
        }
        else
        {
            randomTime = Random.value;
            //desactive la DeadZone du piege
            Killzone.SetActive(false);
        }
    }

    //Une zone de detection du joueur afin d'activer de maniere la plus aleatoire possible la deadzone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            isOn = true;
        }
        else
        {
            isOn = false;
        }

    }

    // Attention pour que ce script marche il faut appliquer le Layer Player à l'objet joueur !!!!!
}
