using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODEvents : MonoBehaviour
{
    public static FMODEvents instance {  get; private set; }

    //[field: Header("Ambience")]
    //[field: SerializeField] public EventReference ambience { get; private set; }

    [field: Header("Music")]
    [field: SerializeField] public EventReference music { get; private set; }

    [field: Header("UI Click SFX")]
    [field: SerializeField] public EventReference clickButton { get; private set; }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("씬에 많은 FMOD Event instance가 발견되었습니다");
        }
        instance = this;
    }
}
