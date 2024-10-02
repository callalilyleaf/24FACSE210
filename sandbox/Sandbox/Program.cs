using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarments = "scrubs";
        nurse.lowerGarments = "scrubs";
        nurse.accessory = "stethoscope";
        
        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarments = "trenchcoat";
        detective.lowerGarments = "slacks";
        detective.accessory = "maganifing glass";

        nurse.showWardrobe();
        detective.showWardrobe();


    }
}
