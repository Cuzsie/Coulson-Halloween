﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    [SerializeField] private string link;


    public void openLink()
    {
        Application.OpenURL(link);
    }
}
