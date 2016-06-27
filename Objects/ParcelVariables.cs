namespace Parcel.Objects
{
  public class ParcelVariables
  {
    private int _width;
    private int _length;
    private int _height;
    private int _weight;

    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(string newWidth)
    {
      _width = int.Parse(newWidth);
    }
    public int GetLength()
    {
      return _length;
    }
    public void SetLength(string newLength)
    {
      _length = int.Parse(newLength);
    }
    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(string newHeight)
    {
      _height = int.Parse(newHeight);
    }
    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(string newWeight)
    {
      _weight = int.Parse(newWeight);
    }

    public int GetVolume()
    {
      int parcelVolume = _height * _width * _length;
      return parcelVolume;
    }
    public int CosttoShip()
    {
      int cost = 0;
      int parcelCost = GetVolume()/166;
      if (parcelCost <= 10)
      {
        cost = 10;
      }
      else if (parcelCost <= 20 && parcelCost > 10)
      {
        cost = 20;
      }
      else if (parcelCost <=30 && parcelCost >20)
      {
        cost = 30;
      }
      else
      {
        cost = 45;

      }
      return cost;
    }
  }
}
