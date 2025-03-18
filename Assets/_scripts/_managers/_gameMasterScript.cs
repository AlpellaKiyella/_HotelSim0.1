using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _gameMasterScript : MonoBehaviour
{
    public _playerScript _playerMasterManager;
    public _npcScript _npcMasterManager;
    void Start()
    {
        _playerMasterManager._playeriYenidenBaslat();
    }

    public void Update()
    {

    }
    public void _leveliYenidenBaslat()
    {
        /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            _playerMasterManager._playeriYenidenBaslat();
        } 
        */
    }

}
