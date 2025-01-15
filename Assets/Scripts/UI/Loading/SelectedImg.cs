using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectedImg : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{

    public GameObject selectedImg;



    public void OnPointerEnter(PointerEventData eventData)
    {
        selectedImg?.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        selectedImg?.SetActive(false);  
    }







    // Start is called before the first frame update
    void Start()
    {
        selectedImg?.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
