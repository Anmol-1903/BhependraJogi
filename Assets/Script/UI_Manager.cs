using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    CameraFollow cameraFollow;
    PlayerMovement playerMovement;
    TouchControl touchControl;
    [SerializeField] GameObject _restartPanel, armature;
    [SerializeField] Animator BhupendraAnimator;
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
        armature.SetActive(false);
        BhupendraAnimator.enabled = true;
        //Normal Coding Insturcions

    }

    public void PLayBtn()
    {
        cameraFollow.enabled = true; 
        playerMovement.enabled = true;
        touchControl.enabled = true;
        BhupendraAnimator.enabled = false;
        armature.SetActive(true) ;
        gameObject.SetActive(false);
    }

    public void QuitBtn()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
