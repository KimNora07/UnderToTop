using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KoreanTyper;
using TMPro;
using UnityEngine.Events;

public class KoreanTypeSimple : MonoBehaviour
{
    [TextArea]
    [SerializeField] private string message;
    [SerializeField] private float delay = 1f;
    [SerializeField] UnityEvent onComplete;

    private TMP_Text text;
    WaitForSeconds typingWait;
    WaitForSeconds eventWait;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        message = text.text;
        typingWait = new WaitForSeconds(0.03f);
        eventWait = new WaitForSeconds(1f);
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        StartCoroutine(TypingMessage());
    }

    public void StartTyping(string value)
    {
        message = value;
        StartCoroutine(TypingMessage());
    }

    private IEnumerator TypingMessage()
    {
        int TypingLength = message.GetTypingLength();
        text.text = "";

        for(int i = 0; i < TypingLength; i++)
        {
            yield return typingWait;
            text.text = message.Typing(i);
        }

        yield return eventWait;

        onComplete.Invoke();
    }
}
