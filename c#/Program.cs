using System.Collections;
using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {


     ArrayList Materias = new ArrayList();
     String[] especialidad = {"Sistemas","Mecatronica","Industrial","Gestion Empresarial","Energias Renovables","Tecnologias de la Informacion"};
     Materias.Add("Calculo");
     Materias.Add("Español");
     Materias.Add("Dibujo Tecnico");
     Materias.Add(especialidad);

    foreach (Object dato in Materias){
        Console.WriteLine(dato.GetType());
    } 

    foreach (Object dato in Materias){
        if (dato.GetType() == typeof(System.String[])){
            foreach (String dato2 in (String[])dato){
                Console.WriteLine(dato2);
            }
         
         else{
            Console.WriteLine(dato.ToString());
        } 
        }
    }
    }
}