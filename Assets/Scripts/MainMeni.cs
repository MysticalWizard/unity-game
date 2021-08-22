using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeni : MonoBehaviour
{
    public string firstLevel;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene(firstLevel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
      SceneManager.LoadScene(firstLevel);
    }

    public void Quit()
    {
      Application.Quit();
      Debug.Log("Quitting");
    }

}
