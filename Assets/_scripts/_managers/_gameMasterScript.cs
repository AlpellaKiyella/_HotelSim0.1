using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _gameMasterScript : MonoBehaviour
{
    public _npcMasterScript _npcMasterManager;
    public _playerScript _playerMasterManager;
    //public _npcScript _npcScriptManager;
    void Start()
    {
        _playerMasterManager._playeriYenidenBaslat();
        //_npcMasterManager._yeniNpclerYarat();
        _npcMasterManager._randomZamanlardaNpcOlusturucu();
    }

    public void Update()
    {

    }
    public void _leveliYenidenBaslat()
    {
        
    }

}
