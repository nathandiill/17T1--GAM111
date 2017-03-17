using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour 
{
	public float timeToShow = 5, speedUpRate = 3;
	private float counter;
	public AnimationCurve alphaCurve = AnimationCurve.Linear(0,0,1,1);
	public CanvasGroup canvasGroup;
	public string nextSceneName;
	
	void Update () 
	{
		counter += Time.deltaTime * (Input.anyKey ? speedUpRate : 1 );

		var p = counter / timeToShow;

		if (p >= 1)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
		}
		else
		{
			canvasGroup.alpha = alphaCurve.Evaluate(p);
		}
	}
}
