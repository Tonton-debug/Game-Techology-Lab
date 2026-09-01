using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject SelectLevelPanel;
    void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Lab1-2");
    }
    public void Exit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwtichPanel(bool selectLevel)
    {
        if (selectLevel)
        {
            MainMenuPanel.SetActive(false);
            SelectLevelPanel.SetActive(true);
        } else
        {
            MainMenuPanel.SetActive(true);
            SelectLevelPanel.SetActive(false);
        }
    }
}
