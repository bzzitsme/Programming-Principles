#include <bits/stdc++.h>
using namespace std;
int main()
{
    ios_base :: sync_with_stdio(0);
    cin.tie(0);cout.tie(0);
    int n;
    cin>>n;
    int x;
    int p=0;
    vector<int> v;
    vector<int> q;
    for(int i=0;i<n;i++)
    {
        cin>>x;
        v.push_back(x);
    }
    int maxi = v[0] + v[1] + v[2];
    for(int i = 1 ;i < v.size(); i++)
    {
        if(i == v.size() - 1)
        {
            p = v[i - 1] + v[i];
            q.push_back(p);
            break;
        }
        p+=v[i - 1] + v[i]+v[i+1];
        q.push_back(p);
        p=0;
    }
    int d = v[0] + v[v.size() - 1] + v[v.size() - 2];
    int d1 = v[0] + v[1] + v[v.size() - 1];
    q.push_back(d);
    q.push_back(d1);
    sort(q.begin(), q.end());
    for(int i = 0; i < q.size(); i++)
    {
        if(q[i] > maxi)
        {
            maxi = q[i];
        }
    }
    cout<<maxi;
}