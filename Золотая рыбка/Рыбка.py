def op(n,N,F,L):
    N=[]
    F=[]
    L=[]
    n=0
    q=open('input_s1_'+lx+'.txt','r')
    n=q.readline().split()
    for i in range (int(n[0])):
        N.append(q.readline().rstrip())
    f=q.readline().split()
    for i in range (int(f[0])):
        F.append(q.readline().rstrip('\n').split(' '))
    l=q.readline().split()
    for i in range (int(l[0])):
        L.append(q.readline().rstrip('\n').split(' '))
    q.close()
    return n,N,F,L


lx=input()
ps=open('output_s1_'+lx+'.txt','r')
otv=ps.readline()
N=[]
F=[]
L=[]
n=0
x1=[]
x2=[]
n,N,F,L=op(n,N,F,L)
for i in range (int(n[0])):
    for c in range (len(F)):
        for t  in range (len(L)):
            if N[i][0]==F[c][0]:
               if N[i][-1]==L[t][0]:
                if int(F[c][1])!=0 and int(L[t][1])!=0:
                    x1.append(N[i])
                    F[c][1]=int(F[c][1])-1
                    L[t][1]=int(L[t][1])-1
n,N,F,L=op(n,N,F,L)
for t in range (len(F)):
    for c in range (len(F)-1):
        if F[c][1]<F[c+1][1]:
            o=F[c]
            F[c]=F[c+1]
            F[c+1]=o
for t in range (len(L)):
    for c in range (len(L)-1):
        if L[c][1]<L[c+1][1]:
            o=L[c]
            L[c]=L[c+1]
            L[c+1]=o
for t  in range (len(L)):
    for c in range (len(F)):
        for i in range (int(n[0])):
            if N[i][0]==F[c][0]:
               if N[i][-1]==L[t][0]:
                if int(F[c][1])!=0 and int(L[t][1])!=0:
                    x2.append(N[i])
                    F[c][1]=int(F[c][1])-1
if len(x1)>len(x2):
    print(len(x1))
else:
    print(len(x2))
print(otv)
