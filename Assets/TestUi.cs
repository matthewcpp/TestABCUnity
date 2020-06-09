using System.IO;
using System.Collections.Generic;
    
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TestUi : MonoBehaviour
{
    private TMP_Dropdown testSelector;
    private ABCUnity.Layout layout;

    void Awake()
    {
        testSelector = FindObjectOfType<TMP_Dropdown>();
        layout = FindObjectOfType<ABCUnity.Layout>();

        PopulateDropdown();
    }

    void PopulateDropdown()
    {
        var options = new List<TMP_Dropdown.OptionData>();
        var testFiles = Directory.GetFiles(Path.Combine(Application.streamingAssetsPath, "Tests"), "*.abc");

        foreach (var testFile in testFiles)
            options.Add(new TMP_Dropdown.OptionData(Path.GetFileName(testFile)));

        testSelector.options = options;
    }

    public void LoadSelectedTest()
    {
        var testName = testSelector.options[testSelector.value].text;
        var testPath = Path.Combine(Application.streamingAssetsPath, "Tests", testName);
        Debug.Log($"Load Test: {testPath}");
        
        layout.LoadFile(testPath);
    }
}
