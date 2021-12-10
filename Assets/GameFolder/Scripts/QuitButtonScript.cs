using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButtonScript : MonoBehaviour
{

    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton = GetComponent<Button>();

        quitButton.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void QuitGame()
    {
        Debug.Log("You have clicked the Quit Button!");
    }
}
