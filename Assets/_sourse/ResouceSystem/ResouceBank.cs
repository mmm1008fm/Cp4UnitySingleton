using System;
using System.Collections;
using System.Collections.Generic;
using ResouceSystem.Data;
using UnityEngine;
namespace ResouceSystem
{
    public class ResouceBank
{
    private const int _startResourceValue =  0;
    private Dictionary<ResourceType, Resource> _resources;
    public ResouceBank()
    {
        InitResources();
    }

    private void InitResources()
    {
        for (int i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
        {
            Resource newResource = new ((ResourceType)i, _startResourceValue);
            _resources.Add((ResourceType)i, newResource);
        }
    }
    public bool TryGetResourceAmount(ResourceType resourceType, out int resourceAmount)
    {
        resourceAmount = 0;
        if (_resources.ContainsKey(resourceType))
        {
        resourceAmount = _resources[resourceType].ResourceAmount;
        return true;
        }
        return false;
    }

}

}
