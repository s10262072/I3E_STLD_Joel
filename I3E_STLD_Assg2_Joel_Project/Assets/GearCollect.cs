
/*
 * Author: Leo Shao Wei Joel
 * Date: 30/06/2024
 * Description: Code for collecting the gear 
 */using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearCollect : MonoBehaviour

{
    [SerializeField] private int value;
    private bool hasTriggered;

    private GearManager gearManager;

// Start is called before the first frame update
    private void Start()
    {
        gearManager = GearManager.instance;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            gearManager.ChangeGears(value);
            Destroy(gameObject);
        }
    }
}
