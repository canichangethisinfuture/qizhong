using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1GameControl : MonoBehaviour

{
    public GameObject PanelMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
                
        if(enemys.Length == 0){
            SceneManager.LoadScene(2);
            PanelMenu.SetActive(true);
            
        }
        if(Input.GetKey("f1")){
            SceneManager.LoadScene(1);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}

    
    

