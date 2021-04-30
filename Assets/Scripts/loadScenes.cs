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
        SceneManager.LoadScene("360VideoTour");
    }

    // Load Scene Cantina
    public void loadSceneCantina()
    {
        SceneManager.LoadScene("Cantina");
    }

    // Load Scene Cube
    public void loadSceneCube()
    {
        SceneManager.LoadScene("Cube");
    }
    // Load Scene Mezzanine
    public void loadSceneMezzanine()
    {
        SceneManager.LoadScene("Mezzanine");
    }
}
