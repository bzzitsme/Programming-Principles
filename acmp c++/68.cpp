#include <bits/stdc++.h>
using namespace std;
int main()
{
    int x;
    string s;
    cin >> s;
    cin >> x;
    if (s == "Home") cout<<"Yes";    
    if (s == "School" && x % 2 == 1) cout << "Yes";
    if (s == "School" && x % 2 == 0) cout << "No";
}