using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;
    public Button b6;
    public Button b7;
    public Button b8;
    public Button b9;
    public int msg;
    public Text message;
    int target = 0;
    void Start()
    {
        target = Random.Range(1, 9);
        b1.onClick.AddListener(()=>action(1));
        b2.onClick.AddListener(()=>action(2));
        b3.onClick.AddListener(()=>action(3));
        b4.onClick.AddListener(()=>action(4));
        b5.onClick.AddListener(()=>action(5));
        b6.onClick.AddListener(()=>action(6));
        b7.onClick.AddListener(()=>action(7));
        b8.onClick.AddListener(()=>action(8));
        b9.onClick.AddListener(()=>action(9));
    }
    public void action(int msg)
    {
        target = Random.Range(1, 9);
        if (msg == target)
        {
            message.text = "Congrats!!";
        }
        else
        {
            message.text = "Try again, Value was : "+target;
        }
    }
}