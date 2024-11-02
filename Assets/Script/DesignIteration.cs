using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DesignButton : MonoBehaviour
{
    private Button designButton; // ��ť����

    void Start()
    {
        // ��ȡ��ť���
        designButton = GetComponent<Button>();
        // Ϊ��ť��ӵ���¼�������
        designButton.onClick.AddListener(LoadSampleScene);
    }

    void LoadSampleScene()
    {
        // ����SampleScene
        SceneManager.LoadScene("DesignIterationScene");
    }
}

