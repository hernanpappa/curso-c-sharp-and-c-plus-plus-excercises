#include <iostream>

using namespace std;

int numerosAleatorios[100];
int CantNumPares = 0;

void random(int [100]);
void MostrarArreglo(int [100]);
void numeros_pares(int [100]);

/*****************************************************************************************************************************/


int main()
{
    cout << "Bienvenido al programa que comprueba numeros pares!" << endl;

    random(numerosAleatorios);
    MostrarArreglo(numerosAleatorios);
    numeros_pares(numerosAleatorios);

    cout << "La cantidad de numeros aleatorios es: " << CantNumPares << endl;

    /*if(47 % 2==0){

            cout << "Numero par";

    }else {cout << "Numero impar";} */

    return 0;
}


/**************************************************************************************************************************************/


void random(int arreglo[100]){

    int Desde = 1;
    int Hasta = 100;

    for(int x=0; x < 100; x++){

        arreglo[x] = rand()%(Hasta-Desde)+Desde;

    }

}

void MostrarArreglo(int arreglo[100]){

     for(int x=0; x < 100; x++){

        cout << "El numero " << x <<" es: " << arreglo[x] << endl;

     }

}

void numeros_pares(int arreglo[100]){

    for(int x = 0; x < 100; x++){


        if(arreglo[x] % 2==0) CantNumPares +=1;

    }

}
