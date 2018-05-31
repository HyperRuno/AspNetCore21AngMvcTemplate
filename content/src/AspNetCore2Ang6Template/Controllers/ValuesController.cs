using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetCore2Ang6Template.Controllers
{
  /// <summary>
  /// Values Controller
  /// </summary>
  /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
  public class ValuesController : Controller
  {
    /// <summary>
    /// Gets some values.
    /// </summary>
    /// <returns>A collection of values</returns>
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }
  }
}
