using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class _levelMasterScript : MonoBehaviour
{
    public _playerScript _playerMasterManager;
    public _npcScript _npcMasterManager;
    public GameObject _holeOnTheWall;


    public void _sellRoom()
    {     
        _playerMasterManager._goldCount += 100;
    }
    public void _buyFromtezgah() 
    {
        _playerMasterManager._cekicCount++;
        _playerMasterManager._goldCount -= 100;
        Debug.Log("Cekic count" + _playerMasterManager._cekicCount);
    }
}
