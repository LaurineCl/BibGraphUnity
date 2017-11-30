using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _MGR_Son_Musique : MonoBehaviour
{
    private static _MGR_Son_Musique p_instance = null;
    public static _MGR_Son_Musique Instance { get { return p_instance; } }
    private AudioClip m_AudioClip;
    [System.Serializable]

    public class Son
    {
        public string nom;
        public AudioClip son;
    }
    // tous les sons à utiliser dans le jeu
    // seront initialisés à la création du manager, dans la scène _preload
    public Son[] sons;
    // tous les audio source prêts à jouer un son
    // plusieurs peuvent être nécessaires car plusieurs sons simultanés possible (e.g. musique+son FX)
    private List<AudioSource> p_listAudioSource;
    // un dictionnaire pour stocker et accéder aux son du jeu depuis leur nom
    private Dictionary<string, AudioClip> p_sons;
    // initialisation du manager
    void Awake()
    { // à compéter //
        //Singleton pattern
        if (p_instance == null)
            p_instance = this;
        else if (p_instance != this)
            Destroy(gameObject);
    }
    // jouer un son du jeu
    // vérifier que le son existe
    // trouver un lecteur libre (audioSource) ou en ajouter un s'ils sont tous en lecture
    // jouer le son sur le lecteur libre (avec le délai fourni)
    public void PlaySound(string __nom, float __delay = 0)
    { // à compéter //
        int n = 0;
        while (p_listAudioSource[n].isPlaying)
            ++n;
        p_listAudioSource[n].clip = p_sons[__nom];

        p_listAudioSource[n].PlayOneShot(p_listAudioSource[n].clip);
    }
}
