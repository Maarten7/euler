import math

def divisors(n):
    divisors = {1}
    for i in range(2, math.ceil(math.sqrt(n)) + 1):
        if n % i == 0:
           divisors.add(i) 
           divisors.add(int(n/i)) 
    return divisors

def sum_divisors(n):
    return sum(divisors(n))

def is_abundant(n):
    if sum_divisors(n) > n:
        return True
    return False

def abundants():
    i = 12 
    abundants = set([12])
    while i < 28123:
        i += 1 
        if is_abundant(i):
            abundants.add(i)

    return abundants

def sums_abundant_numbers():
    abundant_numbers = abundants()

    sums_abundant_numbers = set() 
    for i in abundant_numbers:
        for j in abundant_numbers:
            sum_abundant = i + j
           
            if sum_abundant <= 28123:
                sums_abundant_numbers.add(sum_abundant)

    return sums_abundant_numbers

def main():
    N = set(range(28123))
    san = sums_abundant_numbers()
    return sum(N.difference(san))  

def test():
    z = list(sums_abundant_numbers())
    z.sort()
    print(z)

main()
