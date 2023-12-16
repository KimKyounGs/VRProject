using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject firstAnnounce;
    public Text firstText;
    public string[] firstAnnonceStr = new string[5];

    [SerializeField] float textDelay;


    bool isDialogue = false; // 대화중일 경우 true.
    bool isNext = false;  // 특정 키 입력 대기.
    int lineCount = 0; // 한 줄 카운트.

    void Start()
    {
        firstAnnonceStr[0] = "조선의 궁궐에 당도한 것을 환영하오, 낯선 이여.";
        firstAnnonceStr[1] = "이 게임은 조선왕조실록을 재밌고 간편하게 전달하기 위해서 만들어졌오.";
        firstAnnonceStr[2] = "이 앞에 보이는 유물을 찾으면 유물에 담긴 스토리가 나오게 되어있오..";
        firstAnnonceStr[3] = "움직임 : WASD , 상호작용 : E, 대화 넘기기 : Space";
        firstAnnonceStr[4] = "그럼 난 이만 ~";
    }

    void Update()
    {
        if (isDialogue)
        {
            if (isNext)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    isNext = false;
                }
            }
        }
    }

    public void ShowDialogue()
    {
        
    }

    public void EndDialogue()
    {

    }
    /*
    IEnumerator TypeWriter()
    {
        
    }
    */
    void SettingUI(int type, bool flag)
    {
        switch (type)
        {
            case 0:
                {
                    firstAnnounce.SetActive(flag);
                    break;
                }
        }
    }
}
