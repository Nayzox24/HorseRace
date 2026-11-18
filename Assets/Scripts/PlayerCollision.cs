using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private MovementSpeed playerMovementScript;
  void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.CompareTag ("Obstacle"))
        {
            Debug.Log("On a touché" + collisionInfo.collider.name);
            playerMovementScript.enabled = false;
        }

    }
}
