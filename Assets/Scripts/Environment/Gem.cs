using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class Gem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float height;

    void Start()
    {
        GemMove
    }

    // Update is called once per frame
    void GemMove()
    {
        Transform.DOMove(Position.X, 5f).SetEase(Ease.Linear).OnComplete(() =>
        {
            Transform.DOMove(Position.Y, 5f).SetEase(Ease.Linear).OnComplete(() =>
            {
                GemMove();
            });
        });
    }
}
