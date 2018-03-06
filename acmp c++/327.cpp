#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin>>n;
    int l;
    int a, b, c, q, w, e;
    int t1, t2;
    int a1, b1, c1, q1, w1, e1;
    int a2, b2, c2, q2, w2, e2;
    int cnt = 0;
    for(int i = 0; i < n; i ++)
    {
        cin >> l;
        a = l / 100000;
        b = (l / 10000) % 10;
        c = (l / 1000) % 10;
        q = (l / 100) % 10;
        w = (l / 10) % 10;
        e = l % 10;
        t1 = a + b + c;
        t2 = q + w + e;
        l += 1;
        /* a1 = l / 100000;
        b1 = (l / 10000) % 10;
        c1 = (l / 1000) % 10; */
        q1 = (l / 100) % 10;
        w1 = (l / 10) % 10;
        e1 = l % 10;
        if(t1 == q1 + w1+ e1)
        {
            cout<<"Yes"<<endl;
            cnt++;
        }
        l = l - 2;
        /* a2 = l / 100000;
        b2 = (l / 10000) % 10;
        c2 = (l / 1000) % 10; */
        q2 = (l / 100) % 10;
        w2 = (l / 10) % 10;
        e2 = l % 10;
        if(t1 == q2 + w2 + e2)
        {
            cout<<"Yes"<<endl;
            cnt++;
        }
        if(cnt == 0)
        {
            cout<<"No"<<endl;
        }
        cnt = 0;
    }
}