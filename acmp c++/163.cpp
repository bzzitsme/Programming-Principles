#include <bits/stdc++.h>
using namespace std;
int main()
{
    string s;
    int a,b;
   
    cin >> s;
    if (s[0] == 'x') {
        if (s[1] == '+') {
            a = s[2] - '0';
            b = s[4] - '0';
            cout << b - a;
        } else {
            a = s[2] - '0';
            b = s[4] - '0';
            cout << a + b;
        }
       
    }
    if (s[4] == 'x') {
        if (s[1] == '+') {
            a = s[0] - '0';
            b = s[2] - '0';
            cout << a + b;
        } else {
            a = s[0] - '0';
            b = s[2] - '0';
            cout << a - b;
        }
    }
    if (s[2] == 'x') {
        if (s[1] == '+') {
            a = s[0] - '0';
            b = s[4] - '0';
            cout << b - a;
        } else {
            a = s[0] - '0';
            b = s[4] - '0';
            cout << a - b;
        }
       
    }
}