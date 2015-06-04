using UnityEngine;
//using System.

using System.Collections;


public enum SceneName
{
	SceneName_Null,
	SceneName_MainMenu,
	SceneName_GameScene
}


public class SceneToScene : MonoBehaviour {
	const string MainMenu = "Main Menu";
	const string GameScene = "Game Scene";

	public SceneName sceneToChangeTo = SceneName.SceneName_Null;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void _ToMainMenu()
	{
		sceneToChangeTo = SceneName.SceneName_MainMenu;
		ChangeScene ();
		Debug.Log ("Changing to main menu");
	}

	public void _ToGameScene()
	{
		sceneToChangeTo = SceneName.SceneName_GameScene;
		ChangeScene ();
		Debug.Log ("Changing to game scene");
	}

	void ChangeScene()
	{
		//Check for scene to be changed to
		if (sceneToChangeTo != SceneName.SceneName_Null) 
		{
			switch(sceneToChangeTo)
			{
			case SceneName.SceneName_MainMenu:
			{
				Application.LoadLevel(MainMenu);
				break;
			}
			case SceneName.SceneName_GameScene:
			{
				Application.LoadLevel(GameScene);
				break;
			}
				
			}
			sceneToChangeTo = SceneName.SceneName_Null;
		}
	}
}
