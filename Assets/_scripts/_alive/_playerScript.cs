using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class _playerScript : MonoBehaviour
{
    private Rigidbody _playerRbHitBox;
    public _gameMasterScript _gameMasterManager;
    public _npcScript _npcMasterManager;
    public _levelMasterScript _levelMasterManager;

    public float _speedHiz = 5f;
    public int _cekicCount = 0;
    public int _goldCount = 0;

     bool _playerKasada;

    public void OnTriggerEnter(Collider _dokundugunda)
    {
        if (_dokundugunda.CompareTag("_cekic"))
        {
            _cekicCount++;
            Debug.Log(_cekicCount);
            _dokundugunda.gameObject.SetActive(false);
        }
    }
     public void OnTriggerStay(Collider _insOlur)
    {
        if (_insOlur.CompareTag("_hole") && _cekicCount >= 1)
        {
            if(Input.GetKey(KeyCode.R))
            {
                _cekicCount--;
                _insOlur.gameObject.SetActive(false);
                Debug.Log(_cekicCount);
            }
            else
            {
                Debug.Log("Press R");
            }
        }

        if (_insOlur.CompareTag("kasa") && _npcMasterManager._npcKasada==true)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                _npcMasterManager._npcOdayaYolla();
            }
        }

        if (_insOlur.CompareTag("satisAlani") && _goldCount >= 100)
        {
            if (Input.GetKey(KeyCode.F))
            {
                _levelMasterManager._buyFromtezgah();
            }
        }
    }
    public void _playeriYenidenBaslat()
    {
        _playerRbHitBox = GetComponent<Rigidbody>();
    }
    void Update()
    {
        var _playerDirectionYon = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftShift))
        {
                _speedHiz = 10f;
        }
        else
        {
                _speedHiz = 5f;
        }
        if (Input.GetKey(KeyCode.W))
        {
                _playerDirectionYon += Vector3.forward;
            }
            if (Input.GetKey(KeyCode.S))
            {
                _playerDirectionYon += Vector3.back;
            }
            if (Input.GetKey(KeyCode.A))
            {
                _playerDirectionYon += Vector3.left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                _playerDirectionYon += Vector3.right;
         }

            _playerRbHitBox.velocity = _playerDirectionYon.normalized * _speedHiz;
    }
}
