using UnityEngine;

public class endTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManagerScritpt;   
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player")) 
        {
            Debug.Log("le joueur a atteint la ligne d'arrivée !");
            gameManagerScritpt.CompleteLevel();
        }
    }
}
