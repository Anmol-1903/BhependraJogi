using UnityEngine;

public class RestartPanel : MonoBehaviour
{
    [SerializeField] GameObject _restartPanel;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _restartPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
