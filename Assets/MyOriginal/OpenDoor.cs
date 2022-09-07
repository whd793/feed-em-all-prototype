using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine("Door");
        anim.SetBool("OpenDoor", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("OpenDoor", false);
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("OpenDoor", true);

        }

    }

    IEnumerator Door() {
        anim.SetBool("OpenDoor", true);
        yield return new WaitForSeconds(5);
        anim.SetBool("OpenDoor", false);
    }
}
