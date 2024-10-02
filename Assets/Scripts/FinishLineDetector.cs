using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishLineDetector : MonoBehaviour
{
    [SerializeField]
    GameObject endScreen;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject finishLineSpawnPoint;
    [SerializeField]
    TextMeshProUGUI timeLabel;

    float gameTime = 0.0f;
    bool playing = true;

    public void Update()
    {
        if (playing == true)
        {
            gameTime = gameTime + Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = Vector3.MoveTowards(transform.position, finishLineSpawnPoint.transform.position, Time.deltaTime);
            endScreen.SetActive(true);
            other.GetComponent<PlayerMovement>().enabled = false;
            playing = false;
            timeLabel.text = gameTime.ToString();
        }
    }
}
