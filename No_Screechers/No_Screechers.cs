using UnityEngine;
using HarmonyLib;

public class No_Screechers : Mod
{
    public void Start()
    {
        Debug.Log("Mod No_Screechers has been loaded!");
    }

    public void Update()
    {

    }

    public void OnModUnload()
    {
        Debug.Log("Mod No_Screechers has been unloaded!");
    }
}