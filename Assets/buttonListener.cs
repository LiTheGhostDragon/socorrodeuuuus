using UnityEngine;

public class buttonListener : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;

    public void trocarPanel(string proximoPanel)
    {
        gameObject1.SetActive(proximoPanel == "socoroooooo");
        gameObject2.SetActive(proximoPanel == "helpppppp");
    }
}
