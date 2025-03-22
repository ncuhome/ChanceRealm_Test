using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ESCmenu;
    private bool isPause = false;
    void Start()
    {
        ESCmenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ESCmenu.SetActive(true);
            if (isPause)
            {
                back();
            }
            else
            {
                keepstop();
            }
        }
    }
    public void keepstop()//进入暂停界面
    {
        isPause = true;
        ESCmenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void back()//继续游戏
    {
        ESCmenu.SetActive(false);
        isPause = false;
        Time.timeScale = 1;
    }
    public void quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
