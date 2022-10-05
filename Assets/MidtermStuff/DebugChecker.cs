using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChecker : Observer
{
    GameObject myGameObject;

    public DebugChecker(GameObject gameObject)
    {
        myGameObject = gameObject;
    }
    public override void OnNotify()
    {
       if (CheckForOutOfBounds())
        Debug.Log("[DEBUG_CHECKER]: Player is out of bounds!!");
    }

    bool CheckForOutOfBounds()
    {
        if (myGameObject.transform.position.z > 18.5f)
            return true;

        return false;
    }
}
