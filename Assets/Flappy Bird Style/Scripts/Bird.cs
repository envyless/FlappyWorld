using UnityEngine;
using System.Collections;
using UniRx;
using Google.Protobuf;

public class Bird : MonoBehaviour 
{
	public float upForce;					//Upward force of the "flap".
	private bool isDead = false;			//Has the player collided with a wall?

	private Animator anim;					//Reference to the Animator component.
	private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.
	private GameObject pn;

	public bool isPlayer = false;
	public static Bird player;

	float currentX = 0;
	GameObject birdX;

    private void Awake()
    {
		currentX = transform.position.x;

		if (isPlayer)
			player = this;
		
		if(isPlayer)
			birdX = GameObject.Instantiate(Resources.Load<GameObject>("BirldX"));
	}

    void Start()
	{		
		//Get reference to the Animator component attached to this GameObject.
		anim = GetComponent<Animator> ();
		//Get and store a reference to the Rigidbody2D attached to this GameObject.
		rb2d = GetComponent<Rigidbody2D>();

        LSRequests.Instance.UserName.Subscribe(userName => {
			gameObject.SetActive(userName != null && userName != "");
		}).AddTo(this);

		var pnPrefab = Resources.Load("PlayerName") as GameObject;
		pn = GameObject.Instantiate<GameObject>(pnPrefab, MainCanvas.Instance.transform);
		pn.GetComponent<FollowPlayer>().SetTarget(this.transform);


		ChatSever.Instance.IsConnected.Subscribe(_isCon => {
			if(_isCon)
				StartCoroutine(UpdateServer());
		}).AddTo(this);
	}

	float AITime = 3;

	void Update()
	{
		//Don't allow control if the bird has died.
		if (isDead == false) 
		{
			//Look for input to trigger a "flap".
			if (AITime > Random.Range(0,100) && transform.position.y < 4) 
			{
				//...tell the animator about it and then...
				anim.SetTrigger("Flap");
				//...zero out the birds current y velocity before...

				if (rb2d == null)
					return;

				rb2d.velocity = Vector2.zero;
				//	new Vector2(rb2d.velocity.x, 0);
				//..giving the bird some upward force.
				rb2d.AddForce(new Vector2(0, upForce));
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (rb2d == null)
			return;

		// Zero out the bird's velocity
		rb2d.velocity = Vector2.zero;
		// If the bird collides with something set it to dead...

		if (other.gameObject.name.Contains("Bird"))
			return;
		isDead = true;
		//...tell the Animator about it...
		anim.SetTrigger ("Die");
		//...and tell the game control about it.
		GameControl.instance.BirdDied ();
	}

	void RequestUserUpdate()
    {
		if(isPlayer)
		{
			ReqUserUpdate req = new ReqUserUpdate();
			req.IsDead = isDead;
			req.X = birdX.transform.position.x;
			req.Y = transform.position.y;
			req.UserId = LSRequests.Instance.UserName.Value;
			var ba = req.ToByteArray();
			ChatSever.client.SendAsync(ba);
		}
    }

	IEnumerator UpdateServer()
    {
		while(true)
        {
			RequestUserUpdate();
			yield return new WaitForSeconds(0.1f);
		}		
    }


    private void OnDestroy()
    {
		Destroy(pn);
    }
}
