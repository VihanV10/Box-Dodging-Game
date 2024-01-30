using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public NewBehaviourScript movement; 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Hit");
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
