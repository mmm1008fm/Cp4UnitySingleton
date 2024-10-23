using System.Collections;
using System.Collections.Generic;
using ResouceSystem.Data;
namespace ResouceSystem
{
public class Resource
{
    public int ResourceAmount { get; private set; }
    public ResourceType ResourceType { get; private set; }

    public Resource(ResourceType resourceType, int startValue)
    {
        ResourceAmount = startValue;
        ResourceType = resourceType;
    }
    public void AddResource(int value)
    {
        ResourceAmount += value;
    }
}
}