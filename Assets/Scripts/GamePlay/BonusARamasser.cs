using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusARamasser : ObjetsARamasser
{

    public override void ActionObjetRamasse()
    {
        base.ActionObjetRamasse();
        _MGR_GamePlay.Instance.AugmenterScore(this.gameObject.tag);
    }
}
