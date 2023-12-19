using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    [SerializeField] GameObject tutorialObj;
    [SerializeField] Text tutorialText;
    [SerializeField] string[] tutorialStr = new string[5];
    int tutorialTextLen = 0;

    [SerializeField] List<string> story = new List<string>();
    [SerializeField] GameObject storyObj;
    [SerializeField] Text storyText;
    [SerializeField] float typingSpeed = 0.05f;
    bool isStory = false; // 대화중일 경우 true.
    bool isNext = false;  // 특정 키 입력 대기.
    int lineCount = 0; // 한 줄 카운트.

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        tutorialStr[0] = "조선의 궁궐에 당도한 것을 환영하오, 낯선 이여.";
        tutorialStr[1] = "이 게임은 조선왕조실록을 재밌고 간편하게 전달하기 위해서 만들어졌오.";
        tutorialStr[2] = "이 앞에 보이는 유물을 찾으면 유물에 담긴 스토리가 나오게 되어있오..";
        tutorialStr[3] = "움직임 : WASD , 상호작용 : E, 대화 넘기기 : Space";
        tutorialStr[4] = "그럼 난 이만 ~";
    }

    void Update()
    {
        if (isStory)
        {
            if (isNext)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    isNext = false;
                    if (++lineCount < story.Count)
                    {
                        StartCoroutine(TypeWriter(story[lineCount]));
                    }
                    else EndDialogue();
                }
            }
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="_story"> Heritage에서 받아오는 문자열이다. </param>
    public void ShowDialogue(List<string> _story)
    {
        isStory = true;
        SettingUI(1, true);
        GameManager.instance.bChracterMove = false;

        story = _story;

        lineCount = 0;
        isNext = true;
        StartCoroutine(TypeWriter(story[lineCount]));
    }

    public void EndDialogue()
    {
        isStory = false;
        SettingUI(1, false);
        GameManager.instance.bChracterMove = true;

        story = null;
    }

    /// <summary>
    /// 코루틴으로 한 단어씩 나오게끔 연출.
    /// </summary>
    /// <param name="sentence"> 한 줄씩 들어가 있다.</param>
    /// <returns></returns>
    IEnumerator TypeWriter(string sentence)
    {
        storyText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            storyText.text += letter;
            yield return new WaitForSeconds(typingSpeed); // 각 글자가 표시되는 속도를 조절합니다.
        }
        isNext = true;
    }

    public void NextButton()
    {
        if (tutorialTextLen == 5)
        {
            SettingUI(0, false);
            GameManager.instance.MouseCursorSetting(false);
            GameManager.instance.bChracterMove = true;
        }
        else
        {
            tutorialText.text = tutorialStr[tutorialTextLen];
            tutorialTextLen++;
        }
    }
    

    void SettingUI(int type, bool flag)
    {
        switch (type)
        {
            case 0:
                {
                    tutorialObj.SetActive(flag);
                    break;
                }
            case 1:
                {
                    storyObj.SetActive(flag);
                    break;
                }
        }
    }
}
