
//child class
class TV : Electronical
{
   public TV(bool isOn, string brand):base(isOn, brand)
   {

   }

   public void watchTV()
   {
     if(isOn)
     {
        Console.WriteLine("Watching TV!");
     }else{
        Console.WriteLine("Switch on to watch TV!");
     }
   }
}