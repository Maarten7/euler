import math

def d(n):
    return sum(proper_divisors(n))

def proper_divisors(n):
    proper_divisors = [1]
    for i in range(2, int(math.sqrt(n))):
        if n % i == 0:
            proper_divisors.append(i)
            proper_divisors.append(n / i)
    return proper_divisors

amicalbe_numbers = set([]) 
for i in range(10000):
    if i in amicalbe_numbers:
        continue
    di = d(i)
    ddi = d(di)
    if i == ddi and i != di:
        amicalbe_numbers.add(i)

print(amicalbe_numbers)
print(sum(amicalbe_numbers))

print(d(1), d(d(1)))
