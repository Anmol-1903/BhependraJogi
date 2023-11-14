using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    CameraFollow cameraFollow;
    PlayerMovement playerMovement;
    TouchControl touchControl;
    // Start is called before the first frame update
    void Awake()
    {
        cameraFollow = FindObjectOfType<CameraFollow>();
        playerMovement = FindObjectOfType<PlayerMovement>();    
        touchControl = FindObjectOfType<TouchControl>();    
    }
    private void Start()
    {
        cameraFollow.enabled = false;
        playerMovement.enabled = false;
        touchControl.enabled = false;
        gameObject.SetActive(true);
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
