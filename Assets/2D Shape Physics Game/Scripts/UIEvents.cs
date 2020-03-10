using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



[DisallowMultipleComponent]
public class UIEvents : MonoBehaviour {

    public void SimulateBall(Rigidbody2D ball)
    {
        if (ball == null) return;
        ball.isKinematic = false;
    }

    public void LoadMainScene()
    {
        //SceneManager.LoadScene("Main");
    }

    public void LoadExample1()
    {
       // SceneManager.LoadScene("Example1");
    }

    public void LoadExample2()
    {
        //SceneManager.LoadScene("Example2");
    }
}
