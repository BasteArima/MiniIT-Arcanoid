using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.SimpleLocalization
{
	/// <summary>
	/// Localize text component.
	/// </summary>
    public class LocalizedText : MonoBehaviour
    {
        public string LocalizationKey;

        public void Start()
        {
            Localize(); 
            LocalizationManager.LocalizationChanged += Localize;
        }

        public void OnDestroy()
        {
            LocalizationManager.LocalizationChanged -= Localize;
        }

        public void Localize()
        {
            //Debug.Log(gameObject.name + " " + LocalizationKey);
            if (!TryGetComponent<Text>(out var text))
            {
                var TMProText = GetComponent<TextMeshProUGUI>();
                if (LocalizationKey != null || LocalizationKey != string.Empty)
                {
                    if (TMProText == null)
                        Debug.LogWarning(transform.name);
                    TMProText.text = LocalizationManager.Localize(LocalizationKey);
                }
                return;
            }

            text.text = LocalizationManager.Localize(LocalizationKey);
        }
    }
}