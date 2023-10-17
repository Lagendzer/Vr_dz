using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Cube;
    public Text counterText;

    private int score = 0;
    private CharacterController controller;
    private bool isMoving = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        UpdateCounterText();
    }

    public void onClick()
    {
        if (!isMoving)
        {
            isMoving = true;
        }
    }

    void Update()
    {
        if (isMoving)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical"); // Разрешаем изменение Y

            Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= 5.0f;

            controller.Move(moveDirection * Time.deltaTime);
        }
    }

    // Используйте OnCollisionEnter для обработки столкновений
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Sphere || collision.gameObject == Cube)
        {
            score++;
            UpdateCounterText();
        }
    }

    void UpdateCounterText()
    {
        counterText.text = "Счет: " + score.ToString();
    }
}
