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
    public GameObject homeMenu;
    public GameObject postData;
    public GameObject message;

    public GameObject missingDocMenu;
    public GameObject postDocMenu;

  
    // Start is called before the first frame update
    void OnEnable()
    {
        if (Instance == null)
            Instance = this;

        selectedList.text = "Selected Docs";
        CheckPostDocs();

        if(!GameController.isPostSent)
        {
            message.SetActive(false);
            postData.SetActive(false);
            homeMenu.SetActive(true);
        }
        else
        {
            message.SetActive(true);
            postData.SetActive(false);
            homeMenu.SetActive(false);
        }
        CheckSelectedInfo();
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
        listDocs.Clear();
        for (int i = 0; i < postItemPrefab.Length; i++)
        {
            if (postItemPrefab[i].isSelected)
            {
                listDocs.Add(postItemPrefab[i].heading.text);
               
            }
        }
        docinfo = "Selected Docs";

        foreach (var item in listDocs)
        {
            docinfo +=  "\n" + item;
        }
        selectedList.text = docinfo;

        print("Add -" + PlayerPrefs.GetInt("Address_ID", 0)+
        "Course - "+PlayerPrefs.GetInt("Course_ID", 0)+
        "College - "+PlayerPrefs.GetInt("College_ID", 0)+
       "Facke - "+ PlayerPrefs.GetInt("isFack_ID", 0));
    }

    public void SendPost()
    {

        GameController.isPostSent = true;
       
        message.SetActive(true);
        postData.SetActive(false);
        homeMenu.SetActive(false);

         Debug.Log("Documents Posted");
    }

    public void ValidatePost()
    {

    }

    public void PosTButton()
    {

        if (GameController.isCVCreated == false || GameController.isAddressAvailable == false ||
            GameController.isStudyCerttificatCreated == false || GameController.isLOMCreated == false)
        {
            missingDocMenu.SetActive(true);
            return;
        }
        else
        {
            postDocMenu.SetActive(true);
        }
    }
}
