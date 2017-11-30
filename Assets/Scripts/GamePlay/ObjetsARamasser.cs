using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsARamasser : MonoBehaviour
{
    public virtual void ActionObjetRamasse()
    {
        _MGR_Son_Musique.Instance.PlaySound(gameObject.tag);
        Destroy(gameObject);
    }

    public void ActionObjetRamasse(float _delai)
    {
        Invoke("ActionObjetRamasse", _delai);
    }
}
