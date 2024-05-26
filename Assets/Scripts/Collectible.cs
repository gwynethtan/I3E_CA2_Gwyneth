/*
 * Author: Tan Ting Yu Gwyneth
 * Date: 26 May 2024
 * Description: This script increases the player's movement speed once it collects collectibles.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Collectible : MonoBehaviour
{
    /// <summary>
    /// Handles logic for collection
    /// </summary>
    public virtual void Collected()
    {
        Debug.Log("Collectible collected"); //Check if collectible is collected
    }

    /// <summary>
    /// Calls Collected() when the player collides with the collectible
    /// </summary>
    /// <param name="collision">Handle the collectible collection logic</param>
    private void OnCollisionEnter(Collision collision) // Code for when object is being collided
    {
        if (collision.gameObject.tag == "Player") // Check if basic collectible is touched by player
        {
            Collected();
        }
    }
}