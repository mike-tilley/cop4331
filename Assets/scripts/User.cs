using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private string name = "need"; // will come from user input of textfile load
    private int weaponCode = 000; // 3 digits gun, launcher, bomb. 0 = basic, 1 = upgraded, 2 = max upgrade
    private int coinAmount = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName (string name) {this.name = name;}
    public void SetWeaponCode( int weaponCode) { this.weaponCode = weaponCode; }
    public void SetCoin( int coinAmount) { this.coinAmount = coinAmount; }
    public string GetName() { return name; }
    public int GetWeaponCode() { return weaponCode; }
    public int GetCoinAmount() { return coinAmount; }


}
