using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody ballRB;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>(); 

        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LaunchBall(){
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
