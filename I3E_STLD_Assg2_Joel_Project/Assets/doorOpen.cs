using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public Transform player;
    public Transform door;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if(distance <=25)
        {
            anim.SetBool("Near", true);
        }
        else
        {
            anim.SetBool("Near", false);
        }
    }
}
