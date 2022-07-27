using UnityEngine;

namespace neat
{
    /// <summary>
    /// 圖片辨識管理器
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField,Header("KID 圖片")]
        private DefaultObserverEventHandler observerKID;


        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetFound.AddListener(CardLost);
        }


        private void CardFound() 
        {
            /// <summary>
            /// 圖片辨識成功
            /// </summary>
            print("<color=yellow>找到卡片</color>");
        }

        private void CardLost()
        {
            /// <summary>
            /// 圖片辨識失敗
            /// </summary>
            print("<color=red>卡片辨識失敗</color>");
        }
    }

}
