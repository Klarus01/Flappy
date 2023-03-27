using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] AudioSource AS;
    [SerializeField] AudioClip wingClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void FlySFX()
    {
        AudioClip clip = wingClip;
        AS.PlayOneShot(clip);
    }
}
