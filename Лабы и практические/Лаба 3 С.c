#include <stdio.h>
#include <math.h>

int main() 
{
    float m, n, a, b, c;
    float z, alf, bat;
    
    printf("Введите сходные данные m, n:\n ");
    scanf("%f%f", &m, &n);
    
    if (m > n)
    
        
        alf = m;
    
    else if (m < n)
    
        alf = n;
    
    else if (m == n)
    
        alf = n * cosf(n);
    
    
    
    
    if (m < 5)
    
        
        bat = a;
    
    else if (m == 5)
    
        bat = b;
    
    else if (m > 5)
    
        bat = c;
    
    
    
    z = cbrtf(alf * alf + bat + expf (alf) - cosf(bat));
    
    printf("%f", z);
    
    return 0;
    
    
}