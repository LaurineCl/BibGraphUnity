using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class _MGR_ObjetsRessource : MonoBehaviour
{
    private static _MGR_ObjetsRessource p_instance = null;              //Static instance of ObjectManager which allows it to be accessed by any other script.
    public static _MGR_ObjetsRessource Instance { get { return p_instance; } }     // READ ONLY

    Dictionary<string, ObjetsARamasser> p_Dict_ObjetsRamasses;
    private ObjetsRessource ObjetRessourceCourant;

 
    public void AddObject(ObjetsRessource obj)
    {
        ObjetRessourceCourant = obj;
        p_Dict_ObjetsRamasses.Add(obj.Nom, obj);
    }

    public void RemoveObject(ObjetsRessource obj)
    {
        p_Dict_ObjetsRamasses.Remove(obj.Nom);
    }
}
