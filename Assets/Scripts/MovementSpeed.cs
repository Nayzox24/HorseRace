using UnityEngine;

public class MovementSpeed : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody rbPlayer;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        if (Input.GetKey(KeyCode.Q))
        {
               rbPlayer.AddForce(-10.0f, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.D))
        {
               rbPlayer.AddForce(10.0f, 0.0f, 0.0f);
        }
    }
}
