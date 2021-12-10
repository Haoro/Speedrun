using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour
{

    public Button playButton;
    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<Button>();

        playButton.onClick.AddListener(PlayButtonChangeScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayButtonChangeScene()
    {
        Debug.Log("You have clicked the Play Button!");
    }
}
