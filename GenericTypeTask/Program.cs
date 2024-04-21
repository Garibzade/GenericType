using GenericTypeTask.Models;
using Microsoft.VisualBasic.FileIO;
using static GenericTypeTask.Models.Animal;

namespace GenericTypeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf canavar=new Wolf(10,"Qirmizi",100,Gender.male,true,25);
            Wolf qurd=new Wolf(9,"quzu",100,Gender.male,false,16);
            Elephant fil = new Elephant(22, "ag", 170, Gender.female, 560.3d, false);
           

            Meat et = new Meat(280, Meat.Type.baccon);
            Grass ot = new Grass(120, "keklikotu");
            
            var wolfCage = new ZooCage<Wolf, Meat>(canavar, et);

            var elephantCage = new ZooCage<Elephant, Grass>(fil, ot);

            var wolfCage2 =new ZooCage<Wolf,Grass>(qurd,ot);
            canavar.Hunt<Wolf>(qurd);
           


        }
    }
}
