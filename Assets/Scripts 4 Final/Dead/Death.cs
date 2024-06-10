using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    //Incomplete. Probably not going to build upon unless I have time

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "FallDetection")
        {
            //SceneManager.LoadScene("SampleScene");
        }
    }
}
