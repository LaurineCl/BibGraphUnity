﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _MGR_GamePlay : MonoBehaviour {

    private static _MGR_GamePlay p_instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
    public static _MGR_GamePlay Instance { get { return p_instance; } }

    public uint score { get; private set; }

    // Gestion des bonus
    [System.Serializable]
    public class Bonus
    {
        public string nom;
        public int bonus;
    }
    public Bonus[] allBonus;
    Dictionary<string, int> p_allBonus;


    // Use this for initialization
    void Awake()
    {
        // ===>> SingletonMAnager

        //Check if instance already exists
        if (p_instance == null)
            //if not, set instance to this
            p_instance = this;
        //If instance already exists and it's not this:
        else if (p_instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        //Sets this to not be destroyed when reloading scene
        // DontDestroyOnLoad(gameObject);   par nécessaire ici car déja fait par script __DDOL sur l'objet _EGO_app qui recueille tous les mgr

        p_allBonus = new Dictionary<string, int>();
        foreach (Bonus _bonus in allBonus)
            p_allBonus.Add(_bonus.nom, _bonus.bonus);

    }

    public void StartPlay()
    {
        _MGR_TimeLine.Instance.StartChrono();
    }

    private uint AugmenterScore(int _bonus)
    {
        return (score = (score - _bonus > 0) ? (uint)(score - _bonus) : 0);
    }

    public uint AugmenterScore(string _strBonus)
        {
        int __bonus;
        if (!p_allBonus.ContainsKey(_strBonus))
        {
            CommonDevTools.ERROR("type de bonus non défini: " + _strBonus, this.gameObject);
            __bonus = 0;
        }
        else
            __bonus = p_allBonus[_strBonus];

        print("score = " + score + " + nouveau bonus " + __bonus);
        return AugmenterScore(__bonus);
    }
}
