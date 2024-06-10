names = open('p022_names.txt', 'r')
names = names.read().split(',')
names = list(names)
names = sorted(names)
names = map(lambda x:x.strip('"'), names)
names = map(lambda x:list(x), names)
names = map(lambda x:tuple(map(lambda y:ord(y) - 64, x)), names)
names = map(lambda x:sum(x), names)
names = list(names)

print(list(names)[0:10])
summ = 0
for i in range(len(names)):
    summ += (i+1) * names[i]

print(summ)
    
