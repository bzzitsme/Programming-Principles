#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n, kek, maxi = -100000;
    cin >> n;
    if (n == 1) 
    {
        cout << 1;
        return 0; 
    }
    int a[n + 1], b[n + 1], c[n + 1];
    for (int i = 1; i <= n; i++) 
    {
        cin >> a[i];        
    }
    for (int i = 1; i <= n; i++) 
    {
        cin >> b[i];    
    }
    for (int i = 1; i <= n; i++) 
    {
        c[i] = a[i] * b[i];
        if (c[i] > maxi) { 
            maxi = c[i];
            kek = i;
        }
    }
    cout << kek; 
}