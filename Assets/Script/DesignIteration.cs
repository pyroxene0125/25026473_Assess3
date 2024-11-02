using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DesignButton : MonoBehaviour
{
    private Button designButton; // 按钮引用

    void Start()
    {
        // 获取按钮组件
        designButton = GetComponent<Button>();
        // 为按钮添加点击事件监听器
        designButton.onClick.AddListener(LoadSampleScene);
    }

    void LoadSampleScene()
    {
        // 加载SampleScene
        SceneManager.LoadScene("DesignIterationScene");
    }
}

