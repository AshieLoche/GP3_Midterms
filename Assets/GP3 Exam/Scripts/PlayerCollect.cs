using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            GameManagement.instance.scoreBoard.ScoreCount();
            collision.gameObject.SetActive(false);
        }
    }

}
