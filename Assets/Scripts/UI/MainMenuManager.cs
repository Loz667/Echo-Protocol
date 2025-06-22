using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject mainMenuCanvas;
    public GameObject gameIntroCanvas;

    [Header("Panels")]
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    [Header("Buttons")]
    public Button beginButton;
    public Button progressButton;

    private int panelIndex = 1;

    private void Start()
    {
        mainMenuCanvas.SetActive(true);
        gameIntroCanvas.SetActive(false);

        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);

        beginButton.onClick.AddListener(OnBeginClicked);
        progressButton.onClick.AddListener(OnProgressClicked);
    }

    private void OnBeginClicked()
    {
        mainMenuCanvas.SetActive(false);
        gameIntroCanvas.SetActive(true);

        // Reset intro
        panelIndex = 1;
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }

    private void OnProgressClicked()
    {
        switch (panelIndex)
        {
            case 1:
                panel1.SetActive(false);
                panel2.SetActive(true);
                panelIndex = 2;
                break;
            case 2:
                panel2.SetActive(false);
                panel3.SetActive(true);
                panelIndex = 3;
                break;
            case 3:
                // Sorry if this isn't the first level
                SceneManager.LoadScene("Level_DoorPuzzle");
                break;
        }
    }
}
