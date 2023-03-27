using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundTrack;
    public float strength = 1;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(new Vector2(0, strength), ForceMode2D.Impulse);
            AudioManager.instance.FlySFX();
            rb.velocity = Vector2.up * strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameManager.Instance.OnGameOver();
    }
}
