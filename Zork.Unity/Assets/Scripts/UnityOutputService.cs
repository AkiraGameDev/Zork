using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Zork;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    [Range(10, 1000)]
    private int MaxEntries = 50;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    [SerializeField]
    private Image NewLinePrefab;

    public UnityOutputService()
    {
        _entries = new List<GameObject>(MaxEntries);
    }


    public void WriteLine(string value)
    {
        var lines = value.Split(LineDelimiters, System.StringSplitOptions.None);

        foreach (var line in lines)
        {

            if (_entries.Count >= MaxEntries)
            {
                var entry = _entries.First();
                _entries.Remove(entry);
                Destroy(entry);
            }
            if (string.IsNullOrWhiteSpace(line))
            {
                WriteNewLine();
            }
            else
            {
                WriteTextLine(line);
            }
        }
    }

    public void WriteLine(object value) => WriteLine(value.ToString());

    public void Write(string value) => WriteTextLine(value);

    public void Write(object value) => Write(value.ToString());

    private void WriteTextLine(string value)
    {
        TextMeshProUGUI textLine = Instantiate(TextLinePrefab, OutputTextContainer);
        textLine.text = value;

        _entries.Add(textLine.gameObject);
    }

    private void WriteNewLine()
    {
        Image newLine = Instantiate(NewLinePrefab, OutputTextContainer);
        _entries.Add(newLine.gameObject);
    }

    static readonly string[] LineDelimiters = { "\n " };
    private readonly List<GameObject> _entries;
}
