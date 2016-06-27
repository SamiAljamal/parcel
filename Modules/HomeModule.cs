using Nancy;
using Parcel.Objects;

namespace Parcels
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/parcel"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables();
        myParcelVariables.SetWidth(Request.Query["width"]);
        myParcelVariables.SetLength(Request.Query["length"]);
        myParcelVariables.SetHeight(Request.Query["height"]);
        myParcelVariables.SetWeight(Request.Query["weight"]);

        return View["parcel.cshtml", myParcelVariables];


      };
    }
  }
}
