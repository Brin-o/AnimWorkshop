using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CAT : MonoBehaviour
{
    public static CAT _;
    void Awake()
    {
        if (CAT._ == null) _ = this;
        else Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetKeyDown(KeyCode.Alpha1)) Time.timeScale -= 0.15f;
        if (Input.GetKeyDown(KeyCode.Alpha2)) Time.timeScale += 0.15f;

    }
}
