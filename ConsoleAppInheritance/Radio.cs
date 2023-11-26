//child class

class Radio : Electronical
{
    public Radio(bool isOn , string brand):base(isOn, brand)
    {

    }

    public void listenRadio()
    {
        if(isOn)
        {
            Console.WriteLine("Listening to the radio!");
        }else{
            Console.WriteLine("Switch on to listen radio!");
        }
    }
}