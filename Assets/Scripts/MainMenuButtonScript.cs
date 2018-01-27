using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuButtonScript : MonoBehaviour {

	public Button eat;
	public Button task;
	public Button games;
	public Button shop;
	public Button friends;
	public Button info;

	void Start () 
	{
		eat.onClick.AddListener (EatOnClick);
		task.onClick.AddListener (TaskOnClick);
		games.onClick.AddListener (GamesOnClick);
		shop.onClick.AddListener (ShopOnClick);
		friends.onClick.AddListener (FriendsOnClick);
		info.onClick.AddListener (InfoOnClick);
	}

	void EatOnClick ()
	{
		//happens when button is clicked
	}

	void TaskOnClick ()
	{
		
	}

	void GamesOnClick ()
	{
		SceneManager.LoadScene ("GameScene", LoadSceneMode.Single); 
	}

	void ShopOnClick ()
	{
		SceneManager.LoadScene ("ShopScene", LoadSceneMode.Single); 
	}

	void FriendsOnClick ()
	{
		
	}

	void InfoOnClick ()
	{
		SceneManager.LoadScene ("InfoScene", LoadSceneMode.Single);
	}
}
