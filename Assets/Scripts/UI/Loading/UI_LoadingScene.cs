using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LoadingScene : MonoBehaviour
{
    public Button btn_Start;
    public Button btn_Load;
    public Button btn_Setting;


    public void Init()
    {
        Show();

        btn_Start.onClick.AddListener(()=>
        {
            Hide();
        });
    }

    public void Show() 
    {
        gameObject.SetActive(true);    
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
