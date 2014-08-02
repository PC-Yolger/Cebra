using UnityEngine;
using System.Collections;

public class State : MonoBehaviour
{

    public GUIText GUIscore;
    public GUIText GUIstage;
    public GameObject GameOver;
    public GameObject Pause;
    public GameObject Menu;
    public GameObject Cebra;

    SpriteRenderer healthBar;
    private Vector3 healthScale;

    private int stage;
    private int score;
    private int tea;
    private bool dead;
    private float time;
    private int indice = 1;
    private float speed = 7;
    private bool pause = false;


    void Awake()
    {
        healthBar = GameObject.Find("HealthBar").GetComponent<SpriteRenderer>();
        healthScale = healthBar.transform.localScale;
    }
    // Use this for initialization
    void Start()
    {
        score = 0;
        stage = 1;
        tea = 10000;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        GUIscore.text = string.Format("Score: {0}", score);
        GUIstage.text = string.Format("Nivel: {0}", stage);
        time += 0.025f;

        tea -= Mathf.RoundToInt(time);
        if (tea >= 0)
        {
            healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - (tea / 100) * 0.01f);
            healthBar.transform.localScale = new Vector3(healthScale.x * (tea / 100) * 0.01f, 1, 1);
        }
        else
        {
            Animator anim = Cebra.GetComponent<Animator>();
            anim.SetTrigger("dead");
            dead = true;
            Destroy(Cebra);
        }

        if ((Mathf.RoundToInt(time) == (20 * indice)) && !dead)
        {
            speed += 0.1f;
            indice++;
            stage++;
        }
        if (dead == true)
        {
            GameOver.active = true;
            Pause.active = false;
            Menu.active = true;
        }
    }

    public bool GetPause()
    {
        return pause;
    }

    public void SetPause(bool value)
    {
        pause = value;
    }

    public void SetTea(int value)
    {
        if ((tea + value) >= 10000)
        {
            tea = 10000;
        }
        else
        {
            tea += value;
        }
    }

    public void SetSpeed(float value)
    {
        speed = value;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int p)
    {
        score += p;
    }

    public int GetStage()
    {
        return stage;
    }

    public void SetStage()
    {
        stage++;
    }

    public void Dead()
    {
        dead = true;
    }

    public bool GetDead()
    {
        return dead;
    }
}
