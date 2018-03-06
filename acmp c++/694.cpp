#include <bits/stdc++.h>
using namespace std;
int main () 
{
    int n, mini = 100000, maxi = -100000, a, b;
    cin >> n;
    for (int i = 0; i < n; i++) 
    {
        cin >> a >> b;
        if (maxi < a) 
        {
            maxi = a;
        }
        if (mini > b) 
        {
            mini = b;
        }
    }
    if (mini >= maxi) cout << "YES";
    else cout << "NO";
    return 0;
}