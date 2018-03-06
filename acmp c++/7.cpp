#include <bits/stdc++.h>
using namespace std;
int main()
{
    string a,b,c;
    cin>>a>>b>>c;
    if(a.size()>b.size() and a.size()>c.size())
    {
        cout<<a;
        return 0;
    }
    if(b.size()>a.size() and b.size()>c.size())
    {
        cout<<b;
        return 0;
    }
    if(c.size()>a.size() and c.size()>b.size())
    {
        cout<<c;
        return 0;
    }
    if(a.size()==b.size() and b.size()==c.size())
    {
        cout<<max(a,max(b,c));
    }
    if(a.size()==b.size() and a.size()!=c.size())
    {
        cout<<max(a,b);
    }
    if(a.size()==c.size() and a.size()!=b.size())
    {
        cout<<max(a,c);
    }
    if(b.size()==c.size() and b.size()!=a.size())
    {
        cout<<max(b,c);
    }
}