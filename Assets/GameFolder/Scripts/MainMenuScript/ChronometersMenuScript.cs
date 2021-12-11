using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChronometersMenuScript : MonoBehaviour
{

    private Text ChronoText;
    // Start is called before the first frame update
    void Start()
    {
        ChronoText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ChronoText.text = Time.realtimeSinceStartup.ToString();
    }
}
