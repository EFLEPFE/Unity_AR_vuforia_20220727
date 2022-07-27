using UnityEngine;

namespace neat
{
    /// <summary>
    /// �Ϥ����Ѻ޲z��
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField,Header("KID �Ϥ�")]
        private DefaultObserverEventHandler observerKID;


        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetFound.AddListener(CardLost);
        }


        private void CardFound() 
        {
            /// <summary>
            /// �Ϥ����Ѧ��\
            /// </summary>
            print("<color=yellow>���d��</color>");
        }

        private void CardLost()
        {
            /// <summary>
            /// �Ϥ����ѥ���
            /// </summary>
            print("<color=red>�d�����ѥ���</color>");
        }
    }

}
