using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DropClone : MonoBehaviour
{

    public float fadeTime = 0.1f;
    public float interval = 0.05f;
    public float t = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (DOTween.IsTweening(transform))
        {
            t += Time.deltaTime;
            if (t >= interval)
            {
                t = 0;
                var go = gameObject;
                var spawn = Instantiate(go);
                spawn.GetComponent<SpriteRenderer>().DOFade(0, fadeTime).OnComplete(() => { Destroy(spawn); });
            }
        }
    }
}
