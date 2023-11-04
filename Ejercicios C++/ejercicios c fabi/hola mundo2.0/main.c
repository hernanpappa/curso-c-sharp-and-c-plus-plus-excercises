#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1;
    int num2;
    int num3;
    int resultado;
    printf("ingresar el primer numero :\n");
    scanf("%d",&num1);
    printf("ingresar el segundo numero por favor :\n");
    scanf("%d",&num2);
    printf("ingresar el tercer numero,disculpe las molestias :\n");
    scanf("%d",&num3);
    resultado = num1 + num2 - num3;
    printf("Su tan esperado resultado es:%d",resultado);
    return 0;

}
