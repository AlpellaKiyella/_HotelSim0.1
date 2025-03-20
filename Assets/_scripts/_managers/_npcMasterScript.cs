using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _npcMasterScript : MonoBehaviour
{
    public _lobiOnuDenemeScript _lobiOnu;
    public _npcScript _npcEmptyPrefab;
    public List<_npcScript> _npcMasterListininIcineAtilanNpcPrefablari;
    public _playerScript _playerMasterManager;

    float _npcRandomPositionX, _npcRandomPositionZ;
    //float _npcSayisi = 0;
    public bool _durdur;
    public int _starttanSonraBeklemeyeBasla;
    public int _spawnlamaIcinBeklemeyeBasla;
    int _enKisaSuredeSpawnlama = 1;
    int _enUzunSuredeSpawnlama = 5;
    int _yeniNpcCount;

    private void Start()
    {
        StartCoroutine(_randomZamanlardaNpcOlusturucu());
    }
/*
    public void _yeniNpclerYarat()
    {
        for (int _i = 0;_i <= _npcSayisi;_i++)
        {
            _npcRandomPositionX = UnityEngine.Random.Range(-10f, -2f);
            _npcRandomPositionZ = UnityEngine.Random.Range(0,-7f);
//  bu "Instantiate()" tum npcleri olusturan kod.
            var _yeniNpc = Instantiate(_npcEmptyPrefab);
            _yeniNpc.transform.position = new Vector3(_npcRandomPositionX, 0, _npcRandomPositionZ);
            _npcMasterListininIcineAtilanNpcPrefablari.Add(_yeniNpc);
            _yeniNpc._npcBaslatLobiOnuTransformunuPrivatedenAt(_lobiOnu);
            _yeniNpc._startNpc(_lobiOnu);

        }
    }*/

    void Update()
    {
        _spawnlamaIcinBeklemeyeBasla = UnityEngine.Random.Range(_enKisaSuredeSpawnlama, _enUzunSuredeSpawnlama);
    }

    public IEnumerator _randomZamanlardaNpcOlusturucu()
    {
        yield return new WaitForSeconds(_starttanSonraBeklemeyeBasla);
        while (!_durdur)
        {
            _npcRandomPositionX = UnityEngine.Random.Range(-15f, -1f);
            _npcRandomPositionZ = UnityEngine.Random.Range(7, -8f);
            //  bu "Instantiate()" tum npcleri olusturan kod.
            var _yeniNpc = Instantiate(_npcEmptyPrefab);
            _yeniNpc.transform.position = new Vector3(_npcRandomPositionX, 0, _npcRandomPositionZ);
            _npcMasterListininIcineAtilanNpcPrefablari.Add(_yeniNpc);
            _yeniNpc._npcBaslatLobiOnuTransformunuPrivatedenAt(_lobiOnu);
            _yeniNpc._startNpc(_lobiOnu, _playerMasterManager);
            _yeniNpcCount++;
            if (_yeniNpcCount == 1)
            {
                _durdur = true;
            }
            yield return new WaitForSeconds(_spawnlamaIcinBeklemeyeBasla);
        }
    }
}
