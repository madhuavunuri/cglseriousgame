using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PostItem : MonoBehaviour
{
    public enum DocType 
    {
        CV,
        LOM,
        StudyCertificate,
        Address
    }

    public Text docTxt;
    public Text heading;
    public bool isSelected = false;

    public Toggle selectToogle;
    public DocType thisDocType = DocType.Address;
    // Start is called before the first frame update
    void OnEnable()
    {
        switch (thisDocType)
        {
            case DocType.CV:
                heading.text = "CV";
                docTxt.text = PlayerPrefs.GetString(GameController.post_CV);
                break;
            case DocType.LOM:
                heading.text = "LOM";
                docTxt.text = PlayerPrefs.GetString(GameController.post_LOM);


                break;
            case DocType.StudyCertificate:
                heading.text = "Certificate";
                docTxt.text = PlayerPrefs.GetString(GameController.post_StudyCertificate);


                break;
            case DocType.Address:
                heading.text = "Address";
                docTxt.text = PlayerPrefs.GetString(GameController.diary_address);

                break;
            default:
                break;
        }

        selectToogle.onValueChanged.AddListener(delegate { SelectDoc(); });
    }
    public void SelectDoc()
    {
        isSelected = selectToogle.isOn;
        PostOfficeManager.Instance.CheckSelectedInfo();
        print("aksjdkla");
    }
}
