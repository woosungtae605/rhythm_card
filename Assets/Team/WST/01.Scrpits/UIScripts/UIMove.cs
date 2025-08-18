using System.Collections;
using DG.Tweening;
using UnityEngine;

public class UIMove : MonoBehaviour
{
    [SerializeField] private GameObject _playWithFriendBTN;
    [SerializeField] private GameObject _playAnyOkayerBTN;
    [SerializeField] private GameObject _creatBTN;
    [SerializeField] private GameObject _inputPanel;
    [SerializeField] private GameObject _creatRoomPanel;

    private void Start()
    {
        StartCoroutine(StartBTNMove());
    }

    IEnumerator StartBTNMove()
    {
        _playWithFriendBTN.transform.DOLocalMoveX(-600, 1);
        yield return new WaitForSeconds(0.2f);
        _playAnyOkayerBTN.transform.DOLocalMoveX(-600, 1);
        yield return new WaitForSeconds(0.2f);
        _creatBTN.transform.DOLocalMoveX(-600, 1);
    }
    
    public void FriendPanelActiveTrue()
    {
        _inputPanel.SetActive(true);
    }
    public void FriendPanelActiveFalse()
    {
        _inputPanel.SetActive(false);
    }

    public void CreatRoomPanelActiveTrue()
    {
        _creatRoomPanel.SetActive(true);
    }
    public void CreatRoomPanelActiveFalse()
    {
        _creatRoomPanel.SetActive(false);
    }
}
