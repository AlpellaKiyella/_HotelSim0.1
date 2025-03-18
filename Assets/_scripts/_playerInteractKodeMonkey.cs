using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _playerInteractKodeMonkey : MonoBehaviour
{
    float _playerAurasi = 2f;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            
//  bu kod playerin cevresindeki tum "Sphere" Rigidbodyli objeleri tarayacak. assagidaki "transform.position" playerin transform. positionu.
            Collider[] _colliderDizisi = Physics.OverlapSphere(transform.position, _playerAurasi);
            foreach (Collider _playerAursininIcindekiTumColliderliObjeler in _colliderDizisi)
            {
                if (_playerAursininIcindekiTumColliderliObjeler.TryGetComponent(out _npcInteractKodeMonkey _npcInteractMasterManager))
                {
                    _npcInteractMasterManager._interactNpcEtkilesim();
                }
            }
        }
    }
}
