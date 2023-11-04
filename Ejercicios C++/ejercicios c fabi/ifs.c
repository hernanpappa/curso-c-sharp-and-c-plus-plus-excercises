#include <stdio.h>
#include <stdlib.h>
/*
CONDICIONALES
toma de deciciones         (if)
operadores de igualdad

==   X es igual a Y
!=   X es diferente que Y

Operadores de Relacion

> X mayor que Y
< X menor que Y
>= X mayor o igual que Y
<= X menor o igual que Y
*/
int main()
{
    int edad;
    printf("ingresa tu edad\n");
    scanf("%d",&edad);
    if(edad >=18)
    {
        printf("sos mayor de edad bienvenido!\n");
    }else if(edad==17){
        printf("sorry bro casi sos mayor de edad pero el casi no cuenta. tenes acceso limitado.\n");
    }
    else if(edad<18 && edad>=10){
        printf("sos menor de edad solo vas a tener acceso limitado.\n");
    }else {
        printf("estas por debajo del rango permitido, go out!\n");
    }
    return 0;


}
