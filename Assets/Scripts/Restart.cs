using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button Restartbtn;
    // Start is called before the first frame update
    void Start()
    {
        Button RTbtn = Restartbtn.GetComponent<Button>();
        RTbtn.onClick.AddListener(RTbtnOnclick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RTbtnOnclick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
