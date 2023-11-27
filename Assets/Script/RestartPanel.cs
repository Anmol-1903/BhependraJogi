using UnityEngine;

public class RestartPanel : MonoBehaviour
{
    [SerializeField] GameObject _restartPanel , _bhupenderJogi , _Spawner;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Panel"))
        {
            
            _restartPanel.SetActive(true);
            _bhupenderJogi.SetActive(false);
            _Spawner.SetActive(false);
        }
    }
}
