﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotball : MonoBehaviour {

	[Header("對話")]
    public string Say = "安安你好嗎!!!!!!!!!";
    public float SaySpeed = 0.2f;
    [Header("任務")]
    public bool Complete = false;
    public int BateryFinish = 5;
    public int Batery = 0;

}
