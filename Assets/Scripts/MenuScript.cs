using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.InputSystem.InputAction;

public class MenuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private GameObject _spawnObject;
    private bool isPaused = false;

    void Update()
    {
    }
    public void InputEsc(InputAction.CallbackContext callbackContext)
    {
        if (!callbackContext.started) return;
        if (isPaused)
            ResumeGame();
        else
            PauseGame();
    }
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        if (playerInput != null)
            playerInput.SetLoock(true);
    }
    public void SpawnObject()
    {
      GameObject gM=  Instantiate(_spawnObject);
        gM.transform.position = new Vector3(0, 200, 0);
    }
    public void ResumeGame()
    {
       
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        if (playerInput != null)
            playerInput.SetLoock(false);
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
