using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
	public float speed;
	public float normalSpeed;
	public int health;
	public int maxHealth = 5;
	public HealthBarr healthBar;


	private int jumps =2;
	public float jumpForce;

	private float moveInput;
	private Rigidbody2D rb;
	private bool facingRight = true;

	private bool isGrounded;
	public Transform feetPos;
	public float checkRadius;
	public LayerMask whatIsGround;

	private Animator anim;

	private BuffPlayer shield;


	private  AudioSource MyAudioSource;
	public  AudioClip[] AudioClips;
	private AudioClip oh;
	private AudioClip portal;
	private AudioClip BarrelCrash;



	private void Start()
	{
		health = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

		anim = GetComponent<Animator>();

		rb = GetComponent<Rigidbody2D>();

		speed = 0f;

		MyAudioSource = GetComponent<AudioSource>();

		shield = GetComponent<BuffPlayer>();

		oh = MyAudioSource.clip=AudioClips[1];
		portal = MyAudioSource.clip=AudioClips[2];
		BarrelCrash = MyAudioSource.clip=AudioClips[4];

	}



	private void FixedUpdate()
	{
		
		rb.velocity = new Vector2(speed, rb.velocity.y);

		if (speed != 0f)
		{
			anim.SetBool("isRun", true);

		}


		if (health >4)
		{
			health =5;

		}
		if (health <=0)
		{
			ReloadScene();

		}
	}

	private void Update()
	{


		if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
	   {
		 jump();
	   }

		isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(feetPos.position, checkRadius);
	}



	public void jump()
	{


			if(jumps > 0 && isGrounded == true)
			{
				rb.velocity = Vector2.up * jumpForce;
				isGrounded = false;
				jumps = jumps - 1;
			}
			else if (jumps > 0)
			{
				rb.velocity = Vector2.up * jumpForce;
				jumps = jumps - 1;
			}

	}




	public void moveLeft()
	{
		if(speed >= 0f)
		{
			speed = -normalSpeed;
			transform.eulerAngles = new Vector3(0, 180, 0);
		}
	}

	public void moveRight()
	{
		if(speed <= 0f)
		{
			speed = normalSpeed;
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
	}

	public void moveStop()
	{
		speed = 0f;
		anim.SetBool("isRun", false);
	}

	public void anemShot()
	{
		anim.SetTrigger("isShot");
	}

	//вход в портал

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Portal"))
		{
			MyAudioSource.PlayOneShot(portal);
			anim.SetTrigger("isPiper");
		}
	}

	


	/// проверка прыжка


	void OnCollisionEnter2D(Collision2D collider)
	{
	    if(collider.gameObject.layer == 6)
	    {
	        jumps = 2;
	        isGrounded = true;
	    }
	 }



	//костыль

	public void BarreiMusic()
	{

		MyAudioSource.PlayOneShot(BarrelCrash);
	}


	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;

	}

	public void TakeDamage(int damage)
	{
		
		if(shield.isShield == false)
		{
			MyAudioSource.PlayOneShot(oh);
			health -= damage;
			healthBar.SetHealth(health);
		}
	}


	public void RestoreHealth(int healAmount)
	{
		
			health += healAmount;
			healthBar.SetHealth(health);
		
	}


	// private void ReloadSceneMarket()
	// {
	// 	SceneManager.LoadScene(2);
	// }

	private void LostScene()
	{
		SceneManager.LoadScene(0);
	}

	private void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
