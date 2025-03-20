using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _npcScript : MonoBehaviour
{
    //public _playerScript _playerMasterManager;
    //public _levelMasterScript _levelMasterManager;
    private _lobiOnuDenemeScript _lobiOnuCalisiyorsaElleme;
    //public GameObject _lobiOnu;
    public NavMeshAgent _navMeshAgentMasterManager;
    private Rigidbody _npcRigidbodyHitBox;
    public _playerScript _playerMasterManager;

    public bool _npcKasada;

    public void _startNpc(_lobiOnuDenemeScript _buFonkunLobiOnu, _playerScript _playerMasterManager)
    {
        _lobiOnuCalisiyorsaElleme = _buFonkunLobiOnu;
        this._playerMasterManager = _playerMasterManager;
        _npcRigidbodyHitBox = GetComponent<Rigidbody>();
        _npcHareketEt(new Vector3(5, 0.5f, -4));
    }

    public void Update()
    {
        //_navMeshAgentMasterManager.destination = _lobiOnuCalisiyorsaElleme.transform.position;
    }


    public void OnTriggerStay(Collider _insOlurAmin)
    {
        if (_insOlurAmin.CompareTag("kasa"))
        {
            _npcKasada = true;
            Debug.Log("Npc Kasada");
        }
    }

    public void _npcOdayaYolla()
    {
        Debug.Log("npcoda");
        //_levelMasterManager._sellRoom();
        _npcKasada = false;
        gameObject.SetActive(false);
    }

    public void _npcBaslatLobiOnuTransformunuPrivatedenAt(_lobiOnuDenemeScript _buFonkunLobisi)
    {
        _lobiOnuCalisiyorsaElleme = _buFonkunLobisi;
    }

    public void _npcHareketEt(Vector3 konum)
    {
        _navMeshAgentMasterManager.destination = konum;
    }

}
