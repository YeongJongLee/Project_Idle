using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SocialPlatforms;
using TMPro;

public class StartScene : MonoBehaviour
{
    private IEnumerator Start()
    {
        GlobalManager.Instance.Init();

        yield return CommonIEnumerator.IEWaitUntil(
           predicate: () => { return GlobalManager.Instance.Initialized; },
           onFinish: () => {
               Init();
           }
        );
    }

    private void Init()
    {

    }
}
