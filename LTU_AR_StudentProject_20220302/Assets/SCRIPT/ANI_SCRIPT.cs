using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANI_SCRIPT : MonoBehaviour
{
    public Animator ani;
    public Button btn;
    public GameObject gbImage;
    public bool isPlay;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(delegate() {
            ani.SetTrigger("KKB TRIGGER");
            btn.gameObject.SetActive(false);
            isPlay = true;
        });
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    ani.SetTrigger("p");
        //}

        if (isPlay)
        {
            //Debug.Log(ani.GetCurrentAnimatorStateInfo(0).normalizedTime);
            if (ani.GetCurrentAnimatorStateInfo(0).IsName("KKB START") && ani.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                gbImage.SetActive(false);
            }
        }
    }

    public void close() {
        gbImage.SetActive(false);
    }
}
