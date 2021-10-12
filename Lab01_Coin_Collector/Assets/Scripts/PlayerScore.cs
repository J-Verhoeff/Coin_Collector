using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    public int playerScore = 0;
    private DropSpawner dropSpawner;
    private void OnTriggerEnter2D(Collider2D collision) {
        playerScore += 1;
    }
}
