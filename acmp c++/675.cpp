#include <bits/stdc++.h>
using namespace std;
  
int main () 
{
  
int m,n, cnt, mini = 1000;
      
    cin >> n >> m;
    string details;
  
    for (int i = 0; i < n; i++) {
        cin >> details;
        for (int j = 0; j < m; j++) {
            if (details[j] == '.') cnt++;           
        }
        if (cnt <= minin) mini = cnt;
        cnt = 0;
    }
  
    cout << mini;
    return 0;
}