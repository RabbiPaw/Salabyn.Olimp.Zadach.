m=open('input_s1_01.txt','r')
n=open('output_s1_01.txt','a')
a=m.read()
i=0
d=['']
f=[]
t=''
while i!=len(a):
    if a[i]==' ':
        c=len(d[0])
        k= c//2
        q=''
        l=1
        q+=d[0][k]
        j=k
        for x in range(c-1):
            if j>=k:
                j=j-l
                l+=1
            else:
                j=j+l
                l+=1
            q+=d[0][j]
        d[0]=''
        i+=1
        f.append(q)
    d[0]+=a[i]
    i+=1

c=len(d[0])
k= c//2
q=''
l=1
q+=d[0][k]
j=k
for x in range(c-1):
    if j>=k:
        j=j-l
        l+=1
    else:
        j=j+l
        l+=1
    q+=d[0][j]
f.append(q)
c=len(f)
k= c//2
q=''
l=1
t=t+f[k]+' '
j=k
for x in range(c-1):
    if j>=k:
        j=j-l
        l+=1
    else:
        j=j+l
        l+=1
    t=t+f[j]+' '
n.write('\n')
n.write('\n')
n.write(t)
n.close()
