using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMoProgressBar : MonoBehaviour
{
  public  GameObject player;
    public Image _bar;
   // public RectTransform RT;
    float progress;
    // Update is called once per frame
    //PlayerController beh = player.GetComponent(PlayerController);
    void Update()
    {
        progress = player.GetComponent<PlayerController>().SlowTime;
        ProgressBar(progress);
       
    }
    void ProgressBar(float progress)
    {
        float ammount = (progress / player.GetComponent<PlayerController>().MaxSlowTime) * 180.0f / 360;
        _bar.fillAmount = ammount;
        float RTangle = ammount * 360;
      //  RT.localEulerAngles = new Vector3(0, 0, -RTangle);

    }
}
