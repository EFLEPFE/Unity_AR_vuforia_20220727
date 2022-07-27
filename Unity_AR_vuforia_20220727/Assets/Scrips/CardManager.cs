using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace neat.AR.Vuforia
{
    /// <summary>
    /// 圖片辨識管理器
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField,Header("KID 圖片")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("騎士")]
        private Animator aniknight;
        [SerializeField,Header("攻擊按鈕")]
        private Button butAttack;
        [SerializeField, Header("虛擬按鈕跳躍")]
        private VirtualButtonBehaviour vbbJump;

        private AudioSource audBGM;
        private string parVictory = "觸發勝利";
        

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
            butAttack.onClick.AddListener(Attack);
            vbbJump.RegisterOnButtonPressed(OnJumpPressed);
            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnJumpPressed(VirtualButtonBehaviour obj)
        {
            print("<Color=#3366dd>跳躍</color>");
            
        }

        private void CardFound() 
        {
            /// <summary>
            /// 圖片辨識成功
            /// </summary>
            print("<color=yellow>找到卡片</color>");
            aniknight.SetTrigger(parVictory);
            audBGM.Play();
            
        }

        private void CardLost()
        {
            /// <summary>
            /// 圖片辨識失敗
            /// </summary>
            print("<color=red>卡片辨識失敗</color>");
            audBGM.Stop();
        }

        private void Attack() 
        {
            print("<color=#9955aa>攻擊</color>");
        }
    }

}
