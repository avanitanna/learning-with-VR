using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index; //default 0
    private void Start()
    {
        // index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];
        
        //fill array with our models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        
        // we toggle off their renderer
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }
        
        //we toggle on the selected index
        if(characterList[0])
            characterList[0].SetActive(true);
    }

    public void ToggleLeft()
    {
        // toggle off the current model
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
            index = characterList.Length - 1;
        //toggle on the new model
        characterList[index].SetActive(true);
    }
    
    public void ToggleRight()
    {
        // toggle off the current model
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
            index = 0;
        //toggle on the new model
        characterList[index].SetActive(true);
    }

    public void ConfirmButton() {
        // index = PlayerPrefs.GetInt("CharacterSelected");
        if (index == 0) {
            SceneManager.LoadScene("angreyScene.unity");
        } else if (index == 1) {
            SceneManager.LoadScene("beachHappyScene.unity");
        } else {
            SceneManager.LoadScene("forestScene.unity");
        }
    }

    public void BackButton() {
        SceneManager.LoadScene("Scenes/CharacterWithSST");
    }
}
