using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pausemenu, nopause;
    public string sceneName;
    public bool toggle;
    public SC_FPSController playerScript;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
                if(toggle == false)
            {
                pausemenu.SetActive(false);
                AudioListener.pause = false;
                Time.timeScale = 1;
                playerScript.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                if (nopause.activeInHierarchy == false) {
                    nopause.SetActive(true);
                }
            }
                if(toggle == true)
            {
                pausemenu.SetActive(true);
                AudioListener.pause = true;
                Time.timeScale = 0;
                playerScript.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                if (nopause.activeInHierarchy == true) {
                    nopause.SetActive(false);
                }
            }
            

        }
    }
    public void resumeGame()
    {
        if (nopause.activeInHierarchy == false) {
                    nopause.SetActive(true);
        }
        toggle = false;
        pausemenu.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

   public void quitToMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(sceneName);
    }
}
