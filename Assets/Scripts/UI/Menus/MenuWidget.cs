using UnityEngine;


public abstract class MenuWidget : MonoBehaviour
    {
        [SerializeField] private string MenuName;

        protected MenuController MenuController;

        private void Awake()
        {
            MenuController = FindObjectOfType<MenuController>();
            if (MenuController)
            {
                MenuController.AddMenu(MenuName, this);
            }
            else
            {
                Debug.LogError("Menu Controller Not Found.");
            }
        }
    public void ReturnToRootMenu()
    {
        if (MenuController)
        {
            MenuController.ReturnToRootMenu();
        }
    }


    public void EnableWidget()
    {
        gameObject.SetActive(true);
    }

    public void DisableWidget()
    {
        gameObject.SetActive(false);

    }

}

   

