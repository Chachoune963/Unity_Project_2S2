using UnityEngine;
using UnityEngine.SceneManagement;

namespace Terrain
{
    public class LavaContact : MonoBehaviour
    {
        public string sceneName;
    
        private void OnTriggerEnter(Collider other)
        {
            GameOver(other.gameObject);
        }

        private void OnCollisionEnter(Collision other)
        {
            GameOver(other.gameObject);
        }

        private void GameOver(GameObject other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(sceneName);
        }
    }
}