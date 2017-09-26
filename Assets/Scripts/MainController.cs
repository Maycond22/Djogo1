using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour {

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}
