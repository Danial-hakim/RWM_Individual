using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    public PlayerScript player;
    public TextMeshProUGUI restartText;


    private void Start()
    {
        restartText.gameObject.SetActive(false);
        restartText.SetText("Press 'R' to restart!");
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.alive)
        {
            restartText.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                int scene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(scene);
            }
        }
    }
}
