using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    private Button startButton; 

    void Start()
    {
        
        startButton = GetComponent<Button>();
        
        startButton.onClick.AddListener(LoadSampleScene);
    }

    void LoadSampleScene()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}

