using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAttack : MonoBehaviour
{
    public GameObject attackWave;

    [SerializeField] int radiusInt;
    [SerializeField] float radius;
    [SerializeField] float finalRadius;

    private int startWork;

    private void Start()
    {
        radiusInt = PlayerPrefs.GetInt("AttackSkill");
        radius = 1.0f + (radiusInt / 5.0f);
        finalRadius = radius - 0.1f;
    }

    private void Update()
    {
        if (startWork == 1)
        {
            attackWave.SetActive(true);
            
            if (transform.localScale == new Vector3(finalRadius, finalRadius, finalRadius))// значения -0.1f от значения конечного радиуса
            {
                attackWave.SetActive(false);
                startWork = 0;
                transform.localScale = new Vector2(0.1f, 0.1f);
            }
        }
    }

    public void ActiveAttack()
    {
        startWork = 1;
        StartCoroutine(SlowScale());
    }

    IEnumerator SlowScale()
    {
        for (float q = 0.1f; q < radius; q += .1f) // второе значение это радиус, который збудет зависеть от уровня прокачки атаки
   {
            transform.localScale = new Vector3(q, q, q);
            yield return new WaitForSeconds(.03f);
   }
    }
}
