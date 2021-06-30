using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadScenes : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
    }
    // Load Scene Living Room
    public void loadSceneLivinRoom()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene("360VideoTour");
    }

    // Load Scene Cantina
    public void loadSceneCantina()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene("Cantina");
    }

    // Load Scene Cube
    public void loadSceneCube()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene("Cube");
    }
    // Load Scene Mezzanine
    public void loadSceneMezzanine()
    {
        //StartCoroutine(Fade());
        SceneManager.LoadScene("Mezzanine");
    }
}
