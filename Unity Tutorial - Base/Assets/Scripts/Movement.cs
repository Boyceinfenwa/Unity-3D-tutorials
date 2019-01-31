using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public AudioClip shoutingClip;
    public float speedDamptime = 0.0f;
    public float xSensitivity = 1.0f;

    private Animator anim;
    private HashIDs hash;

    private void Awake()
    {
        anim = GetComponent<Animator> () ;
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();
        anim.SetLayerWeight(1, 1f);
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        bool sneak = Input.GetButton("Sneak");
        float mouse_x = Input.GetAxis("MouseX");

    }
}
