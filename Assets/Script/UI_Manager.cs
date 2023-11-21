using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    CameraFollow cameraFollow;
    PlayerMovement playerMovement;
    TouchControl touchControl;
    [SerializeField] GameObject _restartPanel;
    // Start is called before the first frame update
    void Awake()
    {
        cameraFollow = Camera.main.GetComponent<CameraFollow>();
        playerMovement = FindObjectOfType<PlayerMovement>();    
        touchControl = FindObjectOfType<TouchControl>();    
    }
    private void Start()
    {
        cameraFollow.enabled = false;
        playerMovement.enabled = false;
        touchControl.enabled = false;
        gameObject.SetActive(true);
        _restartPanel.SetActive(false);
        Debug.Log("chal Bhosale ke bete");
        //Normal Coding Insturcions

    }

    public void PLayBtn()
    {
        cameraFollow.enabled = true; 
        playerMovement.enabled = true;
        touchControl.enabled = true;
        gameObject.SetActive(false);
    }

    public void QuitBtn()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
