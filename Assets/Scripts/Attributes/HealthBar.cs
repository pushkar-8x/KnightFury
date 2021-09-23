using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Attributes

{
public class HealthBar : MonoBehaviour
{

    [SerializeField] Health healthScript=null;
    [SerializeField] RectTransform Foreground=null;
   
   [SerializeField] Canvas rootCanvas=null;

    void Update()
    {

        if(Mathf.Approximately(healthScript.GetFraction(),0))
        {
            rootCanvas.enabled=false;
            return;
        }

        rootCanvas.enabled=true;
        Foreground.localScale=new Vector3(healthScript.GetFraction(),1,1);
    }
}

}
