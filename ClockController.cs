using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class ClockController : MonoBehaviour
{
    const float sec = -6f;
    public Transform Pivot;
    void Update()
    {
        var time = DateTime.Now;
        if (Pivot != null)
        Pivot.localRotation = Quaternion.Euler(0f, 0f, sec *time.Second);
    }
}
