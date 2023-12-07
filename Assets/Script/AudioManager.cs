using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] private AudioClip[] bjClips;
    [SerializeField] private AudioClip _clip1;
    [SerializeField] private AudioSource _collision;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayCollisionEffect1()                  // Player collides with map / static objects
    {
        _collision.clip = _clip1;
        _collision.Play();
    }
    public void PlayCollisionEffect2()                  // Player collides with an NPC
    {
        _collision.clip = bjClips[Random.Range(0,bjClips.Length)];
        _collision.Play();
    }
}