using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player player;
    public float restartTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.HoldingBall == false)
		{
            restartTime -= Time.deltaTime;
            
            if (restartTime <= 0)
                SceneManager.LoadScene("SampleScene");
		}
    }
}
