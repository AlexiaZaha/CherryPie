using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float parallaxSpeed = 0.5f;
    private float startXPos;

    private void Start()
    {
        startXPos = transform.position.x;
    }

    private void Update()
    {
        // Calculate the distance the player has moved
        float playerXOffset = player.position.x;
        
        // Move the background based on player position with parallax speed
        transform.position = new Vector3(startXPos + playerXOffset * parallaxSpeed, transform.position.y, transform.position.z);
    }
}
