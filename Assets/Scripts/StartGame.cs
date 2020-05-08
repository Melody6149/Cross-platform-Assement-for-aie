using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame

    public void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
