using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            MusicManager.instance.ActivateFairy(); //MIDTERM ADDITION: Making coin act as fairy. It call the music manager function.
            ScoreManager.instance.ChangeScore(1);
            Destroy(gameObject);
        }
    }
}
