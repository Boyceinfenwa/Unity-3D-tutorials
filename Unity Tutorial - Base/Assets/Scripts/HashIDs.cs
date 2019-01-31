﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour
{
    public int dyingState;
    public int deadBool;
    public int walkState;
    public int shoutingBool;
    public int shoutState;
    public int sneakingBool;
    public int speedFloat;

    // Use this for initialization
	void Start ()
    {
    
    }

   private void Awake()
    {
        dyingState = Animator.StringToHash("Base Layer Dying");
        deadBool = Animator.StringToHash("Dead");
        walkState = Animator.StringToHash("Walk");
        shoutingBool = Animator.StringToHash("Shouting");
        shoutState = Animator.StringToHash("Shouting.Shout");
        speedFloat = Animator.StringToHash("Speed");
        sneakingBool = Animator.StringToHash("Sneaking");
    }



    // Update is called once per frame
    void Update ()
    {
		
	}
}
