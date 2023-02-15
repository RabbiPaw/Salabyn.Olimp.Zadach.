n=open('input_s1_20.txt','r')
a=[int(x) for x in n.readline().split()]
pos1=[int(x) for x in n.readline().split()]
pos2=[0,0,0]
for i in range(a[1]):
    pov=n.readline().split()
    pov[1]=int(pov[1])
    pov[2]=int(pov[2])
    if pov[0]=='X':
        if pov[1]==pos1[0]:
            pos2[0]=pos1[0]
            if pov[2]==1:
                pos2[1]=pos1[2]
                pos2[2]=(int(a[0])-int(pos1[1])+1)
            else:
                pos2[1]=(int(a[0])-int(pos1[2])+1)
                pos2[2]=pos1[1]
    elif pov[0]=='Y':
        if pov[1]==pos1[1]:
            pos2[1]=pos1[1]
            if pov[2]==1:
                pos2[0]=pos1[2]
                pos2[2]=(int(a[0])-int(pos1[0])+1)
            else:
                pos2[0]=(int(a[0])-int(pos1[2])+1)
                pos2[2]=pos1[0]
    elif pov[0]=='Z':
        if pov[1]==pos1[2]:
            pos2[2]=pos1[2]
            if pov[2]==1:
                pos2[0]=pos1[1]
                pos2[1]=(int(a[0])-int(pos1[0])+1)
            else:
                pos2[0]=(int(a[0])-int(pos1[1])+1)
                pos2[1]=pos1[0]
    pos1=pos2
    pos2=[0,0,0]
print(pos1)
    
    
