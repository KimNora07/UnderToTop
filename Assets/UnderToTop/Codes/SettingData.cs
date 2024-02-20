using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SettingData
{
    public enum Resolution
    {
        p360,
        p720,
        p1080,
        p1440,
        p2160
    }
    public Resolution resolution;
    public enum WindowType
    {
        FULL,
        BORDERLESS,
        WINDOW
    }
    public WindowType windowType;
}
