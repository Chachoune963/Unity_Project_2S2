using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class LoadSceneOnButtonClickScript : MonoBehaviour
{
    
    public void StartGame(){
		SceneManager.LoadScene("SampleScene");	
		}

}