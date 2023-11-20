using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoringText;
    [SerializeField] float _score;

    private void Start()
    {
        _scoringText.text = "Score : " + _score;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            _score++;
            Debug.Log(_score);
            _scoringText.text = "Score : " + _score;
        }
    }
}
