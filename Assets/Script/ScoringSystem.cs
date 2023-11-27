using UnityEngine;
using TMPro;
public class ScoringSystem : MonoBehaviour
{
    private static ScoringSystem _instance;
    public static ScoringSystem Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("ScoringSystem not initialized");
            return _instance;
        }
    }
    TextMeshProUGUI _scoringText;
    [SerializeField] TextMeshProUGUI _highScore_txt;
    [SerializeField] int _score, _highScore;
    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        _scoringText = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        _scoringText.text = "Score : " + 00.ToString("D2");
        _highScore = PlayerPrefs.GetInt("highscore");
        _highScore_txt.text = "High Score : " + _highScore.ToString("D2");
    }
    public void AddScore(int amt)
    {
        _score += amt;
        _scoringText.text = "Score : " + _score.ToString("D2");
        if (_highScore < _score)
        {
            _highScore = _score;
            _highScore_txt.text = "High Score : " + _highScore.ToString("D2");
            PlayerPrefs.SetInt("highscore", _highScore);
        }
    }
}