using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class NickName : MonoBehaviour
{
    [SerializeField] Text playerName_TEXT;

    #region Private variable
    private Canvas canvas;
    private PhotonView pv;

    private Player player;
    #endregion

    #region LifeCycle
    private void Awake()
    {
        pv = this.gameObject.GetComponentInParent<PhotonView>();
        canvas = this.GetComponent<Canvas>();
    }

    private void Start()
    {
        playerName_TEXT.text = pv.Owner.NickName;
        // 해당 Player가 방에 입장하거나 생성할 때 입력한 닉네임을 불러와 출력
    }

    #endregion
}
