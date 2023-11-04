#include <iostream>

using namespace std;

void pedirDatos(int[5]);
int determinarNumMayor(int[5]);
void mostrarDistancia(int[5]);

int datos[5];
int Mayor;

int main()
{
    cout << "Bienvenido al ejemplo 1 de arreglos!" << endl;
    pedirDatos(datos);
    Mayor = determinarNumMayor(datos);
    cout << "El numero mayor es: " << Mayor << endl;
    mostrarDistancia(datos);

    return 0;
}

/***********************************************************************************************************************************************/

void pedirDatos(int arreglo[5]){

    for(int x = 0; x < 5; x++){

        cout << "Ingrese el numero " << x << " del arreglo: ";
        cin >> arreglo[x];
        cout << endl;

    }

    cout << endl;
}

int determinarNumMayor(int arreglo[5]){

    int numMayor = 0;
    for(int x = 0; x < 5; x++){

        if(arreglo[x] > numMayor) numMayor = arreglo[x];

    }

    return numMayor;
}

void mostrarDistancia(int arreglo[5]){

    int distancia;

    for(int x = 0; x < 5; x++){

        distancia = Mayor - arreglo[x];
        cout << "La distancia del numero " << x << " al numero mayor es de: " << distancia << " numeros" << endl;

    }

}
