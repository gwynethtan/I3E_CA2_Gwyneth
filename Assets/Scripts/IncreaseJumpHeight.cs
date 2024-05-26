/*
 * Author: Tan Ting Yu Gwyneth
 * Date: 26 May 2024
 * Description: This script increases the player's jump height once it collects collectibles.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseJumpHeight : Collectible
{
    /// <summary>
    /// Amount of height of jump increased
    /// </summary>
    public float jumpIncreaseAmount = 100.5f; // Adjust the amount as needed

    /// <summary>
    /// Increase player jump heights once collectible is collected 
    /// </summary>
    public override void Collected()
    {
        Debug.Log("Increasing jump height");
        var player = GameObject.FindWithTag("Player").GetComponent<StarterAssets.FirstPersonController>();
        if (player != null)
        {
            player.JumpHeight += jumpIncreaseAmount; //Increment player jump height
        }
    }
}


