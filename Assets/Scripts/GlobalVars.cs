using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : Singleton<GlobalVars>
{
    
    protected GlobalVars() { /*This prevent people making GlobalVars Objects, not really needed but nice. */ }

    /* Global Variables, can be used via GlobalVars.name */
    public static float baseEnemeyHealth = 1f; // Every enemy starts at the same health. Games up over time.
    public static float baseTimeScore = 10f; // Base points rewarded per second. 
    public static float baseEnemyScore = 5f; // Base points rewarded per kill
    public static float baseEnemySpeed = 5f; // base speed of the enemy
    public static float baseEnemyBulletSpeed = 1f;
    public static float baseEnemyTimeBetwenShots = 1f;

    public static float basePlayerSpeed = 5f; // base speed of the player
    public static float basePlayerBulletSpeed = 1f;
    public static float basePlayerTimeBetwenShots = .01f;


}
