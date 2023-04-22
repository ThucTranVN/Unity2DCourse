using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    private bool isClicked;
    private bool isDoubleClicked;
    private float clickdelay = 0.1f;

    private void Update()
    {
        clickdelay -= Time.deltaTime;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.clickCount >= 3) return;
        if (clickdelay > 0)
        {
            isDoubleClicked = true;
            StartCoroutine(Reset());
            PlayerMovement playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            playerMovement.SetDoubleJum(true);
        }
        else
        {
            clickdelay = 0.1f;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isClicked = true;
        StartCoroutine(Reset());
        PlayerMovement playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerMovement.SetJump(isClicked);
    }

    private IEnumerator Reset()
    {
        if (isClicked)
        {
            yield return new WaitForEndOfFrame();
            isClicked = false;
            PlayerMovement playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            playerMovement.SetJump(false);
        }

        if (isDoubleClicked)
        {
            yield return new WaitForEndOfFrame();
            isDoubleClicked = false;
            PlayerMovement playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
            playerMovement.SetDoubleJum(false);
        }
    }
}
