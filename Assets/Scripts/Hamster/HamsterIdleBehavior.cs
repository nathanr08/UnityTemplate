﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterIdleBehavior : State {

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        HamsterController hamsterController = ((HamsterController)controller);
        hamsterController.CheckRun();
        hamsterController.DoMovement(hamsterController.walkSpeed);

        // Stop the walk sound
        if (hamsterController.WalkAudio != null && hamsterController.WalkAudio.isPlaying)
        {
            hamsterController.GetComponent<AudioSource>().Stop();
        }
    }
}
