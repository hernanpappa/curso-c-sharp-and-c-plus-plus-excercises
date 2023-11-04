#include <stdio.h>
#include <stdlib.h>

int numeros[5][5];

void random();
void mostrarArreglo();
int DiagonalUno();
int DiagonalDos();

/********************************************************************************************************************/

int main()
{
    printf("Bienvenido a la matriz 5 x 5! \n");
    random();
    mostrarArreglo();
    printf("La suma de la diagonal 1 es: %i \n", DiagonalUno());
    printf("La suma de la diagonal 1 es: %i \n", DiagonalDos());


    return 0;
}

/********************************************************************************************************************/

void random(){

    for(int x = 0; x < 5; x++){
        for(int y = 0; y < 5; y++){

            numeros[x][y] = rand()%10;

        }
    }
}

void mostrarArreglo(){


    for(int x = 0; x < 5; x++){

        printf("\t |");

        for(int y = 0; y < 5; y++){

            printf("%i | ", numeros[x][y]);

        }
        printf("\n");
    }
}

int DiagonalUno(){

    int sumaDiagonal=0;
    for(int x=0; x < 5; x++){

        sumaDiagonal += numeros[x][x];
    }

    return sumaDiagonal;
}

int DiagonalDos(){

    int sumaDiagonal=0;
    for(int x=4; x >= 0; x--){

        sumaDiagonal += numeros[x][length-x];

    }

    return sumaDiagonal;
}
