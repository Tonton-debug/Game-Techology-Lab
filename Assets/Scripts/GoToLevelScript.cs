using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string sceneName;
    [SerializeField] private TextMeshProUGUI _text;
    void Start()
    {
        _text.text = sceneName;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
