using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    // map size
    public static int top = 13;
    public static int bottom = -7;
    public static int leftRight = 10;
    public static int height = 2;


    public static float offsetContinue = 6.0f; // how much further past the edge of the map a shot or enemy goes, or spawns, so that it enters or exits before spawning/despawning
}
