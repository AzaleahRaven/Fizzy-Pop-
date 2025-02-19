using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public GameObject playerBall;
    public GameObject platformObject;
    public Animator platformAnimator;

    private Rigidbody ballRigidbody;
    private bool canMove = true;

    private void Start()
    {
        if (playerBall != null)
        {
            ballRigidbody = playerBall.GetComponent<Rigidbody>();
            if (ballRigidbody == null)
            {
                Debug.LogError($"No Rigidbody found on {playerBall.name}. Please add one.");
            }
        }
        else
        {
            Debug.LogError("Player Ball is not assigned. Please assign a GameObject for the ball.");
        }

        if (platformObject != null && platformAnimator == null)
        {
            platformAnimator = platformObject.GetComponent<Animator>();
            if (platformAnimator == null)
            {
                Debug.LogError($"No Animator found on {platformObject.name}. Please add one or assign it manually.");
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canMove = false;

            if (platformAnimator != null)
            {
                platformAnimator.Play("PlatformOpenClose");
            }
        }
    }

    private void FixedUpdate()
    {
        if (canMove && ballRigidbody != null)
        {
            float move = Input.GetAxis("Horizontal"); 

            Vector3 movement = new Vector3(0f, ballRigidbody.velocity.y, move * moveSpeed);

            ballRigidbody.velocity = new Vector3(ballRigidbody.velocity.x, ballRigidbody.velocity.y, movement.z);
        }
    }
}
