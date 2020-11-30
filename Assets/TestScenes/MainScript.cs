using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IAPManager.Instance.InitializeIAPManager(InitComplete);
    }

    private void InitComplete(IAPOperationStatus status, string message, List<StoreProduct> shopProducts)
    {
        if (status == IAPOperationStatus.Success)
        {
            //IAP was successfully initialized
            //loop through all products
            for (int i = 0; i < shopProducts.Count; i++)
            {
                if (shopProducts[i].productName == "YourProductName")
                {
                    //if active variable is true, means that user had bought that product
                    //so enable access
                    if (shopProducts[i].active)
                    {
                        //activate things for the user
                    }
                }
            }
        }
        else
        {
            Debug.Log("Error occurred " + message);
        }
    }

    public void BuyProduct()
    {
        IAPManager.Instance.BuyProduct(0, BuyComplete);
    }

    private void BuyComplete(IAPOperationStatus status, string message, StoreProduct product)
    {
        if (status == IAPOperationStatus.Success)
        {
            if (product.productName == "RemoveAds")
            {
                //remove ads
            }
        }
        else
        {
            //an error occurred in the buy process, log the message for more details
            Debug.Log("Buy product failed: " + message);
        }

    }

    public void NextScene()
    {
        SceneManager.LoadScene("SecondScene");
    }
}
