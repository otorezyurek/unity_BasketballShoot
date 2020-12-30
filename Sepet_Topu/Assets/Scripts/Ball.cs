using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject trailParticle;
    public GameObject trailParticle2;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        trailParticle.SetActive(false);
        trailParticle2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
