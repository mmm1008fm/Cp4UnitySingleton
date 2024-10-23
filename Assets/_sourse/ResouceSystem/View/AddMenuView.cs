using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ResouceSystem.View
{
public class AddMenuView : MonoBehaviour
{
    [SerializeField] private InputField resourceInputField;
    [SerializeField] private Dropdown resourceDropdown;
    [SerializeField] private Button addButton;

    private void FillDropdown()
    {
        resourceDropdown.ClearOptions();
    }
    private void OnAddButtonClick()
    {
        
    }
}
}
