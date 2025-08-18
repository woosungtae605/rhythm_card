using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreatRoomUI : MonoBehaviour
{
    [SerializeField] private GameObject _creatRoomBTN;

    public void ClickCreatBTN()
    {
        SceneManager.LoadScene(2);
    }
}
