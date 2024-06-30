/*
 * Author: Elyas Chua-Aziz
 * Date: 06/05/2024
 * Description: 
 * The Collectible will destroy itself after being collided with.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Collectible : Interactable
{
    [SerializeField]
    private AudioClip collectAudio;
    public delegate void Action();
    public static event Action OnCollected;
    public static int total = 5;

    void Awake() => total++;
    
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, Time.time * 100f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            AudioSource.PlayClipAtPoint(collectAudio, transform.position, 100f);
            Destroy(gameObject);
        }   
    }
    


   

    


}
