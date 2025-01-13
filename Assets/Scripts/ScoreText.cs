using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Animator animator;

    public void HighLight()
    {
        animator.SetTrigger("highlight");
    }

    public void SetScore(int value)
    {
        text.text = value.ToString();
    }
}
