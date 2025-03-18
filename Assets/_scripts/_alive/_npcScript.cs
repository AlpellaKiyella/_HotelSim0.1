using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _npcScript : MonoBehaviour
{
    public _playerScript _playerMasterManager;
    public _levelMasterScript _levelMasterManager;
    public GameObject _lobiOnu;
    public NavMeshAgent _navMeshAgentMasterManager;

    public bool _npcKasada;


    public void Update()
    {
        _navMeshAgentMasterManager.destination = _lobiOnu.transform.position;
        
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
        _levelMasterManager._sellRoom();
        _npcKasada = false;
        gameObject.SetActive(false);
    }

}
