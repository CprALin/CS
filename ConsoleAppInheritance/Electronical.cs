//parent class

class Electronical
{
    //state of the device
   public bool isOn {get; set;}
    //brand name of the device
   public string brand {get; set;}

   public Electronical(bool isOn, string brand)
   {
      this.isOn = isOn;
      this.brand = brand;
   }
   
   // switch device on
   public void switchOn()
   {
      isOn = true;
   }
   
   // switch device off
   public void switchOff()
   {
      isOn = false;
   }
}