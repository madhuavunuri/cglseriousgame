using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PostOfficeManager : MonoBehaviour
{
    public static PostOfficeManager Instance;

    public PostItem[] postItemPrefab; // 0 - Address, 1- CV , 2- LOM , 3 - Certificate

    public Text selectedList;
    string docinfo;
    // Start is called before the first frame update
    void OnEnable()
    {
        selectedList.text = "Selected Docs";
        CheckPostDocs();
    }

    public void CheckPostDocs()
    {
        for(int i= 0; i<postItemPrefab.Length;i++)
        {
            postItemPrefab[i].gameObject.SetActive(false);
        }
        if (GameController.isAddressAvailable)
            postItemPrefab[0].gameObject.SetActive(true);

        if (GameController.isCVCreated)
            postItemPrefab[1].gameObject.SetActive(true);
        if (GameController.isLOMCreated)
            postItemPrefab[2].gameObject.SetActive(true);
        if (GameController.isStudyCerttificatCreated)
            postItemPrefab[3].gameObject.SetActive(true);

    }

    public void CheckSelectedInfo()
    {
        List<string> listDocs = new List<string>();
        
        for (int i = 0; i < postItemPrefab.Length; i++)
        {
            if(postItemPrefab[i].isSelected)
                listDocs.Add(postItemPrefab[i].heading.text);
        }
        docinfo = "Selected Docs";

        foreach (var item in listDocs)
        {
            docinfo = docinfo + "\n" + item;
        }
    }

    public void SendPost()
    {
        Debug.Log("Documents Posted");
    }

    public void ValidatePost()
    {

    }
}
