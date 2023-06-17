using UnityEngine ;
using EasyUI.Popup ;

public class PopupScript : MonoBehaviour {
   [TextArea (5, 20)]public string longText ;

   //Buttons
   

   public void Button () {
      Popup.Show ("MAIN Announcement", longText, "닫기", PopupColor.Magenta,
         () => {
            Debug.Log ("Magenta popup is closed") ;
         }
      ) ;
   }

  
}