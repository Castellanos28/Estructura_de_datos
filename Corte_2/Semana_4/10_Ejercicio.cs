using System; 

namespace Ejercicio10
{
    class Academia
    {
        private int [,] MatrizAcademia;
        int CANTIDAD_FILAS=3;
        int CANTIDAD_COLUMNAS=4;

        public void CargarMatriz()
        {
            MatrizAcademia=new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for(int f=0;f<CANTIDAD_FILAS;f++){
                for(inr c=0;c<CANTIDAD_COLUMNAS;c++){
                    Console.WriteLine("Digite la cantidad de estudiantes: ");
                    MatrizAcademia[f,c]=int.Parse(Console.ReadLine());
                }

            }
        }
        static void Main(string[] args){
            Academia op=new Academia();
            op.CargarMatriz();
        }
    }
}