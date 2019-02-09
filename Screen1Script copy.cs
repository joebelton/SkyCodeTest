using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Screen1Script : MonoBehaviour
{
    public Image Circle; // the circle that will be depleted when space is held
    public float waitTime = 3f; // time that you need to hold space until the page is loaded.
    
    public Text Instructions;
    public Color instructionsColour;
    
    void Update()
    {
        Instructions.GetComponent<Text>().color = instructionsColour; // retrieve the color component ready to be changed.
        instructionsColour = Color.Lerp(Color.white, Color.cyan, Mathf.PingPong(Time.time, 1)); // change the text colour from white to cyan and reverse in 1 second.
        
        if (Input.GetKey("space")) { Circle.fillAmount -= 1.0f / waitTime * Time.deltaTime; } // deplete the circle fully in the waitTime specified.
        
        if (Circle.fillAmount <= 0f) { SceneManager.LoadScene("Film1Scene"); } // load main scene once the circle is depleted below or equal to 0.
    }
    
    
}
