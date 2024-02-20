using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private EventReference buttonClickSound;

    public void ButtonClicked()
    {
        AudioManager.instance.PlayOneShot(buttonClickSound, this.transform.position);
    }
}
