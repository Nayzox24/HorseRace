using UnityEngine;

public class MovementSpeed : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float sidewaysForce = 15f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        if (Input.GetKey(KeyCode.Q))
        {
               rbPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.D))
        {
               rbPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
    }
}
