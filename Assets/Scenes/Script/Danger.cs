using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Player myPlayer;

        if (other.GetComponent<Player>() !=null)
        {
            myPlayer = other.GetComponent<Player>();
            myPlayer.p_pv -= 1;
            
            if (myPlayer.p_pv == 0)
            {
                myPlayer.gameObject.SetActive(false);
            }
        }
    }
}
