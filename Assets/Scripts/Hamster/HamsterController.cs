﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterController : BaseControllable {

    public int hp;

    public float walkSpeed = 50.0f;

    /// <summary>
    /// running state vars
    /// </summary>
    public float runSpeed = 100.0f;
    public float runTime = 5.0f;
    public float runTimer = 0.0f;

    /// <summary>
    /// for handling stun state
    /// </summary>
    public float stunSpeed = 0.0f;
    public float stunTime = 3.0f;
    private float stunTimer = 0.0f;

    private Rigidbody rBody;

    #region animVars
    static string animHealth = "playerHealth";
    static string animMoveSpeed = "moveSpeed";
    static string animStunTrigger = "stun";
    static string animStunTimer = "stunTimer";
    #endregion

    // Use this for initialization
    public override void Start () {

        rBody = GetComponent<Rigidbody>();

        base.Start();
	}

    public void DoMovement(float moveSpeed)
    {
        float xInput = Input.GetAxis(InputHandles.HorizontalAxis);
        float zInput = Input.GetAxis(InputHandles.VerticalAxis);
        Vector3 movement = new Vector3(xInput * moveSpeed, 0.0f, zInput * moveSpeed);
        rBody.MovePosition(movement);

        this.animator.SetFloat(animMoveSpeed, movement.magnitude);
    }
}
