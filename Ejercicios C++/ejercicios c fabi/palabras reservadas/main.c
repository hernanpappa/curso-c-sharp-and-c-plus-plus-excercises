#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a = 80;
    float f=45.3;
    //printf(" entero %i\n flotante %.2f\n double %.3f\n caracter %c",a, (float) a, (double) a, (char) a);
    float suma = (float)a + f;
    printf("%.2f",suma);
    return 0;
}
