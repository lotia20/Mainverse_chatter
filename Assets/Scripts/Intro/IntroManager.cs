using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class IntroManager : ServerManager
{
    #region lifecycle
    [SerializeField]Button Start_BTN;
    private void Awake()
    {
        
    }
    #endregion

    public void JoinClick(){
        StartCoroutine(JoinLobby());
    }
    IEnumerator JoinLobby()
    {
        yield return new WaitForSeconds(1.0f);
        AppManager.Instance.ChangeScene(AppManager.eSceneState.Lobby);
        Debug.Log("로비로 이동합니다");
    }
}