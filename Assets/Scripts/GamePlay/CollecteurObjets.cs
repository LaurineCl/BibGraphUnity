using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecteurObjets : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        CommonDevTools.DEBUG("Object touché: " + other.name + " objet source " + gameObject.name);
        ObjetsARamasser __o = other.gameObject.GetComponent<ObjetsARamasser>();
        if (__o == null)
            CommonDevTools.ERROR("erreur sur objet à ramasser ! ", other.gameObject);
        else
            __o.ActionObjetRamasse();
    }
}
