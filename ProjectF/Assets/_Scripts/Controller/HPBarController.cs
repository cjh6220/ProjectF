using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBarController : MessageListener
{
    public GameObject HPBar;
    public GameObject Target;
    private void Update() 
    {
        HPBar.transform.position = Target.transform.position;
    }
}
