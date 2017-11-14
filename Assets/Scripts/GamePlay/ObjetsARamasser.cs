using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsARamasser : MonoBehaviour
{
    public virtual void ActionObjetRamasse()
    {
        Destroy(gameObject);
    }

    public void ActionObjetRamasse(float _delai)
    {
        Invoke("ActionObjetRamasse", _delai);
    }
}
