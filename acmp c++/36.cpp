#include <bits/stdc++.h>
using namespace std;
int f(int i)
{   
    bool ok = true;
    for(int j=2;j<=sqrt(i);j++)
    {
        if(i%j==0)
        {
            ok = false;
            break;
        }
    }
    return ok;
}
int main()
{
    int a;
    cin>>a;
    int cnt=0;
    for(int i=a+1;i<2*a;i++)
    {
        if(f(i))
        {
            cnt++;
        }
    }
    cout<<cnt;
}