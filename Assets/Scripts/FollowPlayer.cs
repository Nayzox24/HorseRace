using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; // Reference to the player's transfor
    [SerializeField] private Vector3 offset; // Offset from the player's position
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset; // Update the player's position to follow the camera with the specified offset


    }
}
