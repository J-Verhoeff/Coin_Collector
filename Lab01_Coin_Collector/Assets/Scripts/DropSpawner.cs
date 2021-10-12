using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawner : MonoBehaviour {
    [Header("Object Parameters")]
    [SerializeField] private float fallSpeed = 5f;

    [Header("Camera Parameters")]
    [SerializeField] private float maximumY = 4f;
    [SerializeField] private float minimumY = -4f;
    [SerializeField] private float maximumX = 4f;
    [SerializeField] private float minimumX = -4f;


    public void Respawn() {
        float x = Random.Range(minimumX, maximumX);
        Vector3 position = new Vector3(x, maximumY, 0f);
        transform.position = position;
    }

    private void Update() {
        var pos = transform.position;
        if (pos.y <= minimumY) {
            Respawn();
        } else {
            pos.y += fallSpeed * Time.deltaTime;
            transform.position = pos;
        }
    }

    public int playerScore = 0;
    private void OnTriggerEnter2D(Collider2D collision) {
        playerScore += 1;
        Respawn();
    }
}
