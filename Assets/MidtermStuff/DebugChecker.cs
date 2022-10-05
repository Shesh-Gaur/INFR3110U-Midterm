using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChecker : Observer
{
    GameObject myGameObject;
    GameObject myUiText; //For demo purposes
    public DebugChecker(GameObject gameObject, GameObject uiText)
    {
        myGameObject = gameObject;
        myUiText = uiText;
    }
    public override void OnNotify()
    {
        if (CheckForOutOfBounds())
        {
            Debug.Log("[DEBUG_CHECKER]: Player is out of bounds!!");
            myUiText.SetActive(true);
        }
        else
        {
            myUiText.SetActive(false);
        }
    }

    bool CheckForOutOfBounds()
    {
        if (myGameObject.transform.position.z > 18.5f)
            return true;

        return false;
    }
}
