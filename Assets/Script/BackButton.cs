using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonScript : MonoBehaviour
{
    private Button backButton; 

    void Start()
    {
        
        backButton = GetComponent<Button>();
        
        backButton.onClick.AddListener(LoadStartScene);
    }

    void LoadStartScene()
    {
        
        SceneManager.LoadScene("StartScene");
    }
}

