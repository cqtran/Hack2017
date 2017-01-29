using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    float fallZone = -10f;
    public Transform playerSpawnPoint = null; //create an empty gameobject and assign it to this script  in the inspector   
    void Update()
    {
        if (player.transform.position.y < fallZone) //Assuming its a 2D game
        {
            player.transform.position = playerSpawnPoint.position;
        }

    }
}
