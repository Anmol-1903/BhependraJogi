using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    AudioSource _mainAudio;
    [SerializeField] AudioClip _dinVich, YoYoHoneySingh;

    private void Awake()
    {
        _mainAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DinVich"))
        {
            other.GetComponentInParent<Animator>().enabled = false;
            _mainAudio.clip = _dinVich;
        }
        else if (other.CompareTag("YoHoney"))
        {
            other.GetComponentInParent<Animator>().enabled = false;
            _mainAudio.clip = YoYoHoneySingh;
        }
    }
}
