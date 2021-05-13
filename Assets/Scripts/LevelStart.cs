using System.Data.Common;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class LevelStart : MonoBehaviour
{
    public CanvasGroup panel;

    public GameObject Group;

    public int tpStart;

    public int tpEnd;

    public float duration;

    public float t = 0;

    void Awake()
    {
        Group.SetActive(true);
    }

    void Update()
    {
        if (t <= duration)
        {
            Intro();
        }
        else
        {
            Group.SetActive(false);
        }
    }

    void Intro()
    {
        t += Time.deltaTime / duration;
        panel.alpha = Mathf.Lerp(tpStart, tpEnd, t);
    }
}
