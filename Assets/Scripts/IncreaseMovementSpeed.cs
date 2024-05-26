/*
 * Author: Tan Ting Yu Gwyneth
 * Date: 26 May 2024
 * Description: This script increases the player's movement speed once it collects collectibles.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMovementSpeed : Collectible
{
    /// <summary>
    /// Amount of speed increased
    /// </summary>
    public float speedIncreaseAmount = 2.0f; 

    /// <summary>
    /// Increase player speed once collectible is collected 
    /// </summary>
    public override void Collected()
    {
        Debug.Log("Increasing movement speed");
        var playerController = GameObject.FindWithTag("Player").GetComponent<StarterAssets.FirstPersonController>();
        if (playerController != null)
        {
            playerController.MoveSpeed += speedIncreaseAmount; //increment player movement speed
        }
    }
}
