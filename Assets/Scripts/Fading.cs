using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour
{
    // Get Material
    public Material fade;
    // fade value
    private float fadeValue;
    // color
    private Color color;
    // test fade
    private bool isFade;
    private bool isLoadScene;
    // GameObject Main camera
    public GameObject MainCamera;

    public void Start()
    {
        color = fade.color;
        fadeValue = 0;
        UpdateFade();
    }

    public void scenes()
    {
        if (!isFade)
        {
            isFade = true;
            isLoadScene = true;
            UpdateFade();
        }
    }

    private IEnumerator Fade()
    {
        while (fadeValue < 1)
        {
            fadeValue += 0.08f;
            UpdateFade();
            yield return new WaitForSeconds(0.08f);
        }
        yield return null;

        Debug.Log($"<color><b>is fade</color>");

        while (fadeValue > 0)
        {
            fadeValue -= 0.08f;
            UpdateFade();
            yield return new WaitForSeconds(0.08f);
        }

        isFade = false;
    }

    // Update is called once per frame
    private void UpdateFade()
    {
        color.a = fadeValue;
        fade.color = color;
    }
}
