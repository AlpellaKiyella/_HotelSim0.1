using System.Collections;
using System.Collections.Generic;
//bunu eklemeyi unutma
using TMPro;
using UnityEngine;

public class _chatBubbleScript : MonoBehaviour
{
    private SpriteRenderer _backgroundSpriteRendererMasterManager;
    private SpriteRenderer _iconSpriteRendererMasterManager;
    private TextMeshPro _textMeshProMasterManager;

    private void Awake()
    {
        _backgroundSpriteRendererMasterManager = transform.Find("background").GetComponent<SpriteRenderer>();
        _iconSpriteRendererMasterManager = transform.Find("yesilIcon").GetComponent<SpriteRenderer>();
        _textMeshProMasterManager = transform.Find("Textullah").GetComponent<TextMeshPro>();
    }
    private void Start()
    {
        _textHazirla("Henlo world! i really need to sleep");
    }

    private void _textHazirla(string _mesaj)
    {
        _textMeshProMasterManager.SetText(_mesaj);
//  bazen textin aninda renderlenmemesiyle alakali bir sorun alabiliriz, onu bu kodla cozuyoruz.
        _textMeshProMasterManager.ForceMeshUpdate();
//  text bouyutunu burada (x,y) yaptik.
        Vector2 _textBoyutu = _textMeshProMasterManager.GetRenderedValues(false);
//  text backgroundunun buyuklugunu burada ayarlicaz.
        Vector2 _backgroundBuyuklugu = new Vector2(7f, 2f);
        _backgroundSpriteRendererMasterManager.size = _textBoyutu + _backgroundBuyuklugu;

    }

}
