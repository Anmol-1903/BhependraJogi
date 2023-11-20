using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoringText, _highScore_txt;
    [SerializeField] int _score , _highScore;

    private void Start()
    {
        _scoringText.text = "Score : " + _score;
        _highScore = PlayerPrefs.GetInt("highscore");
        _highScore_txt.text = "High Score : " + _highScore;

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            _score++;
            PlayerPrefs.SetInt("highscore", _score);
            if(_highScore <= _score)
            {
                _highScore = PlayerPrefs.GetInt("highscore");
            }
            _highScore_txt.text = "High Score : " + _highScore;
            Debug.Log(_score);
            _scoringText.text = "Score : " + _score;
        }
    }

    void HighScore()
    {
        
    }
}
