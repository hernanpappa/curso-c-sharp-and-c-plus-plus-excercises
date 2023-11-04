#include <stdio.h>
#include <stdlib.h>
//#include "libreria" poner las comillas sirve para incluir una libreria que haya creado dentro de la misma carpeta.
#define pi 3.15149//crea constantes simbolicas y macros (mini funciones})
#define cuadrado(a) a*a
int main()
{
    //int suma;
    //suma = pi + 3 ;
    //printf("%i\n",suma);
    int x=3;
    //printf("cuadrado vale : %i \n", cuadrado(x));
    int operacion1;
    operacion1= cuadrado(x+5);
    printf("el valor de la operacion es : %i \n", operacion1);

    return 0;
}
