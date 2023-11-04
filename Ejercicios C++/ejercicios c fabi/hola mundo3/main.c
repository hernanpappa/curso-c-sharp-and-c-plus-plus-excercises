#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1;
    int num2;
    int resultado;
    int a=12;
    int b=3;
    printf("introducir el primer numero :\n");
    scanf("%d",&num1);
    printf("introducir el segundo numero :\n");
    scanf("%d",&num2);
    resultado = a*b*num1+num2;
    printf("su resultado es : %d",resultado);
    return 0;
}
