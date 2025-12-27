using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle1;
    [SerializeField] float lunchVelocityX, lunchVelocityY;
    [SerializeField] Vector2 paddleToBallVector;
    [SerializeField] AudioClip[] ballSounds;
    [SerializeField] float randomFactor = 0.2f;


    bool IsLunched = false;


    AudioSource myAudioSource;
    Rigidbody2D myRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        //PaddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsLunched) 
        {
            LockBallToPaddle();
            LunchOnMouseClick();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsLunched)
        {
            VelocityTweak();
            PlaySFX(collision);
        }
    }

    private void VelocityTweak()
    {
        Vector2 velocityTweak = new Vector2
            (Random.Range(0f, randomFactor),
            Random.Range(0f, randomFactor));
        myRigidbody2D.velocity += velocityTweak;
    }

    private void PlaySFX(Collision2D collision)
    {
        if (collision.gameObject.name == "Left Wall" || 
            collision.gameObject.name == "Right Wall" || 
            collision.gameObject.name == "Above Wall")
        {
            myAudioSource.PlayOneShot(ballSounds[2]);
        }
        else if (collision.gameObject.name == "Paddle")
        {
            myAudioSource.PlayOneShot(ballSounds[0]);
        }
    }
    private void LockBallToPaddle()
    {
        Vector2 PaddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = PaddlePosition + paddleToBallVector;
    }
    private void LunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidbody2D.velocity = new Vector2(lunchVelocityX, lunchVelocityY);
            IsLunched = true;
        }
    }

    public void AddBall()
    {
        GameObject newBall = Instantiate(this.gameObject, transform.position, Quaternion.identity);

        newBall.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(randomFactor, randomFactor), 
            Random.Range(randomFactor, randomFactor));
    }
}
