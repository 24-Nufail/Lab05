using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{

    public Text Scoretext;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        Scoretext.text = "Score: " + Score; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Coin"))
        {
            Score += 10;
            Destroy(other.gameObject);
            Scoretext.text = "Score: " + Score;
        }
        else if (other.gameObject.tag.Equals("Water"))
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}
