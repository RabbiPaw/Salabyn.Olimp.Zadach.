for prt in range(1,15):
    f=open('input'+str(prt)+'.txt')
    ids=f.readline().split()
    inc=f.readline().split()
    nds=f.readline().split()
    nnc=f.readline().split()
    m1=f.readline().split()
    m2=''
    t=0
    ics=inc[0]
    inc[0]='0'
    for i in range(len(inc)):
        inc[i]=int(inc[i])
    inc=list(sorted(inc))
    inc=list(reversed(inc))
    inc.pop(-1)
    ncs=nnc[0]
    nnc[0]='0'
    for i in range(len(nnc)):
        nnc[i]=int(nnc[i])
    nnc=list(sorted(nnc))
    nnc.pop(0)
    for i in range(len(m1)):
        for j in range(0,int(ics)):
            if int(int(m1[i]))>int(inc[j]):
                m1[i]=str(int(m1[i])-1)
    for i in range (0,int(ids[0])-1):
        m1[0]=int(m1[0])*int(ids[i+1])+int(m1[i+1])
    m1=int(m1[0])
    if int(nds[0])!=1:
        for i in range(int(nds[0])-1,0,-1):
            if m1//int(nds[i])!=0:
                k=m1//int(nds[i])
                m2=str(m1-int(nds[i])*k)+' '+m2
                m1=k
            else:
                if i!=1:
                    k=''
        m2=str(k)+' '+m2
    else:
        m2=str(m1)
    xc=len(m2.split())
    while xc<int(nds[0]):
        m2='0'+' '+m2
        xc=len(m2.split())
    m2=m2.split()
    for k in range(len(m2)):
        m2[k]=int(m2[k])
        for i in range(0,int(ncs)):
            if (nnc[i])<=m2[k]:
                m2[k]+=1
    otv=str(m2[0])
    for i in range(1,len(m2)):
        otv=otv+' '+str(m2[i])
    print(otv==(open('output'+str(prt)+'.txt').readline()))
        
        
