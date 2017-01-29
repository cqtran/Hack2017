using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    public GameObject Player = GameObject.FindGameObjectWithTag("player");
    public GameObject spawn = GameObject.FindGameObjectWithTag("playerSpawnPoint");
    private bool died = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(Player);
            died = true;
        }

        if (died == true)
        {
            Player.transform.position = spawn.transform.position;
        }
    }

}
