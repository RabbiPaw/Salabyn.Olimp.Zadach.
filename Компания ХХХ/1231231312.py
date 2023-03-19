for k in range(1,21):
    z=str(k)
    if len(z)==1:
        z='0'+z
    file= open('input_s1_'+z+'.txt')
    file2=open('output_s1_'+z+'.txt')
    prov=file2.readlines()
    id1=[]
    id2=[]
    f=[]
    a=[]
    otv=[]
    qp=0
    while a!=['END']:
        a=list(map(str,file.readline().split()))
        if qp%2==0:
            if a[0] not in id1:
                    id1.append(a[0])
        if qp%2!=0:
            if a[0] not in id2:
                    id2.append(a[0])
        qp+=1
        if len (a)>2:
            a[1]=a[1]+' '+a[2]
            a.pop(-1)
        if a!=['END']:
            f.append(a)
    id1.pop(-1)
    for i in id1:
        for j in range(len(f)):
            if i in f[j] and len(f[j]) !=2:
                for t in range(len(f)):
                    if i in f[t] and len(f[t]) ==2:
                        f[j].append(f[t][1])
                        break
    for k in f:
        if len(k)==1:
            k.append('Unknown name')
    a=file.readline()
    for i in range(0,len(f),2):
        if a in f[i]:
            otv.append(f[i+1])
    for i in otv:
        a=i[1]
        b=i[0]
        for i in range(0,len(f),2):
            if b in f[i] :
                if f[i+1] not in otv:
                    otv.append(f[i+1])
    otv=sorted(otv,key=lambda x: x[0])
    print(z)
    if len(otv)!=0:
        for i in otv:
            print(*i)
    else:
        print('NO')
    print('--')
    
    for i in prov:
        print(*i)
    print('---------------------------------')
