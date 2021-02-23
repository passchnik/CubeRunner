using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{

    private float Timer = 3;

    private void Start()
    {
        FindObjectOfType<Score>().enabled = false;
        FindObjectOfType<PlayerMove>().enabled = false;
    }

    private void Update()
    {
        if (Timer > 0)
        {
            FindObjectOfType<Text>().text = Timer.ToString("0");
            Timer -= Time.deltaTime;
        }
        else if ((int)Timer == 0)
        {
            FindObjectOfType<Text>().text = "START";
            Timer -= Time.deltaTime;
        }
        else if((int)Timer == -1)
        {
            FindObjectOfType<Score>().enabled = true;
            FindObjectOfType<PlayerMove>().enabled = true;
            Timer -= 10;
        }
        
        

    }
}
