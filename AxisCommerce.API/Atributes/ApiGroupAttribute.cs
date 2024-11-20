using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Extensions;

namespace AxisCommerce.API.Atributes;

public class ApiGroupAttribute : Attribute, IApiDescriptionGroupNameProvider
{
    public ApiGroupAttribute(ApiGroupNames name)
    {
        GroupName = name.GetDisplayName();
    }
    public string GroupName { get; set; }
}
