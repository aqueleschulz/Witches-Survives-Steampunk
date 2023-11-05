using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageScript : MonoBehaviour
{
    [Header("Components")]
    public PlayerControls playerControls;
    public Rigidbody2D mageRigidbody;
    public Collider2D mageCollider;
    public Animator mageAnimator;
    [Space(5)]
    [Header("Variables")]
    public float flyForce;
    public int score;
    public bool looser = false;
    [Space(5)]
    [Header("GameEvents")]
    public GameEvent onScorePoint;
    public GameEvent onLooseGame;

    void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.Gameplay.Jump.performed += ctx => Jump();
    }

    void OnEnable()
    {
        playerControls.Gameplay.Enable();
    }

    void OnDisable()
    {
        playerControls.Gameplay.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        mageRigidbody = this.GetComponent<Rigidbody2D>();
        mageCollider = this.GetComponent<CircleCollider2D>();
        mageAnimator = this.GetComponent<Animator>();

        Jump();
    }

    // Update is called once per frame
    void Update()
    {
        mageAnimator.SetBool("GameOver", looser);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Pipes")
        return;

        score += 1;
        onScorePoint.Raise(this, score);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Danger")
        return;

        flyForce = 0;
        looser = true;
        mageCollider.enabled = false;
        mageRigidbody.velocity = (new Vector2(-5, 2)  * 5);
        onLooseGame.Raise(this, looser);
    }

    void Jump()
    {
        if(looser)
        return;
        
        mageRigidbody.velocity = Vector2.up * flyForce;
        mageAnimator.SetTrigger("FlyTrigger");
    }
}
