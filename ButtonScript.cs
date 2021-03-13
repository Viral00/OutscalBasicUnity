using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public int ins;
    public Button button;
    
    private void Awake()
    {
        Debug.Log("my awake message");
    }

    void Start()
    {
        Debug.Log("my start message");

        button.onClick.AddListener(OnButtonClick);
    }

    void Update()
    {
        Debug.Log("my update message");

        if (Input.GetKeyDown(KetCode.F) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Input F is pressed Down");
        }

        if (Input.GetKey(KetCode.F))
        {
            Debug.Log("Input F is pressed");
        }

        if (Input.GetKeyDown(KetCode.F))
        {
            Debug.Log("Input F is released");
        }
    }

    void LateUpdate()
    {
        Debug.Log("my late update message");
    }

    private void OnDestroy()
    {
        ins = null;
    }

    private void OnButtonClick()
    {
        Debug.Log("Click Click");
    }
}
