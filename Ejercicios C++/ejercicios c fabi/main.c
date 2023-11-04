#include <stdio.h>
#include <stdlib.h>

int main()
{
    char C ='y'; //tamaño de 1 Byte 0...255
    int a= 20;  // 2 bytes-32768...32767
    short e= -1; // 2 bytes -128...127
    unsigned int u= 65537; // 2 bytes 0..65535
    long l = 5932;// 4bytes - 2147483648...2147483647
    float f =72.537;// 4 bytes
    double d = 12323.877658; // 8bytes
    printf("%.2lf\n",d);
    return 0;
}
