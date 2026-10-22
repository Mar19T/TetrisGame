using UnityEngine;
using UnityEngine.Rendering;

public class Ball : MonoBehaviour
{
    public static int PlayerOneScore = 0; // Player One Score
    public static int PlayerTwoScore = 0; // Player Two Score
    public static int MaxScore = 5; // Maximum score to win the game
    public float speed = 10f; // Speed of the ball movement

    private Rigidbody2D rb; // Reference to the Rigidbody2D component attached to the ball


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity= Vector2.right * speed; // Set the initial velocity of the ball to the right
        PlayerOneScore = 0; // Reset Player One's score to 0
        PlayerTwoScore = 0; // Reset Player Two's score to 0
    }

    public void Update()
    {
     if(PlayerOneScore>=MaxScore || PlayerTwoScore>=MaxScore) 
        {
            //freeze ball in center of scene
            transform.position = Vector2.zero;
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Left_Racket")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            rb.linearVelocity = dir * speed;
        }
        if (col.gameObject.name == "Right_Racket")
        {
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            rb.linearVelocity = dir * speed;
        }

        if (col.gameObject.name == "Right_Wall")
        {   
            //What happens when the ball collides with the right wall
            transform.position = new Vector2(-5, 0);
            //Set new ball position (x-axis -5 ) just left of dotted line
            Vector2 dir = new Vector2(-1, 0).normalized;
            rb.linearVelocity = dir * speed;
            //reverse  x direction so moving left 
            PlayerOneScore++; // Increment Player One's score
            Debug.Log("Player One Score: " + PlayerOneScore); // Log Player One's score to the console


        }
        if (col.gameObject.name == "Left_Wall")
        {       
            //What happens when the ball collides with the left wall
            transform.position = new Vector2(5, 0);
            //set new ball position (x-axis 5 ) just right of dotted line
            Vector2 dir = new Vector2(1, 0).normalized;
            rb.linearVelocity = dir * speed;
            //reverse x direction so moving right
            PlayerTwoScore++; // Increment Player Two's score
            Debug.Log("Player Two Score: " + PlayerTwoScore); // Log Player Two's score to the console

        }
    }


}
