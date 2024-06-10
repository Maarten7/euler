import time

start_time = time.time()

k = 0
for i in range(1,1000):

    if i % 3 == 0 or i % 5 == 0:
        k += i

print k
print time.time() - start_time
start_time = time.time()

k = 0
for i in range(0, 334):
    k += i * 3
for i in range(0, 200):
    z = i * 5
    if z % 3 == 0:
        continue
    k += z 
        
print k
print time.time() - start_time

k = 0
for i in range(0, 334):
    j = i * 3 
    z = i * 5 
    k += j + z
    if z % 3 == 0 or z > 999:
        k -= z

       
print k
print time.time() - start_time
