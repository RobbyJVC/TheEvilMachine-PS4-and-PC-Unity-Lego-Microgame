using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnablePCPrompt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Image>().enabled = true;
#if UNITY_EDITOR || UNITY_STANDALONE
        this.gameObject.GetComponent<Image>().enabled = true;
#else
            this.gameObject.GetComponent<Image>().enabled = false;
#endif
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        this.gameObject.GetComponent<Image>().enabled = true;
#else
            this.gameObject.GetComponent<Image>().enabled = false;
#endif
    }
}
