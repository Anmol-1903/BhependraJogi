using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    AudioSource _mainAudio;
    [SerializeField] AudioClip _dinVich, YoYoHoneySingh;
    [SerializeField] GameObject _dinVichArmature, YoYoHoneySinghArmature;

    private void Awake()
    {
        _mainAudio = GetComponent<AudioSource>();
    }
    private void Start()
    {
        _dinVichArmature.SetActive(false);
        YoYoHoneySinghArmature.SetActive(false);
    }

}
