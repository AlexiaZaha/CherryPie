using UnityEngine;

public class Collectables : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            player.fruits += 1;
            Destroy(gameObject);
        }
    }
}