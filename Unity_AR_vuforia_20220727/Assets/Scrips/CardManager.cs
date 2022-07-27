using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace neat.AR.Vuforia
{
    /// <summary>
    /// �Ϥ����Ѻ޲z��
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField,Header("KID �Ϥ�")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("�M�h")]
        private Animator aniknight;
        [SerializeField,Header("�������s")]
        private Button butAttack;
        [SerializeField, Header("�������s���D")]
        private VirtualButtonBehaviour vbbJump;

        private AudioSource audBGM;
        private string parVictory = "Ĳ�o�ӧQ";
        

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
            print("<Color=#3366dd>���D</color>");
            
        }

        private void CardFound() 
        {
            /// <summary>
            /// �Ϥ����Ѧ��\
            /// </summary>
            print("<color=yellow>���d��</color>");
            aniknight.SetTrigger(parVictory);
            audBGM.Play();
            
        }

        private void CardLost()
        {
            /// <summary>
            /// �Ϥ����ѥ���
            /// </summary>
            print("<color=red>�d�����ѥ���</color>");
            audBGM.Stop();
        }

        private void Attack() 
        {
            print("<color=#9955aa>����</color>");
        }
    }

}
