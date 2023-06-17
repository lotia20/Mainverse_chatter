using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class CharacterColor : MonoBehaviour
{
    private PhotonView pv;
    public Material [] _material;

    void Start ()
    {
        pv = GetComponent<PhotonView>();
        
        if (pv.IsMine)
        {
            this.GetComponent<Renderer>().material = _material[0];
        }
        else
        {
            this.GetComponent<Renderer>() .material = _material[1];
        }
    }

    
}
